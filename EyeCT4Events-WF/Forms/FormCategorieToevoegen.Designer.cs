namespace EyeCT4Events_WF.Forms
{
    partial class FormCategorieToevoegen
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCategorien = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCategorieZoeken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(150, 36);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(142, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(217, 313);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(11, 39);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categorie Toevoegen";
            // 
            // lbCategorien
            // 
            this.lbCategorien.FormattingEnabled = true;
            this.lbCategorien.Location = new System.Drawing.Point(14, 131);
            this.lbCategorien.Name = "lbCategorien";
            this.lbCategorien.Size = new System.Drawing.Size(278, 160);
            this.lbCategorien.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hoofd categorie selecteren";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categorie zoeken:";
            // 
            // tbCategorieZoeken
            // 
            this.tbCategorieZoeken.Location = new System.Drawing.Point(150, 70);
            this.tbCategorieZoeken.Name = "tbCategorieZoeken";
            this.tbCategorieZoeken.Size = new System.Drawing.Size(142, 20);
            this.tbCategorieZoeken.TabIndex = 7;
            this.tbCategorieZoeken.TextChanged += new System.EventHandler(this.tbCategorieZoeken_TextChanged);
            // 
            // FormCategorieToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCategorieZoeken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCategorien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.tbNaam);
            this.Name = "FormCategorieToevoegen";
            this.Text = "CategorieToevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbCategorien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCategorieZoeken;
    }
}