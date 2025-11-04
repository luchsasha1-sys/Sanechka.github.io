namespace Labka6n2
{
    public class ElectronicResource : IPublication, IAuthor
    {
        // --- Поля, що стосуються обох інтерфейсів ---
        private string title;
        private string authorName; // Може бути організація
        private string siteInfo;   // Інфо про сайт
        private int publishYear;

        // --- Власні поля, характерні для класу ---
        private string url;
        private string accessDate; // Дата доступу

        // Конструктор
        public ElectronicResource(string title, string authorName, string siteInfo, int publishYear, string url, string accessDate)
        {
            this.title = title;
            this.authorName = authorName;
            this.siteInfo = siteInfo;
            this.publishYear = publishYear;
            this.url = url;
            this.accessDate = accessDate;
        }

        // --- Реалізація інтерфейсу IPublication ---
        public string GetFullCitation()
        {
            return $"{GetFullName()} ({publishYear}). {title} [Електронний ресурс]. Отримано {accessDate} з {url}";
        }
        public string GetPublishStatus()
        {
            return $"Доступно онлайн за адресою: {url}";
        }

        // --- Реалізація інтерфейсу IAuthor ---
        public string GetFullName()
        {
            return authorName;
        }
        public string GetAuthorInfo()
        {
            return $"Інфо про ресурс: {siteInfo}";
        }

        // --- Власні методи (2) ---
        public string GetUrl()
        {
            return $"Пряме посилання: {url}";
        }
        public bool CheckLink()
        {
            // Імітуємо перевірку посилання
            return true;
        }
    }
}