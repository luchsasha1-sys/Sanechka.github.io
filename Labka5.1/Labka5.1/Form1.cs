using System;
using System.IO;
using System.Windows.Forms;

namespace Labka5_1
{
    public partial class Form1 : Form
    {
        // Створюємо екземпляр нашого класу на рівні форми
        private Student _currentStudent;

        public Form1()
        {
            InitializeComponent();
            // Ініціалізуємо об'єкт при запуску форми
            _currentStudent = new Student();
        }

        // Допоміжний метод для збору даних з полів вводу
        private bool UpdateStudentFromUI()
        {
            try
            {
                _currentStudent.FirstName = txtFirstName.Text;
                _currentStudent.LastName = txtLastName.Text;
                _currentStudent.StudentID = txtStudentID.Text;
                _currentStudent.Faculty = txtFaculty.Text;
                _currentStudent.DateOfBirth = dtpDateOfBirth.Value;

                // Перевірка коректності вводу числових даних
                if (!int.TryParse(txtCourse.Text, out int course))
                {
                    MessageBox.Show("Будь ласка, введіть коректний номер курсу (ціле число).", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                _currentStudent.Course = course;

                if (!double.TryParse(txtAverageGrade.Text, out double grade))
                {
                    MessageBox.Show("Будь ласка, введіть коректний середній бал (число).", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                _currentStudent.AverageGrade = grade;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка при оновленні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Обробник кнопки "Зберегти у файл"
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (UpdateStudentFromUI()) // Оновлюємо дані перед збереженням
            {
                try
                {
                    string filePath = "student_info.txt";
                    string studentData = $"Ім'я: {_currentStudent.FirstName}\n" +
                                         $"Прізвище: {_currentStudent.LastName}\n" +
                                         $"Номер студ. квитка: {_currentStudent.StudentID}\n" +
                                         $"Факультет: {_currentStudent.Faculty}\n" +
                                         $"Курс: {_currentStudent.Course}\n" +
                                         $"Дата народження: {_currentStudent.DateOfBirth:dd.MM.yyyy}\n" +
                                         $"Середній бал: {_currentStudent.AverageGrade}";

                    File.WriteAllText(filePath, studentData);
                    MessageBox.Show($"Дані успішно збережено у файл '{filePath}'", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося зберегти файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Демонстрація методу GetFullName()
        private void btnShowFullName_Click(object sender, EventArgs e)
        {
            if (UpdateStudentFromUI())
            {
                string fullName = _currentStudent.GetFullName();
                MessageBox.Show($"Повне ім'я студента: {fullName}", "Результат методу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Демонстрація методу CalculateAge()
        private void btnCalculateAge_Click(object sender, EventArgs e)
        {
            if (UpdateStudentFromUI())
            {
                int age = _currentStudent.CalculateAge();
                MessageBox.Show($"Повний вік студента: {age} років", "Результат методу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Демонстрація методу GetAcademicStatus()
        private void btnShowStatus_Click(object sender, EventArgs e)
        {
            if (UpdateStudentFromUI())
            {
                string status = _currentStudent.GetAcademicStatus();
                MessageBox.Show($"Академічний статус: {status}", "Результат методу", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBoxStudentData_Enter(object sender, EventArgs e)
        {

        }
    }
}