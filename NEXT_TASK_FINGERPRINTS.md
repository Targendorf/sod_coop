# Задача: синхронизация улик (отпечатки → потом следы и кровь)

> Это самодостаточный prompt для нового чата. Скопируй всё содержимое этого файла в первое сообщение и попроси выполнить.

## Контекст проекта

Это P2P-кооп мод для Shadow of Doubt (Unity 2021.3.45f2, IL2CPP). Стек:
- **BepInEx 6 IL2CPP**, **HarmonyX** для патчинга
- **LiteNetLib 1.2** UDP (ReliableOrdered/Sequenced)
- Расположение проекта: `D:\sod_coop\`
- Сборка: `cd D:/sod_coop && dotnet build --no-restore` (артефакт сразу копируется в плагины Gale)
- Полный декомпил-дамп игры в `D:\sod_coop\Assembly-CSharp_Dump\` (исключён из компиляции через `<Compile Remove="Assembly-CSharp_Dump\**" />`)

## Уже синхронизировано (паттерны, которым нужно следовать)

Основные системы синка живут в `src/Sync/`:

| Файл | Что синкает |
|---|---|
| `PlayerSync.cs` | Позиция игрока, vitals (food/water/energy), interactions |
| `WorldSync.cs` | NPC AI command streaming + ownership transfer |
| `WorldStateSync.cs` | Двери, лампы, переключатели (drawers/cabinets) |
| `WeatherSync.cs` | Погода host-authoritative |
| `ItemSync.cs` | Подбор/выброс предметов |
| `CitizenDeathSync.cs` | Убийства, обнаружение тел |
| `PhoneSync.cs` | Уведомления о звонках |
| `CaseBoardSync.cs` | Полная синхронизация доски расследования (pin/unpin/drag/strings/hide/status/resolve/custom name/string remove) |

**Общий паттерн всех синков:**
1. Packet type в `src/Network/Packets.cs` (enum + range-based dispatch в `SyncManager.cs`)
2. INetPacket struct в `src/Network/NetSerializer.cs` (Serialize/Deserialize)
3. Static class в `src/Sync/XxxSync.cs` со свойством `bool IsApplyingRemote` (re-entrancy guard) + `BroadcastXxx` + `OnPacketReceived` + `ApplyXxx`
4. Harmony patches в `src/Patches/GamePatches.cs` (postfix → broadcast если `!IsApplyingRemote`)
5. Маршрут в `src/Sync/SyncManager.cs.OnPacketReceived` (else-if цепочка)

**Существующий рабочий пример лучше всего смотреть:** `WorldStateSync.cs` (dor/light/switch) или `ItemSync.cs` — простая, чистая архитектура. Скопируй его структуру.

## IL2CPP-специфика, уже устаканенная

- **Конфликт `List<>` / `Dictionary<>`**: используй `Il2CppSystem.Collections.Generic` для типов из игры, `System.Collections.Generic` для своих внутренних. Если оба нужны — type alias: `using Il2CppList = Il2CppSystem.Collections.Generic.List<X>;`
- **GetComponent с генериками падает в IL2CPP** — используй строковую форму с TryCast: `gameObject.GetComponent("Type")?.TryCast<Type>()`
- **Identity check** (один объект или другой): `obj.Pointer == other.Pointer`
- **Player.Instance** — локальный игрок этой машины. `NetworkManager.LocalPlayerId` — наш сетевой ID
- **CityData.Instance.interactableDirectory** — `List<Interactable>` (НЕ Dictionary), индекс часто == id (быстрый путь + linear fallback)
- **CityData.Instance.citizenDictionary** — `Dictionary<int, Human>` keyed by humanID

---

# Задание: синхронизация отпечатков пальцев

## Что найдено в дампе

### `Interactable.DynamicFingerprint` (вложенный класс)
```cs
public class DynamicFingerprint {
    public int    id;       // уникальный идентификатор отпечатка
    public float  created;  // timestamp игрового времени
    public int    seed;     // seed для визуального паттерна
    public PrintLife life;  // enum: timed, manualRemoval
}
```

### На самом `Interactable`:
```cs
public List<DynamicFingerprint> df;   // список всех отпечатков на объекте
public void AddNewDynamicFingerprint(Human from, PrintLife life);
public void RemoveDynamicPrint(DynamicFingerprint print);
public void RemoveManuallyCreatedFingerprints();
```

### `Interactable.PrintLife` enum:
```cs
public enum PrintLife : byte {
    timed = 0,
    manualRemoval = 1,
}
```

## Cross-machine идентификация

Всё уже доступно через существующие схемы:
- **Interactable**: `id` (int) — детерминирован от сида. Lookup через `CityData.Instance.interactableDirectory[id]` (см. `WorldStateSync.FindInteractableById`)
- **Human**: `humanID` (int) — детерминирован. Lookup через `CityData.Instance.citizenDictionary[humanID]`
- **DynamicFingerprint**: `id` (int) — генерируется при `AddNewDynamicFingerprint`. На разных машинах могут быть разные id для одного и того же логического действия → нужна двунаправленная индексация (см. ниже).

## Архитектурный вопрос: какая модель?

**Главное соображение**: на клиенте AI у NPC **отключён** (`WorldSync.DisableAIController`). Значит NPC локально не двигаются, ничего не трогают, и `AddNewDynamicFingerprint` для NPC у клиента **не вызывается естественно**. Только хост генерирует отпечатки от NPC.

Игроки — наоборот, оба бегают по своим машинам, оба могут оставлять отпечатки на своих экземплярах Interactable.

**Рекомендуемая модель:**
- **Любая сторона** может вызвать `AddNewDynamicFingerprint` (свой игрок → её локальный `df` обновился) → broadcast всем.
- На приёме делаем **dedup по логическому ключу** `(interactableId, humanId, ~timestamp)` — потому что у хоста и клиента id-ы DynamicFingerprint могут разойтись для одного и того же события.
- Когда наш patch вызывает `AddNewDynamicFingerprint` от собственного игрока, он порождает локальный объект с локальным id. Broadcast сообщает (interactableId, humanId, life). Receiver вызывает то же `AddNewDynamicFingerprint` под флагом `IsApplyingRemote` → у них появляется свой локальный объект с **своим** id. Списки на разных машинах будут содержать те же логические записи, но с разными внутренними id.

**Это разница не критична**, потому что игроки взаимодействуют с отпечатками через UV-сканер по `(interactable, human)` парам, а не по DynamicFingerprint.id.

**Но Remove операции потребуют осторожности**: чтобы удалить конкретный print на удалённой стороне, мы не можем сослаться на его id. Решение: использовать `(interactableId, humanId)` пару + индекс среди отпечатков от того же human на том же interactable. Либо вообще пропустить `RemoveDynamicPrint`-sync для v1, оставив только Add (и `RemoveManuallyCreatedFingerprints` через broadcast целиком — это очищает все manual prints на interactable).

## Скоуп v1 (предлагаемый)

| # | Действие | Patch target | Packet | Сложность |
|---|---|---|---|---|
| 1 | Добавить отпечаток | `Interactable.AddNewDynamicFingerprint(Human, PrintLife)` postfix | `FingerprintAddPacket(interactableId, humanId, life)` | Low |
| 2 | Удалить все manual prints на объекте | `Interactable.RemoveManuallyCreatedFingerprints()` postfix | `FingerprintClearManualPacket(interactableId)` | Low |
| 3 | (Опционально) Удалить конкретный | `Interactable.RemoveDynamicPrint(DynamicFingerprint)` postfix | сложно — отложить на v2 |

## Дедупликация на приёмнике

Receiver должен пропускать пакеты с `senderId == LocalPlayerId` (echo от своего же broadcast). Это уже стандартный паттерн (см. `PhoneSync` или `ItemSync`).

Дополнительно: если хост и клиент **оба** где-то фильтруют одно и то же событие (например, оба думают что их игрок дотронулся одного объекта в один момент — что в P2P маловероятно но возможно), запатченный `AddNewDynamicFingerprint` сработает дважды на каждой стороне → удвоенные prints. Чтобы этого избежать, в `ApplyAdd` можно добавить проверку: «если у этого interactable уже есть print от этого human, созданный за последние ~0.5 секунды — skip». Это эвристика, но в реальности должно работать.

## Pitfalls

- **`Interactable.df` может быть null** на свежем interactable — проверяй перед итерацией.
- **`Interactable.AddNewDynamicFingerprint(null, life)`** возможно крашится — pass-through `IsApplyingRemote` нужно ставить ДО вызова метода. Стандартный try/finally паттерн.
- Отпечатки **сами очищаются по таймеру** для PrintLife.timed — это deterministic от created timestamp + game time, так что таймерная очистка должна синхронизироваться сама без отдельного broadcast.
- Method `AddNewDynamicFingerprint` зовётся из множества мест в SoD (PickUpTarget, OpenDoor, etc.) — наш patch ловит ВСЕ из них автоматически. Не пытайся патчить отдельные call-sites.

---

# Реализация — пошагово

### Шаг 1: добавить PacketType (range 33 уже занят `ObjectState`, найди свободный — например 52 уже занят `SwitchState`, бери 53)

```cs
// src/Network/Packets.cs
/// <summary>
/// Add a dynamic fingerprint on an Interactable. Keyed by (interactableId, humanId, life).
/// </summary>
FingerprintAdd = 53,

