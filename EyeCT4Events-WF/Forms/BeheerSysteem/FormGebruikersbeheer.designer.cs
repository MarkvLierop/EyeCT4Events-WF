namespace EyeCT4Events_WF
{
    partial class Gebruikersbeheer
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
            this.lbGebruikersnaam = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sdsd = new System.Windows.Forms.TextBox();
            this.tbZoeken = new System.Windows.Forms.Button();
            this.cbSorteer = new System.Windows.Forms.ComboBox();
            this.btSluiten = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGebruikersnaam
            // 
            this.lbGebruikersnaam.FormattingEnabled = true;
            this.lbGebruikersnaam.Location = new System.Drawing.Point(12, 25);
            this.lbGebruikersnaam.Name = "lbGebruikersnaam";
            this.lbGebruikersnaam.Size = new System.Drawing.Size(120, 199);
            this.lbGebruikersnaam.TabIndex = 0;
            this.lbGebruikersnaam.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbGebruikersnaam_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gebruikersnaam";
            // 
            // sdsd
            // 
            this.sdsd.Location = new System.Drawing.Point(138, 54);
            this.sdsd.Name = "sdsd";
            this.sdsd.Size = new System.Drawing.Size(100, 20);
            this.sdsd.TabIndex = 2;
            // 
            // tbZoeken
            // 
            this.tbZoeken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbZoeken.Location = new System.Drawing.Point(244, 54);
            this.tbZoeken.Name = "tbZoeken";
            this.tbZoeken.Size = new System.Drawing.Size(75, 23);
            this.tbZoeken.TabIndex = 3;
            this.tbZoeken.Text = "Zoeken";
            this.tbZoeken.UseVisualStyleBackColor = true;
            this.tbZoeken.Click += new System.EventHandler(this.tbZoeken_Click);
            // 
            // cbSorteer
            // 
            this.cbSorteer.FormattingEnabled = true;
            this.cbSorteer.Location = new System.Drawing.Point(138, 27);
            this.cbSorteer.Name = "cbSorteer";
            this.cbSorteer.Size = new System.Drawing.Size(121, 21);
            this.cbSorteer.TabIndex = 4;
            this.cbSorteer.Text = "Sorteer op";
            this.cbSorteer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btSluiten
            // 
            this.btSluiten.Location = new System.Drawing.Point(496, 12);
            this.btSluiten.Name = "btSluiten";
            this.btSluiten.Size = new System.Drawing.Size(75, 23);
            this.btSluiten.TabIndex = 5;
            this.btSluiten.Text = "Sluiten";
            this.btSluiten.UseVisualStyleBackColor = true;
            this.btSluiten.Click += new System.EventHandler(this.btSluiten_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(496, 54);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // Gebruikersbeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 327);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSluiten);
            this.Controls.Add(this.cbSorteer);
            this.Controls.Add(this.tbZoeken);
            this.Controls.Add(this.sdsd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGebruikersnaam);
            this.Name = "Gebruikersbeheer";
            this.Text = "Gebruikersbeheer";
            this.Load += new System.EventHandler(this.Gebruikersbeheer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGebruikersnaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sdsd;
        private System.Windows.Forms.Button tbZoeken;
        private System.Windows.Forms.ComboBox cbSorteer;
        private System.Windows.Forms.Button btSluiten;
        private System.Windows.Forms.Button btEdit;
    }
}