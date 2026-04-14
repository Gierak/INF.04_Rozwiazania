namespace Pracownik
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_stanowisko = new System.Windows.Forms.ComboBox();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_generuj = new System.Windows.Forms.Button();
            this.checkBox_specjalne = new System.Windows.Forms.CheckBox();
            this.checkBox_cyfry = new System.Windows.Forms.CheckBox();
            this.checkBox_maleWielkie = new System.Windows.Forms.CheckBox();
            this.textBox_ileZnakow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_zatwierdz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_stanowisko);
            this.groupBox1.Controls.Add(this.textBox_nazwisko);
            this.groupBox1.Controls.Add(this.textBox_imie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane pracownika";
            // 
            // comboBox_stanowisko
            // 
            this.comboBox_stanowisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stanowisko.FormattingEnabled = true;
            this.comboBox_stanowisko.Items.AddRange(new object[] {
            "Kierownik",
            "Starszy programista",
            "Młodszy programista",
            "Tester"});
            this.comboBox_stanowisko.Location = new System.Drawing.Point(147, 113);
            this.comboBox_stanowisko.Name = "comboBox_stanowisko";
            this.comboBox_stanowisko.Size = new System.Drawing.Size(167, 24);
            this.comboBox_stanowisko.TabIndex = 5;
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(147, 73);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(167, 22);
            this.textBox_nazwisko.TabIndex = 4;
            // 
            // textBox_imie
            // 
            this.textBox_imie.Location = new System.Drawing.Point(147, 29);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(167, 22);
            this.textBox_imie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanowisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_generuj);
            this.groupBox2.Controls.Add(this.checkBox_specjalne);
            this.groupBox2.Controls.Add(this.checkBox_cyfry);
            this.groupBox2.Controls.Add(this.checkBox_maleWielkie);
            this.groupBox2.Controls.Add(this.textBox_ileZnakow);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(403, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generowanie hasła";
            // 
            // button_generuj
            // 
            this.button_generuj.BackColor = System.Drawing.Color.SteelBlue;
            this.button_generuj.ForeColor = System.Drawing.Color.White;
            this.button_generuj.Location = new System.Drawing.Point(100, 160);
            this.button_generuj.Name = "button_generuj";
            this.button_generuj.Size = new System.Drawing.Size(141, 31);
            this.button_generuj.TabIndex = 2;
            this.button_generuj.Text = "Generuj hasło";
            this.button_generuj.UseVisualStyleBackColor = false;
            this.button_generuj.Click += new System.EventHandler(this.Button_generuj_Click);
            // 
            // checkBox_specjalne
            // 
            this.checkBox_specjalne.AutoSize = true;
            this.checkBox_specjalne.Location = new System.Drawing.Point(29, 131);
            this.checkBox_specjalne.Name = "checkBox_specjalne";
            this.checkBox_specjalne.Size = new System.Drawing.Size(124, 20);
            this.checkBox_specjalne.TabIndex = 10;
            this.checkBox_specjalne.Text = "Znaki specjalne";
            this.checkBox_specjalne.UseVisualStyleBackColor = true;
            // 
            // checkBox_cyfry
            // 
            this.checkBox_cyfry.AutoSize = true;
            this.checkBox_cyfry.Location = new System.Drawing.Point(29, 102);
            this.checkBox_cyfry.Name = "checkBox_cyfry";
            this.checkBox_cyfry.Size = new System.Drawing.Size(59, 20);
            this.checkBox_cyfry.TabIndex = 9;
            this.checkBox_cyfry.Text = "Cyfry";
            this.checkBox_cyfry.UseVisualStyleBackColor = true;
            // 
            // checkBox_maleWielkie
            // 
            this.checkBox_maleWielkie.AutoSize = true;
            this.checkBox_maleWielkie.Checked = true;
            this.checkBox_maleWielkie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_maleWielkie.Location = new System.Drawing.Point(29, 71);
            this.checkBox_maleWielkie.Name = "checkBox_maleWielkie";
            this.checkBox_maleWielkie.Size = new System.Drawing.Size(143, 20);
            this.checkBox_maleWielkie.TabIndex = 8;
            this.checkBox_maleWielkie.Text = "Małe i wielkie litery";
            this.checkBox_maleWielkie.UseVisualStyleBackColor = true;
            // 
            // textBox_ileZnakow
            // 
            this.textBox_ileZnakow.Location = new System.Drawing.Point(153, 27);
            this.textBox_ileZnakow.Name = "textBox_ileZnakow";
            this.textBox_ileZnakow.Size = new System.Drawing.Size(150, 22);
            this.textBox_ileZnakow.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ile znaków?";
            // 
            // button_zatwierdz
            // 
            this.button_zatwierdz.BackColor = System.Drawing.Color.SteelBlue;
            this.button_zatwierdz.ForeColor = System.Drawing.Color.White;
            this.button_zatwierdz.Location = new System.Drawing.Point(181, 242);
            this.button_zatwierdz.Name = "button_zatwierdz";
            this.button_zatwierdz.Size = new System.Drawing.Size(412, 33);
            this.button_zatwierdz.TabIndex = 2;
            this.button_zatwierdz.Text = "Zatwierdź";
            this.button_zatwierdz.UseVisualStyleBackColor = false;
            this.button_zatwierdz.Click += new System.EventHandler(this.Button_zatwierdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.button_zatwierdz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dodaj pracownika 12345678901";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_stanowisko;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_generuj;
        private System.Windows.Forms.CheckBox checkBox_specjalne;
        private System.Windows.Forms.CheckBox checkBox_cyfry;
        private System.Windows.Forms.CheckBox checkBox_maleWielkie;
        private System.Windows.Forms.TextBox textBox_ileZnakow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_zatwierdz;
    }
}

