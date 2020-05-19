namespace ProiectMasini_FormsT10
{
    partial class FormT10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerMasiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaMasiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautaMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.managerMasiniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaMasinaToolStripMenuItem,
            this.modificaMasinaToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // adaugaMasinaToolStripMenuItem
            // 
            this.adaugaMasinaToolStripMenuItem.Name = "adaugaMasinaToolStripMenuItem";
            this.adaugaMasinaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.adaugaMasinaToolStripMenuItem.Text = "Adauga Masina";
            this.adaugaMasinaToolStripMenuItem.Click += new System.EventHandler(this.adaugaMasinaToolStripMenuItem_Click);
            // 
            // modificaMasinaToolStripMenuItem
            // 
            this.modificaMasinaToolStripMenuItem.Name = "modificaMasinaToolStripMenuItem";
            this.modificaMasinaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.modificaMasinaToolStripMenuItem.Text = "Modifica Masina";
            this.modificaMasinaToolStripMenuItem.Click += new System.EventHandler(this.modificaMasinaToolStripMenuItem_Click);
            // 
            // managerMasiniToolStripMenuItem
            // 
            this.managerMasiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiseazaMasiniToolStripMenuItem,
            this.cautaMasinaToolStripMenuItem});
            this.managerMasiniToolStripMenuItem.Name = "managerMasiniToolStripMenuItem";
            this.managerMasiniToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.managerMasiniToolStripMenuItem.Text = "Manager Masini";
            // 
            // afiseazaMasiniToolStripMenuItem
            // 
            this.afiseazaMasiniToolStripMenuItem.Name = "afiseazaMasiniToolStripMenuItem";
            this.afiseazaMasiniToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.afiseazaMasiniToolStripMenuItem.Text = "Afiseaza Masini";
            this.afiseazaMasiniToolStripMenuItem.Click += new System.EventHandler(this.afiseazaMasiniToolStripMenuItem_Click);
            // 
            // cautaMasinaToolStripMenuItem
            // 
            this.cautaMasinaToolStripMenuItem.Name = "cautaMasinaToolStripMenuItem";
            this.cautaMasinaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.cautaMasinaToolStripMenuItem.Text = "Cauta Masina";
            this.cautaMasinaToolStripMenuItem.Click += new System.EventHandler(this.cautaMasinaToolStripMenuItem_Click);
            // 
            // FormT10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 134);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormT10";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormT10_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerMasiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaMasiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautaMasinaToolStripMenuItem;
    }
}

