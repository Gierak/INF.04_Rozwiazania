namespace Muzyka
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_nastepny = new System.Windows.Forms.Button();
            this.button_poprzedni = new System.Windows.Forms.Button();
            this.label_autor = new System.Windows.Forms.Label();
            this.label_tytul = new System.Windows.Forms.Label();
            this.label_rok = new System.Windows.Forms.Label();
            this.label_iloscUtworow = new System.Windows.Forms.Label();
            this.label_iloscPobran = new System.Windows.Forms.Label();
            this.button_pobierz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Muzyka.Properties.Resources.obraz;
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_nastepny
            // 
            this.button_nastepny.BackgroundImage = global::Muzyka.Properties.Resources.obraz2;
            this.button_nastepny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_nastepny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nastepny.Location = new System.Drawing.Point(1322, 151);
            this.button_nastepny.Name = "button_nastepny";
            this.button_nastepny.Size = new System.Drawing.Size(96, 70);
            this.button_nastepny.TabIndex = 1;
            this.button_nastepny.UseVisualStyleBackColor = true;
            this.button_nastepny.Click += new System.EventHandler(this.Button_nastepny_Click);
            // 
            // button_poprzedni
            // 
            this.button_poprzedni.BackgroundImage = global::Muzyka.Properties.Resources.obraz3;
            this.button_poprzedni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_poprzedni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_poprzedni.Location = new System.Drawing.Point(24, 151);
            this.button_poprzedni.Name = "button_poprzedni";
            this.button_poprzedni.Size = new System.Drawing.Size(96, 70);
            this.button_poprzedni.TabIndex = 0;
            this.button_poprzedni.UseVisualStyleBackColor = true;
            this.button_poprzedni.Click += new System.EventHandler(this.Button_poprzedni_Click);
            // 
            // label_autor
            // 
            this.label_autor.AutoSize = true;
            this.label_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_autor.ForeColor = System.Drawing.Color.White;
            this.label_autor.Location = new System.Drawing.Point(456, 41);
            this.label_autor.Name = "label_autor";
            this.label_autor.Size = new System.Drawing.Size(542, 58);
            this.label_autor.TabIndex = 3;
            this.label_autor.Text = "My Chemical Romance";
            // 
            // label_tytul
            // 
            this.label_tytul.AutoSize = true;
            this.label_tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.label_tytul.ForeColor = System.Drawing.Color.White;
            this.label_tytul.Location = new System.Drawing.Point(460, 114);
            this.label_tytul.Name = "label_tytul";
            this.label_tytul.Size = new System.Drawing.Size(272, 36);
            this.label_tytul.TabIndex = 4;
            this.label_tytul.Text = "\"The Black Parade\"";
            // 
            // label_rok
            // 
            this.label_rok.AutoSize = true;
            this.label_rok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_rok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.label_rok.Location = new System.Drawing.Point(624, 171);
            this.label_rok.Name = "label_rok";
            this.label_rok.Size = new System.Drawing.Size(56, 25);
            this.label_rok.TabIndex = 5;
            this.label_rok.Text = "2006";
            // 
            // label_iloscUtworow
            // 
            this.label_iloscUtworow.AutoSize = true;
            this.label_iloscUtworow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_iloscUtworow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.label_iloscUtworow.Location = new System.Drawing.Point(461, 171);
            this.label_iloscUtworow.Name = "label_iloscUtworow";
            this.label_iloscUtworow.Size = new System.Drawing.Size(111, 25);
            this.label_iloscUtworow.TabIndex = 6;
            this.label_iloscUtworow.Text = "14 utworów";
            // 
            // label_iloscPobran
            // 
            this.label_iloscPobran.AutoSize = true;
            this.label_iloscPobran.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_iloscPobran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.label_iloscPobran.Location = new System.Drawing.Point(155, 333);
            this.label_iloscPobran.Name = "label_iloscPobran";
            this.label_iloscPobran.Size = new System.Drawing.Size(111, 25);
            this.label_iloscPobran.TabIndex = 7;
            this.label_iloscPobran.Text = "304666444";
            // 
            // button_pobierz
            // 
            this.button_pobierz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(217)))), ((int)(((byte)(24)))));
            this.button_pobierz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pobierz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button_pobierz.Location = new System.Drawing.Point(322, 325);
            this.button_pobierz.Name = "button_pobierz";
            this.button_pobierz.Size = new System.Drawing.Size(141, 41);
            this.button_pobierz.TabIndex = 8;
            this.button_pobierz.Text = "Pobierz";
            this.button_pobierz.UseVisualStyleBackColor = false;
            this.button_pobierz.Click += new System.EventHandler(this.Button_pobierz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1439, 389);
            this.Controls.Add(this.button_pobierz);
            this.Controls.Add(this.label_iloscPobran);
            this.Controls.Add(this.label_iloscUtworow);
            this.Controls.Add(this.label_rok);
            this.Controls.Add(this.label_tytul);
            this.Controls.Add(this.label_autor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_nastepny);
            this.Controls.Add(this.button_poprzedni);
            this.Name = "Form1";
            this.Text = "MojeDźwięki, Wykonał: 12345678901";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_poprzedni;
        private System.Windows.Forms.Button button_nastepny;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_autor;
        private System.Windows.Forms.Label label_tytul;
        private System.Windows.Forms.Label label_rok;
        private System.Windows.Forms.Label label_iloscUtworow;
        private System.Windows.Forms.Label label_iloscPobran;
        private System.Windows.Forms.Button button_pobierz;
    }
}

