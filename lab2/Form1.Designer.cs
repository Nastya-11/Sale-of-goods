namespace lab2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonSaveChanges;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(23, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(676, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Побутова техніка",
            "Електроніка",
            "Продукти"});
            this.comboBoxCategory.Location = new System.Drawing.Point(100, 20);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(118, 64);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(80, 20);
            this.textBoxMinPrice.TabIndex = 2;
            this.textBoxMinPrice.TextChanged += new System.EventHandler(this.textBoxMinPrice_TextChanged);
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(220, 64);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(80, 20);
            this.textBoxMaxPrice.TabIndex = 3;
            this.textBoxMaxPrice.TextChanged += new System.EventHandler(this.textBoxMaxPrice_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(355, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.Location = new System.Drawing.Point(355, 50);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(218, 31);
            this.checkBoxDate.TabIndex = 5;
            this.checkBoxDate.Text = "Фільтрувати за датою";
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(579, 15);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(120, 34);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Авторизація";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Enabled = false;
            this.buttonImport.Location = new System.Drawing.Point(579, 57);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(120, 25);
            this.buttonImport.TabIndex = 7;
            this.buttonImport.Text = "Імпорт";
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(579, 88);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(120, 25);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Text = "Експорт";
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.Location = new System.Drawing.Point(20, 20);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(74, 20);
            this.labelCategory.TabIndex = 9;
            this.labelCategory.Text = "Категорія:";
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(20, 66);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(104, 20);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Ціна (мін/макс):";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Enabled = false;
            this.buttonSaveChanges.Location = new System.Drawing.Point(579, 398);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(120, 30);
            this.buttonSaveChanges.TabIndex = 11;
            this.buttonSaveChanges.Text = "Зберегти зміни";
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(718, 433);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonSaveChanges);
            this.Name = "Form1";
            this.Text = "Продаж товарів";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
