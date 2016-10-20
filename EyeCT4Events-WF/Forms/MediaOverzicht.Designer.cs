namespace EyeCT4Events_WF
{
    partial class MediaOverzicht
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
            this.pnlCategorieën = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tbZoeken = new System.Windows.Forms.TextBox();
            this.btnMediaUploaden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.pnlCategorieën.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategorieën
            // 
            this.pnlCategorieën.Controls.Add(this.btnPlus);
            this.pnlCategorieën.Location = new System.Drawing.Point(12, 49);
            this.pnlCategorieën.Name = "pnlCategorieën";
            this.pnlCategorieën.Size = new System.Drawing.Size(183, 467);
            this.pnlCategorieën.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(234, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(730, 467);
            this.pnlContent.TabIndex = 1;
            // 
            // tbZoeken
            // 
            this.tbZoeken.Location = new System.Drawing.Point(372, 15);
            this.tbZoeken.Name = "tbZoeken";
            this.tbZoeken.Size = new System.Drawing.Size(384, 20);
            this.tbZoeken.TabIndex = 2;
            // 
            // btnMediaUploaden
            // 
            this.btnMediaUploaden.Location = new System.Drawing.Point(852, 12);
            this.btnMediaUploaden.Name = "btnMediaUploaden";
            this.btnMediaUploaden.Size = new System.Drawing.Size(112, 23);
            this.btnMediaUploaden.TabIndex = 3;
            this.btnMediaUploaden.Text = "Media Uploaden";
            this.btnMediaUploaden.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Media Overzicht";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(141, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(39, 28);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // MediaOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMediaUploaden);
            this.Controls.Add(this.tbZoeken);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlCategorieën);
            this.Name = "MediaOverzicht";
            this.Text = "Media Overzicht";
            this.pnlCategorieën.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategorieën;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TextBox tbZoeken;
        private System.Windows.Forms.Button btnMediaUploaden;
        private System.Windows.Forms.Label label1;
    }
}

