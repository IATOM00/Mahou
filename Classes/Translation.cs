using System;

namespace Mahou
{
    static class Translation
    {
        #region English
        public static string[] UIEN = new string[] {
          /*///////////////Main UI\\\\\\\\\\\\\\\\\
          /*00-03*/"Mahou","Start with Windows","","Hotkeys",
          /*04-06*/"Convert word","Convert selection","Convert line",
          /*07-10*/"CS-Switch","Re-Press","Re-Select","Switch layout by key:",
          /*11-14*/"Block CTRL","Tray icon","Cycle Mode","Emu",
          /*15-16*/"Switch between layouts","Language",
          /*17-20*/"Apply","OK","Cancel","Help",
          /*///////////////Reserved legacy UI\\\\\\\\\\\\\\\\\
          /*21-23*/"","","",
          /*24-28*/"","","","","",
          /*29-32*/"","","","",
          /*33-34*/"","",
          /*35-35*/"",
          /*///////////////MoreConfigs UI\\\\\\\\\\\\\\\\\
          /*36-36*/"Use specific layout changing by Left/Right CTRLS",
          /*37-39*/"LCtrl switches to:","RCtrl switches to:","More configs",
          /*40-41*/"Symbol Ignore:","More Tries:",
          /*///////////////Tray Icon\\\\\\\\\\\\\\\\\
          /*42-44*/"Show/Hide","Exit","Mahou\nLayout switcher.",
          /*///////////////Back to MoreConfigs UI\\\\\\\\\\\\\\\\\
          /*45-47*/"Display language:","Refresh rate(ms):", "Colors:",
          /*///////////////Reserved legacy UI\\\\\\\\\\\\\\\\\
          /*48-51*/"","","","",
          /*///////////////Back to MoreConfigs UI\\\\\\\\\\\\\\\\\
          /*52-58*/"Font","Size:","Position:", "More", "Back","Double hotkey:","Delay:",
  	      /*59-60*/"Experimental CS-Switch+","Transparent background in language tooltip",
  	      /*61-63*/"Use snippets", "On change","Highlight ScrollLock when language 1 is active.",
          /*64-65*/"Convert multiple words hotkey:",""};
        public static string[] ToolTipsEN = new string[] {
          /*///////////////Main TT\\\\\\\\\\\\\\\\\
          /*00*/"While this option enabled, [Convert word] and [Convert line] and [Convert selection with \"CS-Switch\" enabled]\n"+
          "will just cycle between all locales instead of switching between selected in settings.\nThis mode works for almost all programs.\n"+
          "If there is program in which [Convert word] or [Convert line] or [Convert selection with \"CS-Switch\" enabled] not work,\ntry with this option enabled.\n"+
          "If you have just 2 layouts(input languages) it is HIGHLY RECOMMENDED to turn it ON, and \"Emu\" too to ON.",
          /*01*/"This is current hotkey for \"Convert word\".\nPress any key to assign it, or key with modifiers(ALT,CTRL,SHIFT).",
          /*02*/"This is current hotkey for \"Convert selection\".\nPress any key to assign it, or key with modifiers(ALT,CTRL,SHIFT).",
          /*03*/"This is current hotkey for \"Convert line\".\nPress any key to assign it, or key with modifiers(ALT,CTRL,SHIFT)",
          /*04*/"Mahou.",
          /*05*/"Toggles visibility of icon in a tray.\nIf it is hidden, to show configs window hit CTRL+ALT+SHIFT+INSERT or just run Mahou.exe again.",
          /*06*/"",
          /*07*/"Blocks hotkeys that use Control,\nwhen \"Switch layout by key\" is set to Left/Right Control.",
          /*08*/"Switching layout depends on \"Cycle Mode\" & \"Emu\" options.",
          /*09*/"If this option enabled, Cycle Mode will use Emulation of Alt+Shift/Win+Space instead \"sending window message\" that changes layout.",
          /*10*/"If this option enabled, Covert selection will use layout switching.\nAll characters will be rewriten as they must.(no problems with symbols\nThere also an CS-Switch+ in More Configs page 2.",
          /*11*/"Only works when Cycle Mode is OFF.",
          /*12*/"If enabled, modifiers will be repressed after conversion.\nDue to new hotkey managment modifiers NEVER stuck(recommenden).",
          /*13*/"If enabled, pressing ONE space AFTER word will not clear last word.",
          /*14*/"Enabling this, will reselect text after \"Convert selection\".",
          /*15*/"Select type for Emulate change layout.\nWin+Space works only in Windows 10!!\nWin+Space also will work better in Metro apps.",
          /*///////////////MoreConfigs TT\\\\\\\\\\\\\\\\\
          /*16*/"Pressing LCtrl will switch layout to selected.",
          /*17*/"Pressing RCtrl will switch layout to selected.",
          /*18*/"Enabling this will disable LCtrl/RCtrl from \"Switch layout by key\".\nWhile this enabled pressing LCtrl/RCtrl will switch to specified layout.", 
          /*/BACK TO MAIN
          /*19*/"Emu Type",
          /*/BACK TO MoreConfigs
          /*20*/"If enabled, symbols []{};':\",./<>? will be ignored and will not be converted.\nWorks in Convert word, Convert line, Convert selection with Cylce Mode and CS-Switch enabled.\nWon't work if you have >2 layouts an Cycle Mode enabled!",
          /*21*/"Enables more tries to get selected text in Convert selection.",
          /*22*/"If enabled, mouse cursor hovers text it will display a small tip of what langauge is now using.",
          /*23*/"Speed of checking cursor type.(if it equals \"I\" )",
          /*24*/"Colors and font of small tip.(Left - foreground, Right - background)",
          /*25-26*/"Size of language tooltip.", "Position relative to mouse position.",
          /*27*/"Enables double hotkey ability,\nand makes it possible to set modifies to hotkey.",
          /*28*/"Time to wait second hotkey press(ms)", 
          /*29*/"Combines some abilities of Convert selection with enabled CS-Switch and when it disabled.(Enable CS-Switch for it to work)\nIt can:\n1.Conversion from multiple languages at once.\n2.Ignore symbols feature work in it.\n3.Auto get language of text(not all symbols(the ones that exist in both layouts) can be rightly recognized if wrong layout selected from begin)\n4.Ability to convert symbols that exist in both layouts different if change layout before conversion.",
          /*30*/"Makes background of language tooltip transparent.\nDon't forget to change text color.(because \"White\" is default)\nSome fonts may look bad, try changing to another.(\"Georgia\" or \"Palatino Linotype\" is recommend)",
          /*31*/"If this enabled, pressing Space will expand small (which starts with \"->\") word, to big (which is between \"====>\" and \"<====\") word/text fragment.",
          /*32*/"Display language tooltip only on layout change.\nTime of displaying is 7x[Refresh rate].",
          /*33*/"Highlight Scroll Lock when active language 1, selected in main window.",
          /*34-35*/"Allow to convert specific last word count by pressing hotkey and then 1-9 on keyboard.", ""};
        public static string[] MessagesEN = new string[] {
          /*00-01*/"", "",
          /*0002*/"Press Pause(by Default) to convert last inputted word.\nPress Scroll(by Default) while selected text is focused to convert it.\nPress Shift+Pause(by Default) to convert last inputted line.\n"+
          "Press Ctrl+Alt+Shift+Insert to show Mahou main window.\nPress Ctrl+Alt+Shift+F12 to shutdown Mahou.\n\n*Note that if you typing in not of selected in settings layouts(locales/languages), conversion will switch typed text to Language 1(Ignored if Cycle Mode is ON).\n\n"+
          "**If you have problems with symbols conversion(selection) try \"switching languages (1=>2 & 2=>1)\" or \"CS-Switch\" option.\n\nHover on any control of main window for more info about it.\n\n"+
          "***WINDOWS 10 USERS WHO USE METRO APPS***\n\nEnable \"Cycle Mode\", \"Emu\" and set Emu type to \"Win+Space\" these settings work better for Metro apps.\n\nTo reset settings just delete Mahou.ini in Mahou folder.\n\nRegards.", 
          /*03-05*/"ANNOTATIONS","You have assigned same hotkeys for Convert word & Convert line, that is impossible!!", "Warning!",
          /*06-07*/"You have pressed just modifiers for Convert word hotkey!!","You have pressed just modifiers for Convert selection hotkey!!",
          /*08-09*/"You have pressed just modifiers for Convert line hotkey!!","You have removed selected locales, reselect.",
		  /*10-11*/"Snippets configured wrong...", "Mahou snippets error!",
          /*12-13*/"Using CapsLock with CapsLock assigned as [Switch Only Key] will produce issues, disable [Switch Only Key] feature or assign it to another key.","Hotkey with CapsLock warning!"};
        #endregion
        #region Ukrainian
        public static string[] UIRU = new string[] {
          /*///////////////Main UI\\\\\\\\\\\\\\\
          /*00-03*/"Mahou","Start with Windows","","Гарячі клавіші",
          /*04-06*/"Конв. слова","Конв. виділення", "Конв. рядка",
          /*07-10*/"CS-Switch","Повт. натиск.","Повт. виділ.","Розкладка:",
          /*11-14*/"Блок CTRL","Іконка трея","Цикл. режим","Ему",
          /*15-16*/"Перемикання між розкладками","Мова",
          /*17-20*/"Застосувати","OK","Скасувати","Довідка",
          /*///////////////Reserved legacy UI\\\\\\\\\\\\\\\
          /*21-23*/"","","",
          /*24-28*/"","","","","",
          /*29-32*/"","","","",
          /*33-34*/"","",
          /*35-35*/"",
          /*///////////////MoreConfigs UI\\\\\\\\\\\\\\\
          /*36-36*/"Використовувати окреме перемикання через L/R CTRL",
          /*37-39*/"LCtrl перемикає на:","RCtrl перемикає на:","Додаткові налаштування",
          /*40-41*/"Ігнор. символів:","Більше спроб:",
          /*///////////////Tray Icon\\\\\\\\\\\\\\\
          /*42-44*/"Показати/Сховати","Вихід","Mahou\nПеремикач розкладок.",
          /*///////////////Back to MoreConfigs UI\\\\\\\\\\\\\\\\\
          /*45-47*/"Показ мови:","Частота оновл.(мс):", "Кольори:",
          /*///////////////Reserved legacy UI\\\\\\\\\\\\\\\\\
          /*48-51*/"","","","",
          /*///////////////Back to MoreConfigs UI\\\\\\\\\\\\\\\\\
          /*52-58*/"Шрифт","Розмір:","Позиція:", "Ще", "Назад", "Подвійна гар. клавіша:", "Затримка:",
          /*59-60*/"Експериментальний CS-Switch+","Прозорий фон у підказці мови",
          /*61-63*/"Використовувати сніпети","При зміні","Підсвічувати ScrollLock, коли мова 1 активна.",
          /*64-65*/"Гар. клавіша конвертації кількох слів:", ""};
        public static string[] ToolTipsRU = new string[] {
          /*///////////////Main TT\\\\\\\\\\\\\\\\\
          /*00*/"Поки цю опцію увімкнено, [Конв. слова], [Конв. рядка] і [Конв. виділення з увімкненим \"CS-Switch\"]\n"+
          "циклічно перемикатимуть усі розкладки замість перемикання між вибраними в налаштуваннях.\nЦей режим працює з більшістю програм.\n"+
          "Якщо в якійсь програмі [Конв. слова], [Конв. рядка] або [Конв. виділення з увімкненим \"CS-Switch\"] не працює,\nспробуйте увімкнути цю опцію.\n"+
          "Якщо у вас лише 2 розкладки, дуже рекомендовано увімкнути цю опцію і \"Ему\".",
          /*01*/"Поточна гаряча клавіша для \"Конв. слова\".\nНатисніть будь-яку клавішу, щоб призначити її, або клавішу з модифікаторами(ALT,CTRL,SHIFT).",
          /*02*/"Поточна гаряча клавіша для \"Конв. виділення\".\nНатисніть будь-яку клавішу, щоб призначити її, або клавішу з модифікаторами(ALT,CTRL,SHIFT).",
          /*03*/"Поточна гаряча клавіша для \"Конв. рядка\".\nНатисніть будь-яку клавішу, щоб призначити її, або клавішу з модифікаторами(ALT,CTRL,SHIFT).",
          /*04*/"Mahou.",
          /*05*/"Перемикає видимість іконки в треї.\nЯкщо її приховано, щоб показати головне вікно, натисніть CTRL+ALT+SHIFT+INSERT або просто запустіть Mahou.exe ще раз.",
          /*06*/"",
          /*07 */"Ігнорує гарячу клавішу, яка використовує Control,\nколи \"Зміна розкладки клавішею\" встановлено на Left/Right Control.",
          /*08*/"Тип перемикання залежить від \"Цикл. режим\" і \"Ему\".",
          /*09*/"Якщо увімкнено, циклічний режим використовуватиме емуляцію натискання Alt+Shift/Win+Space замість \"надсилання повідомлення вікну\", яке перемикає розкладку.",
          /*10*/"Якщо увімкнено, Конв. виділення використовуватиме перемикання розкладки.\nУсі символи буде введено правильно.(без проблем із символами)",
          /*11*/"Працює лише коли циклічний режим вимкнено.",
          /*12*/"Якщо увімкнено, модифікатори буде натиснуто знову після конвертації.\nЗавдяки новому типу гарячих клавіш модифікатори ніколи не залипнуть(рекомендовано).",
          /*13*/"Якщо увімкнено, натискання ОДНОГО Space ПІСЛЯ слова не очистить останнє слово.",
          /*14*/"Якщо увімкнено, текст буде знову виділено після \"Конв. виділення\".",
          /*15*/"Виберіть тип емуляції перемикання розкладки.\nWin+Space працює лише у Windows 10!!\nWin+Space також працює в Metro-застосунках краще, ніж Alt+Shift.",
          /*///////////////MoreConfigs TT\\\\\\\\\\\\\\\\\
          /*16*/"Натискання LCtrl перемкне розкладку на вибрану.",
          /*17*/"Натискання RCtrl перемкне розкладку на вибрану.",
          /*18*/"Увімкнення цієї функції вимикає LCtrl/RCtrl з \"Зміна розкладки клавішею\".\nПоки її увімкнено, натискання LCtrl/RCtrl перемикатиме розкладку на вибрану.",
          /*19*/"Тип емуляції",
          /*/BACK TO MoreConfigs
          /*20*/"Якщо увімкнено, символи []{};':\",./<>? ігноруватимуться і не конвертуватимуться.\nПрацює в Конв. слова, Конв. рядка, Конв. виділення з увімкненими циклічним режимом і CS-Switch.\nНе працюватиме, якщо у вас >2 розкладок і циклічний режим увімкнено!",
          /*21*/"Увімкнює кілька спроб отримати виділений текст у Конв. виділення.",
          /*22*/"Якщо увімкнено, при наведенні миші на текстове поле буде показано маленьку підказку про поточну мову введення.",
          /*23*/"Швидкість перевірки курсора миші.(чи дорівнює він \"I\" при наведенні на текст/текстове поле))",
          /*24*/"Кольори і шрифт маленької підказки.(Ліворуч - колір тексту, праворуч - колір фону)",
          /*25-26*/"Розмір підказки мови біля курсора.", "Позиція відносно курсора.",
          /*27*/"Увімкнює можливість подвійних гарячих клавіш\nі можливість призначити лише модифікатор як гарячу клавішу",
          /*28*/"Час очікування другого натискання(мс)",
          /*29*/"Поєднує деякі можливості Конв. виділення з увімкненим CS-Switch і коли його вимкнено.(Для роботи увімкніть CS-Switch)\nМожливості:\n1.Конвертація з різних мов за одну дію.\n2.Тут працює ігнорування символів.\n3.Автоматичне розпізнавання мови тексту(не всі символи(ті, що є в обох розкладках) можуть бути розпізнані правильно, якщо спочатку вибрано неправильну мову)\n4.Можливість по-різному конвертувати символи, які є в обох розкладках, якщо змінити мову перед конвертацією.",
          /*30*/"Робить фон підказки мови прозорим.\nНе забудьте змінити колір тексту.(тому що \"Білий\" є типовим)\nДеякі шрифти можуть виглядати не дуже, спробуйте змінити шрифт.(рекомендовано \"Georgia\" або \"Palatino Linotype\")",
          /*31*/"Якщо увімкнено, натискання Space перетворить мале слово (яке починається з \"->\") на велике слово/фрагмент тексту(між \"====>\" і \"<====\").",
          /*32*/"Показує підказку лише при зміні мови.\nЧас відображення = 7x[Частота оновл.].",
          /*33*/"Підсвічує Scroll Lock при активації мови 1, вибраної в головному вікні.",
          /*34-35*/"Дає змогу конвертувати вибрану кількість останніх слів натисканням гарячої клавіші, а потім 1-9 на клавіатурі.", ""};
        public static string[] MessagesRU = new string[] {
          /*00-01*/"", "",
          /*0002*/"Натисніть Pause(за замовчуванням), щоб конвертувати останнє введене слово.\nНатисніть Scroll(за замовчуванням), поки виділений текст у фокусі, щоб конвертувати його.\nНатисніть Shift+Pause(за замовчуванням), щоб конвертувати останній введений рядок.\n"+
          "Натисніть Ctrl+Alt+Shift+Insert, щоб показати/сховати головне вікно.\nНатисніть Ctrl+Alt+Shift+F12, щоб завершити Mahou.\n\n*Зверніть увагу: якщо ви вводите текст не з розкладок, вибраних у налаштуваннях, конвертація перемкне текст у Мову 1(не актуально, якщо увімкнено циклічний режим).\n\n"+
          "**Якщо у вас проблеми із символами під час Конв. виділення, спробуйте \"поміняти мови місцями(1=>2 & 2=>1)\" або увімкніть \"CS-Switch\".\n\nНаведіть мишу на будь-який елемент головного вікна, щоб дізнатися про нього більше.\n\n"+
          "************WINDOWS 10 Metro-застосунки************\nУвімкніть \"Цикл. режим\", \"Ему\" і встановіть тип емуляції на \"Win+Space\". Ці налаштування краще працюють для Metro-застосунків.\n\nЩоб скинути налаштування, просто видаліть Mahou.ini у папці Mahou.\n\nУспіхів.",
          /*03-05*/"****УВАГА****","Ви призначили одну й ту саму гарячу клавішу для Конв. слова і Конв. рядка, це неможливо!!", "Увага!",
          /*06-07*/"Ви натиснули лише модифікатори для Конв. слова!!","Ви натиснули лише модифікатори для Конв. виділення!!",
          /*08-09*/"Ви натиснули лише модифікатори для Конв. рядка!!","Ви прибрали раніше вибрані розкладки, виберіть заново.",
		  /*10-11*/"Сніпети налаштовано неправильно...", "Помилка сніпетів Mahou!",
          /*12-13*/"Використання CapsLock у гарячій клавіші, коли CapsLock призначено як [Зміна розкладки клавішею], спричинить проблеми. Вимкніть функцію [Зміна розкладки клавішею] або призначте її на іншу клавішу.","Увага: клавіша з CapsLock!"};
        #endregion
    }
}
