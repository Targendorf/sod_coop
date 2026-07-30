using System.Collections.Generic;

namespace SoDCoop.Localization;

/// <summary>
/// Per-language translation dictionaries.
///
/// <para>Adding new keys: drop them into <see cref="En"/> first (treated as
/// the canonical reference set), then mirror into other dicts as
/// translations land. Missing keys fall back to EN at lookup time, so
/// it's safe to add a key without immediately filling every language.</para>
///
/// <para>Adding a new language: create a new <see cref="Dictionary{TKey, TValue}"/>
/// here, register it in <see cref="L.LookupDict"/>, and append the code
/// to <see cref="L.SupportedLanguages"/>.</para>
///
/// <para><b>Status</b> as of stub introduction:</para>
/// <list type="bullet">
///   <item><c>en</c> — canonical, fully populated.</item>
///   <item><c>ru</c> — fully populated.</item>
///   <item><c>uk / es / zh / de</c> — stub only (one or two example keys).
///         All other lookups fall back to EN. Translators / contributors
///         can fill in incrementally.</item>
/// </list>
/// </summary>
public static class Translations
{
    // ─────────────────────────────────────────────────────────────────────
    //  English (canonical / fallback)
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> En = new()
    {
        // Main panel
        ["main.title"]              = "Co-op Multiplayer",
        ["main.tagline"]            = "Connect with a teammate to investigate together.",
        ["main.btn.host"]           = "🛜  Host a session",
        ["main.btn.join"]           = "🔌  Join a session",
        ["main.btn.showIp"]         = "📡  Show my IP",
        ["main.btn.settings"]       = "⚙  Settings",
        ["main.btn.close"]          = "✕  Close menu",

        // Host panel
        ["host.title"]              = "Host a session",
        ["host.tagline"]            = "You'll host as your existing in-game character — friends join via Steam invite. Make sure you're in-game before starting.",
        ["host.label.playingAs"]    = "Playing as",
        ["host.identity.reading"]   = "(reading from game…)",
        ["host.identity.noSave"]    = "⚠ Load a save first — your character is read from the loaded game.",
        ["host.identity.fallback"]  = "(no save loaded — will host as 'Host')",
        ["host.btn.start"]          = "▶  Start Hosting",
        ["host.btn.stop"]           = "■  Stop Hosting",
        ["host.btn.invite"]         = "🤝  Invite friends via Steam",
        ["host.btn.back"]           = "←  Back",
        ["host.status.notHosting"]  = "Status: not hosting",
        ["host.status.mainMenu"]    = "Status: in main menu — start or load a save before hosting.",
        ["host.status.hosting"]     = "Status: hosting — {0} peer(s) connected (visible to your Steam friends)",
        ["host.status.invitedOverlay"] = "Steam overlay opened — pick friends to invite.",
        ["host.warn.noSave"]        = "⚠ You must be in-game to host. Load a save first, then come back.",

        // Join panel
        ["join.title"]              = "Join a session",
        ["join.tagline"]            = "Joining is invite-only via Steam. Wait for an invite from a friend, or click \"Join Game\" on their profile in the Steam overlay.",
        ["join.instructions"]       = "How to join:\n  1. Friend hosts a session.\n  2. They invite you via the Steam overlay (or you click \"Join Game\" on their profile).\n  3. The mod auto-joins their lobby — no IP, port, or code needed.",
        ["join.btn.openFriends"]    = "🪟  Open Steam Friends",
        ["join.btn.back"]           = "←  Back",
        ["join.status.overlayOpened"] = "Steam Friends overlay opened.",
        ["join.warn.haveSave"]      = "⚠ Return to the main menu first — you can't join while your own save is loaded.",
        ["join.state.haveSave"]     = "⚠ A save is currently loaded. Return to the main menu before joining.",
        ["join.state.menuOk"]       = "✔ On main menu — ready to join.",

        // Lobby panel
        ["lobby.title"]              = "Lobby",
        ["lobby.btn.disconnect"]     = "Disconnect",
        ["lobby.btn.close"]          = "Close (stay connected)",
        ["lobby.btn.settings"]       = "⚙  Settings",
        ["lobby.label.players"]      = "Players:",
        ["lobby.label.you"]          = "(you)",
        ["lobby.label.host"]         = "[HOST]",

        // Create-character panel
        ["create.title"]             = "Create your character",
        ["create.context"]           = "Welcome to {0}! You're joining {1}.\nThis name will be used by NPCs, ID papers, and case files for your character. It cannot be empty and is saved by the host for future visits.",
        ["create.label.first"]       = "First name",
        ["create.label.surname"]     = "Surname",
        ["create.placeholder.first"] = "e.g. Alex",
        ["create.placeholder.sur"]   = "e.g. Reyes",
        ["create.btn.submit"]        = "✓  Create character & join",
        ["create.btn.cancel"]        = "✕  Cancel & disconnect",
        ["create.status.submitting"] = "Submitting \"{0} {1}\" to host…",
        ["create.reject.generic"]    = "Host rejected the name.",
        ["create.reject.with"]       = "Host rejected: {0}",

        // Settings panel
        ["settings.title"]           = "Settings",
        ["settings.tagline"]         = "Toggles persist between game launches.",
        ["settings.toggle.statusHud"]   = "Show players list (top-right)",
        ["settings.toggle.chat"]        = "Show chat window (bottom-left)",
        ["settings.toggle.nameTags"]    = "Show nicknames above players",
        ["settings.toggle.banners"]     = "Show overlay banners (sleep / phone)",
        ["settings.label.language"]     = "Language (restart needed)",
        ["settings.lang.note"]          = "Edit BepInEx/config/com.sodcoop.mod.cfg → [General] → LanguageOverride. Use \"auto\" for game language.",
        ["settings.section.networking"] = "Networking",
        ["settings.toggle.worldBootstrap"]      = "World bootstrap: Save Transfer",
        ["settings.toggle.worldBootstrap.sharecode"] = "World bootstrap: Share Code",
        ["settings.note.worldBootstrap"] = "Save Transfer — host sends its save file, identical world guaranteed. Share Code — client regenerates city from seed (faster connect, may diverge).",
        ["settings.toggle.saveTransferAuto"]   = "Auto-accept save transfers",
        ["settings.btn.back"]           = "←  Back",

        // IpInfo panel
        ["ipinfo.title"]             = "Your IP addresses",
        ["ipinfo.btn.back"]          = "←  Back",

        // Chat / system messages
        ["chat.system.connected"]    = "Connected to session!",
        ["chat.system.disconnected"] = "Disconnected: {0}",
        ["chat.system.joined"]       = "{0} joined the game.",
        ["chat.system.left"]         = "{0} left the game.",

        // Appearance customization panel
        ["lobby.btn.appearance"]      = "🎭  Customize appearance",
        ["appearance.title"]          = "Customize appearance",
        ["appearance.subtitle"]       = "Changes apply to your in-world citizen. Close the menu (F9) to see yourself in a mirror or 3rd-person.",
        ["appearance.row.gender"]     = "Gender",
        ["appearance.row.build"]      = "Build",
        ["appearance.row.hairStyle"]  = "Hair style",
        ["appearance.row.hairColour"] = "Hair colour",
        ["appearance.row.eyeColour"]  = "Eye colour",
        ["appearance.row.skin"]       = "Skin tone",
        ["appearance.row.lipstick"]   = "Lipstick",
        ["appearance.row.expression"] = "Expression",
        ["appearance.row.outfit"]     = "Outfit",
        ["appearance.row.wardrobe"]   = "Borrow wardrobe",
        ["appearance.wardrobe.own"]   = "(use own outfit)",
        ["appearance.wardrobe.unknown"] = "Unknown citizen #{0}",
        ["appearance.btn.randomize"]  = "🎲  Randomize",
        ["appearance.btn.reset"]      = "↺  Reset",
        ["appearance.btn.confirm"]    = "✓  Confirm",
        ["appearance.btn.cancel"]     = "✕  Cancel",
        ["appearance.btn.back"]       = "←  Back",
        ["appearance.btn.deep"]       = "⚙  Deep customization →",
        ["appearance.preview.unavailable"] = "3D preview needs a loaded world.\nLoad any single-player save first,\nthen reopen this panel.",

        // Deep appearance panel — extra rows on top of the basic panel.
        ["appearanceDeep.title"]                = "Deep customization",
        ["appearanceDeep.section.preset"]       = "Preset — start from a citizen",
        ["appearanceDeep.preset.hint"]          = "Pick any citizen to copy their full appearance (gender, build, hair, eyes, skin, outfit). Tweak any field afterwards and the row label flips to (custom).",
        ["appearanceDeep.row.preset"]           = "Preset",
        ["appearanceDeep.preset.custom"]        = "(custom)",
        ["appearanceDeep.section.body"]         = "Body & wear",
        ["appearanceDeep.section.slots"]        = "Outfit slots — pick a different citizen per slot",
        ["appearanceDeep.slots.hint"]           = "Each slot pulls clothing covering that body part from the picked citizen, layered on top of the whole-outfit wardrobe pick below.",
        ["appearanceDeep.section.wardrobe"]     = "Whole outfit — borrow from a citizen",
        ["appearanceDeep.wardrobe.hint"]        = "Click any citizen to copy their full clothes list for the current outfit category. \"(use own outfit)\" returns to your twin's procedural wardrobe. Per-slot picks above still apply on top.",
        ["appearanceDeep.row.shoeType"]         = "Shoe type",
        ["appearanceDeep.row.grub"]             = "Grime",
        ["appearanceDeep.shoeType.default"]    = "(citizen default)",
        ["appearanceDeep.shoeType.normal"]      = "Normal",
        ["appearanceDeep.shoeType.boots"]       = "Boots",
        ["appearanceDeep.shoeType.heel"]        = "Heels",
        ["appearanceDeep.shoeType.barefoot"]    = "Barefoot",
        ["appearanceDeep.grub.value"]           = "{0} / {1}",
        ["appearanceDeep.slot.hair"]            = "Hair",
        ["appearanceDeep.slot.hat"]             = "Hat",
        ["appearanceDeep.slot.top"]             = "Top (shirt/jacket)",
        ["appearanceDeep.slot.bottom"]          = "Bottom (pants/skirt)",
        ["appearanceDeep.slot.shoes"]           = "Shoes",
        ["appearanceDeep.slot.glasses"]         = "Glasses",
        ["appearanceDeep.slot.hands"]           = "Hands (gloves/watch)",

        // Profile management
        ["main.btn.profiles"]      = "👤  Manage profiles",
        ["main.profile.none"]      = "No active profile — pick one to play.",
        ["main.profile.active"]    = "Playing as: <b>{0}</b>\n<i>{1}</i>",
        ["main.sessions.header"]   = "Recent sessions",
        ["main.sessions.btn.connect"] = "🔌  Rejoin",
        ["profiles.title"]         = "Coop characters",
        ["profiles.subtitle"]      = "Each profile has its own client identity, in-world name, and appearance. Switching profiles makes you a different person to every host.",
        ["profiles.empty"]         = "No profiles yet — create one to get started.",
        ["profiles.unnamed"]       = "(unnamed)",
        ["profiles.noNameYet"]     = "(no in-world name set)",
        ["profiles.btn.create"]    = "＋  Create new profile",
        ["profiles.btn.use"]       = "Use",
        ["profiles.btn.edit"]      = "Edit",
        ["profiles.btn.delete"]    = "Delete",
        ["profiles.btn.deleteArmed"] = "Confirm?",
        ["profiles.btn.back"]      = "←  Back",
        ["profiles.status.activated"]    = "Active profile updated.",
        ["profiles.status.deleteConfirm"] = "Click Delete again to confirm.",
        ["profiles.status.deleted"]      = "Profile deleted.",
        ["editprofile.title"]      = "Edit profile",
        ["editprofile.subtitle"]   = "Display name shows up in the profile picker. First / surname are sent to hosts you join.",
        ["editprofile.label.display"] = "Display name (in this menu)",
        ["editprofile.label.first"]   = "First name (in-world)",
        ["editprofile.label.sur"]     = "Surname (in-world)",
        ["editprofile.placeholder.display"] = "e.g. Detective Alice",
        ["editprofile.placeholder.first"]   = "e.g. Alice",
        ["editprofile.placeholder.sur"]     = "e.g. Reyes",
        ["editprofile.btn.appearance"] = "🎭  Edit appearance",
        ["editprofile.btn.cancel"]  = "✕  Cancel",
        ["editprofile.btn.save"]    = "✓  Save",
        ["editprofile.appearance.default"]    = "Appearance: vanilla (procedurally generated by host).",
        ["editprofile.appearance.customized"] = "Appearance: customized.",
        ["editprofile.status.saved"] = "Profile saved.",
        ["appearance.skin.value"]     = "{0} / {1}",
        ["appearance.lipstick.value"] = "{0} / {1}",
        ["appearance.gender.male"]       = "Male",
        ["appearance.gender.female"]     = "Female",
        ["appearance.gender.nonbinary"]  = "Non-binary",
        ["appearance.build.skinny"]      = "Skinny",
        ["appearance.build.average"]     = "Average",
        ["appearance.build.overweight"]  = "Heavy",
        ["appearance.build.muscular"]    = "Muscular",
        ["appearance.hairStyle.bald"]      = "Bald",
        ["appearance.hairStyle.shorthair"] = "Short",
        ["appearance.hairStyle.longhair"]  = "Long",
        ["appearance.hairColour.black"]  = "Black",
        ["appearance.hairColour.brown"]  = "Brown",
        ["appearance.hairColour.blonde"] = "Blonde",
        ["appearance.hairColour.ginger"] = "Ginger",
        ["appearance.hairColour.red"]    = "Red",
        ["appearance.hairColour.blue"]   = "Blue",
        ["appearance.hairColour.green"]  = "Green",
        ["appearance.hairColour.purple"] = "Purple",
        ["appearance.hairColour.pink"]   = "Pink",
        ["appearance.hairColour.grey"]   = "Grey",
        ["appearance.hairColour.white"]  = "White",
        ["appearance.eyeColour.blueeyes"]  = "Blue",
        ["appearance.eyeColour.browneyes"] = "Brown",
        ["appearance.eyeColour.greeneyes"] = "Green",
        ["appearance.eyeColour.greyeyes"]  = "Grey",
        ["appearance.expression.neutral"]   = "Neutral",
        ["appearance.expression.angry"]     = "Angry",
        ["appearance.expression.sad"]       = "Sad",
        ["appearance.expression.surprised"] = "Surprised",
        ["appearance.expression.happy"]     = "Happy",
        ["appearance.expression.asleep"]    = "Asleep",
        ["appearance.outfit.casual"]         = "Casual",
        ["appearance.outfit.work"]           = "Work",
        ["appearance.outfit.smart"]          = "Smart / formal",
        ["appearance.outfit.outdoorscasual"] = "Outdoors casual",
        ["appearance.outfit.outdoorswork"]   = "Outdoors work",
        ["appearance.outfit.outdoorssmart"]  = "Outdoors smart",
        ["appearance.outfit.undressed"]      = "Undressed",
        ["appearance.outfit.bed"]            = "Pajamas",
        ["appearance.outfit.underwear"]      = "Underwear",
    };

