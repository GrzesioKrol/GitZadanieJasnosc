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
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.jasnosc = new System.Windows.Forms.Button();
            this.Bar = new System.Windows.Forms.TrackBar();
            this.Label = new System.Windows.Forms.Label();
            this.Zapis = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.anuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // obrazek
            // 
            this.obrazek.Location = new System.Drawing.Point(12, 12);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(1000, 400);
            this.obrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obrazek.TabIndex = 0;
            this.obrazek.TabStop = false;
            // 
            // Wstaw
            // 
            this.Wstaw.Location = new System.Drawing.Point(51, 446);
            this.Wstaw.Name = "Wstaw";
            this.Wstaw.Size = new System.Drawing.Size(75, 51);
            this.Wstaw.TabIndex = 1;
            this.Wstaw.Text = "Wstaw";
            this.Wstaw.UseVisualStyleBackColor = true;
            this.Wstaw.Click += new System.EventHandler(this.Wstaw_Click);
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // jasnosc
            // 
            this.jasnosc.Location = new System.Drawing.Point(141, 446);
            this.jasnosc.Name = "jasnosc";
            this.jasnosc.Size = new System.Drawing.Size(75, 51);
            this.jasnosc.TabIndex = 2;
            this.jasnosc.Text = "Jasność";
            this.jasnosc.UseVisualStyleBackColor = true;
            this.jasnosc.Click += new System.EventHandler(this.jasnosc_Click);
            // 
            // Bar
            // 
            this.Bar.LargeChange = 50;
            this.Bar.Location = new System.Drawing.Point(222, 446);
            this.Bar.Maximum = 250;
            this.Bar.Minimum = -250;
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(501, 45);
            this.Bar.TabIndex = 3;
            this.Bar.TickFrequency = 25;
            this.Bar.Scroll += new System.EventHandler(this.Bar_Scroll);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label.Location = new System.Drawing.Point(729, 454);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(20, 24);
            this.Label.TabIndex = 4;
            this.Label.Text = "0";
            // 
            // Zapis
            // 
            this.Zapis.Location = new System.Drawing.Point(51, 497);
            this.Zapis.Name = "Zapis";
            this.Zapis.Size = new System.Drawing.Size(75, 46);
            this.Zapis.TabIndex = 5;
            this.Zapis.Text = "Zapis";
            this.Zapis.UseVisualStyleBackColor = true;
            this.Zapis.Click += new System.EventHandler(this.Zapis_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(222, 497);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(501, 29);
            this.progressBar.TabIndex = 6;
            // 
            // anuluj
            // 
            this.anuluj.Location = new System.Drawing.Point(141, 498);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(75, 45);
            this.anuluj.TabIndex = 7;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = true;
            this.anuluj.Click += new System.EventHandler(this.anuluj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 607);
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Zapis);
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
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.Button jasnosc;
        private System.Windows.Forms.TrackBar Bar;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Zapis;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button anuluj;
    }
}

