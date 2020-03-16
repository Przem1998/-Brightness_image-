namespace WindowsFormsApp1
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.percent = new System.Windows.Forms.Label();
            this.brightnessScale = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.anulujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bw = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessScale)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 24);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(290, 231);
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(148, 345);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(15, 13);
            this.percent.TabIndex = 7;
            this.percent.Text = "%";
            // 
            // brightnessScale
            // 
            this.brightnessScale.LargeChange = 1;
            this.brightnessScale.Location = new System.Drawing.Point(12, 297);
            this.brightnessScale.Maximum = 100;
            this.brightnessScale.Name = "brightnessScale";
            this.brightnessScale.Size = new System.Drawing.Size(290, 45);
            this.brightnessScale.SmallChange = 5;
            this.brightnessScale.TabIndex = 6;
            this.brightnessScale.Scroll += new System.EventHandler(this.brightnessScale_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem,
            this.anulujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem1});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Obraz";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem1
            // 
            this.zapiszToolStripMenuItem1.Name = "zapiszToolStripMenuItem1";
            this.zapiszToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.zapiszToolStripMenuItem1.Text = "Zapisz";
            this.zapiszToolStripMenuItem1.Click += new System.EventHandler(this.zapiszToolStripMenuItem1_Click);
            // 
            // anulujToolStripMenuItem
            // 
            this.anulujToolStripMenuItem.Name = "anulujToolStripMenuItem";
            this.anulujToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.anulujToolStripMenuItem.Text = "Anuluj ";
            this.anulujToolStripMenuItem.Click += new System.EventHandler(this.anulujToolStripMenuItem_Click);
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 372);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.brightnessScale);
            this.Name = "Form1";
            this.Text = "Rozjaśnianie obrazu";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessScale)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.TrackBar brightnessScale;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anulujToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bw;
    }
}

