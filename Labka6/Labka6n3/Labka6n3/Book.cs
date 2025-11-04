using System;

namespace Labka6n3
{
    // Клас Книга, який реалізує IComparable для сортування за замовчуванням
    public class Book : IComparable<Book>
    {
        // Власні поля класу
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int PageCount { get; set; }

        // Конструктор
        public Book(string title, string author, double price, int pageCount)
        {
            Title = title;
            Author = author;
            Price = price;
            PageCount = pageCount;
        }

        // --- 1. Реалізація IComparable ---
        // Це метод сортування "за замовчуванням".
        // Завдання: "порівняння книг за ціною"
        public int CompareTo(Book? other)
        {
            // Якщо інша книга null, ця книга "більша"
            if (other == null) return 1;

            // Використовуємо вбудований CompareTo для типу double
            return this.Price.CompareTo(other.Price);
        }

        // Перевизначаємо ToString() для гарного виводу в GUI
        public override string ToString()
        {
            return $"[{Price} грн] '{Title}' - {Author} ({PageCount} стор.)";
        }
    }
}