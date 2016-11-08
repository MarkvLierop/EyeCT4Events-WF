namespace EyeCT4Events_WF.Forms
{
    partial class FormCategorieZoeken
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbCategorieZoeken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCategorien = new System.Windows.Forms.ListBox();
            this.btnSelecteren = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Categorie zoeken:";
            // 
            // tbCategorieZoeken
            // 
            this.tbCategorieZoeken.Location = new System.Drawing.Point(159, 28);
            this.tbCategorieZoeken.Name = "tbCategorieZoeken";
            this.tbCategorieZoeken.Size = new System.Drawing.Size(142, 20);
            this.tbCategorieZoeken.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categorie Selecteren";
            // 
            // lbCategorien
            // 
            this.lbCategorien.FormattingEnabled = true;
            this.lbCategorien.Location = new System.Drawing.Point(23, 89);
            this.lbCategorien.Name = "lbCategorien";
            this.lbCategorien.Size = new System.Drawing.Size(278, 160);
            this.lbCategorien.TabIndex = 10;
            // 
            // btnSelecteren
            // 
            this.btnSelecteren.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelecteren.Location = new System.Drawing.Point(226, 271);
            this.btnSelecteren.Name = "btnSelecteren";
            this.btnSelecteren.Size = new System.Drawing.Size(75, 23);
            this.btnSelecteren.TabIndex = 9;
            this.btnSelecteren.Text = "Selecteren";
            this.btnSelecteren.UseVisualStyleBackColor = true;
            this.btnSelecteren.Click += new System.EventHandler(this.btnSelecteren_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSluiten.Location = new System.Drawing.Point(23, 271);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(75, 23);
            this.btnSluiten.TabIndex = 14;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            // 
            // FormCategorieZoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 322);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCategorieZoeken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCategorien);
            this.Controls.Add(this.btnSelecteren);
            this.Name = "FormCategorieZoeken";
            this.Text = "FormCategorieZoeken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCategorieZoeken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCategorien;
        private System.Windows.Forms.Button btnSelecteren;
        private System.Windows.Forms.Button btnSluiten;
    }
}