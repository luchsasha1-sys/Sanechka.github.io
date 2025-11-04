using System;

namespace Labka7n3
{
    // Описуємо СТРУКТУРУ,   як вимагає завдання
    public struct HeatingSystem
    {
        // Поля з завдання
        public string City { get; set; }
        public int BoilerID { get; set; }
        public int ObjectCount { get; set; }
        public DateTime StartDate { get; set; }
        public double StartTemperature { get; set; }
        public DateTime EndDate { get; set; }

        // Конструктор для зручного створення
        public HeatingSystem(string city, int boilerID, int objectCount, DateTime startDate, double startTemp, DateTime endDate)
        {
            City = city;
            BoilerID = boilerID;
            ObjectCount = objectCount;
            StartDate = startDate;
            StartTemperature = startTemp;
            EndDate = endDate;
        }

        // --- Допоміжні властивості для завдань ---

        /// <summary>
        /// (Завдання 1) Повертає тривалість сезону в днях.
        /// </summary>
        public int SeasonDurationInDays
        {
            get
            {
                // TimeSpan - це результат віднімання двох дат
                TimeSpan duration = EndDate - StartDate;
                return duration.Days;
            }
        }

        /// <summary>
        /// (Завдання 3) Перевіряє, чи сезон тривав понад 6 місяців.
        /// </summary>
        public bool IsLongerThanSixMonths
        {
            get
            {
                // Найкоректніший спосіб - додати 6 місяців до дати старту
                // і перевірити, чи дата закінчення пізніша.
                return EndDate > StartDate.AddMonths(6);
            }
        }

        /// <summary>
        /// (Завдання 1) Гарний вивід для ListBox.
        /// </summary>
        public override string ToString()
        {
            return $"[Котельня №{BoilerID}, {City}] Об'єктів: {ObjectCount}, Тривалість: {SeasonDurationInDays} дн.";
        }
    }
}