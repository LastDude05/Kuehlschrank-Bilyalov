namespace UF_KS_OO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1KSbefuellen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1inKSlegen = new System.Windows.Forms.Button();
            this.textBox1Fettgehalt = new System.Windows.Forms.TextBox();
            this.label2Fettgehalt = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2oberirdisch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1tierLM = new System.Windows.Forms.RadioButton();
            this.radioButton1pflLM = new System.Windows.Forms.RadioButton();
            this.textBox1kcal = new System.Windows.Forms.TextBox();
            this.textBox1Bezeichnung = new System.Windows.Forms.TextBox();
            this.label2kcal = new System.Windows.Forms.Label();
            this.label2Bezeichnung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(43, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1KSbefuellen);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kühlschrank";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1KSbefuellen
            // 
            this.button1KSbefuellen.Location = new System.Drawing.Point(102, 289);
            this.button1KSbefuellen.Name = "button1KSbefuellen";
            this.button1KSbefuellen.Size = new System.Drawing.Size(278, 35);
            this.button1KSbefuellen.TabIndex = 1;
            this.button1KSbefuellen.Text = "Kühlschrank befüllen";
            this.button1KSbefuellen.UseVisualStyleBackColor = true;
            this.button1KSbefuellen.Click += new System.EventHandler(this.button1KSbefuellen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(466, 271);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1inKSlegen);
            this.tabPage2.Controls.Add(this.textBox1Fettgehalt);
            this.tabPage2.Controls.Add(this.label2Fettgehalt);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label2oberirdisch);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.textBox1kcal);
            this.tabPage2.Controls.Add(this.textBox1Bezeichnung);
            this.tabPage2.Controls.Add(this.label2kcal);
            this.tabPage2.Controls.Add(this.label2Bezeichnung);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Neues Lebensmittel hinzufügen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1inKSlegen
            // 
            this.button1inKSlegen.Location = new System.Drawing.Point(33, 329);
            this.button1inKSlegen.Name = "button1inKSlegen";
            this.button1inKSlegen.Size = new System.Drawing.Size(291, 42);
            this.button1inKSlegen.TabIndex = 10;
            this.button1inKSlegen.Text = "in den Kühlschrank legen";
            this.button1inKSlegen.UseVisualStyleBackColor = true;
            this.button1inKSlegen.Click += new System.EventHandler(this.button1inKSlegen_Click);
            // 
            // textBox1Fettgehalt
            // 
            this.textBox1Fettgehalt.Location = new System.Drawing.Point(152, 277);
            this.textBox1Fettgehalt.Name = "textBox1Fettgehalt";
            this.textBox1Fettgehalt.Size = new System.Drawing.Size(172, 31);
            this.textBox1Fettgehalt.TabIndex = 9;
            // 
            // label2Fettgehalt
            // 
            this.label2Fettgehalt.AutoSize = true;
            this.label2Fettgehalt.Location = new System.Drawing.Point(29, 280);
            this.label2Fettgehalt.Name = "label2Fettgehalt";
            this.label2Fettgehalt.Size = new System.Drawing.Size(100, 25);
            this.label2Fettgehalt.TabIndex = 8;
            this.label2Fettgehalt.Text = "Fettgehalt: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "ja",
            "nein"});
            this.listBox1.Location = new System.Drawing.Point(214, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(110, 29);
            this.listBox1.TabIndex = 7;
            // 
            // label2oberirdisch
            // 
            this.label2oberirdisch.AutoSize = true;
            this.label2oberirdisch.Location = new System.Drawing.Point(33, 280);
            this.label2oberirdisch.Name = "label2oberirdisch";
            this.label2oberirdisch.Size = new System.Drawing.Size(175, 25);
            this.label2oberirdisch.TabIndex = 6;
            this.label2oberirdisch.Text = "Oberirdisch (ja/nein):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1tierLM);
            this.groupBox1.Controls.Add(this.radioButton1pflLM);
            this.groupBox1.Location = new System.Drawing.Point(29, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lebensmittelart";
            // 
            // radioButton1tierLM
            // 
            this.radioButton1tierLM.AutoSize = true;
            this.radioButton1tierLM.Location = new System.Drawing.Point(20, 78);
            this.radioButton1tierLM.Name = "radioButton1tierLM";
            this.radioButton1tierLM.Size = new System.Drawing.Size(214, 29);
            this.radioButton1tierLM.TabIndex = 1;
            this.radioButton1tierLM.TabStop = true;
            this.radioButton1tierLM.Text = "tierisches Lebensmittel";
            this.radioButton1tierLM.UseVisualStyleBackColor = true;
            this.radioButton1tierLM.CheckedChanged += new System.EventHandler(this.radioButton1tierLM_CheckedChanged);
            // 
            // radioButton1pflLM
            // 
            this.radioButton1pflLM.AutoSize = true;
            this.radioButton1pflLM.Location = new System.Drawing.Point(20, 32);
            this.radioButton1pflLM.Name = "radioButton1pflLM";
            this.radioButton1pflLM.Size = new System.Drawing.Size(233, 29);
            this.radioButton1pflLM.TabIndex = 0;
            this.radioButton1pflLM.TabStop = true;
            this.radioButton1pflLM.Text = "pflanzliches Lebensmittel";
            this.radioButton1pflLM.UseVisualStyleBackColor = true;
            this.radioButton1pflLM.CheckedChanged += new System.EventHandler(this.radioButton1pflLM_CheckedChanged);
            // 
            // textBox1kcal
            // 
            this.textBox1kcal.Location = new System.Drawing.Point(153, 93);
            this.textBox1kcal.Name = "textBox1kcal";
            this.textBox1kcal.Size = new System.Drawing.Size(171, 31);
            this.textBox1kcal.TabIndex = 4;
            // 
            // textBox1Bezeichnung
            // 
            this.textBox1Bezeichnung.Location = new System.Drawing.Point(152, 49);
            this.textBox1Bezeichnung.Name = "textBox1Bezeichnung";
            this.textBox1Bezeichnung.Size = new System.Drawing.Size(172, 31);
            this.textBox1Bezeichnung.TabIndex = 3;
            // 
            // label2kcal
            // 
            this.label2kcal.AutoSize = true;
            this.label2kcal.Location = new System.Drawing.Point(21, 89);
            this.label2kcal.Name = "label2kcal";
            this.label2kcal.Size = new System.Drawing.Size(107, 25);
            this.label2kcal.TabIndex = 2;
            this.label2kcal.Text = "Kilokalorien:";
            // 
            // label2Bezeichnung
            // 
            this.label2Bezeichnung.AutoSize = true;
            this.label2Bezeichnung.Location = new System.Drawing.Point(21, 49);
            this.label2Bezeichnung.Name = "label2Bezeichnung";
            this.label2Bezeichnung.Size = new System.Drawing.Size(115, 25);
            this.label2Bezeichnung.TabIndex = 1;
            this.label2Bezeichnung.Text = "Bezeichnung:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kühlschrank mit Lebensmittel befüllen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1KSbefuellen;
        private RichTextBox richTextBox1;
        private TabPage tabPage2;
        private Label label1;
        private Button button1inKSlegen;
        private TextBox textBox1Fettgehalt;
        private Label label2Fettgehalt;
        private ListBox listBox1;
        private Label label2oberirdisch;
        private GroupBox groupBox1;
        private RadioButton radioButton1tierLM;
        private RadioButton radioButton1pflLM;
        private TextBox textBox1kcal;
        private TextBox textBox1Bezeichnung;
        private Label label2kcal;
        private Label label2Bezeichnung;
    }
}