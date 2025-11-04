namespace Labka6n2
{
    // Клас реалізує КОЖЕН інтерфейс
    public class Article : IPublication, IAuthor
    {
        // --- Поля, що стосуються обох інтерфейсів ---
        private string title;
        private string authorName;
        private string authorCredentials;
        private int publishYear;

        // --- Власні поля, характерні для класу ---
        private string journalName;
        private int issueNumber;

        // Конструктор для ініціалізації всіх полів
        public Article(string title, string authorName, string authorCredentials, int publishYear, string journalName, int issueNumber)
        {
            this.title = title;
            this.authorName = authorName;
            this.authorCredentials = authorCredentials;
            this.publishYear = publishYear;
            this.journalName = journalName;
            this.issueNumber = issueNumber;
        }

        // --- Реалізація інтерфейсу IPublication ---
        public string GetFullCitation()
        {
            // Викликаємо метод з IAuthor, хоча ми в одному класі
            return $"{GetFullName()} ({publishYear}). {title}. {journalName}, {issueNumber}.";
        }
        public string GetPublishStatus()
        {
            return $"Опубліковано в журналі: {journalName}";
        }

        // --- Реалізація інтерфейсу IAuthor ---
        public string GetFullName()
        {
            return authorName;
        }
        public string GetAuthorInfo()
        {
            return $"Інфо про автора: {authorCredentials}";
        }

        // --- Власні методи (2) ---
        public string GetJournal()
        {
            return $"Ця стаття з журналу '{journalName}'.";
        }
        public string SubmitForReview()
        {
            return $"Стаття '{title}' відправлена на рецензію.";
        }
    }
}