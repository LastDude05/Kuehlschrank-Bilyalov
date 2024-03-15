using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kühlschrank
{
    public partial class Form1 : Form
    {
        private DatabaseConnection dbConnection;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            textBox3.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Oberirdisch:";
            textBox3.Visible = false;
            listBox1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Fettgehalt:";
            listBox1.Visible = false;
            textBox3.Visible = true;
        }
    }
    
    public class DatabaseConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string tabelle_lebensmittel;
        private string pflanz_lebensmittel;
        private string tier_lebensmittel;


        public DatabaseConnection()
        {
            server = "localhost";
            database = "kuehlschrank";
            uid = "root";
            password = "123Schule123"; 
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};SslMode=none;";
            connection = new MySqlConnection(connectionString);
            tabelle_lebensmittel = "lebensmittel";
            pflanz_lebensmittel = "pflanz_lebensmittel";
            tier_lebensmittel = "tier_lebensmittel";
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
