using System.Data;
using MySql.Data.MySqlClient;

namespace Kühlschrank;

public partial class Form1 : Form
{
    private readonly DatabaseConnection dbConnection;

    public Form1()
    {
        InitializeComponent();
        radioButton1.Checked = true;
        textBox3.Visible = false;

        dbConnection = new DatabaseConnection("localhost", "kuehlschrank", "root", "123Schule123");

        SelectLebensmittel();
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

    private void button2_Click(object sender, EventArgs e)
    {
        var bezeichnung = textBox1.Text;
        var kcal = Convert.ToInt32(textBox2.Text);

        if (radioButton1.Checked)
        {
            bool oberirdisch;
            if (listBox1.SelectedIndex == 1)
                oberirdisch = true;
            else
                oberirdisch = false;
            dbConnection.InsertPflanzlLM(bezeichnung, kcal, oberirdisch);
        }
        else if (radioButton2.Checked)
        {
            var fettgehalt = Convert.ToSingle(textBox3.Text);
            dbConnection.InsertTierLM(bezeichnung, kcal, fettgehalt);
        }

        SelectLebensmittel();

        tabControl1.SelectedIndex = 0;
    }

    private void SelectLebensmittel()
    {
        string bezeichnung;
        int kcal;
        dbConnection.OpenConnection();
        
        var query = "SELECT Bezeichnung, KCal FROM lebensmittel";
        var command = new MySqlCommand(query, dbConnection.GetConnection());
        var reader = command.ExecuteReader();

        richTextBox1.Clear();

        while (reader.Read())
        {
            bezeichnung = reader.GetString(0);
            kcal = reader.GetInt32(1);
            richTextBox1.AppendText($"Bezeichnung: {bezeichnung}, KCal: {kcal}\n");
        }

        reader.Close();
        dbConnection.CloseConnection();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        try
        {
            dbConnection.OpenConnection();

            var deletePflanzQuery = "DELETE FROM pflanz_lebensmittel";
            var deletePflanzCommand = new MySqlCommand(deletePflanzQuery, dbConnection.GetConnection());
            deletePflanzCommand.ExecuteNonQuery();

            var deleteTierQuery = "DELETE FROM tier_lebensmittel";
            var deleteTierCommand = new MySqlCommand(deleteTierQuery, dbConnection.GetConnection());
            deleteTierCommand.ExecuteNonQuery();

            var deleteLebensmittelQuery = "DELETE FROM lebensmittel";
            var deleteLebensmittelCommand = new MySqlCommand(deleteLebensmittelQuery, dbConnection.GetConnection());
            deleteLebensmittelCommand.ExecuteNonQuery();

            MessageBox.Show("Alle Lebensmittel gelöscht.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Löschen der Lebensmittel: " + ex.Message);
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 1;
    }
}

public class DatabaseConnection
{
    private readonly MySqlConnection connection;

    public DatabaseConnection(string server, string database, string uid, string password)
    {
        var connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};SslMode=none;";
        connection = new MySqlConnection(connectionString);
    }

    public void OpenConnection()
    {
        if (connection.State == ConnectionState.Closed)
            connection.Open();
    }

    public void CloseConnection()
    {
        if (connection.State == ConnectionState.Open)
            connection.Close();
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }

    public void InsertPflanzlLM(string bezeichnung, int kcal, bool oberirdisch)
    {
        OpenConnection();

        var lebensmittelQuery = "INSERT INTO lebensmittel (Bezeichnung, KCal) VALUES (@bezeichnung, @kcal)";
        var lebensmittelCommand = new MySqlCommand(lebensmittelQuery, connection);
        lebensmittelCommand.Parameters.AddWithValue("@bezeichnung", bezeichnung);
        lebensmittelCommand.Parameters.AddWithValue("@kcal", kcal);
        lebensmittelCommand.ExecuteNonQuery();

        var lebensmittelID = (int)lebensmittelCommand.LastInsertedId;

        var pflanzQuery = "INSERT INTO pflanz_lebensmittel (P_ID, Wurzelart) VALUES (@p_id, @wurzelart)";
        var pflanzCommand = new MySqlCommand(pflanzQuery, connection);
        pflanzCommand.Parameters.AddWithValue("@p_id", lebensmittelID);
        pflanzCommand.Parameters.AddWithValue("@wurzelart", oberirdisch ? "Oberirdisch" : "Unterirdisch");
        pflanzCommand.ExecuteNonQuery();

        CloseConnection();
    }

    public void InsertTierLM(string bezeichnung, int kcal, float fettgehalt)
    {
        OpenConnection();

        var lebensmittelQuery = "INSERT INTO lebensmittel (Bezeichnung, KCal) VALUES (@bezeichnung, @kcal)";
        var lebensmittelCommand = new MySqlCommand(lebensmittelQuery, connection);
        lebensmittelCommand.Parameters.AddWithValue("@bezeichnung", bezeichnung);
        lebensmittelCommand.Parameters.AddWithValue("@kcal", kcal);
        lebensmittelCommand.ExecuteNonQuery();

        var lebensmittelID = (int)lebensmittelCommand.LastInsertedId;

        var tierQuery = "INSERT INTO tier_lebensmittel (T_ID, Fettgehalt) VALUES (@t_id, @fettgehalt)";
        var tierCommand = new MySqlCommand(tierQuery, connection);
        tierCommand.Parameters.AddWithValue("@t_id", lebensmittelID);
        tierCommand.Parameters.AddWithValue("@fettgehalt", fettgehalt);
        tierCommand.ExecuteNonQuery();

        CloseConnection();
    }
}