namespace ProiectMasini_FormsT10
{
    partial class AfisareForm
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
            this.afisareListBox = new System.Windows.Forms.ListBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // afisareListBox
            // 
            this.afisareListBox.FormattingEnabled = true;
            this.afisareListBox.ItemHeight = 16;
            this.afisareListBox.Location = new System.Drawing.Point(45, 12);
            this.afisareListBox.Name = "afisareListBox";
            this.afisareListBox.Size = new System.Drawing.Size(887, 436);
            this.afisareListBox.TabIndex = 29;
            this.afisareListBox.SelectedIndexChanged += new System.EventHandler(this.afisareListBox_SelectedIndexChanged);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(339, 469);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(317, 43);
            this.okBtn.TabIndex = 30;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // AfisareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 524);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.afisareListBox);
            this.Name = "AfisareForm";
            this.Text = "AfisareForm";
            this.Load += new System.EventHandler(this.AfisareForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox afisareListBox;
        private System.Windows.Forms.Button okBtn;
    }
}