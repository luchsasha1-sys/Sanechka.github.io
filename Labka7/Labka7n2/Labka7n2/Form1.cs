using System;
using System.Collections.Generic;
using System.Linq; // Потрібен для LINQ (Where)
using System.Text; // Потрібен для StringBuilder
using System.Windows.Forms;
using System.Xml.Linq;

namespace Labka7n2
{
    public partial class Form1 : Form
    {
        // "масив ABITUR" (використовуємо List<> - він гнучкіший за масив)
        private List<Abiturient> abiturientList;

        public Form1()
        {
            InitializeComponent();

            // Ініціалізуємо наш список
            abiturientList = new List<Abiturient>();

            // Додамо кілька абітурієнтів для тестування
            abiturientList.Add(new Abiturient("Петренко П.П.", "Чол", "Інженерія ПЗ", new int[] { 180, 190, 200 }));
            abiturientList.Add(new Abiturient("Іванова О.І.", "Жін", "Філологія", new int[] { 150, 160, 170 }));
            abiturientList.Add(new Abiturient("Сидоренко А.В.", "Чол", "Інженерія ПЗ", new int[] { 140, 150, 155 }));

            // Одразу оновимо екран
            UpdateDisplay();
        }

        // --- Завдання 1: Введення даних ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Зчитуємо дані з полів
                string name = txtName.Text;
                string gender = txtGender.Text;
                string spec = txtSpec.Text;
                int score1 = int.Parse(txtExam1.Text);
                int score2 = int.Parse(txtExam2.Text);
                int score3 = int.Parse(txtExam3.Text);

                // 2. Створюємо масив іспитів
                int[] scores = { score1, score2, score3 };

                // 3. Створюємо нову структуру
                Abiturient newAbiturient = new Abiturient(name, gender, spec, scores);

                // 4. Додаємо в наш список
                abiturientList.Add(newAbiturient);

                // 5. Оновлюємо ListBox
                UpdateDisplay();

                // 6. Очищуємо поля для нового вводу
                txtName.Clear();
                txtGender.Clear();
                txtSpec.Clear();
                txtExam1.Clear();
                txtExam2.Clear();
                txtExam3.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка вводу. Перевірте, чи всі бали за іспити введено коректно (як числа).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Завдання 2: Впорядкування записів ---
        private void btnSort_Click(object sender, EventArgs e)
        {
            // .Sort() автоматично використовує метод CompareTo()
            // який ми визначили в структурі Abiturient (завдяки IComparable)
            abiturientList.Sort();

            // Оновлюємо ListBox
            UpdateDisplay();
        }

        // --- Завдання 3: Виведення "двієчників" ---
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Отримуємо прохідний бал
                double passingScore = double.Parse(txtPassingScore.Text);

                // 2. Шукаємо абітурієнтів з балом НИЖЧЕ прохідного
                // Використовуємо LINQ .Where() - це найпростіший спосіб
                var failedStudents = abiturientList
                    .Where(student => student.AverageScore < passingScore)
                    .ToList(); // Конвертуємо результат в новий список

                // 3. Перевіряємо, чи когось знайшли
                if (failedStudents.Count == 0)
                {
                    // "якщо таких абітурієнтів немає, то вивести відповідне повідомлення"
                    MessageBox.Show(
                        $"Абітурієнтів з середнім балом нижче {passingScore} не знайдено.",
                        "Результат пошуку",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    // "виведення на екран прізвищ та назв спеціальностей"
                    // Збираємо результат у гарний рядок
                    StringBuilder resultText = new StringBuilder();
                    resultText.AppendLine($"Абітурієнти з балом нижче {passingScore}:");
                    resultText.AppendLine("--------------------------------");

                    foreach (var student in failedStudents)
                    {
                        resultText.AppendLine($"{student.Name} - {student.Speciality} (Бал: {student.AverageScore:F2})");
                    }

                    // Виводимо результат у MessageBox
                    MessageBox.Show(resultText.ToString(), "Результат пошуку");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректний прохідний бал (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Допоміжний метод для оновлення ListBox
        private void UpdateDisplay()
        {
            lstOutput.Items.Clear(); // Очищуємо список

            // Додаємо кожного абітурієнта
            // ListBox автоматично викличе .ToString() для кожного
            foreach (var abiturient in abiturientList)
            {
                lstOutput.Items.Add(abiturient);
            }
        }
    }
}