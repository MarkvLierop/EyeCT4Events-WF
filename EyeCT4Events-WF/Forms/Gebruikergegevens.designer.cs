namespace EyeCT4Events_WF
{
    partial class Gebruikergegevens
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
            this.tbEdit = new System.Windows.Forms.Button();
            this.Naam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbnaam = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btDeleteAccount = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbTussenvoegsel = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(1, 149);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(75, 23);
            this.tbEdit.TabIndex = 1;
            this.tbEdit.Text = "Edit";
            this.tbEdit.UseVisualStyleBackColor = true;
            this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(25, 32);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(35, 13);
            this.Naam.TabIndex = 2;
            this.Naam.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wachtwoord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(82, 83);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(100, 20);
            this.tbWachtwoord.TabIndex = 10;
            this.tbWachtwoord.TextChanged += new System.EventHandler(this.tbWachtwoord_TextChanged);
            // 
            // tbnaam
            // 
            this.tbnaam.Location = new System.Drawing.Point(82, 29);
            this.tbnaam.Name = "tbnaam";
            this.tbnaam.Size = new System.Drawing.Size(100, 20);
            this.tbnaam.TabIndex = 11;
            this.tbnaam.TextChanged += new System.EventHandler(this.tbnaam_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(82, 57);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // btDeleteAccount
            // 
            this.btDeleteAccount.Location = new System.Drawing.Point(82, 149);
            this.btDeleteAccount.Name = "btDeleteAccount";
            this.btDeleteAccount.Size = new System.Drawing.Size(95, 23);
            this.btDeleteAccount.TabIndex = 13;
            this.btDeleteAccount.Text = "Delete account";
            this.btDeleteAccount.UseVisualStyleBackColor = true;
            this.btDeleteAccount.Click += new System.EventHandler(this.btDeleteAccount_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(508, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 14;
            // 
            // tbTussenvoegsel
            // 
            this.tbTussenvoegsel.Location = new System.Drawing.Point(188, 29);
            this.tbTussenvoegsel.Name = "tbTussenvoegsel";
            this.tbTussenvoegsel.Size = new System.Drawing.Size(44, 20);
            this.tbTussenvoegsel.TabIndex = 15;
            this.tbTussenvoegsel.TextChanged += new System.EventHandler(this.tbTussenvoegsel_TextChanged);
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(238, 29);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(100, 20);
            this.tbAchternaam.TabIndex = 16;
            this.tbAchternaam.TextChanged += new System.EventHandler(this.tbAchternaam_TextChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Gebruikergegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 421);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.tbTussenvoegsel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btDeleteAccount);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbnaam);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.tbEdit);
            this.Name = "Gebruikergegevens";
            this.Text = "Gebruikergegevens";
            this.Load += new System.EventHandler(this.Gebruikergegevens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tbEdit;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbnaam;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btDeleteAccount;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbTussenvoegsel;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}