/// <summary>
/// Clear all manually-removed fingerprints on an Interactable.
/// Replays Interactable.RemoveManuallyCreatedFingerprints.
/// </summary>
FingerprintClearManual = 54,
```

### Шаг 2: packet structs в `src/Network/NetSerializer.cs`

```cs
public struct FingerprintAddPacket : INetPacket {
    public PacketType Type => PacketType.FingerprintAdd;
    public int InteractableId;
    public int HumanId;
    public byte Life;       // PrintLife enum
    public int SenderId;    // for echo dedup

    public void Serialize(NetDataWriter w) {
        w.Put(InteractableId); w.Put(HumanId); w.Put(Life); w.Put(SenderId);
    }
    public void Deserialize(NetDataReader r) {
        InteractableId = r.GetInt(); HumanId = r.GetInt();
        Life = r.GetByte(); SenderId = r.GetInt();
    }
}

public struct FingerprintClearManualPacket : INetPacket {
    public PacketType Type => PacketType.FingerprintClearManual;
    public int InteractableId;
    public void Serialize(NetDataWriter w) { w.Put(InteractableId); }
    public void Deserialize(NetDataReader r) { InteractableId = r.GetInt(); }
}
```

### Шаг 3: создай `src/Sync/FingerprintSync.cs`

Структура — копируй из `WorldStateSync.cs` или `ItemSync.cs`:
- `public static bool IsApplyingRemote { get; private set; }`
- `private static readonly NetDataWriter _writer = new();`
- `BroadcastAdd(int interactableId, int humanId, byte life)`
- `BroadcastClearManual(int interactableId)`
- `OnPacketReceived(PacketType, NetPacketReader, int senderId)`
- `ApplyAdd(FingerprintAddPacket p)` — find Interactable by id (используй `WorldStateSync.FindInteractableById` через рефлексию или скопируй helper), find Human by humanID, set IsApplyingRemote=true, call `inter.AddNewDynamicFingerprint(human, (PrintLife)p.Life)`, finally clear flag.
- `ApplyClearManual` — то же, вызывает `inter.RemoveManuallyCreatedFingerprints()`.

**Важно**: `WorldStateSync.FindInteractableById` сейчас private. Подними его в public или дублируй helper в FingerprintSync.

### Шаг 4: Harmony patches в `src/Patches/GamePatches.cs`

```cs
[HarmonyPatch(typeof(Interactable), nameof(Interactable.AddNewDynamicFingerprint))]
public static class Interactable_AddNewDynamicFingerprint_Patch {
    [HarmonyPostfix]
    public static void Postfix(Interactable __instance, Human from, Interactable.PrintLife life) {
        try {
            if (__instance == null || from == null) return;
            if (FingerprintSync.IsApplyingRemote) return;
            FingerprintSync.BroadcastAdd(__instance.id, from.humanID, (byte)life);
        }
        catch (System.Exception ex) {
            Plugin.Log.LogWarning($"AddNewDynamicFingerprint patch: {ex.Message}");
        }
    }
}

