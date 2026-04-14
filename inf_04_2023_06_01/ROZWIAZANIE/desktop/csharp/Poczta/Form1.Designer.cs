namespace Poczta
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
            this.radioButton_paczka = new System.Windows.Forms.RadioButton();
            this.radioButton_list = new System.Windows.Forms.RadioButton();
            this.radioButton_pocztowka = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_miasto = new System.Windows.Forms.TextBox();
            this.textBox_kodPocztowy = new System.Windows.Forms.TextBox();
            this.textBox_ulicaZNumerem = new System.Windows.Forms.TextBox();
            this.button_sprawdzCene = new System.Windows.Forms.Button();
            this.label_cena = new System.Windows.Forms.Label();
            this.button_zatwierdz = new System.Windows.Forms.Button();
            this.pictureBox_zdjecie = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdjecie)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_paczka);
            this.groupBox1.Controls.Add(this.radioButton_list);
            this.groupBox1.Controls.Add(this.radioButton_pocztowka);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj przesyłki";
            // 
            // radioButton_paczka
            // 
            this.radioButton_paczka.AutoSize = true;
            this.radioButton_paczka.Location = new System.Drawing.Point(16, 93);
            this.radioButton_paczka.Name = "radioButton_paczka";
            this.radioButton_paczka.Size = new System.Drawing.Size(73, 20);
            this.radioButton_paczka.TabIndex = 2;
            this.radioButton_paczka.Tag = "paczka";
            this.radioButton_paczka.Text = "Paczka";
            this.radioButton_paczka.UseVisualStyleBackColor = true;
            this.radioButton_paczka.Click += new System.EventHandler(this.RadioButton_pocztowka_Click);
            // 
            // radioButton_list
            // 
            this.radioButton_list.AutoSize = true;
            this.radioButton_list.Location = new System.Drawing.Point(16, 61);
            this.radioButton_list.Name = "radioButton_list";
            this.radioButton_list.Size = new System.Drawing.Size(48, 20);
            this.radioButton_list.TabIndex = 1;
            this.radioButton_list.Tag = "list";
            this.radioButton_list.Text = "List";
            this.radioButton_list.UseVisualStyleBackColor = true;
            this.radioButton_list.Click += new System.EventHandler(this.RadioButton_pocztowka_Click);
            // 
            // radioButton_pocztowka
            // 
            this.radioButton_pocztowka.AutoSize = true;
            this.radioButton_pocztowka.Checked = true;
            this.radioButton_pocztowka.Location = new System.Drawing.Point(16, 30);
            this.radioButton_pocztowka.Name = "radioButton_pocztowka";
            this.radioButton_pocztowka.Size = new System.Drawing.Size(93, 20);
            this.radioButton_pocztowka.TabIndex = 0;
            this.radioButton_pocztowka.TabStop = true;
            this.radioButton_pocztowka.Tag = "pocztowka";
            this.radioButton_pocztowka.Text = "Pocztówka";
            this.radioButton_pocztowka.UseVisualStyleBackColor = true;
            this.radioButton_pocztowka.Click += new System.EventHandler(this.RadioButton_pocztowka_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_miasto);
            this.groupBox2.Controls.Add(this.textBox_kodPocztowy);
            this.groupBox2.Controls.Add(this.textBox_ulicaZNumerem);
            this.groupBox2.Location = new System.Drawing.Point(342, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane adresowe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Miasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kod pocztowy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ulica z numerem";
            // 
            // textBox_miasto
            // 
            this.textBox_miasto.Location = new System.Drawing.Point(17, 184);
            this.textBox_miasto.Name = "textBox_miasto";
            this.textBox_miasto.Size = new System.Drawing.Size(258, 22);
            this.textBox_miasto.TabIndex = 2;
            // 
            // textBox_kodPocztowy
            // 
            this.textBox_kodPocztowy.Location = new System.Drawing.Point(17, 119);
            this.textBox_kodPocztowy.Name = "textBox_kodPocztowy";
            this.textBox_kodPocztowy.Size = new System.Drawing.Size(153, 22);
            this.textBox_kodPocztowy.TabIndex = 1;
            // 
            // textBox_ulicaZNumerem
            // 
            this.textBox_ulicaZNumerem.Location = new System.Drawing.Point(17, 53);
            this.textBox_ulicaZNumerem.Name = "textBox_ulicaZNumerem";
            this.textBox_ulicaZNumerem.Size = new System.Drawing.Size(258, 22);
            this.textBox_ulicaZNumerem.TabIndex = 0;
            // 
            // button_sprawdzCene
            // 
            this.button_sprawdzCene.Location = new System.Drawing.Point(25, 155);
            this.button_sprawdzCene.Name = "button_sprawdzCene";
            this.button_sprawdzCene.Size = new System.Drawing.Size(240, 27);
            this.button_sprawdzCene.TabIndex = 2;
            this.button_sprawdzCene.Text = "Sprawdź Cenę";
            this.button_sprawdzCene.UseVisualStyleBackColor = true;
            this.button_sprawdzCene.Click += new System.EventHandler(this.Button_sprawdzCene_Click);
            // 
            // label_cena
            // 
            this.label_cena.AutoSize = true;
            this.label_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cena.Location = new System.Drawing.Point(175, 209);
            this.label_cena.Name = "label_cena";
            this.label_cena.Size = new System.Drawing.Size(81, 29);
            this.label_cena.TabIndex = 3;
            this.label_cena.Text = "Cena:";
            // 
            // button_zatwierdz
            // 
            this.button_zatwierdz.Location = new System.Drawing.Point(25, 304);
            this.button_zatwierdz.Name = "button_zatwierdz";
            this.button_zatwierdz.Size = new System.Drawing.Size(616, 27);
            this.button_zatwierdz.TabIndex = 5;
            this.button_zatwierdz.Text = "Zatwierdź";
            this.button_zatwierdz.UseVisualStyleBackColor = true;
            this.button_zatwierdz.Click += new System.EventHandler(this.Button_zatwierdz_Click);
            // 
            // pictureBox_zdjecie
            // 
            this.pictureBox_zdjecie.Image = global::Poczta.Properties.Resources.pocztowka;
            this.pictureBox_zdjecie.Location = new System.Drawing.Point(25, 193);
            this.pictureBox_zdjecie.Name = "pictureBox_zdjecie";
            this.pictureBox_zdjecie.Size = new System.Drawing.Size(144, 87);
            this.pictureBox_zdjecie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_zdjecie.TabIndex = 4;
            this.pictureBox_zdjecie.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 341);
            this.Controls.Add(this.button_zatwierdz);
            this.Controls.Add(this.pictureBox_zdjecie);
            this.Controls.Add(this.label_cena);
            this.Controls.Add(this.button_sprawdzCene);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nadaj Przesyłkę PESEL 12345678901";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdjecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_paczka;
        private System.Windows.Forms.RadioButton radioButton_list;
        private System.Windows.Forms.RadioButton radioButton_pocztowka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_sprawdzCene;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_miasto;
        private System.Windows.Forms.TextBox textBox_kodPocztowy;
        private System.Windows.Forms.TextBox textBox_ulicaZNumerem;
        private System.Windows.Forms.Label label_cena;
        private System.Windows.Forms.PictureBox pictureBox_zdjecie;
        private System.Windows.Forms.Button button_zatwierdz;
    }
}

