namespace EyeCT4Events_WF.Forms
{
    partial class MediaUploaden
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
            this.lblCategorie = new System.Windows.Forms.Label();
            this.tbCategorie = new System.Windows.Forms.TextBox();
            this.tbBestandZoeken = new System.Windows.Forms.Button();
            this.lblBestandsNaam = new System.Windows.Forms.Label();
            this.btnCategorieToevoegen = new System.Windows.Forms.Button();
            this.tbBeschrijving = new System.Windows.Forms.RichTextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
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
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(13, 133);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 2;
            this.lblCategorie.Text = "Categorie";
            // 
            // tbCategorie
            // 
            this.tbCategorie.Location = new System.Drawing.Point(108, 133);
            this.tbCategorie.Multiline = true;
            this.tbCategorie.Name = "tbCategorie";
            this.tbCategorie.Size = new System.Drawing.Size(318, 25);
            this.tbCategorie.TabIndex = 3;
            // 
            // tbBestandZoeken
            // 
            this.tbBestandZoeken.Location = new System.Drawing.Point(12, 76);
            this.tbBestandZoeken.Name = "tbBestandZoeken";
            this.tbBestandZoeken.Size = new System.Drawing.Size(75, 23);
            this.tbBestandZoeken.TabIndex = 4;
            this.tbBestandZoeken.Text = "Bestand";
            this.tbBestandZoeken.UseVisualStyleBackColor = true;
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
            // btnCategorieToevoegen
            // 
            this.btnCategorieToevoegen.Location = new System.Drawing.Point(450, 135);
            this.btnCategorieToevoegen.Name = "btnCategorieToevoegen";
            this.btnCategorieToevoegen.Size = new System.Drawing.Size(128, 23);
            this.btnCategorieToevoegen.TabIndex = 6;
            this.btnCategorieToevoegen.Text = "Categorie Toevoegen";
            this.btnCategorieToevoegen.UseVisualStyleBackColor = true;
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(108, 176);
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(470, 123);
            this.tbBeschrijving.TabIndex = 7;
            this.tbBeschrijving.Text = "";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(498, 319);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(80, 23);
            this.btnOpslaan.TabIndex = 8;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            // 
            // MediaUploaden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 354);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.tbBeschrijving);
            this.Controls.Add(this.btnCategorieToevoegen);
            this.Controls.Add(this.lblBestandsNaam);
            this.Controls.Add(this.tbBestandZoeken);
            this.Controls.Add(this.tbCategorie);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.tbTitel);
            this.Name = "MediaUploaden";
            this.Text = "MediaUploaden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.TextBox tbCategorie;
        private System.Windows.Forms.Button tbBestandZoeken;
        private System.Windows.Forms.Label lblBestandsNaam;
        private System.Windows.Forms.Button btnCategorieToevoegen;
        private System.Windows.Forms.RichTextBox tbBeschrijving;
        private System.Windows.Forms.Button btnOpslaan;
    }
}