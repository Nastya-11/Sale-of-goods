using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        private bool isAuthorized = false;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "server=localhost;port=3306;database=salesdb;uid=root;pwd=твій пароль до бд;";
            connection = new MySqlConnection(connectionString);
            LoadData();
        }

        private void LoadData(string query = "SELECT * FROM Sales")
        {
            adapter = new MySqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void FilterData()
        {
            string category = comboBoxCategory.Text;
            string minPrice = textBoxMinPrice.Text;
            string maxPrice = textBoxMaxPrice.Text;
            string dateFilter = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string query = "SELECT * FROM Sales WHERE 1=1";

            if (!string.IsNullOrEmpty(category))
                query += $" AND Category LIKE '%{category}%'";

            if (!string.IsNullOrEmpty(minPrice) && !string.IsNullOrEmpty(maxPrice))
                query += $" AND Price BETWEEN {minPrice} AND {maxPrice}";

            if (checkBoxDate.Checked)
                query += $" AND SaleDate = '{dateFilter}'";

            LoadData(query);
        }

        //Події фільтрації
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e) => FilterData();
        private void textBoxMinPrice_TextChanged(object sender, EventArgs e) => FilterData();
        private void textBoxMaxPrice_TextChanged(object sender, EventArgs e) => FilterData();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) => FilterData();
        private void checkBoxDate_CheckedChanged(object sender, EventArgs e) => FilterData();

        //Авторизація
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            if (login.ShowDialog() == DialogResult.OK)
            {
                isAuthorized = login.IsAuthorized;
                buttonImport.Enabled = isAuthorized;
                buttonSaveChanges.Enabled = isAuthorized;
                dataGridView1.ReadOnly = !isAuthorized;
            }
        }

        //Імпорт даних
        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (!isAuthorized) return;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files|*.csv|Text files|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(ofd.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length == 4)
                        {
                            string query = "INSERT INTO Sales (ProductName, Category, Price, SaleDate) VALUES (@p,@c,@pr,@d)";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@p", line[0]);
                            cmd.Parameters.AddWithValue("@c", line[1]);
                            cmd.Parameters.AddWithValue("@pr", decimal.Parse(line[2]));
                            cmd.Parameters.AddWithValue("@d", DateTime.Parse(line[3]));

                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                }
                LoadData();
            }
        }

        //Експорт даних
        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files|*.csv|Text files|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        writer.WriteLine($"{row["ProductName"]},{row["Category"]},{row["Price"]},{row["SaleDate"]}");
                    }
                }
            }
        }

        //Збереження змін із DataGridView у базу даних
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (!isAuthorized)
            {
                MessageBox.Show("Спочатку авторизуйтесь!");
                return;
            }

            try
            {
                connection.Open();
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                adapter.Update(dataTable);
                MessageBox.Show("Зміни успішно збережені в базі даних!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