    // ─────────────────────────────────────────────────────────────────────
    //  Russian
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> Ru = new()
    {
        // Main panel
        ["main.title"]              = "Кооп-мультиплеер",
        ["main.tagline"]            = "Подключись к напарнику и расследуй дела вместе.",
        ["main.btn.host"]           = "🛜  Создать сессию",
        ["main.btn.join"]           = "🔌  Подключиться",
        ["main.btn.showIp"]         = "📡  Показать мой IP",
        ["main.btn.settings"]       = "⚙  Настройки",
        ["main.btn.close"]          = "✕  Закрыть меню",

        // Host panel
        ["host.title"]              = "Создать сессию",
        ["host.tagline"]            = "Ты будешь хостить под своим внутриигровым персонажем. Имя берётся из загруженного сейва — убедись что зашёл в игру до старта.",
        ["host.label.playingAs"]    = "Играешь как",
        ["host.identity.reading"]   = "(читаем из игры…)",
        ["host.identity.noSave"]    = "⚠ Сначала загрузи сейв — имя берётся из загруженной игры.",
        ["host.identity.fallback"]  = "(сейв не загружен — будем хостить как 'Host')",
        ["host.label.port"]         = "Порт",
        ["host.btn.start"]          = "▶  Запустить хостинг",
        ["host.btn.stop"]           = "■  Остановить",
        ["host.btn.copy"]           = "📋  Скопировать код",
        ["host.btn.back"]           = "←  Назад",
        ["host.status.notHosting"]  = "Статус: не хостим",
        ["host.status.mainMenu"]    = "Статус: главное меню — загрузи сейв перед хостингом.",
        ["host.status.hosting"]     = "Статус: хостинг — подключено {0} пир(ов)",
        ["host.status.codeCopied"]  = "Статус: код скопирован!",
        ["host.label.joinCode"]     = "Код подключения (отправь его другу)",
        ["host.code.notReady"]      = "(запусти хостинг чтобы получить код)",
        ["host.warn.noSave"]        = "⚠ Чтобы хостить, нужно быть в игре. Загрузи сейв и вернись.",

        // Join panel
        ["join.title"]              = "Подключиться",
        ["join.tagline"]            = "Вставь код подключения, либо введи IP и порт хоста вручную. Если это твой первый заход в мир хоста — после подключения попросят создать персонажа.",
        ["join.label.code"]         = "Код подключения (рекомендуется)",
        ["join.code.placeholder"]   = "Вставь сюда код",
        ["join.label.manual"]       = "Или ввести вручную",
        ["join.placeholder.ip"]     = "IP хоста",
        ["join.btn.connect"]        = "🔌  Подключиться",
        ["join.btn.back"]           = "←  Назад",
        ["join.status.connecting"]  = "Подключаемся к {0}:{1}…",
        ["join.status.failed"]      = "Не удалось подключиться — проверь IP и порт.",
        ["join.status.codeOk"]      = "Код OK — {0}:{1}",
        ["join.status.codeOkCity"]  = "Код OK — {0}:{1} (город: {2})",
        ["join.status.codeBad"]     = "Код не распознан — введи вручную.",
        ["join.warn.haveSave"]      = "⚠ Сначала вернись в главное меню — нельзя подключиться когда загружен свой сейв.",
        ["join.state.haveSave"]     = "⚠ Сейчас загружен сейв. Вернись в главное меню перед подключением.",
        ["join.state.menuOk"]       = "✔ В главном меню — готов к подключению.",

        // Lobby panel
        ["lobby.title"]              = "Лобби",
        ["lobby.btn.disconnect"]     = "Отключиться",
        ["lobby.btn.close"]          = "Закрыть (остаться в сессии)",
        ["lobby.btn.settings"]       = "⚙  Настройки",
        ["lobby.label.players"]      = "Игроки:",
        ["lobby.label.you"]          = "(ты)",
        ["lobby.label.host"]         = "[ХОСТ]",

        // Create-character panel
        ["create.title"]             = "Создание персонажа",
        ["create.context"]           = "Добро пожаловать в {0}! Ты подключаешься к {1}.\nЭто имя будет использоваться NPC, в документах и в досье для твоего персонажа. Не может быть пустым и сохраняется хостом для будущих заходов.",
        ["create.label.first"]       = "Имя",
        ["create.label.surname"]     = "Фамилия",
        ["create.placeholder.first"] = "напр. Александр",
        ["create.placeholder.sur"]   = "напр. Иванов",
        ["create.btn.submit"]        = "✓  Создать и зайти",
        ["create.btn.cancel"]        = "✕  Отмена и отключение",
        ["create.status.submitting"] = "Отправляем «{0} {1}» хосту…",
        ["create.reject.generic"]    = "Хост отклонил имя.",
        ["create.reject.with"]       = "Хост отклонил: {0}",

        // Settings panel
        ["settings.title"]           = "Настройки",
        ["settings.tagline"]         = "Переключатели сохраняются между запусками игры.",
        ["settings.toggle.statusHud"]   = "Показывать список игроков (сверху справа)",
        ["settings.toggle.chat"]        = "Показывать чат (снизу слева)",
        ["settings.toggle.nameTags"]    = "Показывать ники над игроками",
        ["settings.toggle.banners"]     = "Показывать баннеры (сон / звонки)",
        ["settings.label.language"]     = "Язык (нужен перезапуск)",
        ["settings.lang.note"]          = "Редактируй BepInEx/config/com.sodcoop.mod.cfg → [General] → LanguageOverride. \"auto\" — язык игры.",
        ["settings.btn.back"]           = "←  Назад",

        // IpInfo panel
        ["ipinfo.title"]             = "Твои IP-адреса",
        ["ipinfo.btn.back"]          = "←  Назад",

        // Chat / system messages
        ["chat.system.connected"]    = "Подключено к сессии!",
        ["chat.system.disconnected"] = "Отключено: {0}",
        ["chat.system.joined"]       = "{0} зашёл в игру.",
        ["chat.system.left"]         = "{0} вышел из игры.",

        // Appearance customization panel
        ["lobby.btn.appearance"]      = "🎭  Настроить внешность",
        ["appearance.title"]          = "Настройка внешности",
        ["appearance.subtitle"]       = "Изменения применяются к твоему персонажу. Закрой меню (F9) и посмотрись в зеркало.",
        ["appearance.row.gender"]     = "Пол",
        ["appearance.row.build"]      = "Телосложение",
        ["appearance.row.hairStyle"]  = "Причёска",
        ["appearance.row.hairColour"] = "Цвет волос",
        ["appearance.row.eyeColour"]  = "Цвет глаз",
        ["appearance.row.skin"]       = "Цвет кожи",
        ["appearance.row.lipstick"]   = "Помада",
        ["appearance.row.expression"] = "Выражение",
        ["appearance.row.outfit"]     = "Одежда",
        ["appearance.row.wardrobe"]   = "Гардероб",
        ["appearance.wardrobe.own"]   = "(свой комплект)",
        ["appearance.wardrobe.unknown"] = "Неизвестный житель #{0}",
        ["appearance.btn.randomize"]  = "🎲  Случайно",
        ["appearance.btn.reset"]      = "↺  Сброс",
        ["appearance.btn.confirm"]    = "✓  Применить",
        ["appearance.btn.cancel"]     = "✕  Отмена",
        ["appearance.btn.back"]       = "←  Назад",
        ["appearance.preview.unavailable"] = "Для 3D-превью нужен загруженный мир.\nЗагрузи любой одиночный сейв,\nпотом открой эту панель снова.",

        // Profile management
        ["main.btn.profiles"]      = "👤  Мои персонажи",
        ["main.profile.none"]      = "Нет активного персонажа — выбери одного.",
        ["main.profile.active"]    = "Играешь за: <b>{0}</b>\n<i>{1}</i>",
        ["main.sessions.header"]   = "Недавние сессии",
        ["main.sessions.btn.connect"] = "🔌  Войти",
        ["profiles.title"]         = "Кооп-персонажи",
        ["profiles.subtitle"]      = "У каждого персонажа своя сетевая идентичность, имя в игре и внешность. Смена персонажа = другой человек для каждого хоста.",
        ["profiles.empty"]         = "Персонажей пока нет — создай первого.",
        ["profiles.unnamed"]       = "(без названия)",
        ["profiles.noNameYet"]     = "(имя в игре не задано)",
        ["profiles.btn.create"]    = "＋  Создать персонажа",
        ["profiles.btn.use"]       = "Выбрать",
        ["profiles.btn.edit"]      = "Изменить",
        ["profiles.btn.delete"]    = "Удалить",
        ["profiles.btn.deleteArmed"] = "Точно?",
        ["profiles.btn.back"]      = "←  Назад",
        ["profiles.status.activated"]    = "Активный персонаж обновлён.",
        ["profiles.status.deleteConfirm"] = "Нажми Удалить ещё раз для подтверждения.",
        ["profiles.status.deleted"]      = "Персонаж удалён.",
        ["editprofile.title"]      = "Редактирование персонажа",
        ["editprofile.subtitle"]   = "Название показывается в списке. Имя/фамилия отправляются хосту при подключении.",
        ["editprofile.label.display"] = "Название (в меню)",
        ["editprofile.label.first"]   = "Имя (в игре)",
        ["editprofile.label.sur"]     = "Фамилия (в игре)",
        ["editprofile.placeholder.display"] = "напр. Детектив Алиса",
        ["editprofile.placeholder.first"]   = "напр. Алиса",
        ["editprofile.placeholder.sur"]     = "напр. Рейес",
        ["editprofile.btn.appearance"] = "🎭  Изменить внешность",
        ["editprofile.btn.cancel"]  = "✕  Отмена",
        ["editprofile.btn.save"]    = "✓  Сохранить",
        ["editprofile.appearance.default"]    = "Внешность: стандартная (генерируется хостом).",
        ["editprofile.appearance.customized"] = "Внешность: настроенная.",
        ["editprofile.status.saved"] = "Персонаж сохранён.",
        ["appearance.skin.value"]     = "{0} / {1}",
        ["appearance.lipstick.value"] = "{0} / {1}",
        ["appearance.gender.male"]       = "Мужской",
        ["appearance.gender.female"]     = "Женский",
        ["appearance.gender.nonbinary"]  = "Небинарный",
        ["appearance.build.skinny"]      = "Худощавое",
        ["appearance.build.average"]     = "Среднее",
        ["appearance.build.overweight"]  = "Полное",
        ["appearance.build.muscular"]    = "Мускулистое",
        ["appearance.hairStyle.bald"]      = "Лысый",
        ["appearance.hairStyle.shorthair"] = "Короткие",
        ["appearance.hairStyle.longhair"]  = "Длинные",
        ["appearance.hairColour.black"]  = "Чёрный",
        ["appearance.hairColour.brown"]  = "Каштановый",
        ["appearance.hairColour.blonde"] = "Блонд",
        ["appearance.hairColour.ginger"] = "Рыжий",
        ["appearance.hairColour.red"]    = "Красный",
        ["appearance.hairColour.blue"]   = "Синий",
        ["appearance.hairColour.green"]  = "Зелёный",
        ["appearance.hairColour.purple"] = "Фиолетовый",
        ["appearance.hairColour.pink"]   = "Розовый",
        ["appearance.hairColour.grey"]   = "Седой",
        ["appearance.hairColour.white"]  = "Белый",
        ["appearance.eyeColour.blueeyes"]  = "Голубые",
        ["appearance.eyeColour.browneyes"] = "Карие",
        ["appearance.eyeColour.greeneyes"] = "Зелёные",
        ["appearance.eyeColour.greyeyes"]  = "Серые",
        ["appearance.expression.neutral"]   = "Спокойное",
        ["appearance.expression.angry"]     = "Злое",
        ["appearance.expression.sad"]       = "Грустное",
        ["appearance.expression.surprised"] = "Удивлённое",
        ["appearance.expression.happy"]     = "Весёлое",
        ["appearance.expression.asleep"]    = "Сонное",
        ["appearance.outfit.casual"]         = "Повседневная",
        ["appearance.outfit.work"]           = "Рабочая",
        ["appearance.outfit.smart"]          = "Деловая",
        ["appearance.outfit.outdoorscasual"] = "На улицу повседн.",
        ["appearance.outfit.outdoorswork"]   = "На улицу рабочая",
        ["appearance.outfit.outdoorssmart"]  = "На улицу деловая",
        ["appearance.outfit.undressed"]      = "Без одежды",
        ["appearance.outfit.bed"]            = "Пижама",
        ["appearance.outfit.underwear"]      = "Бельё",
    };

