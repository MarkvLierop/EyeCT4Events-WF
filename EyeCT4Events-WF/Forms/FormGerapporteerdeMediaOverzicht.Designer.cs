namespace EyeCT4Events_WF.Forms
{
    partial class FormGerapporteerdeMediaOverzicht
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
            this.lsGerapporteerdeMediaOverzicht = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.btnBekijk = new System.Windows.Forms.Button();
            this.nudVerbergThreshhold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerbergThreshhold)).BeginInit();
            this.SuspendLayout();
            // 
            // lsGerapporteerdeMediaOverzicht
            // 
            this.lsGerapporteerdeMediaOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lsGerapporteerdeMediaOverzicht.FormattingEnabled = true;
            this.lsGerapporteerdeMediaOverzicht.ItemHeight = 22;
            this.lsGerapporteerdeMediaOverzicht.Location = new System.Drawing.Point(12, 56);
            this.lsGerapporteerdeMediaOverzicht.Name = "lsGerapporteerdeMediaOverzicht";
            this.lsGerapporteerdeMediaOverzicht.Size = new System.Drawing.Size(556, 268);
            this.lsGerapporteerdeMediaOverzicht.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerapporteerde Media";
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(18, 339);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(75, 23);
            this.btnSluiten.TabIndex = 2;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            // 
            // btnBekijk
            // 
            this.btnBekijk.Location = new System.Drawing.Point(493, 339);
            this.btnBekijk.Name = "btnBekijk";
            this.btnBekijk.Size = new System.Drawing.Size(75, 23);
            this.btnBekijk.TabIndex = 3;
            this.btnBekijk.Text = "Bekijken";
            this.btnBekijk.UseVisualStyleBackColor = true;
            this.btnBekijk.Click += new System.EventHandler(this.btnBekijk_Click);
            // 
            // nudVerbergThreshhold
            // 
            this.nudVerbergThreshhold.Location = new System.Drawing.Point(510, 22);
            this.nudVerbergThreshhold.Name = "nudVerbergThreshhold";
            this.nudVerbergThreshhold.Size = new System.Drawing.Size(58, 20);
            this.nudVerbergThreshhold.TabIndex = 4;
            this.nudVerbergThreshhold.ValueChanged += new System.EventHandler(this.nudVerbergThreshhold_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Media Verberg Threshhold:";
            // 
            // FormGerapporteerdeMediaOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudVerbergThreshhold);
            this.Controls.Add(this.btnBekijk);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsGerapporteerdeMediaOverzicht);
            this.Name = "FormGerapporteerdeMediaOverzicht";
            this.Text = "FormGerapporteerdeMediaOverzicht";
            this.DoubleClick += new System.EventHandler(this.FormGerapporteerdeMediaOverzicht_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.nudVerbergThreshhold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsGerapporteerdeMediaOverzicht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Button btnBekijk;
        private System.Windows.Forms.NumericUpDown nudVerbergThreshhold;
        private System.Windows.Forms.Label label2;
    }
}