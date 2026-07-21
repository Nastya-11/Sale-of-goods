using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        public bool IsAuthorized { get; private set; } = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "admin123")
            {
                IsAuthorized = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Невірний пароль!");
            }
        }
    }
}
