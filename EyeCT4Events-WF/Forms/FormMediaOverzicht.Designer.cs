﻿namespace EyeCT4Events_WF
{
    partial class FormMediaOverzicht
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
            this.btnCategorieToevoegen = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tbZoeken = new System.Windows.Forms.TextBox();
            this.btnMediaUploaden = new System.Windows.Forms.Button();
            this.lblMediaOverzicht = new System.Windows.Forms.Label();
            this.pnlCategorieën.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategorieën
            // 
            this.pnlCategorieën.AutoScroll = true;
            this.pnlCategorieën.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCategorieën.Controls.Add(this.btnCategorieToevoegen);
            this.pnlCategorieën.Location = new System.Drawing.Point(12, 73);
            this.pnlCategorieën.Name = "pnlCategorieën";
            this.pnlCategorieën.Size = new System.Drawing.Size(197, 443);
            this.pnlCategorieën.TabIndex = 0;
            this.pnlCategorieën.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCategorieën_Paint);
            // 
            // btnCategorieToevoegen
            // 
            this.btnCategorieToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnCategorieToevoegen.Location = new System.Drawing.Point(150, 0);
            this.btnCategorieToevoegen.Name = "btnCategorieToevoegen";
            this.btnCategorieToevoegen.Size = new System.Drawing.Size(47, 41);
            this.btnCategorieToevoegen.TabIndex = 0;
            this.btnCategorieToevoegen.Text = "+";
            this.btnCategorieToevoegen.UseVisualStyleBackColor = true;
            this.btnCategorieToevoegen.Click += new System.EventHandler(this.btnCategorieToevoegen_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(232, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(732, 467);
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
            this.btnMediaUploaden.Click += new System.EventHandler(this.btnMediaUploaden_Click);
            // 
            // lblMediaOverzicht
            // 
            this.lblMediaOverzicht.AutoSize = true;
            this.lblMediaOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblMediaOverzicht.Location = new System.Drawing.Point(13, 12);
            this.lblMediaOverzicht.Name = "lblMediaOverzicht";
            this.lblMediaOverzicht.Size = new System.Drawing.Size(196, 29);
            this.lblMediaOverzicht.TabIndex = 4;
            this.lblMediaOverzicht.Text = "Media Overzicht";
            // 
            // FormMediaOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 528);
            this.Controls.Add(this.lblMediaOverzicht);
            this.Controls.Add(this.btnMediaUploaden);
            this.Controls.Add(this.tbZoeken);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlCategorieën);
            this.Name = "FormMediaOverzicht";
            this.Text = "Media Overzicht";
            this.pnlCategorieën.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategorieën;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TextBox tbZoeken;
        private System.Windows.Forms.Button btnMediaUploaden;
        private System.Windows.Forms.Label lblMediaOverzicht;
        private System.Windows.Forms.Button btnCategorieToevoegen;
    }
}

