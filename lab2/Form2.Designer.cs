namespace lab2
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonOK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(20, 20);
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Name = "textBoxPassword";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(80, 60);
            this.buttonOK.Size = new System.Drawing.Size(80, 25);
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.Name = "buttonOK";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(250, 120);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonOK);
            this.Name = "Form2";
            this.Text = "Авторизація";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
