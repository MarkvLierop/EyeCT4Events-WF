namespace EyeCT4Events_WF.Forms
{
    partial class FormMateriaalToevoegen
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblVoorraad = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.nudPrijs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudVoorraad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrijs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoorraad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(12, 272);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(75, 23);
            this.btnSluiten.TabIndex = 0;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(138, 272);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(93, 54);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(120, 20);
            this.txtNaam.TabIndex = 2;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(10, 57);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "Naam";
            // 
            // lblVoorraad
            // 
            this.lblVoorraad.AutoSize = true;
            this.lblVoorraad.Location = new System.Drawing.Point(10, 97);
            this.lblVoorraad.Name = "lblVoorraad";
            this.lblVoorraad.Size = new System.Drawing.Size(47, 13);
            this.lblVoorraad.TabIndex = 5;
            this.lblVoorraad.Text = "Vooraad";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(10, 143);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(26, 13);
            this.lblPrijs.TabIndex = 7;
            this.lblPrijs.Text = "Prijs";
            // 
            // nudPrijs
            // 
            this.nudPrijs.DecimalPlaces = 2;
            this.nudPrijs.Location = new System.Drawing.Point(93, 135);
            this.nudPrijs.Name = "nudPrijs";
            this.nudPrijs.Size = new System.Drawing.Size(120, 20);
            this.nudPrijs.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Materiaal Toevoegen";
            // 
            // nudVoorraad
            // 
            this.nudVoorraad.Location = new System.Drawing.Point(93, 97);
            this.nudVoorraad.Name = "nudVoorraad";
            this.nudVoorraad.Size = new System.Drawing.Size(120, 20);
            this.nudVoorraad.TabIndex = 10;
            // 
            // FormMateriaalToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 307);
            this.Controls.Add(this.nudVoorraad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPrijs);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblVoorraad);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnSluiten);
            this.Name = "FormMateriaalToevoegen";
            this.Text = "FormMateriaalToevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrijs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoorraad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblVoorraad;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.NumericUpDown nudPrijs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudVoorraad;
    }
}