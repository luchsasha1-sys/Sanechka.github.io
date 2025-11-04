using System;
using System.Collections.Generic; // Потрібно для List<>
using System.Windows.Forms;

namespace Labka5n3
{
    public partial class Form1 : Form
    {
        // Це і є ПОЛІМОРФІЗМ:
        // Список типу "Транспорт", в якому будуть лежати
        // і Транспорт, і Вантажівки, і Трактори.
        private List<Transport> allVehicles = new List<Transport>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Встановлюємо значення за замовчуванням при завантаженні
            cmbType.SelectedIndex = 0;
        }

        // Цей метод змінює підпис до 5-го поля
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbType.SelectedItem.ToString();

            if (selectedType == "Вантажівка")
            {
                lblExtraParam.Text = "Вага (кг):";
                lblExtraParam.Visible = true;
                txtExtraParam.Visible = true;
            }
            else if (selectedType == "Трактор")
            {
                lblExtraParam.Text = "К-сть коліс:";
                lblExtraParam.Visible = true;
                txtExtraParam.Visible = true;
            }
            else // "Транспортний засіб"
            {
                lblExtraParam.Visible = false;
                txtExtraParam.Visible = false;
            }
        }

        // Кнопка "Створити об'єкт"
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Зчитуємо базові поля
                string marka = txtMarka.Text;
                int cylinders = int.Parse(txtCylinders.Text);
                int power = int.Parse(txtPower.Text);
                int maxSpeed = int.Parse(txtMaxSpeed.Text);

                Transport newVehicle = null;
                string selectedType = cmbType.SelectedItem.ToString();

                // 2. Створюємо конкретний об'єкт
                if (selectedType == "Вантажівка")
                {
                    int weight = int.Parse(txtExtraParam.Text);
                    // Викликаємо конструктор Вантажівки
                    newVehicle = new Truck(marka, cylinders, power, maxSpeed, weight);
                }
                else if (selectedType == "Трактор")
                {
                    int wheels = int.Parse(txtExtraParam.Text);
                    // Викликаємо конструктор Трактора
                    newVehicle = new Tractor(marka, cylinders, power, maxSpeed, wheels);
                }
                else // "Транспортний засіб"
                {
                    // Викликаємо конструктор Транспорту
                    newVehicle = new Transport(marka, cylinders, power, maxSpeed);
                }

                // 3. Додаємо створений об'єкт у наш загальний список
                allVehicles.Add(newVehicle);

                // 4. Виводимо інформацію (завдання: "вивести інформацію про них")
                txtOutput.AppendText("--- СТВОРЕНО НОВИЙ ОБ'ЄКТ ---\r\n");
                // Викликаємо GetInfo() - він сам викличе правильний GetPayload()
                txtOutput.AppendText(newVehicle.GetInfo() + "\r\n\r\n");

            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка вводу. Перевірте, чи всі поля (окрім марки) заповнені числами.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message);
            }
        }

        // Кнопка "Оновити моделі"
        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("========== ОНОВЛЕННЯ МОДЕЛЕЙ ==========\r\n");

            // Завдання: "Оновити інформацію про об’єкти"
            foreach (Transport vehicle in allVehicles)
            {
                // ПОЛІМОРФІЗМ В ДІЇ:
                // Ми не знаємо, чи це Truck, чи Tractor, чи Transport.
                // Ми просто кажемо "оновись", і C# сам викликає
                // правильний (перевизначений) метод UpdateModel().
                vehicle.UpdateModel();
            }

            // Завдання: "і знову вивести інформацію"
            foreach (Transport vehicle in allVehicles)
            {
                // ПОЛІМОРФІЗМ В ДІЇ (знову):
                // Викликаємо GetInfo(). Він, у свою чергу, викличе
                // правильну (перевизначену) версію GetPayload().
                txtOutput.AppendText(vehicle.GetInfo() + "\r\n");
            }
            txtOutput.AppendText("==========================================\r\n\r\n");
        }
    }
}