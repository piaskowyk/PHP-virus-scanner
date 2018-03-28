namespace PHP_virus_scaner
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbScanFile = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPotentialRisk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbIgnoreFile = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Count of files:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(58, 31);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(16, 13);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Scan file:";
            // 
            // lbScanFile
            // 
            this.lbScanFile.AutoSize = true;
            this.lbScanFile.Location = new System.Drawing.Point(69, 54);
            this.lbScanFile.Name = "lbScanFile";
            this.lbScanFile.Size = new System.Drawing.Size(16, 13);
            this.lbScanFile.TabIndex = 6;
            this.lbScanFile.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Potential risk:";
            // 
            // lbPotentialRisk
            // 
            this.lbPotentialRisk.AutoSize = true;
            this.lbPotentialRisk.Location = new System.Drawing.Point(89, 76);
            this.lbPotentialRisk.Name = "lbPotentialRisk";
            this.lbPotentialRisk.Size = new System.Drawing.Size(13, 13);
            this.lbPotentialRisk.TabIndex = 10;
            this.lbPotentialRisk.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ignore file:";
            // 
            // lbIgnoreFile
            // 
            this.lbIgnoreFile.AutoSize = true;
            this.lbIgnoreFile.Location = new System.Drawing.Point(75, 99);
            this.lbIgnoreFile.Name = "lbIgnoreFile";
            this.lbIgnoreFile.Size = new System.Drawing.Size(13, 13);
            this.lbIgnoreFile.TabIndex = 12;
            this.lbIgnoreFile.Text = "0";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 130);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(249, 23);
            this.progress.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 216);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lbIgnoreFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPotentialRisk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbScanFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "PHP virus scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbScanFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPotentialRisk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbIgnoreFile;
        private System.Windows.Forms.ProgressBar progress;
    }
}

