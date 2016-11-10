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
            this.btnMaakEventAan = new System.Windows.Forms.Button();
            this.btnAanwezigeBezoekers = new System.Windows.Forms.Button();
            this.btnPlaatsReserveren = new System.Windows.Forms.Button();
            this.btnMateriaalReserveren = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lblMedewerker = new System.Windows.Forms.Label();
            this.btnloguit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaakEventAan
            // 
            this.btnMaakEventAan.Location = new System.Drawing.Point(27, 32);
            this.btnMaakEventAan.Name = "btnMaakEventAan";
            this.btnMaakEventAan.Size = new System.Drawing.Size(141, 83);
            this.btnMaakEventAan.TabIndex = 3;
            this.btnMaakEventAan.Text = "Event Aanmaken";
            this.btnMaakEventAan.UseVisualStyleBackColor = true;
            this.btnMaakEventAan.Click += new System.EventHandler(this.btnMaakEventAan_Click);
            // 
            // btnAanwezigeBezoekers
            // 
            this.btnAanwezigeBezoekers.Location = new System.Drawing.Point(27, 203);
            this.btnAanwezigeBezoekers.Name = "btnAanwezigeBezoekers";
            this.btnAanwezigeBezoekers.Size = new System.Drawing.Size(141, 83);
            this.btnAanwezigeBezoekers.TabIndex = 4;
            this.btnAanwezigeBezoekers.Text = "Aanwezige Bezoekers";
            this.btnAanwezigeBezoekers.UseVisualStyleBackColor = true;
            this.btnAanwezigeBezoekers.Click += new System.EventHandler(this.btnAanwezigeBezoekers_Click);
            // 
            // btnPlaatsReserveren
            // 
            this.btnPlaatsReserveren.Location = new System.Drawing.Point(351, 203);
            this.btnPlaatsReserveren.Name = "btnPlaatsReserveren";
            this.btnPlaatsReserveren.Size = new System.Drawing.Size(141, 83);
            this.btnPlaatsReserveren.TabIndex = 5;
            this.btnPlaatsReserveren.Text = "Reserveer Plaats";
            this.btnPlaatsReserveren.UseVisualStyleBackColor = true;
            this.btnPlaatsReserveren.Click += new System.EventHandler(this.btnPlaatsReserveren_Click);
            // 
            // btnMateriaalReserveren
            // 
            this.btnMateriaalReserveren.Location = new System.Drawing.Point(351, 32);
            this.btnMateriaalReserveren.Name = "btnMateriaalReserveren";
            this.btnMateriaalReserveren.Size = new System.Drawing.Size(141, 83);
            this.btnMateriaalReserveren.TabIndex = 6;
            this.btnMateriaalReserveren.Text = "Reserveer Materiaal";
            this.btnMateriaalReserveren.UseVisualStyleBackColor = true;
            this.btnMateriaalReserveren.Click += new System.EventHandler(this.btnMateriaalReserveren_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(190, 119);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(141, 83);
            this.btnMedia.TabIndex = 7;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lblMedewerker
            // 
            this.lblMedewerker.AutoSize = true;
            this.lblMedewerker.Location = new System.Drawing.Point(24, 13);
            this.lblMedewerker.Name = "lblMedewerker";
            this.lblMedewerker.Size = new System.Drawing.Size(35, 13);
            this.lblMedewerker.TabIndex = 8;
            this.lblMedewerker.Text = "label1";
            // 
            // btnloguit
            // 
            this.btnloguit.Location = new System.Drawing.Point(432, 1);
            this.btnloguit.Name = "btnloguit";
            this.btnloguit.Size = new System.Drawing.Size(60, 25);
            this.btnloguit.TabIndex = 9;
            this.btnloguit.Text = "Uitloggen";
            this.btnloguit.UseVisualStyleBackColor = true;
            this.btnloguit.Click += new System.EventHandler(this.btnloguit_Click);
            // 
            // FormMedewerkerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 298);
            this.Controls.Add(this.btnloguit);
            this.Controls.Add(this.lblMedewerker);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnMateriaalReserveren);
            this.Controls.Add(this.btnPlaatsReserveren);
            this.Controls.Add(this.btnAanwezigeBezoekers);
            this.Controls.Add(this.btnMaakEventAan);
            this.Name = "FormMedewerkerMainMenu";
            this.Text = "FormMedewerkerMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaakEventAan;
        private System.Windows.Forms.Button btnAanwezigeBezoekers;
        private System.Windows.Forms.Button btnPlaatsReserveren;
        private System.Windows.Forms.Button btnMateriaalReserveren;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label lblMedewerker;
        private System.Windows.Forms.Button btnloguit;
    }
}