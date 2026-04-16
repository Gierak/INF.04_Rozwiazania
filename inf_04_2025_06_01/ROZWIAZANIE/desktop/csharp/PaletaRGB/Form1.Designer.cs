namespace PaletaRGB
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
            this.panel_podglad = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_czerwony = new System.Windows.Forms.Label();
            this.trackBar_czerwony = new System.Windows.Forms.TrackBar();
            this.trackBar_zielony = new System.Windows.Forms.TrackBar();
            this.label_zielony = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_niebieski = new System.Windows.Forms.TrackBar();
            this.label_niebieski = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_pobierz = new System.Windows.Forms.Button();
            this.label_zapisane = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_czerwony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_zielony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_niebieski)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_podglad
            // 
            this.panel_podglad.BackColor = System.Drawing.Color.White;
            this.panel_podglad.Location = new System.Drawing.Point(33, 24);
            this.panel_podglad.Name = "panel_podglad";
            this.panel_podglad.Size = new System.Drawing.Size(715, 81);
            this.panel_podglad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobierz kolor suwakami i zapisz przyciskiem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "R";
            // 
            // label_czerwony
            // 
            this.label_czerwony.AutoSize = true;
            this.label_czerwony.Location = new System.Drawing.Point(720, 202);
            this.label_czerwony.Name = "label_czerwony";
            this.label_czerwony.Size = new System.Drawing.Size(28, 16);
            this.label_czerwony.TabIndex = 3;
            this.label_czerwony.Text = "255";
            // 
            // trackBar_czerwony
            // 
            this.trackBar_czerwony.LargeChange = 1;
            this.trackBar_czerwony.Location = new System.Drawing.Point(89, 187);
            this.trackBar_czerwony.Maximum = 255;
            this.trackBar_czerwony.Name = "trackBar_czerwony";
            this.trackBar_czerwony.Size = new System.Drawing.Size(593, 56);
            this.trackBar_czerwony.TabIndex = 8;
            this.trackBar_czerwony.TickFrequency = 0;
            this.trackBar_czerwony.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_czerwony.Value = 255;
            this.trackBar_czerwony.Scroll += new System.EventHandler(this.TrackBar_czerwony_Scroll);
            // 
            // trackBar_zielony
            // 
            this.trackBar_zielony.LargeChange = 1;
            this.trackBar_zielony.Location = new System.Drawing.Point(89, 244);
            this.trackBar_zielony.Maximum = 255;
            this.trackBar_zielony.Name = "trackBar_zielony";
            this.trackBar_zielony.Size = new System.Drawing.Size(593, 56);
            this.trackBar_zielony.TabIndex = 11;
            this.trackBar_zielony.TickFrequency = 0;
            this.trackBar_zielony.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_zielony.Value = 255;
            this.trackBar_zielony.Scroll += new System.EventHandler(this.TrackBar_zielony_Scroll);
            // 
            // label_zielony
            // 
            this.label_zielony.AutoSize = true;
            this.label_zielony.Location = new System.Drawing.Point(720, 259);
            this.label_zielony.Name = "label_zielony";
            this.label_zielony.Size = new System.Drawing.Size(28, 16);
            this.label_zielony.TabIndex = 10;
            this.label_zielony.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "G";
            // 
            // trackBar_niebieski
            // 
            this.trackBar_niebieski.LargeChange = 1;
            this.trackBar_niebieski.Location = new System.Drawing.Point(89, 299);
            this.trackBar_niebieski.Maximum = 255;
            this.trackBar_niebieski.Name = "trackBar_niebieski";
            this.trackBar_niebieski.Size = new System.Drawing.Size(593, 56);
            this.trackBar_niebieski.TabIndex = 14;
            this.trackBar_niebieski.TickFrequency = 0;
            this.trackBar_niebieski.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_niebieski.Value = 255;
            this.trackBar_niebieski.Scroll += new System.EventHandler(this.TrackBar_niebieski_Scroll);
            // 
            // label_niebieski
            // 
            this.label_niebieski.AutoSize = true;
            this.label_niebieski.Location = new System.Drawing.Point(720, 314);
            this.label_niebieski.Name = "label_niebieski";
            this.label_niebieski.Size = new System.Drawing.Size(28, 16);
            this.label_niebieski.TabIndex = 13;
            this.label_niebieski.Text = "255";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "B";
            // 
            // button_pobierz
            // 
            this.button_pobierz.BackColor = System.Drawing.Color.Peru;
            this.button_pobierz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pobierz.Location = new System.Drawing.Point(265, 358);
            this.button_pobierz.Name = "button_pobierz";
            this.button_pobierz.Size = new System.Drawing.Size(208, 44);
            this.button_pobierz.TabIndex = 15;
            this.button_pobierz.Text = "Pobierz";
            this.button_pobierz.UseVisualStyleBackColor = false;
            this.button_pobierz.Click += new System.EventHandler(this.Button_pobierz_Click);
            // 
            // label_zapisane
            // 
            this.label_zapisane.BackColor = System.Drawing.Color.White;
            this.label_zapisane.Location = new System.Drawing.Point(262, 424);
            this.label_zapisane.Name = "label_zapisane";
            this.label_zapisane.Size = new System.Drawing.Size(211, 39);
            this.label_zapisane.TabIndex = 16;
            this.label_zapisane.Text = "255, 255, 255";
            this.label_zapisane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.label_zapisane);
            this.Controls.Add(this.button_pobierz);
            this.Controls.Add(this.trackBar_niebieski);
            this.Controls.Add(this.label_niebieski);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar_zielony);
            this.Controls.Add(this.label_zielony);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar_czerwony);
            this.Controls.Add(this.label_czerwony);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_podglad);
            this.Name = "Form1";
            this.Text = "Wzornik kolorów RGB. Wykonał 12345678901";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_czerwony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_zielony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_niebieski)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_podglad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_czerwony;
        private System.Windows.Forms.TrackBar trackBar_czerwony;
        private System.Windows.Forms.TrackBar trackBar_zielony;
        private System.Windows.Forms.Label label_zielony;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar_niebieski;
        private System.Windows.Forms.Label label_niebieski;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_pobierz;
        private System.Windows.Forms.Label label_zapisane;
    }
}

