namespace EyeCT4Events_WF.Forms.SocialMediaSharing
{
    partial class FormEventOverzicht
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
            this.pnlEventOverzicht = new System.Windows.Forms.Panel();
            this.lsEvents = new System.Windows.Forms.ListBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblBeschrijving = new System.Windows.Forms.Label();
            this.lblDatumVan = new System.Windows.Forms.Label();
            this.lblDatumTot = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.pnlEventOverzicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEventOverzicht
            // 
            this.pnlEventOverzicht.Controls.Add(this.lblLocatie);
            this.pnlEventOverzicht.Controls.Add(this.lblDatumTot);
            this.pnlEventOverzicht.Controls.Add(this.lblDatumVan);
            this.pnlEventOverzicht.Controls.Add(this.lblBeschrijving);
            this.pnlEventOverzicht.Controls.Add(this.lblTitel);
            this.pnlEventOverzicht.Location = new System.Drawing.Point(0, 146);
            this.pnlEventOverzicht.Name = "pnlEventOverzicht";
            this.pnlEventOverzicht.Size = new System.Drawing.Size(271, 362);
            this.pnlEventOverzicht.TabIndex = 0;
            this.pnlEventOverzicht.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lsEvents
            // 
            this.lsEvents.FormattingEnabled = true;
            this.lsEvents.Location = new System.Drawing.Point(0, 2);
            this.lsEvents.Name = "lsEvents";
            this.lsEvents.Size = new System.Drawing.Size(271, 147);
            this.lsEvents.TabIndex = 1;
            this.lsEvents.SelectedIndexChanged += new System.EventHandler(this.lsEvents_SelectedIndexChanged);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTitel.Location = new System.Drawing.Point(13, 10);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(60, 24);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "label1";
            // 
            // lblBeschrijving
            // 
            this.lblBeschrijving.AutoSize = true;
            this.lblBeschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschrijving.Location = new System.Drawing.Point(13, 143);
            this.lblBeschrijving.Name = "lblBeschrijving";
            this.lblBeschrijving.Size = new System.Drawing.Size(46, 18);
            this.lblBeschrijving.TabIndex = 1;
            this.lblBeschrijving.Text = "label2";
            // 
            // lblDatumVan
            // 
            this.lblDatumVan.AutoSize = true;
            this.lblDatumVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumVan.Location = new System.Drawing.Point(13, 56);
            this.lblDatumVan.Name = "lblDatumVan";
            this.lblDatumVan.Size = new System.Drawing.Size(46, 18);
            this.lblDatumVan.TabIndex = 2;
            this.lblDatumVan.Text = "label1";
            // 
            // lblDatumTot
            // 
            this.lblDatumTot.AutoSize = true;
            this.lblDatumTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumTot.Location = new System.Drawing.Point(13, 80);
            this.lblDatumTot.Name = "lblDatumTot";
            this.lblDatumTot.Size = new System.Drawing.Size(46, 18);
            this.lblDatumTot.TabIndex = 3;
            this.lblDatumTot.Text = "label1";
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocatie.Location = new System.Drawing.Point(12, 107);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(46, 18);
            this.lblLocatie.TabIndex = 4;
            this.lblLocatie.Text = "label1";
            // 
            // FormEventOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 508);
            this.Controls.Add(this.lsEvents);
            this.Controls.Add(this.pnlEventOverzicht);
            this.Name = "FormEventOverzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEventOverzicht";
            this.pnlEventOverzicht.ResumeLayout(false);
            this.pnlEventOverzicht.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEventOverzicht;
        private System.Windows.Forms.ListBox lsEvents;
        private System.Windows.Forms.Label lblBeschrijving;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblDatumTot;
        private System.Windows.Forms.Label lblDatumVan;
    }
}