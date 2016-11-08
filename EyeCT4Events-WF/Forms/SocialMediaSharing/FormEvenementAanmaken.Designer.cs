namespace EyeCT4Events_WF.Forms
{
    partial class FormEvenementAanmaken
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
            this.btnAanmaken = new System.Windows.Forms.Button();
            this.dtpDatumTot = new System.Windows.Forms.DateTimePicker();
            this.txtEventNaam = new System.Windows.Forms.TextBox();
            this.txtBeschrijving = new System.Windows.Forms.RichTextBox();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumVan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(12, 347);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(75, 23);
            this.btnSluiten.TabIndex = 0;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.Location = new System.Drawing.Point(410, 347);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(75, 23);
            this.btnAanmaken.TabIndex = 1;
            this.btnAanmaken.Text = "Aanmaken";
            this.btnAanmaken.UseVisualStyleBackColor = true;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // dtpDatumTot
            // 
            this.dtpDatumTot.Location = new System.Drawing.Point(283, 81);
            this.dtpDatumTot.Name = "dtpDatumTot";
            this.dtpDatumTot.Size = new System.Drawing.Size(134, 20);
            this.dtpDatumTot.TabIndex = 3;
            // 
            // txtEventNaam
            // 
            this.txtEventNaam.Location = new System.Drawing.Point(121, 27);
            this.txtEventNaam.Name = "txtEventNaam";
            this.txtEventNaam.Size = new System.Drawing.Size(100, 20);
            this.txtEventNaam.TabIndex = 4;
            // 
            // txtBeschrijving
            // 
            this.txtBeschrijving.Location = new System.Drawing.Point(40, 149);
            this.txtBeschrijving.Name = "txtBeschrijving";
            this.txtBeschrijving.Size = new System.Drawing.Size(409, 158);
            this.txtBeschrijving.TabIndex = 5;
            this.txtBeschrijving.Text = "";
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(349, 27);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(100, 20);
            this.txtLocatie.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Locatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Event Naam:";
            // 
            // dtpDatumVan
            // 
            this.dtpDatumVan.Location = new System.Drawing.Point(40, 81);
            this.dtpDatumVan.Name = "dtpDatumVan";
            this.dtpDatumVan.Size = new System.Drawing.Size(134, 20);
            this.dtpDatumVan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum/Tijd van";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum/Tijd tot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Event Beschrijving:";
            // 
            // FormEvenementAanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.txtBeschrijving);
            this.Controls.Add(this.txtEventNaam);
            this.Controls.Add(this.dtpDatumTot);
            this.Controls.Add(this.dtpDatumVan);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.btnSluiten);
            this.Name = "FormEvenementAanmaken";
            this.Text = "Event Aanmaken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Button btnAanmaken;
        private System.Windows.Forms.DateTimePicker dtpDatumTot;
        private System.Windows.Forms.TextBox txtEventNaam;
        private System.Windows.Forms.RichTextBox txtBeschrijving;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumVan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}