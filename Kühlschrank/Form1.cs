using MySql.Data.MySqlClient;
using System.Configuration;

namespace Kühlschrank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            textBox3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Oberirdisch:";
            textBox3.Visible = false;
            listBox1.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Fettgehalt:";
            listBox1.Visible = false;
            textBox3.Visible = true;
        }
    }

    
}

