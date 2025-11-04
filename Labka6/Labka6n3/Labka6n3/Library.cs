using System.Collections;
using System.Collections.Generic;

namespace Labka6n3
{
    // --- 3. Реалізація IEnumerable ---
    // Цей клас є "базою (масивом) з n машин" (книг)
    public class Library : IEnumerable<Book>
    {
        // Наша база - це просто список
        private List<Book> books = new List<Book>();

        // Метод для додавання в базу
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // --- Методи сортування, які використовують інтерфейси ---

        // Використовує IComparable з Book.cs
        public void SortByDefault()
        {
            books.Sort();
        }

        // Використовує будь-який IComparer
        public void SortBy(IComparer<Book> comparer)
        {
            books.Sort(comparer);
        }

        // --- Реалізація IEnumerable<Book> ---
        // Це дозволяє нам писати "foreach (Book book in myLibrary)"
        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        // Стара версія (не типізована), потрібна для інтерфейсу
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}