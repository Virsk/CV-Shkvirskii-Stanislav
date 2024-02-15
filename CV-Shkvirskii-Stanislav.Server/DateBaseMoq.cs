﻿using CV_Shkvirskii_Stanislav.Server.models;

namespace CV_Shkvirskii_Stanislav.Server
{
    public static class DateBaseMoq
    {
        static List<ContentModel> content;
        static DateBaseMoq()
        {
            content = new List<ContentModel>()
{
    new ContentModel(
        [new AppellationModel("23. 12. 1989", "Шквiрський Станiслав Анатолiйович")],
        "About Me",
        new string[]
        {
            "Мене звуть Станислав, і я працюю full stack-розробником з більш, ніж дворічним досвідом роботи в галузі розробки.",
            "Мої навички включають роботу з HTML, CSS, SCSS, JavaScript, TypeScript, C# а також з фреймворками, такими як Angular, Vue.js, ASP.NET, Blazor.",
            "Маю також досвiд: мобiльна розробка Maui+Blazor, API: Google, Firebase, Бібліотеки SignalR, RXjs",
            "Мені подобається вчитися новому, досліджувати технологічні інновації та дізнаватися про найкращі практики в галузі розробки.",
            "Я відкритий до спілкування та готовий до успішної співпраці з командою розробників для досягнення спільних цілей.",
            "Я ставлю перед собою високі стандарти роботи та прагну до постійного удосконалення своїх навичок, щоб стати кращим у своїй професії."
        }),

    new ContentModel(
        [new AppellationModel("29. 02. 2024", "Full Stack Developer")],
        "Experience",
        new string[]
        {
            "Протягом останiх двох рокiв я успішно працював в компанії 'Xanel' в якості Full Stack Developer, вдосконалював свої навички та накопичував досвід у технологіях, необхідних для успішної роботи Full Stack Developer.",
            "Моя робота включала в себе не лише реалізацію веб-додатків, а й їх подальше вдосконалення та оптимізацію. Я був активно задіяний у забезпеченні ефективної взаємодії між фронтендом та бекендом, розробляючи та вдосконалюючи функціонал відповідно до вимог та очікувань користувачів.",
            "Моя робота часто вимагала вміння працювати від ідеї до релізу, включаючи усі етапи розробки від проектування до тестування та впровадження. Завжди надавав пріоритет високій якості та ефективності коду, впевнений, що чистий та оптимізований код є ключовим елементом успішної розробки.",
            "Моє завдання полягало в пошуку та впровадженні оптимальних рішень для досягнення найкращих результатів.",
            "Загалом, моя робота в сфері Full Stack Development була невід'ємною частиною мого професійного зростання, дозволяючи мені не лише реалізовувати вимоги проектів, а й вносити власний вклад у розвиток та вдосконалення веб-технологій."
        }),

    new ContentModel(
        [new AppellationModel("20. 01. 2022", "ITVDN , '.NET Developer'"),
        new AppellationModel("07. 03. 2023", "Курси англійської ESL"),
        new AppellationModel("01. 07. 2013", "ДДГУ, 'Процесси машини та обладнання '")],
        "Education",
        new string[]
        {
            "Курс .NET Developer дав мені можливість отримати практичний досвід у розробці веб-сайтів та додатків з нуля та на базі готових рішень. Я здобув великий досвід у виконанні завдань та проектів, працюючи як самостійно, так і в команді. Я готовий внести свій внесок у розробку високоякісних веб-додатків та продуктів.",
            "Курс англійської мови на рівні Pre-Intermediate надав навичок для впевненого спілкування. Розвивав розуміння мови та покращував навички читання, письма, розмови та слухання.",
            "Після успішного завершення навчання на факультеті 'Процеси машини та обладнання' Дніпропетровського державного університету, я отримав високоякісну освіту та значні фахові навички в галузі машинобудування та обладнання. Моя освіта дала глибокі знання і підготувала мене до викликів, пов'язаних із технічними інноваціями та інженерною діяльністю. Моє логічне мислення, розвинуте під час навчання, виявляється великою перевагою у моїй роботі програміста."
        })
};

        }

        public static List<ContentModel> GetContent()
        {
            return content;
        }
    }
}