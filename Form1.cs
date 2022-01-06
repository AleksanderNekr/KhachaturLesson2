using System;
using System.Globalization;
using System.Windows.Forms;

namespace Les2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            TextBox.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}