    // ─────────────────────────────────────────────────────────────────────
    //  Ukrainian
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> Uk = new()
    {
        // Main panel
        ["main.title"]              = "Кооп-мультиплеєр",
        ["main.tagline"]            = "Підключайся до напарника та розслідуйте справи разом.",
        ["main.btn.host"]           = "🛜  Створити сесію",
        ["main.btn.join"]           = "🔌  Підключитися",
        ["main.btn.showIp"]         = "📡  Показати мою IP",
        ["main.btn.settings"]       = "⚙  Налаштування",
        ["main.btn.close"]          = "✕  Закрити меню",

        // Host panel
        ["host.title"]              = "Створити сесію",
        ["host.tagline"]            = "Ти будеш хостити під своїм внутрішньоігровим персонажем. Ім’я береться із завантаженого збереження — переконайся що зайшов у гру до старту.",
        ["host.label.playingAs"]    = "Граєш як",
        ["host.identity.reading"]   = "(читаємо з гри…)",
        ["host.identity.noSave"]    = "⚠ Спочатку завантаж збереження — ім’я береться із завантаженої гри.",
        ["host.identity.fallback"]  = "(збереження не завантажено — будемо хостити як 'Host')",
        ["host.label.port"]         = "Порт",
        ["host.btn.start"]          = "▶  Запустити хостинг",
        ["host.btn.stop"]           = "■  Зупинити",
        ["host.btn.copy"]           = "📋  Скопіювати код",
        ["host.btn.back"]           = "←  Назад",
        ["host.status.notHosting"]  = "Стан: не хостимо",
        ["host.status.mainMenu"]    = "Стан: головне меню — завантаж збереження перед хостингом.",
        ["host.status.hosting"]     = "Стан: хостинг — підключено {0} пір(ів)",
        ["host.status.codeCopied"]  = "Стан: код скопійовано!",
        ["host.label.joinCode"]     = "Код підключення (надішли його другу)",
        ["host.code.notReady"]      = "(запусти хостинг, щоб отримати код)",
        ["host.warn.noSave"]        = "⚠ Щоб хостити, треба бути у грі. Завантаж збереження й повернися.",

        // Join panel
        ["join.title"]              = "Підключитися",
        ["join.tagline"]            = "Встав код підключення, або введи IP і порт хоста вручну. Якщо це твій перший захід у світ хоста — після підключення попросять створити персонажа.",
        ["join.label.code"]         = "Код підключення (рекомендовано)",
        ["join.code.placeholder"]   = "Встав сюди код",
        ["join.label.manual"]       = "Або ввести вручну",
        ["join.placeholder.ip"]     = "IP хоста",
        ["join.btn.connect"]        = "🔌  Підключитися",
        ["join.btn.back"]           = "←  Назад",
        ["join.status.connecting"]  = "Підключаємось до {0}:{1}…",
        ["join.status.failed"]      = "Не вдалося підключитися — перевір IP та порт.",
        ["join.status.codeOk"]      = "Код OK — {0}:{1}",
        ["join.status.codeOkCity"]  = "Код OK — {0}:{1} (місто: {2})",
        ["join.status.codeBad"]     = "Код не розпізнано — введи вручну.",
        ["join.warn.haveSave"]      = "⚠ Спочатку повернися в головне меню — не можна підключитися коли завантажене своє збереження.",
        ["join.state.haveSave"]     = "⚠ Зараз завантажене збереження. Повернися в головне меню перед підключенням.",
        ["join.state.menuOk"]       = "✔ У головному меню — готовий до підключення.",

        // Lobby panel
        ["lobby.title"]              = "Лобі",
        ["lobby.btn.disconnect"]     = "Відключитися",
        ["lobby.btn.close"]          = "Закрити (залишитись у сесії)",
        ["lobby.btn.settings"]       = "⚙  Налаштування",
        ["lobby.label.players"]      = "Гравці:",
        ["lobby.label.you"]          = "(ти)",
        ["lobby.label.host"]         = "[ХОСТ]",

        // Create-character panel
        ["create.title"]             = "Створення персонажа",
        ["create.context"]           = "Ласкаво просимо до {0}! Ти підключаєшся до {1}.\nЦе ім’я буде використовуватися NPC, у документах і в досьє для твого персонажа. Не може бути пустим і зберігається хостом для майбутніх заходів.",
        ["create.label.first"]       = "Ім’я",
        ["create.label.surname"]     = "Прізвище",
        ["create.placeholder.first"] = "напр. Олексій",
        ["create.placeholder.sur"]   = "напр. Іванов",
        ["create.btn.submit"]        = "✓  Створити та зайти",
        ["create.btn.cancel"]        = "✕  Скасувати та відключитися",
        ["create.status.submitting"] = "Надсилаємо «{0} {1}» хосту…",
        ["create.reject.generic"]    = "Хост відхилив ім’я.",
        ["create.reject.with"]       = "Хост відхилив: {0}",

        // Settings panel
        ["settings.title"]           = "Налаштування",
        ["settings.tagline"]         = "Перемикачі зберігаються між запусками гри.",
        ["settings.toggle.statusHud"]   = "Показувати список гравців (зверху справа)",
        ["settings.toggle.chat"]        = "Показувати чат (знизу зліва)",
        ["settings.toggle.nameTags"]    = "Показувати ніки над гравцями",
        ["settings.toggle.banners"]     = "Показувати банери (сон / дзвінки)",
        ["settings.label.language"]     = "Мова (потрібен перезапуск)",
        ["settings.lang.note"]          = "Редагуй BepInEx/config/com.sodcoop.mod.cfg → [General] → LanguageOverride. \"auto\" — мова гри.",
        ["settings.btn.back"]           = "←  Назад",

        // IpInfo panel
        ["ipinfo.title"]             = "Твої IP-адреси",
        ["ipinfo.btn.back"]          = "←  Назад",

        // Chat / system messages
        ["chat.system.connected"]    = "Підключено до сесії!",
        ["chat.system.disconnected"] = "Відключено: {0}",
        ["chat.system.joined"]       = "{0} зайшов у гру.",
        ["chat.system.left"]         = "{0} вийшов з гри.",
    };

