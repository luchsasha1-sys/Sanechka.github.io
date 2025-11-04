using System;
using System.Windows.Forms;

namespace Labka6n2
{
    public partial class Form1 : Form
    {
        // --- Демонстрація поліморфізму ---
        // Ми зберігаємо один і той самий об'єкт,
        // але "дивимось" на нього через різні "лінзи" (інтерфейси)
        private IPublication? currentPublication;
        private IAuthor? currentAuthor;

        // Зберігаємо об'єкт і в його "справжньому" типі,
        // щоб мати доступ до *власних* методів
        private object? currentObject;

        public Form1()
        {
            InitializeComponent();
        }

        // При завантаженні форми, обираємо "Стаття" за замовчуванням
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
        }

        // Динамічно змінюємо підписи до полів
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbType.SelectedItem?.ToString() ?? "";
            if (selected == "Стаття")
            {
                lblDynamic1.Text = "Журнал:";
                lblDynamic2.Text = "Номер випуску:";
            }
            else // "Електронний ресурс"
            {
                lblDynamic1.Text = "URL:";
                lblDynamic2.Text = "Дата доступу:";
            }
        }

        // Кнопка "Створити об'єкт"
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Збираємо спільні дані
                string title = txtTitle.Text;
                string author = txtAuthorName.Text;
                string authorInfo = txtAuthorInfo.Text;
                int year = int.Parse(txtPublishYear.Text);
                string val1 = txtDynamic1.Text;
                string val2 = txtDynamic2.Text;

                string selected = cmbType.SelectedItem?.ToString() ?? "";

                // Очищуємо старі об'єкти
                currentPublication = null;
                currentAuthor = null;
                currentObject = null;
                txtOutput.Clear();

                // 2. Створюємо конкретний об'єкт
                if (selected == "Стаття")
                {
                    Article art = new Article(title, author, authorInfo, year, val1, int.Parse(val2));

                    // 3. Дивимось на об'єкт Article через різні інтерфейси
                    currentPublication = art;
                    currentAuthor = art;
                    currentObject = art;
                }
                else // "Електронний ресурс"
                {
                    ElectronicResource res = new ElectronicResource(title, author, authorInfo, year, val1, val2);

                    // 3. Дивимось на об'єкт ElectronicResource через різні інтерфейси
                    currentPublication = res;
                    currentAuthor = res;
                    currentObject = res;
                }

                txtOutput.AppendText($"--- СТВОРЕНО: {selected} ---\r\n");
                txtOutput.AppendText($"Об'єкт '{title}' успішно створено.\r\n");

            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка вводу. 'Рік видання' та 'Номер випуску' мають бути числами.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        // Кнопка "Показати інформацію"
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (currentPublication == null || currentAuthor == null || currentObject == null)
            {
                MessageBox.Show("Спочатку створіть об'єкт.");
                return;
            }

            txtOutput.AppendText("\r\n--- 1. Виклик методів з інтерфейсу IPublication ---\r\n");
            txtOutput.AppendText(currentPublication.GetFullCitation() + "\r\n");
            txtOutput.AppendText(currentPublication.GetPublishStatus() + "\r\n");

            txtOutput.AppendText("\r\n--- 2. Виклик методів з інтерфейсу IAuthor ---\r\n");
            txtOutput.AppendText(currentAuthor.GetFullName() + "\r\n");
            txtOutput.AppendText(currentAuthor.GetAuthorInfo() + "\r\n");

            txtOutput.AppendText("\r\n--- 3. Виклик ВЛАСНИХ методів класу ---\r\n");

            // Щоб викликати власні методи, нам треба "привести" (cast)
            // об'єкт до його конкретного типу
            if (currentObject is Article)
            {
                Article art = (Article)currentObject;
                txtOutput.AppendText(art.GetJournal() + "\r\n");
                txtOutput.AppendText(art.SubmitForReview() + "\r\n");
            }
            else if (currentObject is ElectronicResource)
            {
                ElectronicResource res = (ElectronicResource)currentObject;
                txtOutput.AppendText(res.GetUrl() + "\r\n");
                txtOutput.AppendText("Перевірка посилання (власний метод): " + res.CheckLink() + "\r\n");
            }
        }
    }
}