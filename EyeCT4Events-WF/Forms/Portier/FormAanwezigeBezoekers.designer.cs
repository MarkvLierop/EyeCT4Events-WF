namespace EyeCT4Events_WF
{
    partial class FormAanwezigeBezoekers
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
            this.lbSluiten = new System.Windows.Forms.Button();
            this.lvAanwezigeBezoekers = new System.Windows.Forms.ListView();
            this.txtBezoekerAanmelden = new System.Windows.Forms.TextBox();
            this.lblBezoekerAanmelden = new System.Windows.Forms.Label();
            this.lblAfmelden = new System.Windows.Forms.Label();
            this.txtBezoekerAfmelden = new System.Windows.Forms.TextBox();
            this.btnBetalingsgegevens = new System.Windows.Forms.Button();
            this.lblBetalingsgegevens = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAanwezigeBezoekers
            // 
            this.lblAanwezigeBezoekers.AutoSize = true;
            this.lblAanwezigeBezoekers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAanwezigeBezoekers.Location = new System.Drawing.Point(12, 9);
            this.lblAanwezigeBezoekers.Name = "lblAanwezigeBezoekers";
            this.lblAanwezigeBezoekers.Size = new System.Drawing.Size(225, 26);
            this.lblAanwezigeBezoekers.TabIndex = 9;
            this.lblAanwezigeBezoekers.Text = "Aanwezige bezoekers";
            this.lblAanwezigeBezoekers.UseMnemonic = false;
            // 
            // lbSluiten
            // 
            this.lbSluiten.Location = new System.Drawing.Point(17, 372);
            this.lbSluiten.Name = "lbSluiten";
            this.lbSluiten.Size = new System.Drawing.Size(86, 27);
            this.lbSluiten.TabIndex = 10;
            this.lbSluiten.Text = "Sluiten";
            this.lbSluiten.UseVisualStyleBackColor = true;
            this.lbSluiten.Click += new System.EventHandler(this.lbSluiten_Click);
            // 
            // lvAanwezigeBezoekers
            // 
            this.lvAanwezigeBezoekers.Location = new System.Drawing.Point(17, 49);
            this.lvAanwezigeBezoekers.Name = "lvAanwezigeBezoekers";
            this.lvAanwezigeBezoekers.Size = new System.Drawing.Size(660, 306);
            this.lvAanwezigeBezoekers.TabIndex = 12;
            this.lvAanwezigeBezoekers.UseCompatibleStateImageBehavior = false;
            // 
            // txtBezoekerAanmelden
            // 
            this.txtBezoekerAanmelden.Location = new System.Drawing.Point(298, 379);
            this.txtBezoekerAanmelden.Name = "txtBezoekerAanmelden";
            this.txtBezoekerAanmelden.Size = new System.Drawing.Size(120, 20);
            this.txtBezoekerAanmelden.TabIndex = 13;
            this.txtBezoekerAanmelden.TextChanged += new System.EventHandler(this.txtBezoekerAanmelden_TextChanged);
            // 
            // lblBezoekerAanmelden
            // 
            this.lblBezoekerAanmelden.AutoSize = true;
            this.lblBezoekerAanmelden.Location = new System.Drawing.Point(179, 382);
            this.lblBezoekerAanmelden.Name = "lblBezoekerAanmelden";
            this.lblBezoekerAanmelden.Size = new System.Drawing.Size(113, 13);
            this.lblBezoekerAanmelden.TabIndex = 14;
            this.lblBezoekerAanmelden.Text = "Bezoeker aanmelden: ";
            // 
            // lblAfmelden
            // 
            this.lblAfmelden.AutoSize = true;
            this.lblAfmelden.Location = new System.Drawing.Point(438, 382);
            this.lblAfmelden.Name = "lblAfmelden";
            this.lblAfmelden.Size = new System.Drawing.Size(101, 13);
            this.lblAfmelden.TabIndex = 16;
            this.lblAfmelden.Text = "Bezoeker afmelden:";
            // 
            // txtBezoekerAfmelden
            // 
            this.txtBezoekerAfmelden.Location = new System.Drawing.Point(557, 379);
            this.txtBezoekerAfmelden.Name = "txtBezoekerAfmelden";
            this.txtBezoekerAfmelden.Size = new System.Drawing.Size(120, 20);
            this.txtBezoekerAfmelden.TabIndex = 15;
            this.txtBezoekerAfmelden.TextChanged += new System.EventHandler(this.txtBezoekerAfmelden_TextChanged);
            // 
            // btnBetalingsgegevens
            // 
            this.btnBetalingsgegevens.Location = new System.Drawing.Point(593, 18);
            this.btnBetalingsgegevens.Name = "btnBetalingsgegevens";
            this.btnBetalingsgegevens.Size = new System.Drawing.Size(74, 27);
            this.btnBetalingsgegevens.TabIndex = 17;
            this.btnBetalingsgegevens.Text = "Opvragen";
            this.btnBetalingsgegevens.UseVisualStyleBackColor = true;
            this.btnBetalingsgegevens.Click += new System.EventHandler(this.btnBetalingsgegevens_Click);
            // 
            // lblBetalingsgegevens
            // 
            this.lblBetalingsgegevens.AutoSize = true;
            this.lblBetalingsgegevens.Location = new System.Drawing.Point(437, 18);
            this.lblBetalingsgegevens.Name = "lblBetalingsgegevens";
            this.lblBetalingsgegevens.Size = new System.Drawing.Size(150, 13);
            this.lblBetalingsgegevens.TabIndex = 18;
            this.lblBetalingsgegevens.Text = "Betalingsgegevens Opvragen:";
            // 
            // FormAanwezigeBezoekers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 414);
            this.Controls.Add(this.lblBetalingsgegevens);
            this.Controls.Add(this.btnBetalingsgegevens);
            this.Controls.Add(this.lblAfmelden);
            this.Controls.Add(this.txtBezoekerAfmelden);
            this.Controls.Add(this.lblBezoekerAanmelden);
            this.Controls.Add(this.txtBezoekerAanmelden);
            this.Controls.Add(this.lvAanwezigeBezoekers);
            this.Controls.Add(this.lbSluiten);
            this.Controls.Add(this.lblAanwezigeBezoekers);
            this.Name = "FormAanwezigeBezoekers";
            this.Text = "AanwezigBezoekers";
            this.Load += new System.EventHandler(this.AanwezigBezoekers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAanwezigeBezoekers;
        private System.Windows.Forms.Button lbSluiten;
        private System.Windows.Forms.ListView lvAanwezigeBezoekers;
        private System.Windows.Forms.TextBox txtBezoekerAanmelden;
        private System.Windows.Forms.Label lblBezoekerAanmelden;
        private System.Windows.Forms.Label lblAfmelden;
        private System.Windows.Forms.TextBox txtBezoekerAfmelden;
        private System.Windows.Forms.Button btnBetalingsgegevens;
        private System.Windows.Forms.Label lblBetalingsgegevens;
    }
}