    // ─────────────────────────────────────────────────────────────────────
    //  Spanish
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> Es = new()
    {
        // Main panel
        ["main.title"]              = "Multijugador cooperativo",
        ["main.tagline"]            = "Conéctate con un compañero para investigar juntos.",
        ["main.btn.host"]           = "🛜  Hospedar sesión",
        ["main.btn.join"]           = "🔌  Unirse a sesión",
        ["main.btn.showIp"]         = "📡  Mostrar mi IP",
        ["main.btn.settings"]       = "⚙  Ajustes",
        ["main.btn.close"]          = "✕  Cerrar menú",

        // Host panel
        ["host.title"]              = "Hospedar sesión",
        ["host.tagline"]            = "Hospedarás como tu personaje en el juego. El nombre se lee de la partida cargada — asegúrate de estar dentro del juego antes de empezar.",
        ["host.label.playingAs"]    = "Jugando como",
        ["host.identity.reading"]   = "(leyendo del juego…)",
        ["host.identity.noSave"]    = "⚠ Carga una partida primero — el nombre se lee del juego cargado.",
        ["host.identity.fallback"]  = "(sin partida cargada — se hospedará como 'Host')",
        ["host.label.port"]         = "Puerto",
        ["host.btn.start"]          = "▶  Iniciar hospedaje",
        ["host.btn.stop"]           = "■  Detener hospedaje",
        ["host.btn.copy"]           = "📋  Copiar código al portapapeles",
        ["host.btn.back"]           = "←  Atrás",
        ["host.status.notHosting"]  = "Estado: sin hospedar",
        ["host.status.mainMenu"]    = "Estado: en menú principal — carga una partida antes de hospedar.",
        ["host.status.hosting"]     = "Estado: hospedando — {0} compañero(s) conectado(s)",
        ["host.status.codeCopied"]  = "Estado: ¡código copiado!",
        ["host.label.joinCode"]     = "Código (envíalo a tu amigo)",
        ["host.code.notReady"]      = "(inicia el hospedaje para generar)",
        ["host.warn.noSave"]        = "⚠ Debes estar en el juego para hospedar. Carga una partida y vuelve.",

        // Join panel
        ["join.title"]              = "Unirse a sesión",
        ["join.tagline"]            = "Pega un código de unión, o introduce manualmente la IP y el puerto del host. Si es tu primera vez en el mundo del host, se te pedirá crear tu personaje al conectar.",
        ["join.label.code"]         = "Código (recomendado)",
        ["join.code.placeholder"]   = "Pega aquí el código",
        ["join.label.manual"]       = "O introduce manualmente",
        ["join.placeholder.ip"]     = "IP del host",
        ["join.btn.connect"]        = "🔌  Conectar",
        ["join.btn.back"]           = "←  Atrás",
        ["join.status.connecting"]  = "Conectando a {0}:{1}…",
        ["join.status.failed"]      = "Falló la conexión — comprueba IP / puerto.",
        ["join.status.codeOk"]      = "Código OK — {0}:{1}",
        ["join.status.codeOkCity"]  = "Código OK — {0}:{1} (ciudad: {2})",
        ["join.status.codeBad"]     = "Código no reconocido — introduce manualmente.",
        ["join.warn.haveSave"]      = "⚠ Vuelve al menú principal — no puedes unirte mientras tu propia partida esté cargada.",
        ["join.state.haveSave"]     = "⚠ Hay una partida cargada. Vuelve al menú principal antes de unirte.",
        ["join.state.menuOk"]       = "✔ En el menú principal — listo para unirse.",

        // Lobby panel
        ["lobby.title"]              = "Lobby",
        ["lobby.btn.disconnect"]     = "Desconectar",
        ["lobby.btn.close"]          = "Cerrar (mantener conexión)",
        ["lobby.btn.settings"]       = "⚙  Ajustes",
        ["lobby.label.players"]      = "Jugadores:",
        ["lobby.label.you"]          = "(tú)",
        ["lobby.label.host"]         = "[HOST]",

        // Create-character panel
        ["create.title"]             = "Crear tu personaje",
        ["create.context"]           = "¡Bienvenido a {0}! Te estás uniendo a {1}.\nEste nombre lo usarán los NPC, los documentos de identidad y los archivos del caso para tu personaje. No puede estar vacío y el host lo guarda para visitas futuras.",
        ["create.label.first"]       = "Nombre",
        ["create.label.surname"]     = "Apellido",
        ["create.placeholder.first"] = "p. ej. Alex",
        ["create.placeholder.sur"]   = "p. ej. Reyes",
        ["create.btn.submit"]        = "✓  Crear personaje y unirse",
        ["create.btn.cancel"]        = "✕  Cancelar y desconectar",
        ["create.status.submitting"] = "Enviando «{0} {1}» al host…",
        ["create.reject.generic"]    = "El host rechazó el nombre.",
        ["create.reject.with"]       = "El host rechazó: {0}",

        // Settings panel
        ["settings.title"]           = "Ajustes",
        ["settings.tagline"]         = "Las opciones se conservan entre ejecuciones.",
        ["settings.toggle.statusHud"]   = "Mostrar lista de jugadores (arriba derecha)",
        ["settings.toggle.chat"]        = "Mostrar ventana de chat (abajo izquierda)",
        ["settings.toggle.nameTags"]    = "Mostrar nombres sobre los jugadores",
        ["settings.toggle.banners"]     = "Mostrar avisos (sueño / teléfono)",
        ["settings.label.language"]     = "Idioma (requiere reinicio)",
        ["settings.lang.note"]          = "Edita BepInEx/config/com.sodcoop.mod.cfg → [General] → LanguageOverride. \"auto\" usa el idioma del juego.",
        ["settings.btn.back"]           = "←  Atrás",

        // IpInfo panel
        ["ipinfo.title"]             = "Tus direcciones IP",
        ["ipinfo.btn.back"]          = "←  Atrás",

        // Chat / system messages
        ["chat.system.connected"]    = "¡Conectado a la sesión!",
        ["chat.system.disconnected"] = "Desconectado: {0}",
        ["chat.system.joined"]       = "{0} se unió a la partida.",
        ["chat.system.left"]         = "{0} salió de la partida.",
    };

