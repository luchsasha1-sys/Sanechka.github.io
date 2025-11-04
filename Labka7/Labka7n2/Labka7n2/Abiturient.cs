using System;
using System.Linq; // Додаємо це для легкого розрахунку середнього

namespace Labka7n2
{
    // Описуємо СТРУКТУРУ, як вимагає завдання
    public struct Abiturient : IComparable<Abiturient>
    {
        // Поля з завдання (зроблені як властивості)
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Speciality { get; set; }
        public int[] ExamScores { get; set; }

        // Додаємо конструктор для зручного створення
        public Abiturient(string name, string gender, string spec, int[] scores)
        {
            Name = name;
            Gender = gender;
            Speciality = spec;
            ExamScores = scores;
        }

        // Допоміжна властивість для розрахунку середнього балу
        public double AverageScore
        {
            get
            {
                // Перевірка, щоб уникнути помилки, якщо масив порожній
                if (ExamScores == null || ExamScores.Length == 0)
                    return 0;

                // Використовуємо Linq .Average() для простоти
                return ExamScores.Average();
            }
        }

        // --- Реалізація IComparable (для Завдання 2) ---
        // Вчить структуру, як порівнювати себе з іншою
        // Завдання: "впорядкування записів за зростанням середнього балу"
        public int CompareTo(Abiturient other)
        {
            // CompareTo для double ідеально підходить
            // Це сортує за зростанням
            return this.AverageScore.CompareTo(other.AverageScore);
        }

        // Перевизначаємо ToString() для гарного виводу в ListBox
        public override string ToString()
        {
            // Виводимо бал на початку для наочності сортування
            return $"[Бал: {AverageScore:F2}] {Name} - {Speciality}";
        }
    }
}