namespace EyeCT4Events_WF
{
    partial class FormReserveerMateriaal
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
            this.btnGeenMateriaal = new System.Windows.Forms.Button();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.lblHuurder = new System.Windows.Forms.Label();
            this.lblMedewerker = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGeenMateriaal
            // 
            this.btnGeenMateriaal.Location = new System.Drawing.Point(12, 400);
            this.btnGeenMateriaal.Name = "btnGeenMateriaal";
            this.btnGeenMateriaal.Size = new System.Drawing.Size(139, 30);
            this.btnGeenMateriaal.TabIndex = 6;
            this.btnGeenMateriaal.Text = "Geen Materiaal Nodig";
            this.btnGeenMateriaal.UseVisualStyleBackColor = true;
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(570, 400);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(80, 30);
            this.btnBevestig.TabIndex = 7;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHuurder
            // 
            this.lblHuurder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHuurder.Location = new System.Drawing.Point(12, 13);
            this.lblHuurder.Name = "lblHuurder";
            this.lblHuurder.Size = new System.Drawing.Size(54, 20);
            this.lblHuurder.TabIndex = 9;
            this.lblHuurder.Text = "Huurder:";
            this.lblHuurder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMedewerker
            // 
            this.lblMedewerker.AutoSize = true;
            this.lblMedewerker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMedewerker.Location = new System.Drawing.Point(524, 13);
            this.lblMedewerker.Name = "lblMedewerker";
            this.lblMedewerker.Size = new System.Drawing.Size(78, 15);
            this.lblMedewerker.TabIndex = 13;
            this.lblMedewerker.Text = "lblMedewerker";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 212);
            this.listBox1.TabIndex = 14;
            // 
            // FormReserveerMateriaal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 451);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblMedewerker);
            this.Controls.Add(this.lblHuurder);
            this.Controls.Add(this.btnGeenMateriaal);
            this.Controls.Add(this.btnBevestig);
            this.Name = "FormReserveerMateriaal";
            this.Text = "ReserveerMateriaal";
            this.Load += new System.EventHandler(this.ReserveerMateriaal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeenMateriaal;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Label lblHuurder;
        private System.Windows.Forms.Label lblMedewerker;
        private System.Windows.Forms.ListBox listBox1;
    }
}