    // ─────────────────────────────────────────────────────────────────────
    //  Chinese (Simplified)
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> Zh = new()
    {
        // Main panel
        ["main.title"]              = "合作多人模式",
        ["main.tagline"]            = "与队友连线,共同调查案件。",
        ["main.btn.host"]           = "🛜  创建房间",
        ["main.btn.join"]           = "🔌  加入房间",
        ["main.btn.showIp"]         = "📡  显示我的 IP",
        ["main.btn.settings"]       = "⚙  设置",
        ["main.btn.close"]          = "✕  关闭菜单",

        // Host panel
        ["host.title"]              = "创建房间",
        ["host.tagline"]            = "你将以已加载存档的角色身份建立房间。名称会从存档中读取——开始前请确认已进入游戏。",
        ["host.label.playingAs"]    = "扮演",
        ["host.identity.reading"]   = "(正在从游戏读取…)",
        ["host.identity.noSave"]    = "⚠ 请先加载存档——名称从已加载的游戏中读取。",
        ["host.identity.fallback"]  = "(未加载存档——将以 'Host' 名称建立房间)",
        ["host.label.port"]         = "端口",
        ["host.btn.start"]          = "▶  开始托管",
        ["host.btn.stop"]           = "■  停止托管",
        ["host.btn.copy"]           = "📋  复制代码到剪贴板",
        ["host.btn.back"]           = "←  返回",
        ["host.status.notHosting"]  = "状态:未托管",
        ["host.status.mainMenu"]    = "状态:在主菜单——托管前请加载存档。",
        ["host.status.hosting"]     = "状态:托管中——已连接 {0} 位玩家",
        ["host.status.codeCopied"]  = "状态:代码已复制!",
        ["host.label.joinCode"]     = "加入代码(发送给好友)",
        ["host.code.notReady"]      = "(开始托管后生成)",
        ["host.warn.noSave"]        = "⚠ 你必须在游戏中才能托管。请先加载存档,然后返回。",

        // Join panel
        ["join.title"]              = "加入房间",
        ["join.tagline"]            = "粘贴加入代码,或手动输入主机的 IP 和端口。若你是第一次进入主机的世界,连接后会要求你创建角色。",
        ["join.label.code"]         = "加入代码(推荐)",
        ["join.code.placeholder"]   = "在此粘贴代码",
        ["join.label.manual"]       = "或手动输入",
        ["join.placeholder.ip"]     = "主机 IP",
        ["join.btn.connect"]        = "🔌  连接",
        ["join.btn.back"]           = "←  返回",
        ["join.status.connecting"]  = "正在连接 {0}:{1}…",
        ["join.status.failed"]      = "连接失败——请检查 IP 和端口。",
        ["join.status.codeOk"]      = "代码有效 — {0}:{1}",
        ["join.status.codeOkCity"]  = "代码有效 — {0}:{1} (城市:{2})",
        ["join.status.codeBad"]     = "无法识别代码——请手动输入。",
        ["join.warn.haveSave"]      = "⚠ 请先返回主菜单——已加载自己的存档时无法加入。",
        ["join.state.haveSave"]     = "⚠ 当前已加载存档。加入前请返回主菜单。",
        ["join.state.menuOk"]       = "✔ 在主菜单——可以加入。",

        // Lobby panel
        ["lobby.title"]              = "大厅",
        ["lobby.btn.disconnect"]     = "断开连接",
        ["lobby.btn.close"]          = "关闭(保持连接)",
        ["lobby.btn.settings"]       = "⚙  设置",
        ["lobby.label.players"]      = "玩家:",
        ["lobby.label.you"]          = "(你)",
        ["lobby.label.host"]         = "[主机]",

        // Create-character panel
        ["create.title"]             = "创建你的角色",
        ["create.context"]           = "欢迎来到 {0}!你正在加入 {1}。\nNPC、身份证件和案件档案都会使用这个名称。它不能为空,主机会保存它以供未来访问使用。",
        ["create.label.first"]       = "名",
        ["create.label.surname"]     = "姓",
        ["create.placeholder.first"] = "例如:志强",
        ["create.placeholder.sur"]   = "例如:王",
        ["create.btn.submit"]        = "✓  创建角色并加入",
        ["create.btn.cancel"]        = "✕  取消并断开",
        ["create.status.submitting"] = "正在向主机提交「{0} {1}」…",
        ["create.reject.generic"]    = "主机拒绝了该名称。",
        ["create.reject.with"]       = "主机拒绝:{0}",

        // Settings panel
        ["settings.title"]           = "设置",
        ["settings.tagline"]         = "这些开关会在重启游戏后保留。",
        ["settings.toggle.statusHud"]   = "显示玩家列表(右上角)",
        ["settings.toggle.chat"]        = "显示聊天窗口(左下角)",
        ["settings.toggle.nameTags"]    = "在玩家头顶显示昵称",
        ["settings.toggle.banners"]     = "显示通知横幅(睡眠 / 电话)",
        ["settings.label.language"]     = "语言(需重启)",
        ["settings.lang.note"]          = "编辑 BepInEx/config/com.sodcoop.mod.cfg → [General] → LanguageOverride。\"auto\" 跟随游戏语言。",
        ["settings.btn.back"]           = "←  返回",

        // IpInfo panel
        ["ipinfo.title"]             = "你的 IP 地址",
        ["ipinfo.btn.back"]          = "←  返回",

        // Chat / system messages
        ["chat.system.connected"]    = "已连接至会话!",
        ["chat.system.disconnected"] = "已断开:{0}",
        ["chat.system.joined"]       = "{0} 加入了游戏。",
        ["chat.system.left"]         = "{0} 离开了游戏。",
    };

