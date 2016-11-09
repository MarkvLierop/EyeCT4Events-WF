namespace EyeCT4Events_WF.Forms
{
    partial class FormBeheerderMainMenu
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
            this.btnSocialmediaSharing = new System.Windows.Forms.Button();
            this.btnAanwezigeBezoekers = new System.Windows.Forms.Button();
            this.btnGebruikersBeheren = new System.Windows.Forms.Button();
            this.btnGerapporteerdeMedia = new System.Windows.Forms.Button();
            this.btnEvenementAanmaken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSocialmediaSharing
            // 
            this.btnSocialmediaSharing.Location = new System.Drawing.Point(12, 22);
            this.btnSocialmediaSharing.Name = "btnSocialmediaSharing";
            this.btnSocialmediaSharing.Size = new System.Drawing.Size(163, 88);
            this.btnSocialmediaSharing.TabIndex = 6;
            this.btnSocialmediaSharing.Text = "Social Media Sharing";
            this.btnSocialmediaSharing.UseCompatibleTextRendering = true;
            this.btnSocialmediaSharing.UseVisualStyleBackColor = true;
            this.btnSocialmediaSharing.Click += new System.EventHandler(this.btnSocialmediaSharing_Click);
            // 
            // btnAanwezigeBezoekers
            // 
            this.btnAanwezigeBezoekers.Location = new System.Drawing.Point(251, 22);
            this.btnAanwezigeBezoekers.Name = "btnAanwezigeBezoekers";
            this.btnAanwezigeBezoekers.Size = new System.Drawing.Size(163, 88);
            this.btnAanwezigeBezoekers.TabIndex = 7;
            this.btnAanwezigeBezoekers.Text = "Aanwezige Bezoekers";
            this.btnAanwezigeBezoekers.UseCompatibleTextRendering = true;
            this.btnAanwezigeBezoekers.UseVisualStyleBackColor = true;
            this.btnAanwezigeBezoekers.Click += new System.EventHandler(this.btnAanwezigeBezoekers_Click);
            // 
            // btnGebruikersBeheren
            // 
            this.btnGebruikersBeheren.Location = new System.Drawing.Point(251, 157);
            this.btnGebruikersBeheren.Name = "btnGebruikersBeheren";
            this.btnGebruikersBeheren.Size = new System.Drawing.Size(163, 88);
            this.btnGebruikersBeheren.TabIndex = 8;
            this.btnGebruikersBeheren.Text = "Gebruikers Beheren";
            this.btnGebruikersBeheren.UseCompatibleTextRendering = true;
            this.btnGebruikersBeheren.UseVisualStyleBackColor = true;
            this.btnGebruikersBeheren.Click += new System.EventHandler(this.btnGebruikersBeheren_Click);
            // 
            // btnGerapporteerdeMedia
            // 
            this.btnGerapporteerdeMedia.Location = new System.Drawing.Point(12, 157);
            this.btnGerapporteerdeMedia.Name = "btnGerapporteerdeMedia";
            this.btnGerapporteerdeMedia.Size = new System.Drawing.Size(163, 88);
            this.btnGerapporteerdeMedia.TabIndex = 9;
            this.btnGerapporteerdeMedia.Text = "Gerapporteerde Media";
            this.btnGerapporteerdeMedia.UseCompatibleTextRendering = true;
            this.btnGerapporteerdeMedia.UseVisualStyleBackColor = true;
            this.btnGerapporteerdeMedia.Click += new System.EventHandler(this.btnGerapporteerdeMedia_Click);
            // 
            // btnEvenementAanmaken
            // 
            this.btnEvenementAanmaken.Location = new System.Drawing.Point(133, 268);
            this.btnEvenementAanmaken.Name = "btnEvenementAanmaken";
            this.btnEvenementAanmaken.Size = new System.Drawing.Size(163, 88);
            this.btnEvenementAanmaken.TabIndex = 10;
            this.btnEvenementAanmaken.Text = "Evenement Aanmaken";
            this.btnEvenementAanmaken.UseCompatibleTextRendering = true;
            this.btnEvenementAanmaken.UseVisualStyleBackColor = true;
            this.btnEvenementAanmaken.Click += new System.EventHandler(this.btnEvenementAanmaken_Click);
            // 
            // FormBeheerderMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 390);
            this.Controls.Add(this.btnEvenementAanmaken);
            this.Controls.Add(this.btnGerapporteerdeMedia);
            this.Controls.Add(this.btnGebruikersBeheren);
            this.Controls.Add(this.btnAanwezigeBezoekers);
            this.Controls.Add(this.btnSocialmediaSharing);
            this.Name = "FormBeheerderMainMenu";
            this.Text = "FormBeheerderMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSocialmediaSharing;
        private System.Windows.Forms.Button btnAanwezigeBezoekers;
        private System.Windows.Forms.Button btnGebruikersBeheren;
        private System.Windows.Forms.Button btnGerapporteerdeMedia;
        private System.Windows.Forms.Button btnEvenementAanmaken;
    }
}