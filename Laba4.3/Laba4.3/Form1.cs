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

        // ����������� ������: �������� ����� ��� ������� �� ����� ����� 䳿
        private void InitializeLogger()
        {
            try
            {
                File.WriteAllText(logFilePath, string.Empty); // ������� ����
                LogAction("������� ��������");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�� ������� ������������ ������: {ex.Message}");
            }
        }

        // ����� ��� ������ �� � ������
        private void LogAction(string action)
        {
            try
            {
                // ������ ����� � ���� ������� � ����� �� �����
                File.AppendAllText(logFilePath, $"ĳ�: {action}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ������ � ������: {ex.Message}");
            }
        }

        // �������� ������ "����������� ����� ���"
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtInputFile.Text.Trim();
                if (!File.Exists(path))
                {
                    MessageBox.Show("���� �� ��������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(path);
                if (lines.Length < 2)
                {
                    MessageBox.Show("���� �������, ������ ���.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (double.TryParse(lines[0], out double num1) && double.TryParse(lines[1], out double num2))
                {
                    txtNumber1.Text = num1.ToString();
                    txtNumber2.Text = num2.ToString();
                    LogAction("������ ������������ ����� ���");
                }
                else
                {
                    MessageBox.Show("���������� �������� �������� ���������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� �������: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // �������� ������ "��������� �����"
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtNumber1.Text, out double num1) || !double.TryParse(txtNumber2.Text, out double num2))
                {
                    MessageBox.Show("���������� �������� �������� ���������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("ĳ����� �� 0 ����������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LogAction("������ ������ �� ����");
                        return;
                    }
                    result = num1 / num2;
                    operationSymbol = '/';
                }
                else if (rbPower.Checked) { result = Math.Pow(num1, num2); operationSymbol = '^'; }

                lblResult.Text = $"{num1} {operationSymbol} {num2}, ���������: {result}";
                LogAction("������ ���������� �����");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� �������: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // �������� ������ "������������ � ����"
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblResult.Text))
                {
                    MessageBox.Show("���� ���������� ��� ��������. �������� �������� �����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ������������� ��� �� ���� ��� ������, ����� � ������
                string path = "Output data.txt";
                File.WriteAllText(path, lblResult.Text);
                MessageBox.Show($"��������� ������ ������������ � ���� '{path}'.", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogAction("������ ������������� ��������� � ����");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ��������: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ³������������� ������ �������� ��� ���������
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
                LogAction($"������ ����������� �������� �{operation}�");
            }
        }

        // ����� � ������ ��� ������� ��������
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogAction("������� �������");
        }
    }
}