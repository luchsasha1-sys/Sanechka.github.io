using System;
using System.Windows.Forms;

namespace Labka6n3
{
    public partial class Form1 : Form
    {
        // Наша "база", яка реалізує IEnumerable
        private Library myLibrary = new Library();

        // Наші "сортувальники", які реалізують IComparer
        private SortByPriceComparer priceComparer = new SortByPriceComparer();
        private SortByPageCountComparer pageComparer = new SortByPageCountComparer();

        public Form1()
        {
            InitializeComponent();

            // Додамо кілька книг для прикладу
            myLibrary.AddBook(new Book("Кобзар", "Т. Шевченко", 350.0, 500));
            myLibrary.AddBook(new Book("Замок", "Ф. Кафка", 220.5, 320));
            myLibrary.AddBook(new Book("1984", "Д. Орвелл", 250.0, 350));

            // Одразу виводимо список (завдання "Виведіть на GUI список")
            UpdateDisplay();
        }

        // Кнопка "Додати"
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Зчитуємо дані з полів
                string title = txtTitle.Text;
                string author = txtAuthor.Text;
                double price = double.Parse(txtPrice.Text);
                int pageCount = int.Parse(txtPageCount.Text);

                // 2. Створюємо об'єкт
                Book newBook = new Book(title, author, price, pageCount);

                // 3. Додаємо в "базу"
                myLibrary.AddBook(newBook);

                // 4. Оновлюємо GUI
                UpdateDisplay();

                // 5. Очищуємо поля вводу
                txtTitle.Clear();
                txtAuthor.Clear();
                txtPrice.Clear();
                txtPageCount.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка вводу. Ціна та К-сть сторінок мають бути числами.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        // Кнопка сортування "За замовчуванням" (IComparable)
        private void btnSortDefault_Click(object sender, EventArgs e)
        {
            // Викликаємо метод, який використовує Book.CompareTo()
            myLibrary.SortByDefault();
            UpdateDisplay();
        }

        // Кнопка сортування "За ціною" (IComparer)
        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            // Викликаємо метод і передаємо йому наш "сортувальник"
            myLibrary.SortBy(priceComparer);
            UpdateDisplay();
        }

        // Кнопка сортування "За сторінками" (IComparer)
        private void btnSortByPages_Click(object sender, EventArgs e)
        {
            // Викликаємо метод і передаємо йому інший "сортувальник"
            myLibrary.SortBy(pageComparer);
            UpdateDisplay();
        }


        // Допоміжний метод для оновлення ListBox
        private void UpdateDisplay()
        {
            lstOutput.Items.Clear();

            // --- 4. Демонстрація IEnumerable ---
            // Ми можемо перебрати "myLibrary" у циклі foreach
            // саме тому, що клас Library реалізує IEnumerable!
            foreach (Book book in myLibrary)
            {
                // Додаємо об'єкт, ListBox автоматично викличе .ToString()
                lstOutput.Items.Add(book);
            }
        }
    }
}