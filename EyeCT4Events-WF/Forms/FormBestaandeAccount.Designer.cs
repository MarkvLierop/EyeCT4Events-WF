namespace EyeCT4Events_WF.Forms
{
    partial class FormBestaandeAccount
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
            this.btnNieuweAccAanmaken = new System.Windows.Forms.Button();
            this.lbBestaandeGebruikers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKampeerplaatsReserveren = new System.Windows.Forms.Button();
            this.tbZoekGebruikers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNieuweAccAanmaken
            // 
            this.btnNieuweAccAanmaken.Location = new System.Drawing.Point(321, 32);
            this.btnNieuweAccAanmaken.Name = "btnNieuweAccAanmaken";
            this.btnNieuweAccAanmaken.Size = new System.Drawing.Size(166, 23);
            this.btnNieuweAccAanmaken.TabIndex = 0;
            this.btnNieuweAccAanmaken.Text = "Nieuwe Account Aanmaken";
            this.btnNieuweAccAanmaken.UseVisualStyleBackColor = true;
            this.btnNieuweAccAanmaken.Click += new System.EventHandler(this.btnNieuweAccAanmaken_Click);
            // 
            // lbBestaandeGebruikers
            // 
            this.lbBestaandeGebruikers.FormattingEnabled = true;
            this.lbBestaandeGebruikers.Location = new System.Drawing.Point(13, 71);
            this.lbBestaandeGebruikers.Name = "lbBestaandeGebruikers";
            this.lbBestaandeGebruikers.Size = new System.Drawing.Size(195, 199);
            this.lbBestaandeGebruikers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoek op naam:";
            // 
            // btnKampeerplaatsReserveren
            // 
            this.btnKampeerplaatsReserveren.Location = new System.Drawing.Point(321, 247);
            this.btnKampeerplaatsReserveren.Name = "btnKampeerplaatsReserveren";
            this.btnKampeerplaatsReserveren.Size = new System.Drawing.Size(166, 23);
            this.btnKampeerplaatsReserveren.TabIndex = 3;
            this.btnKampeerplaatsReserveren.Text = "Kampeerplaats Reserveren";
            this.btnKampeerplaatsReserveren.UseVisualStyleBackColor = true;
            this.btnKampeerplaatsReserveren.Click += new System.EventHandler(this.btnKampeerplaatsReserveren_Click);
            // 
            // tbZoekGebruikers
            // 
            this.tbZoekGebruikers.Location = new System.Drawing.Point(99, 33);
            this.tbZoekGebruikers.Name = "tbZoekGebruikers";
            this.tbZoekGebruikers.Size = new System.Drawing.Size(109, 20);
            this.tbZoekGebruikers.TabIndex = 4;
            this.tbZoekGebruikers.TextChanged += new System.EventHandler(this.tbZoekGebruikers_TextChanged);
            // 
            // FormBestaandeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 296);
            this.Controls.Add(this.tbZoekGebruikers);
            this.Controls.Add(this.btnKampeerplaatsReserveren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBestaandeGebruikers);
            this.Controls.Add(this.btnNieuweAccAanmaken);
            this.Name = "FormBestaandeAccount";
            this.Text = "Bestaande Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNieuweAccAanmaken;
        private System.Windows.Forms.ListBox lbBestaandeGebruikers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKampeerplaatsReserveren;
        private System.Windows.Forms.TextBox tbZoekGebruikers;
    }
}