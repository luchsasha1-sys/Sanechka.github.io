using System;

namespace Labka5_1
{
    public class Student
    {
        // 1. Закриті поля класу (7 полів)
        private string _firstName;
        private string _lastName;
        private string _studentID;
        private string _faculty;
        private int _course;
        private DateTime _dateOfBirth;
        private double _averageGrade;

        // 2. Властивості (get/set) для доступу до полів
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public string Faculty
        {
            get { return _faculty; }
            set { _faculty = value; }
        }

        public int Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public double AverageGrade
        {
            get { return _averageGrade; }
            set { _averageGrade = value; }
        }

        // 3. Конструктор без параметрів
        public Student()
        {
            // Ініціалізуємо поля значеннями за замовчуванням
            _firstName = "Невідомо";
            _lastName = "Невідомо";
            _studentID = "n/a";
            _faculty = "n/a";
            _course = 1;
            _dateOfBirth = DateTime.Now;
            _averageGrade = 0.0;
        }

        // --- Власні методи класу (3 методи) ---

        /// <summary>
        /// Повертає повне ім'я студента.
        /// </summary>
        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        /// <summary>
        /// Обчислює повний вік студента.
        /// </summary>
        public int CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - _dateOfBirth.Year;
            // Корекція, якщо день народження цього року ще не настав
            if (_dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        /// <summary>
        /// Повертає статус успішності на основі середнього балу.
        /// </summary>
        public string GetAcademicStatus()
        {
            if (_averageGrade >= 90)
            {
                return "Відмінник";
            }
            else if (_averageGrade >= 75)
            {
                return "Хорошист";
            }
            else if (_averageGrade >= 60)
            {
                return "Трійочник";
            }
            else
            {
                return "Потребує покращення";
            }
        }
    }
}