[HarmonyPatch(typeof(Interactable), nameof(Interactable.RemoveManuallyCreatedFingerprints))]
public static class Interactable_RemoveManuallyCreatedFingerprints_Patch {
    [HarmonyPostfix]
    public static void Postfix(Interactable __instance) {
        try {
            if (__instance == null) return;
            if (FingerprintSync.IsApplyingRemote) return;
            FingerprintSync.BroadcastClearManual(__instance.id);
        }
        catch (System.Exception ex) {
            Plugin.Log.LogWarning($"RemoveManuallyCreatedFingerprints patch: {ex.Message}");
        }
    }
}
```

### Шаг 5: маршрут в `src/Sync/SyncManager.cs`

Добавить ветку в `OnPacketReceived` ПЕРЕД range-based dispatch (диапазон 30-49 идёт в WorldSync, наши пакеты 53/54 в этом диапазоне):

```cs
else if (type == PacketType.FingerprintAdd || type == PacketType.FingerprintClearManual) {
    FingerprintSync.OnPacketReceived(type, reader, senderId);
}
```

### Шаг 6: сборка и коммит

```bash
cd D:/sod_coop && dotnet build --no-restore
```

Должна быть чистая (предупреждение `NU1603` о Cpp2IL.Core можно игнорировать).

Коммит в стиле существующих:

```bash
git add -A && git commit -m "$(cat <<'EOF'
Sync dynamic fingerprints via Interactable.AddNewDynamicFingerprint

