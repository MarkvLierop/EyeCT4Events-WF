namespace EyeCT4Events_WF
{
    partial class AanwezigBezoekers
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
            this.listView1 = new System.Windows.Forms.ListView();
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(17, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(660, 306);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AanwezigBezoekers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 414);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
    }
}