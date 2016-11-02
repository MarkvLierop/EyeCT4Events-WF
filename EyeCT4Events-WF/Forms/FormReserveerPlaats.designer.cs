namespace EyeCT4Events_WF
{
    partial class FormReserveerPlaats
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
            this.PBCampeerplek = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbKampeerplaatsen = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLawaai = new System.Windows.Forms.RadioButton();
            this.rbComfort = new System.Windows.Forms.RadioButton();
            this.rbInvalide = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBungalow = new System.Windows.Forms.CheckBox();
            this.cbHuurTent = new System.Windows.Forms.CheckBox();
            this.cbStaCaravan = new System.Windows.Forms.CheckBox();
            this.cbBlokhut = new System.Windows.Forms.CheckBox();
            this.cbBungalino = new System.Windows.Forms.CheckBox();
            this.cbEigenTent = new System.Windows.Forms.CheckBox();
            this.lblMedewerker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBCampeerplek)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBCampeerplek
            // 
            this.PBCampeerplek.Location = new System.Drawing.Point(20, 60);
            this.PBCampeerplek.Name = "PBCampeerplek";
            this.PBCampeerplek.Size = new System.Drawing.Size(400, 310);
            this.PBCampeerplek.TabIndex = 8;
            this.PBCampeerplek.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Verder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Annuleer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbKampeerplaatsen
            // 
            this.lbKampeerplaatsen.FormattingEnabled = true;
            this.lbKampeerplaatsen.Location = new System.Drawing.Point(450, 127);
            this.lbKampeerplaatsen.Name = "lbKampeerplaatsen";
            this.lbKampeerplaatsen.Size = new System.Drawing.Size(200, 238);
            this.lbKampeerplaatsen.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLawaai);
            this.groupBox1.Controls.Add(this.rbComfort);
            this.groupBox1.Controls.Add(this.rbInvalide);
            this.groupBox1.Location = new System.Drawing.Point(450, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 36);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rbLawaai
            // 
            this.rbLawaai.AutoSize = true;
            this.rbLawaai.Location = new System.Drawing.Point(135, 13);
            this.rbLawaai.Name = "rbLawaai";
            this.rbLawaai.Size = new System.Drawing.Size(59, 17);
            this.rbLawaai.TabIndex = 18;
            this.rbLawaai.TabStop = true;
            this.rbLawaai.Text = "Lawaai";
            this.rbLawaai.UseVisualStyleBackColor = true;
            // 
            // rbComfort
            // 
            this.rbComfort.AutoSize = true;
            this.rbComfort.Location = new System.Drawing.Point(74, 13);
            this.rbComfort.Name = "rbComfort";
            this.rbComfort.Size = new System.Drawing.Size(61, 17);
            this.rbComfort.TabIndex = 1;
            this.rbComfort.TabStop = true;
            this.rbComfort.Text = "Comfort";
            this.rbComfort.UseVisualStyleBackColor = true;
            // 
            // rbInvalide
            // 
            this.rbInvalide.AutoSize = true;
            this.rbInvalide.Location = new System.Drawing.Point(6, 13);
            this.rbInvalide.Name = "rbInvalide";
            this.rbInvalide.Size = new System.Drawing.Size(62, 17);
            this.rbInvalide.TabIndex = 0;
            this.rbInvalide.TabStop = true;
            this.rbInvalide.Text = "Invalide";
            this.rbInvalide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbInvalide.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEigenTent);
            this.groupBox2.Controls.Add(this.cbBungalino);
            this.groupBox2.Controls.Add(this.cbBlokhut);
            this.groupBox2.Controls.Add(this.cbStaCaravan);
            this.groupBox2.Controls.Add(this.cbHuurTent);
            this.groupBox2.Controls.Add(this.cbBungalow);
            this.groupBox2.Location = new System.Drawing.Point(450, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 73);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verblijf";
            // 
            // cbBungalow
            // 
            this.cbBungalow.AutoSize = true;
            this.cbBungalow.Location = new System.Drawing.Point(6, 19);
            this.cbBungalow.Name = "cbBungalow";
            this.cbBungalow.Size = new System.Drawing.Size(73, 17);
            this.cbBungalow.TabIndex = 0;
            this.cbBungalow.Text = "Bungalow";
            this.cbBungalow.UseVisualStyleBackColor = true;
            // 
            // cbHuurTent
            // 
            this.cbHuurTent.AutoSize = true;
            this.cbHuurTent.Location = new System.Drawing.Point(92, 19);
            this.cbHuurTent.Name = "cbHuurTent";
            this.cbHuurTent.Size = new System.Drawing.Size(71, 17);
            this.cbHuurTent.TabIndex = 1;
            this.cbHuurTent.Text = "HuurTent";
            this.cbHuurTent.UseVisualStyleBackColor = true;
            // 
            // cbStaCaravan
            // 
            this.cbStaCaravan.AutoSize = true;
            this.cbStaCaravan.Location = new System.Drawing.Point(6, 35);
            this.cbStaCaravan.Name = "cbStaCaravan";
            this.cbStaCaravan.Size = new System.Drawing.Size(82, 17);
            this.cbStaCaravan.TabIndex = 2;
            this.cbStaCaravan.Text = "StaCaravan";
            this.cbStaCaravan.UseVisualStyleBackColor = true;
            // 
            // cbBlokhut
            // 
            this.cbBlokhut.AutoSize = true;
            this.cbBlokhut.Location = new System.Drawing.Point(6, 52);
            this.cbBlokhut.Name = "cbBlokhut";
            this.cbBlokhut.Size = new System.Drawing.Size(62, 17);
            this.cbBlokhut.TabIndex = 3;
            this.cbBlokhut.Text = "Blokhut";
            this.cbBlokhut.UseVisualStyleBackColor = true;
            // 
            // cbBungalino
            // 
            this.cbBungalino.AutoSize = true;
            this.cbBungalino.Location = new System.Drawing.Point(92, 35);
            this.cbBungalino.Name = "cbBungalino";
            this.cbBungalino.Size = new System.Drawing.Size(73, 17);
            this.cbBungalino.TabIndex = 4;
            this.cbBungalino.Text = "Bungalino";
            this.cbBungalino.UseVisualStyleBackColor = true;
            // 
            // cbEigenTent
            // 
            this.cbEigenTent.AutoSize = true;
            this.cbEigenTent.Location = new System.Drawing.Point(92, 52);
            this.cbEigenTent.Name = "cbEigenTent";
            this.cbEigenTent.Size = new System.Drawing.Size(78, 17);
            this.cbEigenTent.TabIndex = 5;
            this.cbEigenTent.Text = "Eigen Tent";
            this.cbEigenTent.UseVisualStyleBackColor = true;
            // 
            // lblMedewerker
            // 
            this.lblMedewerker.AutoSize = true;
            this.lblMedewerker.Location = new System.Drawing.Point(20, 12);
            this.lblMedewerker.Name = "lblMedewerker";
            this.lblMedewerker.Size = new System.Drawing.Size(90, 13);
            this.lblMedewerker.TabIndex = 18;
            this.lblMedewerker.Text = "label medewerker";
            // 
            // FormReserveerPlaats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 451);
            this.Controls.Add(this.lblMedewerker);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbKampeerplaatsen);
            this.Controls.Add(this.PBCampeerplek);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormReserveerPlaats";
            this.Text = "Reserveren";
            this.Load += new System.EventHandler(this.ReserveerPlaats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBCampeerplek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PBCampeerplek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbKampeerplaatsen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLawaai;
        private System.Windows.Forms.RadioButton rbComfort;
        private System.Windows.Forms.RadioButton rbInvalide;
        private System.Windows.Forms.CheckBox cbEigenTent;
        private System.Windows.Forms.CheckBox cbBungalino;
        private System.Windows.Forms.CheckBox cbBlokhut;
        private System.Windows.Forms.CheckBox cbStaCaravan;
        private System.Windows.Forms.CheckBox cbHuurTent;
        private System.Windows.Forms.CheckBox cbBungalow;
        private System.Windows.Forms.Label lblMedewerker;
    }
}