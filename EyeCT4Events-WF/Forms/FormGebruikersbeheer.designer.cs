namespace EyeCT4Events_WF
{
    partial class Gebruikersbeheer
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSorteer = new System.Windows.Forms.ComboBox();
            this.btSluiten = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.lvGebruikerOverzicht = new System.Windows.Forms.ListView();
            this.txtZoeken = new System.Windows.Forms.TextBox();
            this.BtnZoeken = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.BtAddNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fill in first name";
            // 
            // cbSorteer
            // 
            this.cbSorteer.FormattingEnabled = true;
            this.cbSorteer.Location = new System.Drawing.Point(480, 15);
            this.cbSorteer.Name = "cbSorteer";
            this.cbSorteer.Size = new System.Drawing.Size(83, 21);
            this.cbSorteer.TabIndex = 4;
            this.cbSorteer.Text = "Sort by";
            this.cbSorteer.SelectedIndexChanged += new System.EventHandler(this.cbSorteer_SelectedIndexChanged);
            // 
            // btSluiten
            // 
            this.btSluiten.Location = new System.Drawing.Point(480, 245);
            this.btSluiten.Name = "btSluiten";
            this.btSluiten.Size = new System.Drawing.Size(80, 20);
            this.btSluiten.TabIndex = 5;
            this.btSluiten.Text = "Close";
            this.btSluiten.UseVisualStyleBackColor = true;
            this.btSluiten.Click += new System.EventHandler(this.btSluiten_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(480, 140);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(80, 20);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // lvGebruikerOverzicht
            // 
            this.lvGebruikerOverzicht.Location = new System.Drawing.Point(15, 50);
            this.lvGebruikerOverzicht.Name = "lvGebruikerOverzicht";
            this.lvGebruikerOverzicht.Size = new System.Drawing.Size(455, 215);
            this.lvGebruikerOverzicht.TabIndex = 7;
            this.lvGebruikerOverzicht.UseCompatibleStateImageBehavior = false;
            // 
            // txtZoeken
            // 
            this.txtZoeken.Location = new System.Drawing.Point(280, 15);
            this.txtZoeken.Name = "txtZoeken";
            this.txtZoeken.Size = new System.Drawing.Size(100, 20);
            this.txtZoeken.TabIndex = 8;
            this.txtZoeken.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnZoeken
            // 
            this.BtnZoeken.Location = new System.Drawing.Point(390, 15);
            this.BtnZoeken.Name = "BtnZoeken";
            this.BtnZoeken.Size = new System.Drawing.Size(80, 20);
            this.BtnZoeken.TabIndex = 9;
            this.BtnZoeken.Text = "Search";
            this.BtnZoeken.UseVisualStyleBackColor = true;
            this.BtnZoeken.Click += new System.EventHandler(this.BtnZoeken_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(480, 210);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(80, 20);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // BtAddNew
            // 
            this.BtAddNew.Location = new System.Drawing.Point(480, 175);
            this.BtAddNew.Name = "BtAddNew";
            this.BtAddNew.Size = new System.Drawing.Size(80, 20);
            this.BtAddNew.TabIndex = 10;
            this.BtAddNew.Text = "Add new";
            this.BtAddNew.UseVisualStyleBackColor = true;
            this.BtAddNew.Click += new System.EventHandler(this.BtAddNew_Click);
            // 
            // Gebruikersbeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.BtAddNew);
            this.Controls.Add(this.BtnZoeken);
            this.Controls.Add(this.txtZoeken);
            this.Controls.Add(this.lvGebruikerOverzicht);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSluiten);
            this.Controls.Add(this.cbSorteer);
            this.Controls.Add(this.label1);
            this.Name = "Gebruikersbeheer";
            this.Text = "Gebruikersbeheer";
            this.Load += new System.EventHandler(this.Gebruikersbeheer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSorteer;
        private System.Windows.Forms.Button btSluiten;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.ListView lvGebruikerOverzicht;
        private System.Windows.Forms.TextBox txtZoeken;
        private System.Windows.Forms.Button BtnZoeken;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button BtAddNew;
    }
}