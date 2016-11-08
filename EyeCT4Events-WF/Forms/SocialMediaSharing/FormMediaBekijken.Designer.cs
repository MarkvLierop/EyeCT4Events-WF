namespace EyeCT4Events_WF.Forms
{
    partial class FormMediaBekijken
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
            this.btnSluiten = new System.Windows.Forms.Button();
            this.btnVerwijderMedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsReacties = new System.Windows.Forms.ListBox();
            this.lblBestand = new System.Windows.Forms.Label();
            this.lblBeschrijving = new System.Windows.Forms.Label();
            this.btnVerwijderReactie = new System.Windows.Forms.Button();
            this.btnAantalKerenGerapporteerd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(18, 343);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(75, 23);
            this.btnSluiten.TabIndex = 0;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnVerwijderMedia
            // 
            this.btnVerwijderMedia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerwijderMedia.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerwijderMedia.Location = new System.Drawing.Point(354, 342);
            this.btnVerwijderMedia.Name = "btnVerwijderMedia";
            this.btnVerwijderMedia.Size = new System.Drawing.Size(119, 23);
            this.btnVerwijderMedia.TabIndex = 1;
            this.btnVerwijderMedia.Text = "Verwijder Media";
            this.btnVerwijderMedia.UseVisualStyleBackColor = true;
            this.btnVerwijderMedia.Click += new System.EventHandler(this.btnVerwijderMedia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geplaatst Door:";
            // 
            // lsReacties
            // 
            this.lsReacties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsReacties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lsReacties.FormattingEnabled = true;
            this.lsReacties.ItemHeight = 20;
            this.lsReacties.Location = new System.Drawing.Point(15, 194);
            this.lsReacties.Name = "lsReacties";
            this.lsReacties.Size = new System.Drawing.Size(458, 124);
            this.lsReacties.TabIndex = 4;
            // 
            // lblBestand
            // 
            this.lblBestand.AutoSize = true;
            this.lblBestand.Location = new System.Drawing.Point(12, 56);
            this.lblBestand.Name = "lblBestand";
            this.lblBestand.Size = new System.Drawing.Size(46, 13);
            this.lblBestand.TabIndex = 7;
            this.lblBestand.Text = "Bestand";
            this.lblBestand.Click += new System.EventHandler(this.lblBestand_Click);
            // 
            // lblBeschrijving
            // 
            this.lblBeschrijving.AutoSize = true;
            this.lblBeschrijving.Location = new System.Drawing.Point(12, 115);
            this.lblBeschrijving.Name = "lblBeschrijving";
            this.lblBeschrijving.Size = new System.Drawing.Size(64, 13);
            this.lblBeschrijving.TabIndex = 8;
            this.lblBeschrijving.Text = "Beschrijving";
            // 
            // btnVerwijderReactie
            // 
            this.btnVerwijderReactie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerwijderReactie.Location = new System.Drawing.Point(354, 165);
            this.btnVerwijderReactie.Name = "btnVerwijderReactie";
            this.btnVerwijderReactie.Size = new System.Drawing.Size(119, 23);
            this.btnVerwijderReactie.TabIndex = 9;
            this.btnVerwijderReactie.Text = "Verwijder Reactie";
            this.btnVerwijderReactie.UseVisualStyleBackColor = true;
            this.btnVerwijderReactie.Click += new System.EventHandler(this.btnVerwijderReactie_Click);
            // 
            // btnAantalKerenGerapporteerd
            // 
            this.btnAantalKerenGerapporteerd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAantalKerenGerapporteerd.Location = new System.Drawing.Point(407, 10);
            this.btnAantalKerenGerapporteerd.Name = "btnAantalKerenGerapporteerd";
            this.btnAantalKerenGerapporteerd.Size = new System.Drawing.Size(75, 23);
            this.btnAantalKerenGerapporteerd.TabIndex = 10;
            this.btnAantalKerenGerapporteerd.Text = "Zet op 0";
            this.btnAantalKerenGerapporteerd.UseVisualStyleBackColor = true;
            this.btnAantalKerenGerapporteerd.Click += new System.EventHandler(this.btnAantalKerenGerapporteerd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zet aantal keren gerapporteerd op 0";
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Location = new System.Drawing.Point(99, 15);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(33, 13);
            this.lblGebruiker.TabIndex = 12;
            this.lblGebruiker.Text = "naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Beschrijving";
            // 
            // FormMediaBekijken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAantalKerenGerapporteerd);
            this.Controls.Add(this.btnVerwijderReactie);
            this.Controls.Add(this.lblBeschrijving);
            this.Controls.Add(this.lblBestand);
            this.Controls.Add(this.lsReacties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerwijderMedia);
            this.Controls.Add(this.btnSluiten);
            this.Name = "FormMediaBekijken";
            this.Text = "FormMediaBekijken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Button btnVerwijderMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsReacties;
        private System.Windows.Forms.Label lblBestand;
        private System.Windows.Forms.Label lblBeschrijving;
        private System.Windows.Forms.Button btnVerwijderReactie;
        private System.Windows.Forms.Button btnAantalKerenGerapporteerd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.Label label2;
    }
}