    // ─────────────────────────────────────────────────────────────────────
    //  French
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> Fr = new()
    {
        // Main panel
        ["main.title"]              = "Multijoueur coopératif",
        ["main.tagline"]            = "Rejoins un coéquipier pour enquêter ensemble.",
        ["main.btn.host"]           = "🛜  Héberger une session",
        ["main.btn.join"]           = "🔌  Rejoindre une session",
        ["main.btn.showIp"]         = "📡  Afficher mon IP",
        ["main.btn.settings"]       = "⚙  Paramètres",
        ["main.btn.close"]          = "✕  Fermer le menu",

        // Host panel
        ["host.title"]              = "Héberger une session",
        ["host.tagline"]            = "Tu hébergeras avec ton personnage existant. Le nom est lu depuis la sauvegarde chargée — assure-toi d'être en jeu avant de démarrer.",
        ["host.label.playingAs"]    = "Tu joues",
        ["host.identity.reading"]   = "(lecture depuis le jeu…)",
        ["host.identity.noSave"]    = "⚠ Charge d'abord une sauvegarde — le nom est lu depuis le jeu chargé.",
        ["host.identity.fallback"]  = "(aucune sauvegarde chargée — hébergera sous 'Host')",
        ["host.label.port"]         = "Port",
        ["host.btn.start"]          = "▶  Démarrer l'hébergement",
        ["host.btn.stop"]           = "■  Arrêter l'hébergement",
        ["host.btn.copy"]           = "📋  Copier le code dans le presse-papiers",
        ["host.btn.back"]           = "←  Retour",
        ["host.status.notHosting"]  = "Statut : pas d'hébergement",
        ["host.status.mainMenu"]    = "Statut : menu principal — charge une sauvegarde avant d'héberger.",
        ["host.status.hosting"]     = "Statut : hébergement — {0} pair(s) connecté(s)",
        ["host.status.codeCopied"]  = "Statut : code copié !",
        ["host.label.joinCode"]     = "Code de connexion (envoie-le à ton ami)",
        ["host.code.notReady"]      = "(démarre l'hébergement pour générer)",
        ["host.warn.noSave"]        = "⚠ Tu dois être en jeu pour héberger. Charge une sauvegarde et reviens.",

        // Join panel
        ["join.title"]              = "Rejoindre une session",
        ["join.tagline"]            = "Colle un code de connexion, ou saisis l'IP et le port de l'hôte manuellement. Si c'est ta première fois dans le monde de l'hôte, on te demandera de créer ton personnage après la connexion.",
        ["join.label.code"]         = "Code de connexion (recommandé)",
        ["join.code.placeholder"]   = "Colle le code ici",
        ["join.label.manual"]       = "Ou saisir manuellement",
        ["join.placeholder.ip"]     = "IP de l'hôte",
        ["join.btn.connect"]        = "🔌  Se connecter",
        ["join.btn.back"]           = "←  Retour",
        ["join.status.connecting"]  = "Connexion à {0}:{1}…",
        ["join.status.failed"]      = "Échec de connexion — vérifie l'IP / le port.",
        ["join.status.codeOk"]      = "Code OK — {0}:{1}",
        ["join.status.codeOkCity"]  = "Code OK — {0}:{1} (ville : {2})",
        ["join.status.codeBad"]     = "Code non reconnu — saisis manuellement.",
        ["join.warn.haveSave"]      = "⚠ Retourne d'abord au menu principal — impossible de rejoindre tant que ta sauvegarde est chargée.",
        ["join.state.haveSave"]     = "⚠ Une sauvegarde est chargée. Retourne au menu principal avant de rejoindre.",
        ["join.state.menuOk"]       = "✔ Au menu principal — prêt à rejoindre.",

        // Lobby panel
        ["lobby.title"]              = "Salon",
        ["lobby.btn.disconnect"]     = "Se déconnecter",
        ["lobby.btn.close"]          = "Fermer (rester connecté)",
        ["lobby.btn.settings"]       = "⚙  Paramètres",
        ["lobby.label.players"]      = "Joueurs :",
        ["lobby.label.you"]          = "(toi)",
        ["lobby.label.host"]         = "[HÔTE]",

        // Create-character panel
        ["create.title"]             = "Créer ton personnage",
        ["create.context"]           = "Bienvenue à {0} ! Tu rejoins {1}.\nCe nom sera utilisé par les PNJ, les papiers d'identité et les dossiers d'enquête de ton personnage. Il ne peut pas être vide et l'hôte le sauvegarde pour les visites futures.",
        ["create.label.first"]       = "Prénom",
        ["create.label.surname"]     = "Nom",
        ["create.placeholder.first"] = "ex. Alex",
        ["create.placeholder.sur"]   = "ex. Reyes",
        ["create.btn.submit"]        = "✓  Créer le personnage et rejoindre",
        ["create.btn.cancel"]        = "✕  Annuler et déconnecter",
        ["create.status.submitting"] = "Envoi de « {0} {1} » à l'hôte…",
        ["create.reject.generic"]    = "L'hôte a rejeté le nom.",
        ["create.reject.with"]       = "L'hôte a rejeté : {0}",

        // Settings panel
        ["settings.title"]           = "Paramètres",
        ["settings.tagline"]         = "Les bascules persistent entre les lancements du jeu.",
        ["settings.toggle.statusHud"]   = "Afficher la liste des joueurs (en haut à droite)",
        ["settings.toggle.chat"]        = "Afficher la fenêtre de chat (en bas à gauche)",
        ["settings.toggle.nameTags"]    = "Afficher les pseudos au-dessus des joueurs",
        ["settings.toggle.banners"]     = "Afficher les bannières (sommeil / téléphone)",
        ["settings.label.language"]     = "Langue (redémarrage requis)",
        ["settings.lang.note"]          = "Modifie BepInEx/config/com.sodcoop.mod.cfg → [General] → LanguageOverride. « auto » suit la langue du jeu.",
        ["settings.btn.back"]           = "←  Retour",

        // IpInfo panel
        ["ipinfo.title"]             = "Tes adresses IP",
        ["ipinfo.btn.back"]          = "←  Retour",

        // Chat / system messages
        ["chat.system.connected"]    = "Connecté à la session !",
        ["chat.system.disconnected"] = "Déconnecté : {0}",
        ["chat.system.joined"]       = "{0} a rejoint la partie.",
        ["chat.system.left"]         = "{0} a quitté la partie.",
    };

