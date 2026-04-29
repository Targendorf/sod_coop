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
