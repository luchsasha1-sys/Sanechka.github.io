using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Laba4_3
{
    public partial class Form1 : Form
    {
        private readonly string logFilePath = "Session log.txt";

        public Form1()
        {
            InitializeComponent();
            InitializeLogger();
        }

        // Ініціалізація логера: очищення файлу при запуску та запис першої дії
        private void InitializeLogger()
        {
            try
            {
                File.WriteAllText(logFilePath, string.Empty); // Очищуємо файл
                LogAction("додаток запущено");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося ініціалізувати журнал: {ex.Message}");
            }
        }

        // Метод для запису дій у журнал
        private void LogAction(string action)
        {
            try
            {
                // Додаємо запис у файл журналу з датою та часом
                File.AppendAllText(logFilePath, $"Дія: {action}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка запису в журнал: {ex.Message}");
            }
        }

        // Обробник кнопки "Імпортувати вхідні дані"
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtInputFile.Text.Trim();
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(path);
                if (lines.Length < 2)
                {
                    MessageBox.Show("Файл порожній, введіть дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (double.TryParse(lines[0], out double num1) && double.TryParse(lines[1], out double num2))
                {
                    txtNumber1.Text = num1.ToString();
                    txtNumber2.Text = num2.ToString();
                    LogAction("обрано «Імпортувати вхідні дані»");
                }
                else
                {
                    MessageBox.Show("Недопустимі значення введених параметрів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробник кнопки "Обчислити вираз"
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtNumber1.Text, out double num1) || !double.TryParse(txtNumber2.Text, out double num2))
                {
                    MessageBox.Show("Недопустимі значення введених параметрів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = 0;
                char operationSymbol = ' ';

                if (rbAdd.Checked) { result = num1 + num2; operationSymbol = '+'; }
                else if (rbSubtract.Checked) { result = num1 - num2; operationSymbol = '-'; }
                else if (rbMultiply.Checked) { result = num1 * num2; operationSymbol = '*'; }
                else if (rbDivide.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Ділення на 0 заборонено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LogAction("спроба ділення на нуль");
                        return;
                    }
                    result = num1 / num2;
                    operationSymbol = '/';
                }
                else if (rbPower.Checked) { result = Math.Pow(num1, num2); operationSymbol = '^'; }

                lblResult.Text = $"{num1} {operationSymbol} {num2}, Результат: {result}";
                LogAction("обрано «Обчислити вираз»");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробник кнопки "Експортувати у файл"
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblResult.Text))
                {
                    MessageBox.Show("Немає результату для експорту. Спочатку обчисліть вираз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Використовуємо той же файл для виводу, згідно з умовою
                string path = "Output data.txt";
                File.WriteAllText(path, lblResult.Text);
                MessageBox.Show($"Результат успішно експортовано у файл '{path}'.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogAction("обрано «Експортувати результат у файл»");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка експорту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Відслідковування вибору операції для логування
        private void Operation_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                string operation = "";
                if (rb == rbAdd) operation = "+";
                else if (rb == rbSubtract) operation = "-";
                else if (rb == rbMultiply) operation = "*";
                else if (rb == rbDivide) operation = "/";
                else if (rb == rbPower) operation = "^";
                LogAction($"обрано арифметичну операцію «{operation}»");
            }
        }

        // Запис у журнал при закритті програми
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogAction("додаток закрито");
        }
    }
}