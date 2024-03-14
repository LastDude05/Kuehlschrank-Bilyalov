namespace UF_KS_OO
{
    public partial class Form1 : Form
    {
        /**************ACHTUNG NEU************/
        Kuehlschrank ks; //KÜHLSCHRANK deklarieren
        public Form1()
        {
            InitializeComponent();
            this.textBox1Fettgehalt.Visible= false;
            this.label2Fettgehalt.Visible= false;
            ks = new Kuehlschrank(4);
            this.radioButton1pflLM.Checked = true;
        }

        private void button1KSbefuellen_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex= 1;  
        }

        private void button1inKSlegen_Click(object sender, EventArgs e)
        {
            if (this.radioButton1pflLM.Checked == true)
            {
                bool temp;
                if (listBox1.Text == "ja")
                    temp = true;
                else
                    temp = false;

                ks.BefuelleKS(new PflanzlLM(Convert.ToInt16(textBox1kcal.Text), 
                    this.textBox1Bezeichnung.Text, temp));
            }
            else 
            {
                ks.BefuelleKS(new TierLM(Convert.ToInt32(textBox1kcal.Text), textBox1Bezeichnung.Text, 
                    (float)Convert.ToDouble(textBox1Fettgehalt.Text)));
            }
            this.richTextBox1.Text = ks.ZeigeInhalt();
            this.textBox1Bezeichnung.Clear();
            this.textBox1Fettgehalt.Clear();
            this.textBox1kcal.Clear();
            tabControl1.SelectedIndex = 0;
        }

        private void radioButton1tierLM_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1Fettgehalt.Visible = true;
            this.label2Fettgehalt.Visible = true;
            this.label2oberirdisch.Visible = false;
            this.listBox1.Visible = false;

        }

        private void radioButton1pflLM_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1Fettgehalt.Visible = false;
            this.label2Fettgehalt.Visible = false;
            this.label2oberirdisch.Visible = true;
            this.listBox1.Visible = true;
        }
    }
}