using System.IO; // Потрібно для роботи з файлами

namespace Labka5n1
{
    public class Student
    {
        // 1. Приватні поля (вимагалось 7)
        private string _lastName;
        private string _firstName;
        private string _patronymic; // По-батькові
        private string _studentID;
        private string _group;
        private int _course;
        private double _averageGrade;

        // 2. Властивості (get/set) для доступу до приватних полів
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        public int Course
        {
            get { return _course; }
            // Додамо просту перевірку, щоб курс не був від'ємним
            set { _course = (value > 0) ? value : 1; }
        }

        public double AverageGrade
        {
            get { return _averageGrade; }
            // Перевірка, щоб середній бал був у допустимих межах (наприклад, 0-100)
            set { _averageGrade = (value >= 0 && value <= 100) ? value : 0; }
        }

        // 3. Конструктор без параметрів
        public Student()
        {
            // Ініціалізуємо поля початковими значеннями
            _lastName = "Не вказано";
            _firstName = "Не вказано";
            _patronymic = "Не вказано";
            _studentID = "000000";
            _group = "Не вказано";
            _course = 1;
            _averageGrade = 0.0;
        }

        // 4. Власні методи (вимагалось 3)

        /// <summary>
        /// Повертає повне ім'я студента у форматі "Прізвище І. П."
        /// </summary>
        public string GetShortFullName()
        {
            // Перевіряємо, чи імена не порожні, перш ніж брати перший символ
            string firstInitial = !string.IsNullOrEmpty(_firstName) ? _firstName.Substring(0, 1) + "." : "";
            string patronymicInitial = !string.IsNullOrEmpty(_patronymic) ? _patronymic.Substring(0, 1) + "." : "";

            return $"{_lastName} {firstInitial} {patronymicInitial}";
        }

        /// <summary>
        /// Переводить студента на наступний курс.
        /// </summary>
        public void PromoteToNextCourse()
        {
            // Просто збільшуємо курс на 1
            // Використовуємо властивість, щоб спрацювала логіка з 'set' (хоча тут вона проста)
            Course = Course + 1;
        }

        /// <summary>
        /// Оновлює середній бал студента.
        /// </summary>
        /// <param name="newAverageGrade">Нове значення середнього балу</param>
        public void UpdateAverageGrade(double newAverageGrade)
        {
            // Використовуємо властивість, щоб спрацювала логіка з 'set'
            AverageGrade = newAverageGrade;
        }

        // Допоміжний метод для легкого збереження у файл
        public override string ToString()
        {
            return $"ПІБ: {_lastName} {_firstName} {_patronymic}\r\n" +
                   $"Студентський квиток: {_studentID}\r\n" +
                   $"Група: {_group}\r\n" +
                   $"Курс: {_course}\r\n" +
                   $"Середній бал: {_averageGrade}";
        }
    }
}