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
            this.SuspendLayout();
            // 
            // pnlEventOverzicht
            // 
            this.pnlEventOverzicht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEventOverzicht.Location = new System.Drawing.Point(0, 0);
            this.pnlEventOverzicht.Name = "pnlEventOverzicht";
            this.pnlEventOverzicht.Size = new System.Drawing.Size(271, 508);
            this.pnlEventOverzicht.TabIndex = 0;
            this.pnlEventOverzicht.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormEventOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 508);
            this.Controls.Add(this.pnlEventOverzicht);
            this.Name = "FormEventOverzicht";
            this.Text = "FormEventOverzicht";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEventOverzicht;
    }
}