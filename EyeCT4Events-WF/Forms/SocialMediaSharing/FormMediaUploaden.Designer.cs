namespace EyeCT4Events_WF.Forms
{
    partial class FormMediaUploaden
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
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.tbBestandZoeken = new System.Windows.Forms.Button();
            this.lblBestandsNaam = new System.Windows.Forms.Label();
            this.tbBeschrijving = new System.Windows.Forms.RichTextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnCategorieZoeken = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(108, 26);
            this.tbTitel.Multiline = true;
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(318, 25);
            this.tbTitel.TabIndex = 0;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(13, 26);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(27, 13);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Titel";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(13, 133);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "Categorie";
            // 
            // tbBestandZoeken
            // 
            this.tbBestandZoeken.Location = new System.Drawing.Point(12, 76);
            this.tbBestandZoeken.Name = "tbBestandZoeken";
            this.tbBestandZoeken.Size = new System.Drawing.Size(75, 23);
            this.tbBestandZoeken.TabIndex = 4;
            this.tbBestandZoeken.Text = "Bestand";
            this.tbBestandZoeken.UseVisualStyleBackColor = true;
            this.tbBestandZoeken.Click += new System.EventHandler(this.tbBestandZoeken_Click);
            // 
            // lblBestandsNaam
            // 
            this.lblBestandsNaam.AutoSize = true;
            this.lblBestandsNaam.Location = new System.Drawing.Point(105, 81);
            this.lblBestandsNaam.Name = "lblBestandsNaam";
            this.lblBestandsNaam.Size = new System.Drawing.Size(79, 13);
            this.lblBestandsNaam.TabIndex = 5;
            this.lblBestandsNaam.Text = "BestandsNaam";
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(108, 176);
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(443, 123);
            this.tbBeschrijving.TabIndex = 7;
            this.tbBeschrijving.Text = "";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(471, 319);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(80, 23);
            this.btnOpslaan.TabIndex = 8;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnCategorieZoeken
            // 
            this.btnCategorieZoeken.Location = new System.Drawing.Point(423, 128);
            this.btnCategorieZoeken.Name = "btnCategorieZoeken";
            this.btnCategorieZoeken.Size = new System.Drawing.Size(128, 23);
            this.btnCategorieZoeken.TabIndex = 9;
            this.btnCategorieZoeken.Text = "Categorie Zoeken";
            this.btnCategorieZoeken.UseVisualStyleBackColor = true;
            this.btnCategorieZoeken.Click += new System.EventHandler(this.btnCategorieZoeken_Click);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(105, 135);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(0, 13);
            this.lblCategorie.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Beschrijving";
            // 
            // FormMediaUploaden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.btnCategorieZoeken);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.tbBeschrijving);
            this.Controls.Add(this.lblBestandsNaam);
            this.Controls.Add(this.tbBestandZoeken);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.tbTitel);
            this.Name = "FormMediaUploaden";
            this.Text = "MediaUploaden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button tbBestandZoeken;
        private System.Windows.Forms.Label lblBestandsNaam;
        private System.Windows.Forms.RichTextBox tbBeschrijving;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnCategorieZoeken;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label label1;
    }
}