    // ─────────────────────────────────────────────────────────────────────
    //  Italian
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> It = new()
    {
        // Main panel
        ["main.title"]              = "Multigiocatore cooperativo",
        ["main.tagline"]            = "Connettiti con un compagno per indagare insieme.",
        ["main.btn.host"]           = "🛜  Ospita una sessione",
        ["main.btn.join"]           = "🔌  Unisciti a una sessione",
        ["main.btn.showIp"]         = "📡  Mostra il mio IP",
        ["main.btn.settings"]       = "⚙  Impostazioni",
        ["main.btn.close"]          = "✕  Chiudi menu",

        // Host panel
        ["host.title"]              = "Ospita una sessione",
        ["host.tagline"]            = "Ospiterai con il tuo personaggio esistente. Il nome viene letto dal salvataggio caricato — assicurati di essere in gioco prima di iniziare.",
        ["host.label.playingAs"]    = "Stai giocando come",
        ["host.identity.reading"]   = "(lettura dal gioco…)",
        ["host.identity.noSave"]    = "⚠ Carica prima un salvataggio — il nome viene letto dal gioco caricato.",
        ["host.identity.fallback"]  = "(nessun salvataggio caricato — ospiterà come 'Host')",
        ["host.label.port"]         = "Porta",
        ["host.btn.start"]          = "▶  Avvia hosting",
        ["host.btn.stop"]           = "■  Ferma hosting",
        ["host.btn.copy"]           = "📋  Copia il codice negli appunti",
        ["host.btn.back"]           = "←  Indietro",
        ["host.status.notHosting"]  = "Stato: non in hosting",
        ["host.status.mainMenu"]    = "Stato: nel menu principale — carica un salvataggio prima di ospitare.",
        ["host.status.hosting"]     = "Stato: in hosting — {0} compagno(i) connesso(i)",
        ["host.status.codeCopied"]  = "Stato: codice copiato!",
        ["host.label.joinCode"]     = "Codice di connessione (invialo a un amico)",
        ["host.code.notReady"]      = "(avvia l'hosting per generare)",
        ["host.warn.noSave"]        = "⚠ Devi essere in gioco per ospitare. Carica un salvataggio e torna.",

        // Join panel
        ["join.title"]              = "Unisciti a una sessione",
        ["join.tagline"]            = "Incolla un codice di connessione, o inserisci manualmente l'IP e la porta dell'host. Se è la tua prima volta nel mondo dell'host, ti verrà chiesto di creare il tuo personaggio dopo la connessione.",
        ["join.label.code"]         = "Codice di connessione (consigliato)",
        ["join.code.placeholder"]   = "Incolla qui il codice",
        ["join.label.manual"]       = "O inserisci manualmente",
        ["join.placeholder.ip"]     = "IP dell'host",
        ["join.btn.connect"]        = "🔌  Connetti",
        ["join.btn.back"]           = "←  Indietro",
        ["join.status.connecting"]  = "Connessione a {0}:{1}…",
        ["join.status.failed"]      = "Connessione fallita — controlla IP / porta.",
        ["join.status.codeOk"]      = "Codice OK — {0}:{1}",
        ["join.status.codeOkCity"]  = "Codice OK — {0}:{1} (città: {2})",
        ["join.status.codeBad"]     = "Codice non riconosciuto — inseriscilo manualmente.",
        ["join.warn.haveSave"]      = "⚠ Torna prima al menu principale — non puoi unirti mentre il tuo salvataggio è caricato.",
        ["join.state.haveSave"]     = "⚠ È caricato un salvataggio. Torna al menu principale prima di unirti.",
        ["join.state.menuOk"]       = "✔ Nel menu principale — pronto per unirti.",

        // Lobby panel
        ["lobby.title"]              = "Lobby",
        ["lobby.btn.disconnect"]     = "Disconnetti",
        ["lobby.btn.close"]          = "Chiudi (resta connesso)",
        ["lobby.btn.settings"]       = "⚙  Impostazioni",
        ["lobby.label.players"]      = "Giocatori:",
        ["lobby.label.you"]          = "(tu)",
        ["lobby.label.host"]         = "[HOST]",

        // Create-character panel
        ["create.title"]             = "Crea il tuo personaggio",
        ["create.context"]           = "Benvenuto a {0}! Ti stai unendo a {1}.\nQuesto nome verrà usato dagli NPC, dai documenti d'identità e dai fascicoli del caso del tuo personaggio. Non può essere vuoto e l'host lo salva per le visite future.",
        ["create.label.first"]       = "Nome",
        ["create.label.surname"]     = "Cognome",
        ["create.placeholder.first"] = "es. Alex",
        ["create.placeholder.sur"]   = "es. Rossi",
        ["create.btn.submit"]        = "✓  Crea personaggio e unisciti",
        ["create.btn.cancel"]        = "✕  Annulla e disconnetti",
        ["create.status.submitting"] = "Invio di «{0} {1}» all'host…",
        ["create.reject.generic"]    = "L'host ha rifiutato il nome.",
        ["create.reject.with"]       = "L'host ha rifiutato: {0}",

        // Settings panel
        ["settings.title"]           = "Impostazioni",
        ["settings.tagline"]         = "Le opzioni rimangono salvate tra gli avvii del gioco.",
        ["settings.toggle.statusHud"]   = "Mostra elenco giocatori (in alto a destra)",
        ["settings.toggle.chat"]        = "Mostra finestra chat (in basso a sinistra)",
        ["settings.toggle.nameTags"]    = "Mostra nick sopra i giocatori",
        ["settings.toggle.banners"]     = "Mostra banner (sonno / telefono)",
        ["settings.label.language"]     = "Lingua (riavvio richiesto)",
        ["settings.lang.note"]          = "Modifica BepInEx/config/com.sodcoop.mod.cfg → [General] → LanguageOverride. \"auto\" segue la lingua del gioco.",
        ["settings.btn.back"]           = "←  Indietro",

        // IpInfo panel
        ["ipinfo.title"]             = "I tuoi indirizzi IP",
        ["ipinfo.btn.back"]          = "←  Indietro",

        // Chat / system messages
        ["chat.system.connected"]    = "Connesso alla sessione!",
        ["chat.system.disconnected"] = "Disconnesso: {0}",
        ["chat.system.joined"]       = "{0} è entrato in partita.",
        ["chat.system.left"]         = "{0} è uscito dalla partita.",
    };

