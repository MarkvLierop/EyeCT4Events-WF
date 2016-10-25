namespace EyeCT4Events_WF
{
    partial class AanwezigBezoekers
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
            this.lblAanwezigeBezoekers = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.ListBox();
            this.lbTelefoonnummer = new System.Windows.Forms.ListBox();
            this.lbLocatie = new System.Windows.Forms.ListBox();
            this.lbBezoeker = new System.Windows.Forms.ListBox();
            this.lbSluiten = new System.Windows.Forms.Button();
            this.btHuren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAanwezigeBezoekers
            // 
            this.lblAanwezigeBezoekers.AutoSize = true;
            this.lblAanwezigeBezoekers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAanwezigeBezoekers.Location = new System.Drawing.Point(76, 41);
            this.lblAanwezigeBezoekers.Name = "lblAanwezigeBezoekers";
            this.lblAanwezigeBezoekers.Size = new System.Drawing.Size(225, 26);
            this.lblAanwezigeBezoekers.TabIndex = 9;
            this.lblAanwezigeBezoekers.Text = "Aanwezige bezoekers";
            this.lblAanwezigeBezoekers.UseMnemonic = false;
            // 
            // lbEmail
            // 
            this.lbEmail.FormattingEnabled = true;
            this.lbEmail.Location = new System.Drawing.Point(427, 81);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(120, 225);
            this.lbEmail.TabIndex = 8;
            // 
            // lbTelefoonnummer
            // 
            this.lbTelefoonnummer.FormattingEnabled = true;
            this.lbTelefoonnummer.Location = new System.Drawing.Point(314, 81);
            this.lbTelefoonnummer.Name = "lbTelefoonnummer";
            this.lbTelefoonnummer.Size = new System.Drawing.Size(120, 225);
            this.lbTelefoonnummer.TabIndex = 7;
            // 
            // lbLocatie
            // 
            this.lbLocatie.FormattingEnabled = true;
            this.lbLocatie.Location = new System.Drawing.Point(198, 81);
            this.lbLocatie.Name = "lbLocatie";
            this.lbLocatie.Size = new System.Drawing.Size(120, 225);
            this.lbLocatie.TabIndex = 6;
            // 
            // lbBezoeker
            // 
            this.lbBezoeker.FormattingEnabled = true;
            this.lbBezoeker.Location = new System.Drawing.Point(81, 81);
            this.lbBezoeker.Name = "lbBezoeker";
            this.lbBezoeker.Size = new System.Drawing.Size(120, 225);
            this.lbBezoeker.TabIndex = 5;
            // 
            // lbSluiten
            // 
            this.lbSluiten.Location = new System.Drawing.Point(686, 2);
            this.lbSluiten.Name = "lbSluiten";
            this.lbSluiten.Size = new System.Drawing.Size(57, 23);
            this.lbSluiten.TabIndex = 10;
            this.lbSluiten.Text = "Sluiten";
            this.lbSluiten.UseVisualStyleBackColor = true;
            this.lbSluiten.Click += new System.EventHandler(this.lbSluiten_Click);
            // 
            // btHuren
            // 
            this.btHuren.Location = new System.Drawing.Point(81, 312);
            this.btHuren.Name = "btHuren";
            this.btHuren.Size = new System.Drawing.Size(75, 23);
            this.btHuren.TabIndex = 11;
            this.btHuren.Text = "Huren";
            this.btHuren.UseVisualStyleBackColor = true;
            // 
            // AanwezigBezoekers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 500);
            this.Controls.Add(this.btHuren);
            this.Controls.Add(this.lbSluiten);
            this.Controls.Add(this.lblAanwezigeBezoekers);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefoonnummer);
            this.Controls.Add(this.lbLocatie);
            this.Controls.Add(this.lbBezoeker);
            this.Name = "AanwezigBezoekers";
            this.Text = "AanwezigBezoekers";
            this.Load += new System.EventHandler(this.AanwezigBezoekers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAanwezigeBezoekers;
        private System.Windows.Forms.ListBox lbEmail;
        private System.Windows.Forms.ListBox lbTelefoonnummer;
        private System.Windows.Forms.ListBox lbLocatie;
        private System.Windows.Forms.ListBox lbBezoeker;
        private System.Windows.Forms.Button lbSluiten;
        private System.Windows.Forms.Button btHuren;
    }
}