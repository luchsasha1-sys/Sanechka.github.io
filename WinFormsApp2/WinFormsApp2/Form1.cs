using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string firstText = txtFirstText.Text;
            string secondText = txtSecondText.Text;

            string[] firstWords = Regex.Split(firstText, @"\W+");
            string[] secondWords = Regex.Split(secondText, @"\W+");

            var commonWords = firstWords.Intersect(secondWords);

            string result = string.Join(" ", commonWords);

            lblResult.Text = result;
        }
    }
}
