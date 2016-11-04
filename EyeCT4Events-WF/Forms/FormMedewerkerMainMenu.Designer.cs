namespace EyeCT4Events_WF.Forms
{
    partial class FormMedewerkerMainMenu
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
            this.btnReserveer = new System.Windows.Forms.Button();
            this.btnEventAanmaken = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnBezoekers = new System.Windows.Forms.Button();
            this.btnMateriaal = new System.Windows.Forms.Button();
            this.lblMedewerkerNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReserveer
            // 
            this.btnReserveer.Location = new System.Drawing.Point(247, 180);
            this.btnReserveer.Name = "btnReserveer";
            this.btnReserveer.Size = new System.Drawing.Size(163, 88);
            this.btnReserveer.TabIndex = 1;
            this.btnReserveer.Text = "Reserveer Plaats";
            this.btnReserveer.UseCompatibleTextRendering = true;
            this.btnReserveer.UseVisualStyleBackColor = true;
            this.btnReserveer.Click += new System.EventHandler(this.btnReserveer_Click);
            // 
            // btnEventAanmaken
            // 
            this.btnEventAanmaken.Location = new System.Drawing.Point(13, 180);
            this.btnEventAanmaken.Name = "btnEventAanmaken";
            this.btnEventAanmaken.Size = new System.Drawing.Size(176, 88);
            this.btnEventAanmaken.TabIndex = 2;
            this.btnEventAanmaken.Text = "Evenement Aanmaken";
            this.btnEventAanmaken.UseVisualStyleBackColor = true;
            this.btnEventAanmaken.Click += new System.EventHandler(this.btnEventAanmaken_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(163, 123);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(107, 51);
            this.btnMedia.TabIndex = 3;
            this.btnMedia.Text = "Social Media Sharing";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnBezoekers
            // 
            this.btnBezoekers.Location = new System.Drawing.Point(13, 30);
            this.btnBezoekers.Name = "btnBezoekers";
            this.btnBezoekers.Size = new System.Drawing.Size(176, 87);
            this.btnBezoekers.TabIndex = 4;
            this.btnBezoekers.Text = "Aanwezige Bezoekers";
            this.btnBezoekers.UseVisualStyleBackColor = true;
            this.btnBezoekers.Click += new System.EventHandler(this.btnBezoekers_Click);
            // 
            // btnMateriaal
            // 
            this.btnMateriaal.Location = new System.Drawing.Point(247, 25);
            this.btnMateriaal.Name = "btnMateriaal";
            this.btnMateriaal.Size = new System.Drawing.Size(163, 88);
            this.btnMateriaal.TabIndex = 5;
            this.btnMateriaal.Text = "Materiaal";
            this.btnMateriaal.UseCompatibleTextRendering = true;
            this.btnMateriaal.UseVisualStyleBackColor = true;
            this.btnMateriaal.Click += new System.EventHandler(this.btnMateriaal_Click);
            // 
            // lblMedewerkerNaam
            // 
            this.lblMedewerkerNaam.AutoSize = true;
            this.lblMedewerkerNaam.Location = new System.Drawing.Point(333, 6);
            this.lblMedewerkerNaam.Name = "lblMedewerkerNaam";
            this.lblMedewerkerNaam.Size = new System.Drawing.Size(94, 13);
            this.lblMedewerkerNaam.TabIndex = 6;
            this.lblMedewerkerNaam.Text = "medewerker naam";
            // 
            // FormMedewerkerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 280);
            this.Controls.Add(this.lblMedewerkerNaam);
            this.Controls.Add(this.btnMateriaal);
            this.Controls.Add(this.btnBezoekers);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnEventAanmaken);
            this.Controls.Add(this.btnReserveer);
            this.Name = "FormMedewerkerMainMenu";
            this.Text = "Hub Medewerker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReserveer;
        private System.Windows.Forms.Button btnEventAanmaken;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnBezoekers;
        private System.Windows.Forms.Button btnMateriaal;
        private System.Windows.Forms.Label lblMedewerkerNaam;
    }
}