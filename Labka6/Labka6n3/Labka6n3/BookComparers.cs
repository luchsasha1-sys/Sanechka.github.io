using System.Collections.Generic;

namespace Labka6n3
{
    // --- 2. Реалізація IComparer (Критерій 1: Ціна) ---
    // Цей клас дублює логіку IComparable, але потрібен
    // для демонстрації гнучкості IComparer
    public class SortByPriceComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x == null || y == null) return 0;
            return x.Price.CompareTo(y.Price);
        }
    }

    // --- 2. Реалізація IComparer (Критерій 2: Кількість сторінок) ---
    // Завдання: "за ціною і за кількістю сторінок"
    public class SortByPageCountComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x == null || y == null) return 0;
            return x.PageCount.CompareTo(y.PageCount);
        }
    }
}