using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            int indexOfDollar = input.IndexOf('$'); 

            if (indexOfDollar == -1) 
            {
                lblResult.Text = "Символ '$' не знайдено!";
                return;
            }

            int beforeCount = indexOfDollar;
            int afterCount = input.Length - indexOfDollar - 1;

            lblResult.Text = $"До '$': {beforeCount}, Після '$': {afterCount}";
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
