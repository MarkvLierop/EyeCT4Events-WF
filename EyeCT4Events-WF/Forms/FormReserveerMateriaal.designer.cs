namespace EyeCT4Events_WF
{
    partial class FormReserveerMateriaal
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
            this.btnGeenMateriaal = new System.Windows.Forms.Button();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.labelHuurder = new System.Windows.Forms.Label();
            this.lblMedewerker = new System.Windows.Forms.Label();
            this.lbBeschikbareMaterialen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAantal = new System.Windows.Forms.NumericUpDown();
            this.btnReserveer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGekozenMaterialen = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblHuurder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeenMateriaal
            // 
            this.btnGeenMateriaal.Location = new System.Drawing.Point(12, 400);
            this.btnGeenMateriaal.Name = "btnGeenMateriaal";
            this.btnGeenMateriaal.Size = new System.Drawing.Size(139, 30);
            this.btnGeenMateriaal.TabIndex = 6;
            this.btnGeenMateriaal.Text = "Geen Materiaal Nodig";
            this.btnGeenMateriaal.UseVisualStyleBackColor = true;
            this.btnGeenMateriaal.Click += new System.EventHandler(this.btnGeenMateriaal_Click);
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(570, 400);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(80, 30);
            this.btnBevestig.TabIndex = 7;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHuurder
            // 
            this.labelHuurder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHuurder.Location = new System.Drawing.Point(57, 12);
            this.labelHuurder.Name = "labelHuurder";
            this.labelHuurder.Size = new System.Drawing.Size(51, 20);
            this.labelHuurder.TabIndex = 9;
            this.labelHuurder.Text = "Huurder:";
            this.labelHuurder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMedewerker
            // 
            this.lblMedewerker.AutoSize = true;
            this.lblMedewerker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMedewerker.Location = new System.Drawing.Point(495, 18);
            this.lblMedewerker.Name = "lblMedewerker";
            this.lblMedewerker.Size = new System.Drawing.Size(78, 15);
            this.lblMedewerker.TabIndex = 13;
            this.lblMedewerker.Text = "lblMedewerker";
            // 
            // lbBeschikbareMaterialen
            // 
            this.lbBeschikbareMaterialen.FormattingEnabled = true;
            this.lbBeschikbareMaterialen.Location = new System.Drawing.Point(12, 92);
            this.lbBeschikbareMaterialen.Name = "lbBeschikbareMaterialen";
            this.lbBeschikbareMaterialen.Size = new System.Drawing.Size(247, 264);
            this.lbBeschikbareMaterialen.TabIndex = 14;
            this.lbBeschikbareMaterialen.SelectedIndexChanged += new System.EventHandler(this.lbBeschikbareMaterialen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Beschikbare Materialen";
            // 
            // nudAantal
            // 
            this.nudAantal.Location = new System.Drawing.Point(421, 89);
            this.nudAantal.Name = "nudAantal";
            this.nudAantal.Size = new System.Drawing.Size(68, 20);
            this.nudAantal.TabIndex = 16;
            // 
            // btnReserveer
            // 
            this.btnReserveer.Location = new System.Drawing.Point(268, 141);
            this.btnReserveer.Name = "btnReserveer";
            this.btnReserveer.Size = new System.Drawing.Size(221, 23);
            this.btnReserveer.TabIndex = 17;
            this.btnReserveer.Text = "Voeg toe";
            this.btnReserveer.UseVisualStyleBackColor = true;
            this.btnReserveer.Click += new System.EventHandler(this.btnReserveer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Aantal:";
            // 
            // lbGekozenMaterialen
            // 
            this.lbGekozenMaterialen.FormattingEnabled = true;
            this.lbGekozenMaterialen.Location = new System.Drawing.Point(495, 92);
            this.lbGekozenMaterialen.Name = "lbGekozenMaterialen";
            this.lbGekozenMaterialen.Size = new System.Drawing.Size(155, 264);
            this.lbGekozenMaterialen.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Datum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblHuurder
            // 
            this.lblHuurder.AutoSize = true;
            this.lblHuurder.Location = new System.Drawing.Point(13, 16);
            this.lblHuurder.Name = "lblHuurder";
            this.lblHuurder.Size = new System.Drawing.Size(38, 13);
            this.lblHuurder.TabIndex = 22;
            this.lblHuurder.Text = "Naam:";
            // 
            // FormReserveerMateriaal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 451);
            this.Controls.Add(this.lblHuurder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbGekozenMaterialen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReserveer);
            this.Controls.Add(this.nudAantal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBeschikbareMaterialen);
            this.Controls.Add(this.lblMedewerker);
            this.Controls.Add(this.labelHuurder);
            this.Controls.Add(this.btnGeenMateriaal);
            this.Controls.Add(this.btnBevestig);
            this.Name = "FormReserveerMateriaal";
            this.Text = "ReserveerMateriaal";
            this.Load += new System.EventHandler(this.ReserveerMateriaal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAantal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeenMateriaal;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Label labelHuurder;
        private System.Windows.Forms.Label lblMedewerker;
        private System.Windows.Forms.ListBox lbBeschikbareMaterialen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAantal;
        private System.Windows.Forms.Button btnReserveer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbGekozenMaterialen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblHuurder;
    }
}