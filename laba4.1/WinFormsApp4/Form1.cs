using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MannequinApp
{
    // Клас для зберігання інформації про манекенницю
    public class Mannequin
    {
        public string Surname { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; } = string.Empty;

        // Метод для перетворення рядка файлу на об'єкт Mannequin
        public static Mannequin Parse(string[] parts)
        {
            var birthDate = new DateTime(
                int.Parse(parts[6].Trim()),
                int.Parse(parts[7].Trim()),
                int.Parse(parts[8].Trim())
            );
            string address = string.Join(", ", parts[9..]);

            return new Mannequin
            {
                Surname = parts[0].Trim(),
                Name = parts[1].Trim(),
                Patronymic = parts[2].Trim(),
                Nationality = parts[3].Trim(),
                Height = int.Parse(parts[4].Trim()),
                Weight = int.Parse(parts[5].Trim()),
                BirthDate = birthDate,
                Address = address
            };
        }
    }

    public partial class Form1 : Form
    {
        private List<Mannequin> mannequins = new List<Mannequin>();

        public Form1()
        {
            InitializeComponent();
            SetupDataGridViewStyles(); // Застосовуємо наші кастомні стилі до таблиці
        }

        // Метод для налаштування візуальних стилів таблиці
        private void SetupDataGridViewStyles()
        {
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        // Обробник натискання кнопки "Завантажити дані"
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string path = textBoxInput.Text.Trim();
                if (!File.Exists(path))
                {
                    MessageBox.Show($"Файл не знайдено за шляхом: {path}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var lines = File.ReadAllLines(path);
                mannequins.Clear();

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    if (parts.Length < 16)
                    {
                        MessageBox.Show($"Некоректний формат даних у рядку: {line}", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }
                    mannequins.Add(Mannequin.Parse(parts));
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mannequins;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Авто-ширина стовпців

                labelStatus.Text = $"Успішно завантажено {mannequins.Count} записів.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час читання файлу: {ex.Message}", "Критична помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробник натискання кнопки "Знайти наймолодшу"
        private void BtnFindYoungest_Click(object sender, EventArgs e)
        {
            if (mannequins.Count == 0)
            {
                MessageBox.Show("Будь ласка, спочатку завантажте дані з файлу.", "Дані відсутні", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Знаходимо наймолодшу: сортуємо за датою народження у порядку спадання і беремо перший елемент
            var youngest = mannequins.OrderByDescending(m => m.BirthDate).First();

            string resultText = $"Наймолодша манекенниця:\n\n" +
                                $"ПІБ: {youngest.Surname} {youngest.Name} {youngest.Patronymic}\n" +
                                $"Дата народження: {youngest.BirthDate:dd.MM.yyyy}\n" +
                                $"Адреса: {youngest.Address}";

            MessageBox.Show(resultText, "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                string outputPath = textBoxOutput.Text.Trim();
                File.WriteAllText(outputPath, resultText);
                labelStatus.Text = $"Результат успішно записано у файл: {outputPath}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося зберегти файл: {ex.Message}", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}