    // ─────────────────────────────────────────────────────────────────────
    //  German
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> De = new()
    {
        // Main panel
        ["main.title"]              = "Koop-Mehrspieler",
        ["main.tagline"]            = "Verbinde dich mit einem Mitspieler und ermittelt gemeinsam.",
        ["main.btn.host"]           = "🛜  Sitzung hosten",
        ["main.btn.join"]           = "🔌  Sitzung beitreten",
        ["main.btn.showIp"]         = "📡  Meine IP anzeigen",
        ["main.btn.settings"]       = "⚙  Einstellungen",
        ["main.btn.close"]          = "✕  Menü schließen",

        // Host panel
        ["host.title"]              = "Sitzung hosten",
        ["host.tagline"]            = "Du hostest mit deinem bestehenden Spielcharakter. Der Name wird aus dem geladenen Spielstand gelesen — stelle sicher, dass du im Spiel bist, bevor du startest.",
        ["host.label.playingAs"]    = "Du spielst als",
        ["host.identity.reading"]   = "(lese aus dem Spiel…)",
        ["host.identity.noSave"]    = "⚠ Lade zuerst einen Spielstand — der Name wird aus dem geladenen Spiel gelesen.",
        ["host.identity.fallback"]  = "(kein Spielstand geladen — wird als 'Host' hosten)",
        ["host.label.port"]         = "Port",
        ["host.btn.start"]          = "▶  Hosting starten",
        ["host.btn.stop"]           = "■  Hosting stoppen",
        ["host.btn.copy"]           = "📋  Code in Zwischenablage kopieren",
        ["host.btn.back"]           = "←  Zurück",
        ["host.status.notHosting"]  = "Status: nicht am Hosten",
        ["host.status.mainMenu"]    = "Status: im Hauptmenü — lade einen Spielstand vor dem Hosten.",
        ["host.status.hosting"]     = "Status: am Hosten — {0} Mitspieler verbunden",
        ["host.status.codeCopied"]  = "Status: Code kopiert!",
        ["host.label.joinCode"]     = "Beitrittscode (an deinen Freund senden)",
        ["host.code.notReady"]      = "(Hosting starten, um zu generieren)",
        ["host.warn.noSave"]        = "⚠ Du musst im Spiel sein, um zu hosten. Lade einen Spielstand und komm zurück.",

        // Join panel
        ["join.title"]              = "Sitzung beitreten",
        ["join.tagline"]            = "Füge einen Beitrittscode ein oder gib IP und Port des Hosts manuell ein. Wenn du zum ersten Mal in der Welt des Hosts bist, wirst du nach dem Verbinden zur Charaktererstellung aufgefordert.",
        ["join.label.code"]         = "Beitrittscode (empfohlen)",
        ["join.code.placeholder"]   = "Code hier einfügen",
        ["join.label.manual"]       = "Oder manuell eingeben",
        ["join.placeholder.ip"]     = "Host-IP",
        ["join.btn.connect"]        = "🔌  Verbinden",
        ["join.btn.back"]           = "←  Zurück",
        ["join.status.connecting"]  = "Verbinde mit {0}:{1}…",
        ["join.status.failed"]      = "Verbindung fehlgeschlagen — IP / Port prüfen.",
        ["join.status.codeOk"]      = "Code OK — {0}:{1}",
        ["join.status.codeOkCity"]  = "Code OK — {0}:{1} (Stadt: {2})",
        ["join.status.codeBad"]     = "Code nicht erkannt — manuell einfügen.",
        ["join.warn.haveSave"]      = "⚠ Geh zuerst zurück ins Hauptmenü — beitreten geht nicht, solange dein eigener Spielstand geladen ist.",
        ["join.state.haveSave"]     = "⚠ Es ist gerade ein Spielstand geladen. Geh ins Hauptmenü, bevor du beitrittst.",
        ["join.state.menuOk"]       = "✔ Im Hauptmenü — bereit zum Beitreten.",

        // Lobby panel
        ["lobby.title"]              = "Lobby",
        ["lobby.btn.disconnect"]     = "Trennen",
        ["lobby.btn.close"]          = "Schließen (verbunden bleiben)",
        ["lobby.btn.settings"]       = "⚙  Einstellungen",
        ["lobby.label.players"]      = "Spieler:",
        ["lobby.label.you"]          = "(du)",
        ["lobby.label.host"]         = "[HOST]",

        // Create-character panel
        ["create.title"]             = "Charakter erstellen",
        ["create.context"]           = "Willkommen in {0}! Du trittst {1} bei.\nDieser Name wird von NPCs, Ausweispapieren und Fallakten für deinen Charakter verwendet. Er darf nicht leer sein und wird vom Host für künftige Besuche gespeichert.",
        ["create.label.first"]       = "Vorname",
        ["create.label.surname"]     = "Nachname",
        ["create.placeholder.first"] = "z. B. Alex",
        ["create.placeholder.sur"]   = "z. B. Müller",
        ["create.btn.submit"]        = "✓  Charakter erstellen & beitreten",
        ["create.btn.cancel"]        = "✕  Abbrechen & trennen",
        ["create.status.submitting"] = "Sende „{0} {1}\" an den Host…",
        ["create.reject.generic"]    = "Host hat den Namen abgelehnt.",
        ["create.reject.with"]       = "Host hat abgelehnt: {0}",

        // Settings panel
        ["settings.title"]           = "Einstellungen",
        ["settings.tagline"]         = "Schalter bleiben zwischen Spielstarts erhalten.",
        ["settings.toggle.statusHud"]   = "Spielerliste anzeigen (oben rechts)",
        ["settings.toggle.chat"]        = "Chatfenster anzeigen (unten links)",
        ["settings.toggle.nameTags"]    = "Namen über Spielern anzeigen",
        ["settings.toggle.banners"]     = "Hinweisbanner anzeigen (Schlaf / Telefon)",
        ["settings.label.language"]     = "Sprache (Neustart erforderlich)",
        ["settings.lang.note"]          = "Bearbeite BepInEx/config/com.sodcoop.mod.cfg → [General] → LanguageOverride. „auto\" folgt der Spielsprache.",
        ["settings.btn.back"]           = "←  Zurück",

        // IpInfo panel
        ["ipinfo.title"]             = "Deine IP-Adressen",
        ["ipinfo.btn.back"]          = "←  Zurück",

        // Chat / system messages
        ["chat.system.connected"]    = "Mit Sitzung verbunden!",
        ["chat.system.disconnected"] = "Getrennt: {0}",
        ["chat.system.joined"]       = "{0} ist dem Spiel beigetreten.",
        ["chat.system.left"]         = "{0} hat das Spiel verlassen.",
    };
}
