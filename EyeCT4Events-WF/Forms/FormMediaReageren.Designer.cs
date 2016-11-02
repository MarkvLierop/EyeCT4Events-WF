namespace EyeCT4Events_WF.Forms
{
    partial class FormMediaReageren
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
            this.txtReactieInhoud = new System.Windows.Forms.RichTextBox();
            this.btnReactiePlaatsen = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReactieInhoud
            // 
            this.txtReactieInhoud.Location = new System.Drawing.Point(12, 12);
            this.txtReactieInhoud.Name = "txtReactieInhoud";
            this.txtReactieInhoud.Size = new System.Drawing.Size(282, 101);
            this.txtReactieInhoud.TabIndex = 0;
            this.txtReactieInhoud.Text = "";
            // 
            // btnReactiePlaatsen
            // 
            this.btnReactiePlaatsen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReactiePlaatsen.Location = new System.Drawing.Point(219, 130);
            this.btnReactiePlaatsen.Name = "btnReactiePlaatsen";
            this.btnReactiePlaatsen.Size = new System.Drawing.Size(75, 23);
            this.btnReactiePlaatsen.TabIndex = 1;
            this.btnReactiePlaatsen.Text = "Reageren";
            this.btnReactiePlaatsen.UseVisualStyleBackColor = true;
            this.btnReactiePlaatsen.Click += new System.EventHandler(this.btnReactiePlaatsen_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSluiten.Location = new System.Drawing.Point(12, 130);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(75, 23);
            this.btnSluiten.TabIndex = 2;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            // 
            // FormMediaReageren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 165);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnReactiePlaatsen);
            this.Controls.Add(this.txtReactieInhoud);
            this.Name = "FormMediaReageren";
            this.Text = "FormMediaReageren";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtReactieInhoud;
        private System.Windows.Forms.Button btnReactiePlaatsen;
        private System.Windows.Forms.Button btnSluiten;
    }
}