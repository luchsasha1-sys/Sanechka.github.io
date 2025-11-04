using System;
using System.Collections.Generic;
using System.Globalization; // Потрібен для ParseExact
using System.Linq; // Потрібен для LINQ (Where, OrderBy...)
using System.Text; // Потрібен для StringBuilder
using System.Windows.Forms;

namespace Labka7n3
{
    public partial class Form1 : Form
    {
        // Наш "масив" (List<>) структур
        private List<HeatingSystem> allSystems;

        public Form1()
        {
            InitializeComponent();
            allSystems = new List<HeatingSystem>();

            // Додамо кілька тестових записів
            try
            {
                allSystems.Add(new HeatingSystem("Київ", 101, 500, ParseDate("14102024"), 8.5, ParseDate("15042025")));
                allSystems.Add(new HeatingSystem("Львів", 22, 300, ParseDate("20102024"), 7.0, ParseDate("10042025")));
                allSystems.Add(new HeatingSystem("Одеса", 5, 450, ParseDate("01112024"), 10.0, ParseDate("01042025")));
                allSystems.Add(new HeatingSystem("Чернівці", 7, 150, ParseDate("15102024"), 9.0, ParseDate("20052025"))); // > 6 міс
            }
            catch { /* Ігноруємо помилки парсингу в тестових даних */ }

            // Одразу показуємо всіх (Завдання 1)
            UpdateDisplay(allSystems);
        }

        // --- Головний метод для вводу даних ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Зчитуємо дані з полів
                string city = txtCity.Text;
                int boilerId = int.Parse(txtBoilerID.Text);
                int objectCount = int.Parse(txtObjectCount.Text);
                double startTemp = double.Parse(txtStartTemp.Text);

                // 2. Парсимо дати за форматом ДДММРРРР
                DateTime startDate = ParseDate(txtStartDate.Text);
                DateTime endDate = ParseDate(txtEndDate.Text);

                // 3. Створюємо нову структуру
                HeatingSystem newSystem = new HeatingSystem(city, boilerId, objectCount, startDate, startTemp, endDate);

                // 4. Додаємо в список
                allSystems.Add(newSystem);

                // 5. Оновлюємо те, що бачить користувач
                UpdateDisplay(allSystems);
                ClearInputFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка вводу! Перевірте формат даних.\n\nДати: ДДММРРРР\nІнші поля: Числа.", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 1. Вивести відомості щодо всіх котелень (з тривалістю) ---
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateDisplay(allSystems);
        }

        // --- 2. Вивести котельні, що розпочали сезон після 15 жовтня ---
        private void btnShowAfterOct15_Click(object sender, EventArgs e)
        {
            // Використовуємо LINQ для фільтрації
            List<HeatingSystem> filtered = allSystems
                .Where(system => system.StartDate.Month > 10 || (system.StartDate.Month == 10 && system.StartDate.Day > 15))
                .ToList();

            UpdateDisplay(filtered);
            ShowEmptyMessage(filtered.Count, "Котелень, що почали сезон після 15.10, не знайдено.");
        }

        // --- 3. Вивести та підрахувати котельні, сезон яких > 6 місяців ---
        private void btnShowOver6Months_Click(object sender, EventArgs e)
        {
            // Використовуємо допоміжну властивість зі структури
            List<HeatingSystem> filtered = allSystems
                .Where(system => system.IsLongerThanSixMonths)
                .ToList();

            UpdateDisplay(filtered);
            MessageBox.Show($"Знайдено котелень з сезоном > 6 місяців: {filtered.Count}", "Результат підрахунку");
        }

        // --- 4. Знайти найкоротший за часом опалювальний сезон ---
        private void btnFindShortest_Click(object sender, EventArgs e)
        {
            if (allSystems.Count == 0)
            {
                ShowEmptyMessage(0, "База даних порожня.");
                return;
            }

            // Використовуємо LINQ .OrderBy() і беремо перший
            HeatingSystem shortest = allSystems
                .OrderBy(system => system.SeasonDurationInDays)
                .First();

            // Виводимо результат у MessageBox та оновлюємо список, щоб показати тільки його
            MessageBox.Show($"Найкоротший сезон: {shortest.SeasonDurationInDays} дн.\n(Котельня №{shortest.BoilerID}, {shortest.City})", "Результат пошуку");
            UpdateDisplay(new List<HeatingSystem> { shortest }); // Показуємо тільки 1
        }

        // --- 5. Ввести дату та вивести інформацію про всі котельні ---
        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime searchDate = ParseDate(txtSearchDate.Text);

                // .Date порівнює тільки дату, ігноруючи час
                List<HeatingSystem> filtered = allSystems
                    .Where(system => system.StartDate.Date == searchDate.Date)
                    .ToList();

                UpdateDisplay(filtered);
                ShowEmptyMessage(filtered.Count, $"Котелень, що почали сезон {searchDate:dd.MM.yyyy}, не знайдено.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірний формат дати. Введіть ДДММРРРР.", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Допоміжні методи ---

        /// <summary>
        /// Парсить рядок у форматі "ДДММРРРР" в об'єкт DateTime.
        /// </summary>
        private DateTime ParseDate(string dateStr)
        {
            return DateTime.ParseExact(dateStr, "ddMMyyyy", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Оновлює ListBox, показуючи список котелень.
        /// </summary>
        private void UpdateDisplay(List<HeatingSystem> systems)
        {
            lstOutput.Items.Clear();
            foreach (var system in systems)
            {
                // ListBox автоматично викличе .ToString() для кожного об'єкта
                lstOutput.Items.Add(system);
            }
        }

        /// <summary>
        /// Очищує поля вводу.
        /// </summary>
        private void ClearInputFields()
        {
            txtCity.Clear();
            txtBoilerID.Clear();
            txtObjectCount.Clear();
            txtStartDate.Clear();
            txtStartTemp.Clear();
            txtEndDate.Clear();
        }

        /// <summary>
        /// Повідомляє, якщо список результатів порожній.
        /// </summary>
        private void ShowEmptyMessage(int count, string message)
        {
            if (count == 0)
            {
                MessageBox.Show(message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}