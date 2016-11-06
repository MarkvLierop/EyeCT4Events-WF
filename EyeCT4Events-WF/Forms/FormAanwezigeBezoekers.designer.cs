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
            this.lstAanwezigeBezoekers = new System.Windows.Forms.ListView();
            this.txtBezoekerAanmelden = new System.Windows.Forms.TextBox();
            this.lblBezoekerAanmelden = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBezoekerAfmelden = new System.Windows.Forms.TextBox();
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
            // lstAanwezigeBezoekers
            // 
            this.lstAanwezigeBezoekers.Location = new System.Drawing.Point(17, 49);
            this.lstAanwezigeBezoekers.Name = "lstAanwezigeBezoekers";
            this.lstAanwezigeBezoekers.Size = new System.Drawing.Size(660, 306);
            this.lstAanwezigeBezoekers.TabIndex = 12;
            this.lstAanwezigeBezoekers.UseCompatibleStateImageBehavior = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bezoeker afmelden:";
            // 
            // txtBezoekerAfmelden
            // 
            this.txtBezoekerAfmelden.Location = new System.Drawing.Point(557, 379);
            this.txtBezoekerAfmelden.Name = "txtBezoekerAfmelden";
            this.txtBezoekerAfmelden.Size = new System.Drawing.Size(120, 20);
            this.txtBezoekerAfmelden.TabIndex = 15;
            this.txtBezoekerAfmelden.TextChanged += new System.EventHandler(this.txtBezoekerAfmelden_TextChanged);
            // 
            // AanwezigBezoekers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBezoekerAfmelden);
            this.Controls.Add(this.lblBezoekerAanmelden);
            this.Controls.Add(this.txtBezoekerAanmelden);
            this.Controls.Add(this.lstAanwezigeBezoekers);
            this.Controls.Add(this.lbSluiten);
            this.Controls.Add(this.lblAanwezigeBezoekers);
            this.Name = "AanwezigBezoekers";
            this.Text = "AanwezigBezoekers";
            this.Load += new System.EventHandler(this.AanwezigBezoekers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAanwezigeBezoekers;
        private System.Windows.Forms.Button lbSluiten;
        private System.Windows.Forms.ListView lstAanwezigeBezoekers;
        private System.Windows.Forms.TextBox txtBezoekerAanmelden;
        private System.Windows.Forms.Label lblBezoekerAanmelden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBezoekerAfmelden;
    }
}