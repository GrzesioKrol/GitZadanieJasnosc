namespace jasnosc
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
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.Wstaw = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.jasnosc = new System.Windows.Forms.Button();
            this.Bar = new System.Windows.Forms.TrackBar();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // obrazek
            // 
            this.obrazek.Location = new System.Drawing.Point(12, 12);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(727, 329);
            this.obrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obrazek.TabIndex = 0;
            this.obrazek.TabStop = false;
            // 
            // Wstaw
            // 
            this.Wstaw.Location = new System.Drawing.Point(41, 347);
            this.Wstaw.Name = "Wstaw";
            this.Wstaw.Size = new System.Drawing.Size(75, 23);
            this.Wstaw.TabIndex = 1;
            this.Wstaw.Text = "Wstaw";
            this.Wstaw.UseVisualStyleBackColor = true;
            this.Wstaw.Click += new System.EventHandler(this.Wstaw_Click);
            // 
            // jasnosc
            // 
            this.jasnosc.Location = new System.Drawing.Point(131, 347);
            this.jasnosc.Name = "jasnosc";
            this.jasnosc.Size = new System.Drawing.Size(75, 23);
            this.jasnosc.TabIndex = 2;
            this.jasnosc.Text = "Jasność";
            this.jasnosc.UseVisualStyleBackColor = true;
            this.jasnosc.Click += new System.EventHandler(this.jasnosc_Click);
            // 
            // Bar
            // 
            this.Bar.Location = new System.Drawing.Point(212, 347);
            this.Bar.Maximum = 100;
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(442, 45);
            this.Bar.TabIndex = 3;
            this.Bar.Scroll += new System.EventHandler(this.Bar_Scroll);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(660, 352);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(13, 13);
            this.Label.TabIndex = 4;
            this.Label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.jasnosc);
            this.Controls.Add(this.Wstaw);
            this.Controls.Add(this.obrazek);
            this.Name = "Form1";
            this.Text = "Zmienność";
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.Button Wstaw;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button jasnosc;
        private System.Windows.Forms.TrackBar Bar;
        private System.Windows.Forms.Label Label;
    }
}

