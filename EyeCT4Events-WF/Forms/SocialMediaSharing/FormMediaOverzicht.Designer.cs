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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategorieZoeken = new System.Windows.Forms.TextBox();
            this.lblCategorieZoeken = new System.Windows.Forms.Label();
            this.pnlCategorieën.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategorieën
            // 
            this.pnlCategorieën.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCategorieën.AutoScroll = true;
            this.pnlCategorieën.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCategorieën.Controls.Add(this.btnCategorieToevoegen);
            this.pnlCategorieën.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlCategorieën.Location = new System.Drawing.Point(12, 104);
            this.pnlCategorieën.Name = "pnlCategorieën";
            this.pnlCategorieën.Size = new System.Drawing.Size(197, 485);
            this.pnlCategorieën.TabIndex = 0;
            this.pnlCategorieën.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCategorieën_Paint);
            this.pnlCategorieën.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCategorieën_MouseDown);
            // 
            // btnCategorieToevoegen
            // 
            this.btnCategorieToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnCategorieToevoegen.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Location = new System.Drawing.Point(232, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(732, 540);
            this.pnlContent.TabIndex = 1;
            // 
            // tbZoeken
            // 
            this.tbZoeken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZoeken.Location = new System.Drawing.Point(449, 15);
            this.tbZoeken.Name = "tbZoeken";
            this.tbZoeken.Size = new System.Drawing.Size(384, 20);
            this.tbZoeken.TabIndex = 2;
            this.tbZoeken.TextChanged += new System.EventHandler(this.tbZoeken_TextChanged);
            // 
            // btnMediaUploaden
            // 
            this.btnMediaUploaden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblMediaOverzicht.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMediaOverzicht.Location = new System.Drawing.Point(13, 12);
            this.lblMediaOverzicht.Name = "lblMediaOverzicht";
            this.lblMediaOverzicht.Size = new System.Drawing.Size(196, 29);
            this.lblMediaOverzicht.TabIndex = 4;
            this.lblMediaOverzicht.Text = "Media Overzicht";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zoeken op type media of gebruiker";
            // 
            // txtCategorieZoeken
            // 
            this.txtCategorieZoeken.Location = new System.Drawing.Point(12, 78);
            this.txtCategorieZoeken.Name = "txtCategorieZoeken";
            this.txtCategorieZoeken.Size = new System.Drawing.Size(197, 20);
            this.txtCategorieZoeken.TabIndex = 6;
            this.txtCategorieZoeken.TextChanged += new System.EventHandler(this.txtCategorieZoeken_TextChanged);
            // 
            // lblCategorieZoeken
            // 
            this.lblCategorieZoeken.AutoSize = true;
            this.lblCategorieZoeken.Location = new System.Drawing.Point(12, 62);
            this.lblCategorieZoeken.Name = "lblCategorieZoeken";
            this.lblCategorieZoeken.Size = new System.Drawing.Size(92, 13);
            this.lblCategorieZoeken.TabIndex = 7;
            this.lblCategorieZoeken.Text = "Categorie Zoeken";
            // 
            // FormMediaOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 601);
            this.Controls.Add(this.lblCategorieZoeken);
            this.Controls.Add(this.txtCategorieZoeken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMediaOverzicht);
            this.Controls.Add(this.btnMediaUploaden);
            this.Controls.Add(this.tbZoeken);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlCategorieën);
            this.Name = "FormMediaOverzicht";
            this.Text = "Media Overzicht";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMediaOverzicht_FormClosing);
            this.Load += new System.EventHandler(this.FormMediaOverzicht_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategorieZoeken;
        private System.Windows.Forms.Label lblCategorieZoeken;
    }
}

