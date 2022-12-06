namespace Tugas
{
    partial class FormHasil
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
            this.groupBoxHasil = new System.Windows.Forms.GroupBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.listBoxHasil = new System.Windows.Forms.ListBox();
            this.groupBoxHasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHasil
            // 
            this.groupBoxHasil.Controls.Add(this.listBoxHasil);
            this.groupBoxHasil.Location = new System.Drawing.Point(14, 13);
            this.groupBoxHasil.Name = "groupBoxHasil";
            this.groupBoxHasil.Size = new System.Drawing.Size(548, 371);
            this.groupBoxHasil.TabIndex = 0;
            this.groupBoxHasil.TabStop = false;
            this.groupBoxHasil.Text = "[ Hasil ]";
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHitung.Location = new System.Drawing.Point(14, 390);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(548, 37);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // listBoxHasil
            // 
            this.listBoxHasil.FormattingEnabled = true;
            this.listBoxHasil.ItemHeight = 20;
            this.listBoxHasil.Location = new System.Drawing.Point(20, 26);
            this.listBoxHasil.Name = "listBoxHasil";
            this.listBoxHasil.Size = new System.Drawing.Size(510, 324);
            this.listBoxHasil.TabIndex = 0;
            // 
            // FormHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 439);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.groupBoxHasil);
            this.Name = "FormHasil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.groupBoxHasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.ListBox listBoxHasil;
    }
}

