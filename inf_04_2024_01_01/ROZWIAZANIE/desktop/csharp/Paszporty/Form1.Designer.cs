namespace Paszporty
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_numer = new System.Windows.Forms.TextBox();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button_ok = new System.Windows.Forms.Button();
            this.pictureBox_osoba = new System.Windows.Forms.PictureBox();
            this.pictureBox_odcisk = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_osoba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odcisk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer";
            // 
            // textBox_numer
            // 
            this.textBox_numer.BackColor = System.Drawing.Color.Azure;
            this.textBox_numer.Location = new System.Drawing.Point(136, 29);
            this.textBox_numer.Name = "textBox_numer";
            this.textBox_numer.Size = new System.Drawing.Size(280, 22);
            this.textBox_numer.TabIndex = 1;
            this.textBox_numer.Leave += new System.EventHandler(this.TextBox_numer_Leave);
            // 
            // textBox_imie
            // 
            this.textBox_imie.BackColor = System.Drawing.Color.Azure;
            this.textBox_imie.Location = new System.Drawing.Point(136, 73);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(280, 22);
            this.textBox_imie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię";
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.BackColor = System.Drawing.Color.Azure;
            this.textBox_nazwisko.Location = new System.Drawing.Point(136, 123);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(280, 22);
            this.textBox_nazwisko.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwisko";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(30, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kolor oczu";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 92);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(63, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "piwne";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.RadioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "zielone";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.RadioButton1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "niebieskie";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.RadioButton1_Click);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.Azure;
            this.button_ok.Location = new System.Drawing.Point(566, 258);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(257, 40);
            this.button_ok.TabIndex = 7;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.Button_ok_Click);
            // 
            // pictureBox_osoba
            // 
            this.pictureBox_osoba.Image = global::Paszporty.Properties.Resources._000_zdjecie;
            this.pictureBox_osoba.Location = new System.Drawing.Point(509, 48);
            this.pictureBox_osoba.Name = "pictureBox_osoba";
            this.pictureBox_osoba.Size = new System.Drawing.Size(154, 180);
            this.pictureBox_osoba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_osoba.TabIndex = 8;
            this.pictureBox_osoba.TabStop = false;
            // 
            // pictureBox_odcisk
            // 
            this.pictureBox_odcisk.Image = global::Paszporty.Properties.Resources._000_odcisk;
            this.pictureBox_odcisk.Location = new System.Drawing.Point(722, 48);
            this.pictureBox_odcisk.Name = "pictureBox_odcisk";
            this.pictureBox_odcisk.Size = new System.Drawing.Size(154, 180);
            this.pictureBox_odcisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_odcisk.TabIndex = 9;
            this.pictureBox_odcisk.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(925, 338);
            this.Controls.Add(this.pictureBox_odcisk);
            this.Controls.Add(this.pictureBox_osoba);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_nazwisko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_imie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_numer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wprowadzenie danych do paszportu. Wykonał: 12345678901";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_osoba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odcisk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numer;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.PictureBox pictureBox_osoba;
        private System.Windows.Forms.PictureBox pictureBox_odcisk;
    }
}

