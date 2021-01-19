namespace Dice.Sample.Bot
{
    partial class Login
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
            this.button_CreateAccount = new System.Windows.Forms.Button();
            this.button_Continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_totp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_currencies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_site = new System.Windows.Forms.ComboBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_CreateAccount
            // 
            this.button_CreateAccount.Enabled = false;
            this.button_CreateAccount.Location = new System.Drawing.Point(51, 112);
            this.button_CreateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.button_CreateAccount.Name = "button_CreateAccount";
            this.button_CreateAccount.Size = new System.Drawing.Size(178, 28);
            this.button_CreateAccount.TabIndex = 3;
            this.button_CreateAccount.Text = "Create New Account";
            this.button_CreateAccount.UseVisualStyleBackColor = true;
            this.button_CreateAccount.Click += new System.EventHandler(this.button_CreateAccount_Click);
            // 
            // button_Continue
            // 
            this.button_Continue.Enabled = false;
            this.button_Continue.Location = new System.Drawing.Point(51, 166);
            this.button_Continue.Margin = new System.Windows.Forms.Padding(4);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(178, 28);
            this.button_Continue.TabIndex = 4;
            this.button_Continue.Text = "Continue Last Session";
            this.button_Continue.UseVisualStyleBackColor = true;
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // button_Login
            // 
            this.button_Login.Enabled = false;
            this.button_Login.Location = new System.Drawing.Point(51, 359);
            this.button_Login.Margin = new System.Windows.Forms.Padding(4);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(178, 28);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_totp
            // 
            this.textBox_totp.Location = new System.Drawing.Point(110, 290);
            this.textBox_totp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_totp.MaxLength = 50;
            this.textBox_totp.Name = "textBox_totp";
            this.textBox_totp.Size = new System.Drawing.Size(132, 22);
            this.textBox_totp.TabIndex = 5;
            this.textBox_totp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Google Auth";
            // 
            // comboBox_currencies
            // 
            this.comboBox_currencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_currencies.FormattingEnabled = true;
            this.comboBox_currencies.Items.AddRange(new object[] {
            "Bitcoin",
            "Dogecoin",
            "Litecoin",
            "Ethereum"});
            this.comboBox_currencies.Location = new System.Drawing.Point(124, 14);
            this.comboBox_currencies.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_currencies.Name = "comboBox_currencies";
            this.comboBox_currencies.Size = new System.Drawing.Size(119, 24);
            this.comboBox_currencies.TabIndex = 7;
            this.comboBox_currencies.SelectedIndexChanged += new System.EventHandler(this.comboBox_currencies_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Site";
            // 
            // comboBox_site
            // 
            this.comboBox_site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_site.FormattingEnabled = true;
            this.comboBox_site.Items.AddRange(new object[] {
            "999dice",
            "999-dice (mirror)",
            "999doge (mirror)",
            "notdicelol (mirror)"});
            this.comboBox_site.Location = new System.Drawing.Point(124, 48);
            this.comboBox_site.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_site.Name = "comboBox_site";
            this.comboBox_site.Size = new System.Drawing.Size(119, 24);
            this.comboBox_site.TabIndex = 9;
            this.comboBox_site.SelectedIndexChanged += new System.EventHandler(this.comboBox_site_SelectedIndexChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(110, 258);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Password.MaxLength = 100;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(132, 22);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(110, 226);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Username.MaxLength = 50;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(132, 22);
            this.textBox_Username.TabIndex = 0;
            this.textBox_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_site);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_currencies);
            this.Controls.Add(this.textBox_totp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.button_CreateAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateAccount;
        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_totp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_currencies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_site;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
    }
}

