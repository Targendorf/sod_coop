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
        ["host.tagline"]            = "You'll host as your existing in-game character. Your name is read from the loaded save — make sure you're in-game before starting.",
        ["host.label.playingAs"]    = "Playing as",
        ["host.identity.reading"]   = "(reading from game…)",
        ["host.identity.noSave"]    = "⚠ Load a save first — your character is read from the loaded game.",
        ["host.identity.fallback"]  = "(no save loaded — will host as 'Host')",
        ["host.label.port"]         = "Port",
        ["host.btn.start"]          = "▶  Start Hosting",
        ["host.btn.stop"]           = "■  Stop Hosting",
        ["host.btn.copy"]           = "📋  Copy code to clipboard",
        ["host.btn.back"]           = "←  Back",
        ["host.status.notHosting"]  = "Status: not hosting",
        ["host.status.mainMenu"]    = "Status: in main menu — start or load a save before hosting.",
        ["host.status.hosting"]     = "Status: hosting — {0} peer(s) connected",
        ["host.status.codeCopied"]  = "Status: code copied!",
        ["host.label.joinCode"]     = "Join Code (paste this to your friend)",
        ["host.code.notReady"]      = "(start hosting to generate)",
        ["host.warn.noSave"]        = "⚠ You must be in-game to host. Load a save first, then come back.",

        // Join panel
        ["join.title"]              = "Join a session",
        ["join.tagline"]            = "Paste a join code, or enter the host's IP and port manually. If this is your first time on the host's world, you'll be asked to create your character after connecting.",
        ["join.label.code"]         = "Join code (recommended)",
        ["join.code.placeholder"]   = "Paste join code here",
        ["join.label.manual"]       = "Or enter manually",
        ["join.placeholder.ip"]     = "Host IP",
        ["join.btn.connect"]        = "🔌  Connect",
        ["join.btn.back"]           = "←  Back",
        ["join.status.connecting"]  = "Connecting to {0}:{1}…",
        ["join.status.failed"]      = "Connect failed — check IP / port.",
        ["join.status.codeOk"]      = "Code OK — {0}:{1}",
        ["join.status.codeOkCity"]  = "Code OK — {0}:{1} (city: {2})",
        ["join.status.codeBad"]     = "Code unrecognised — paste manually if needed.",
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
        ["settings.btn.back"]           = "←  Back",

        // IpInfo panel
        ["ipinfo.title"]             = "Your IP addresses",
        ["ipinfo.btn.back"]          = "←  Back",

        // Chat / system messages
        ["chat.system.connected"]    = "Connected to session!",
        ["chat.system.disconnected"] = "Disconnected: {0}",
        ["chat.system.joined"]       = "{0} joined the game.",
        ["chat.system.left"]         = "{0} left the game.",
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
    };

    // ─────────────────────────────────────────────────────────────────────
    //  Ukrainian — STUB. Translators welcome.
    //  Keys not present here fall back to En at lookup time.
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> Uk = new()
    {
        ["main.title"]    = "Кооп-мультиплеєр",
        ["main.btn.host"] = "🛜  Створити сесію",
        ["main.btn.join"] = "🔌  Підключитися",
        // TODO: повна локалізація — додавайте ключі за зразком En / Ru.
    };

    // ─────────────────────────────────────────────────────────────────────
    //  Spanish — STUB. Translators welcome.
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> Es = new()
    {
        ["main.title"]    = "Multijugador cooperativo",
        ["main.btn.host"] = "🛜  Hospedar sesión",
        ["main.btn.join"] = "🔌  Unirse a sesión",
        // TODO: localización completa — añade claves siguiendo el ejemplo de En / Ru.
    };

    // ─────────────────────────────────────────────────────────────────────
    //  Chinese (Simplified) — STUB. Translators welcome.
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> Zh = new()
    {
        ["main.title"]    = "合作多人模式",
        ["main.btn.host"] = "🛜  创建房间",
        ["main.btn.join"] = "🔌  加入房间",
        // TODO: 完整本地化 — 按照 En / Ru 模式添加键值。
    };

    // ─────────────────────────────────────────────────────────────────────
    //  German — STUB. Translators welcome.
    // ─────────────────────────────────────────────────────────────────────

    public static readonly Dictionary<string, string> De = new()
    {
        ["main.title"]    = "Koop-Mehrspieler",
        ["main.btn.host"] = "🛜  Sitzung hosten",
        ["main.btn.join"] = "🔌  Sitzung beitreten",
        // TODO: vollständige Lokalisierung — Schlüssel nach En / Ru ergänzen.
    };
}
