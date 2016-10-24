namespace EyeCT4Events_WF.Forms
{
    partial class CategorieToevoegen
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
            this.cbHoofdCategorie = new System.Windows.Forms.ComboBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZoeken = new System.Windows.Forms.Label();
            this.tbHoofdCategorie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(150, 53);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(142, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(217, 186);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // cbHoofdCategorie
            // 
            this.cbHoofdCategorie.FormattingEnabled = true;
            this.cbHoofdCategorie.Location = new System.Drawing.Point(150, 93);
            this.cbHoofdCategorie.Name = "cbHoofdCategorie";
            this.cbHoofdCategorie.Size = new System.Drawing.Size(142, 21);
            this.cbHoofdCategorie.TabIndex = 2;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(11, 53);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categorie Toevoegen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hoofd categorie:";
            // 
            // lblZoeken
            // 
            this.lblZoeken.AutoSize = true;
            this.lblZoeken.Location = new System.Drawing.Point(11, 138);
            this.lblZoeken.Name = "lblZoeken";
            this.lblZoeken.Size = new System.Drawing.Size(133, 13);
            this.lblZoeken.TabIndex = 6;
            this.lblZoeken.Text = "Of voer hoofd categorie in:";
            // 
            // tbHoofdCategorie
            // 
            this.tbHoofdCategorie.Location = new System.Drawing.Point(150, 135);
            this.tbHoofdCategorie.Name = "tbHoofdCategorie";
            this.tbHoofdCategorie.Size = new System.Drawing.Size(142, 20);
            this.tbHoofdCategorie.TabIndex = 7;
            // 
            // CategorieToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 221);
            this.Controls.Add(this.tbHoofdCategorie);
            this.Controls.Add(this.lblZoeken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.cbHoofdCategorie);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.tbNaam);
            this.Name = "CategorieToevoegen";
            this.Text = "CategorieToevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ComboBox cbHoofdCategorie;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZoeken;
        private System.Windows.Forms.TextBox tbHoofdCategorie;
    }
}