using Labka5n1;
using System;
using System.IO; // Обов'язково для роботи з файлами
using System.Windows.Forms;

namespace Labka5n1
{
    public partial class Form1 : Form
    {
        // Створюємо поле класу для зберігання нашого об'єкта студента
        // Він буде доступний для всіх методів (кнопок) у цій формі
        private Student currentStudent;

        public Form1()
        {
            InitializeComponent();

            // Ініціалізуємо об'єкт одразу при запуску програми
            currentStudent = new Student();
        }

        // Обробник для кнопки "Створити та Зберегти"
        private void btnCreateSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Зчитуємо дані з полів вводу (TextBox)
                // і записуємо їх у властивості нашого об'єкта
                currentStudent.LastName = txtLastName.Text;
                currentStudent.FirstName = txtFirstName.Text;
                currentStudent.Patronymic = txtPatronymic.Text;
                currentStudent.StudentID = txtStudentID.Text;
                currentStudent.Group = txtGroup.Text;

                // Для чисел потрібне перетворення (парсинг)
                currentStudent.Course = int.Parse(txtCourse.Text);
                currentStudent.AverageGrade = double.Parse(txtAverageGrade.Text);

                // 2. Зберігаємо дані у текстовий файл
                // Використовуємо метод ToString(), який ми перевизначили у класі Student
                File.WriteAllText("student_data.txt", currentStudent.ToString());

                // 3. Повідомляємо користувача про успіх
                lblResult.Text = "Студента створено та збережено у student_data.txt";
            }
            catch (FormatException)
            {
                // Ця помилка виникне, якщо користувач введе текст замість числа
                MessageBox.Show("Помилка: 'Курс' має бути числом (напр. 2), а 'Середній бал' - дробовим числом (напр. 85,5).", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Ловимо будь-які інші помилки (напр. немає доступу до файлу)
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Загальна помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробник для кнопки "Показати ПІБ" (демонстрація методу 1)
        private void btnShowFullName_Click(object sender, EventArgs e)
        {
            // Викликаємо наш власний метод з класу Student
            string shortName = currentStudent.GetShortFullName();
            lblResult.Text = $"Скорочене ПІБ: {shortName}";
        }

        // Обробник для кнопки "Перевести на наст. курс" (демонстрація методу 2)
        private void btnPromote_Click(object sender, EventArgs e)
        {
            // Викликаємо метод
            currentStudent.PromoteToNextCourse();

            // Оновлюємо поле "Курс" на формі, щоб бачити зміни
            txtCourse.Text = currentStudent.Course.ToString();

            lblResult.Text = $"Студента переведено. Новий курс: {currentStudent.Course}";
        }

        // Обробник для кнопки "Оновити бал" (демонстрація методу 3)
        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитуємо новий бал з окремого поля txtNewGrade
                double newGrade = double.Parse(txtNewGrade.Text);

                // Викликаємо наш метод
                currentStudent.UpdateAverageGrade(newGrade);

                // Оновлюємо поле "Середній бал" на формі
                txtAverageGrade.Text = currentStudent.AverageGrade.ToString();

                lblResult.Text = $"Середній бал оновлено: {currentStudent.AverageGrade}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка: Новий бал має бути числом (напр. 90,2).", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}