Hook AddNewDynamicFingerprint postfix → broadcast (interactableId, humanId,
PrintLife). Receiver re-invokes the same method locally under
FingerprintSync.IsApplyingRemote so the patch doesn't echo. Each machine
generates its own internal print id/seed pair — they don't need to match
because gameplay queries prints by (interactable, human) pair, not by
DynamicFingerprint.id.

Also patches RemoveManuallyCreatedFingerprints to mirror manual cleanup
events. Specific RemoveDynamicPrint syncing is deferred until we have a
need — it requires a stable cross-machine print identifier.

NPC-driven prints originate only on the host (clients have AI disabled)
so they're broadcast once, host→clients. Player-driven prints are bidirect-
ional: each side broadcasts its own player's contact events.

EOF
)"
```

---

# Phase 2 (опционально, после fingerprints)

После того как fingerprints работают, такой же паттерн можно применить к **footprints** и **blood spatter** — но это сложнее, потому что они визуальные decals и для NPC у клиента (с отключённым AI) не генерируются естественно.

### Footprints
- `GameplayController.Footprint` — ctor `(Human, Vector3 position, Vector3 euler, float dirt, float blood, NewRoom)`
- Хранятся в `GameplayController.Instance.footprintsList` (List) и `activeFootprints` (Dict<NewRoom, List<Footprint>>)
- Patch points: нужно искать в `Human.cs` или `CitizenAnimationController.cs` где вызывается их добавление
- Подход: host-only broadcast — клиент только зеркалит

### Blood spatter
- `SpatterSimulation` — ctor берёт human + position + direction + preset + erase mode
- Хранятся в `GameplayController.Instance.spatter` (List<SpatterSimulation>)
- Patch points: triggered from `Human.RecieveDamage(...)` — это виртуальный метод, его уже видим в дампе
- Подход: host-only broadcast (поскольку RecieveDamage от NPC только на хосте)

Footprints и blood — отдельная задача после fingerprints, можно вынести в `EvidenceVisualSync.cs`.

---

# Критерии успеха

1. ✅ Сборка чистая (0 ошибок)
2. ✅ Hubcoop логирует `[FingerprintSync] Add broadcast` когда любой игрок касается объекта
3. ✅ Логирует `[FingerprintSync] applied remote add` на принимающей стороне
4. ✅ Когда хост убивает NPC и тот падает на оружие, оба игрока через UV-сканер видят отпечатки этого NPC на оружии
5. ✅ Когда игрок A кладёт что-то в шкаф, у обоих игроков на этом шкафу появляется отпечаток игрока А

# Контакты в коде

- Логи: `Plugin.Log.LogInfo / LogWarning / LogError`
- Лучшие референсы для копипасты структуры: `src/Sync/WorldStateSync.cs` (door/light/switch), `src/Sync/ItemSync.cs` (pickup/drop)
- Существующие patches: `src/Patches/GamePatches.cs` — уже большой файл, добавляй в конец class GamePatches

Удачи. Любые вопросы по архитектуре — `git log --oneline -20` покажет историю последних 20 фич, любая из них следует тому же паттерну.
