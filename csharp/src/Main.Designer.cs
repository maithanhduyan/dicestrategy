namespace Dice.Sample.Bot
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.label_Balance = new System.Windows.Forms.Label();
            this.button_SetupLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_BetCount = new System.Windows.Forms.Label();
            this.label_BetProfits = new System.Windows.Forms.Label();
            this.label_BetWins = new System.Windows.Forms.Label();
            this.label_BetWinsPercent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_SavedEmail = new System.Windows.Forms.Label();
            this.label_SavedEmergencyAddress = new System.Windows.Forms.Label();
            this.label_AccountId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Emergency = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Withdraw = new System.Windows.Forms.Button();
            this.textBox_DepositAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel_GuessOptions = new System.Windows.Forms.Panel();
            this.label_PayoutMultiplier = new System.Windows.Forms.Label();
            this.label_ChanceToWin = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown_GuessHigh = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_GuessLow = new System.Windows.Forms.NumericUpDown();
            this.button_ExportToCSV = new System.Windows.Forms.Button();
            this.panel_BetOptions = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_BetCount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_StopMaxBalance = new System.Windows.Forms.TextBox();
            this.textBox_IncreaseOnLoss = new System.Windows.Forms.TextBox();
            this.label_cur3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label_cur1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_MaxBet = new System.Windows.Forms.TextBox();
            this.textBox_IncreaseOnWin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label_afterMaxBet = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox_ResetOnLoseMax = new System.Windows.Forms.CheckBox();
            this.textBox_BaseBet = new System.Windows.Forms.TextBox();
            this.checkBox_StopOnLoseMax = new System.Windows.Forms.CheckBox();
            this.label_cur2 = new System.Windows.Forms.Label();
            this.checkBox_ResetOnLoss = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBox_ResetOnWin = new System.Windows.Forms.CheckBox();
            this.button_StopStartBets = new System.Windows.Forms.Button();
            this.toolTip_labels = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel_GuessOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GuessHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GuessLow)).BeginInit();
            this.panel_BetOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.Location = new System.Drawing.Point(100, 25);
            this.label_Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(16, 17);
            this.label_Balance.TabIndex = 1;
            this.label_Balance.Text = "0";
            // 
            // button_SetupLogin
            // 
            this.button_SetupLogin.Location = new System.Drawing.Point(284, 54);
            this.button_SetupLogin.Margin = new System.Windows.Forms.Padding(4);
            this.button_SetupLogin.Name = "button_SetupLogin";
            this.button_SetupLogin.Size = new System.Drawing.Size(189, 28);
            this.button_SetupLogin.TabIndex = 0;
            this.button_SetupLogin.Text = "Set Username && Password";
            this.button_SetupLogin.UseVisualStyleBackColor = true;
            this.button_SetupLogin.Click += new System.EventHandler(this.button_SetupLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "# Bets: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Profit: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wins: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "% Wins: ";
            // 
            // label_BetCount
            // 
            this.label_BetCount.AutoSize = true;
            this.label_BetCount.Location = new System.Drawing.Point(93, 31);
            this.label_BetCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BetCount.Name = "label_BetCount";
            this.label_BetCount.Size = new System.Drawing.Size(16, 17);
            this.label_BetCount.TabIndex = 8;
            this.label_BetCount.Text = "0";
            // 
            // label_BetProfits
            // 
            this.label_BetProfits.AutoSize = true;
            this.label_BetProfits.Location = new System.Drawing.Point(93, 47);
            this.label_BetProfits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BetProfits.Name = "label_BetProfits";
            this.label_BetProfits.Size = new System.Drawing.Size(16, 17);
            this.label_BetProfits.TabIndex = 9;
            this.label_BetProfits.Text = "0";
            // 
            // label_BetWins
            // 
            this.label_BetWins.AutoSize = true;
            this.label_BetWins.Location = new System.Drawing.Point(93, 63);
            this.label_BetWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BetWins.Name = "label_BetWins";
            this.label_BetWins.Size = new System.Drawing.Size(16, 17);
            this.label_BetWins.TabIndex = 10;
            this.label_BetWins.Text = "0";
            // 
            // label_BetWinsPercent
            // 
            this.label_BetWinsPercent.AutoSize = true;
            this.label_BetWinsPercent.Location = new System.Drawing.Point(93, 79);
            this.label_BetWinsPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BetWinsPercent.Name = "label_BetWinsPercent";
            this.label_BetWinsPercent.Size = new System.Drawing.Size(16, 17);
            this.label_BetWinsPercent.TabIndex = 11;
            this.label_BetWinsPercent.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Emergency Withdrawal Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_SavedEmail);
            this.groupBox1.Controls.Add(this.label_SavedEmergencyAddress);
            this.groupBox1.Controls.Add(this.label_AccountId);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_Emergency);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.label_Username);
            this.groupBox1.Controls.Add(this.button_SetupLogin);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(17, 367);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(703, 155);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Info";
            // 
            // label_SavedEmail
            // 
            this.label_SavedEmail.AutoSize = true;
            this.label_SavedEmail.ForeColor = System.Drawing.Color.Green;
            this.label_SavedEmail.Location = new System.Drawing.Point(568, 89);
            this.label_SavedEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SavedEmail.Name = "label_SavedEmail";
            this.label_SavedEmail.Size = new System.Drawing.Size(48, 17);
            this.label_SavedEmail.TabIndex = 25;
            this.label_SavedEmail.Text = "Saved";
            this.label_SavedEmail.Visible = false;
            // 
            // label_SavedEmergencyAddress
            // 
            this.label_SavedEmergencyAddress.AutoSize = true;
            this.label_SavedEmergencyAddress.ForeColor = System.Drawing.Color.Green;
            this.label_SavedEmergencyAddress.Location = new System.Drawing.Point(568, 118);
            this.label_SavedEmergencyAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SavedEmergencyAddress.Name = "label_SavedEmergencyAddress";
            this.label_SavedEmergencyAddress.Size = new System.Drawing.Size(48, 17);
            this.label_SavedEmergencyAddress.TabIndex = 24;
            this.label_SavedEmergencyAddress.Text = "Saved";
            this.label_SavedEmergencyAddress.Visible = false;
            // 
            // label_AccountId
            // 
            this.label_AccountId.AutoSize = true;
            this.label_AccountId.Location = new System.Drawing.Point(285, 32);
            this.label_AccountId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AccountId.Name = "label_AccountId";
            this.label_AccountId.Size = new System.Drawing.Size(20, 17);
            this.label_AccountId.TabIndex = 22;
            this.label_AccountId.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Account ID:";
            // 
            // textBox_Emergency
            // 
            this.textBox_Emergency.Location = new System.Drawing.Point(284, 114);
            this.textBox_Emergency.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Emergency.MaxLength = 40;
            this.textBox_Emergency.Name = "textBox_Emergency";
            this.textBox_Emergency.Size = new System.Drawing.Size(275, 22);
            this.textBox_Emergency.TabIndex = 2;
            this.textBox_Emergency.Leave += new System.EventHandler(this.textBox_Emergency_Leave);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(284, 85);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Email.MaxLength = 100;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(275, 22);
            this.textBox_Email.TabIndex = 1;
            this.textBox_Email.Leave += new System.EventHandler(this.textBox_Email_Leave);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(285, 60);
            this.label_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(30, 17);
            this.label_Username.TabIndex = 16;
            this.label_Username.Text = "(...)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label_BetWinsPercent);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label_BetWins);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_BetProfits);
            this.groupBox2.Controls.Add(this.label_BetCount);
            this.groupBox2.Location = new System.Drawing.Point(464, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(255, 112);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Betting Statistics";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Withdraw);
            this.groupBox3.Controls.Add(this.textBox_DepositAddress);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label_Balance);
            this.groupBox3.Location = new System.Drawing.Point(24, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(432, 91);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transactions";
            // 
            // button_Withdraw
            // 
            this.button_Withdraw.Location = new System.Drawing.Point(312, 18);
            this.button_Withdraw.Margin = new System.Windows.Forms.Padding(4);
            this.button_Withdraw.Name = "button_Withdraw";
            this.button_Withdraw.Size = new System.Drawing.Size(100, 28);
            this.button_Withdraw.TabIndex = 1;
            this.button_Withdraw.Text = "Withdraw";
            this.button_Withdraw.UseVisualStyleBackColor = true;
            this.button_Withdraw.Click += new System.EventHandler(this.button_Withdraw_Click);
            // 
            // textBox_DepositAddress
            // 
            this.textBox_DepositAddress.Location = new System.Drawing.Point(103, 50);
            this.textBox_DepositAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DepositAddress.Name = "textBox_DepositAddress";
            this.textBox_DepositAddress.ReadOnly = true;
            this.textBox_DepositAddress.Size = new System.Drawing.Size(308, 22);
            this.textBox_DepositAddress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deposit to:";
            this.toolTip_labels.SetToolTip(this.label2, "Deposit Bitcoins to this address. Deposits are credited as soon as they are recei" +
        "ved.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Balance:";
            this.toolTip_labels.SetToolTip(this.label1, "Your current balance in BTC (Updated once per minute and after each bet)");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel_GuessOptions);
            this.groupBox4.Controls.Add(this.button_ExportToCSV);
            this.groupBox4.Controls.Add(this.panel_BetOptions);
            this.groupBox4.Controls.Add(this.button_StopStartBets);
            this.groupBox4.Location = new System.Drawing.Point(16, 134);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(703, 225);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Automatic Betting";
            // 
            // panel_GuessOptions
            // 
            this.panel_GuessOptions.Controls.Add(this.label_PayoutMultiplier);
            this.panel_GuessOptions.Controls.Add(this.label_ChanceToWin);
            this.panel_GuessOptions.Controls.Add(this.label25);
            this.panel_GuessOptions.Controls.Add(this.label21);
            this.panel_GuessOptions.Controls.Add(this.numericUpDown_GuessHigh);
            this.panel_GuessOptions.Controls.Add(this.numericUpDown_GuessLow);
            this.panel_GuessOptions.Location = new System.Drawing.Point(488, 68);
            this.panel_GuessOptions.Margin = new System.Windows.Forms.Padding(4);
            this.panel_GuessOptions.Name = "panel_GuessOptions";
            this.panel_GuessOptions.Size = new System.Drawing.Size(207, 114);
            this.panel_GuessOptions.TabIndex = 3;
            // 
            // label_PayoutMultiplier
            // 
            this.label_PayoutMultiplier.Location = new System.Drawing.Point(17, 89);
            this.label_PayoutMultiplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PayoutMultiplier.Name = "label_PayoutMultiplier";
            this.label_PayoutMultiplier.Size = new System.Drawing.Size(180, 16);
            this.label_PayoutMultiplier.TabIndex = 6;
            this.label_PayoutMultiplier.Text = "Payout 2x";
            this.label_PayoutMultiplier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_ChanceToWin
            // 
            this.label_ChanceToWin.Location = new System.Drawing.Point(17, 73);
            this.label_ChanceToWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ChanceToWin.Name = "label_ChanceToWin";
            this.label_ChanceToWin.Size = new System.Drawing.Size(180, 16);
            this.label_ChanceToWin.TabIndex = 5;
            this.label_ChanceToWin.Text = "49.95% Chance";
            this.label_ChanceToWin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 47);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 17);
            this.label25.TabIndex = 4;
            this.label25.Text = "Guess High";
            this.toolTip_labels.SetToolTip(this.label25, "The high end of the number range you are guessing.");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 17);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "Guess Low";
            this.toolTip_labels.SetToolTip(this.label21, "The low end of the number range you are guessing.");
            // 
            // numericUpDown_GuessHigh
            // 
            this.numericUpDown_GuessHigh.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_GuessHigh.Location = new System.Drawing.Point(105, 44);
            this.numericUpDown_GuessHigh.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_GuessHigh.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_GuessHigh.Minimum = new decimal(new int[] {
            949999,
            0,
            0,
            0});
            this.numericUpDown_GuessHigh.Name = "numericUpDown_GuessHigh";
            this.numericUpDown_GuessHigh.Size = new System.Drawing.Size(93, 22);
            this.numericUpDown_GuessHigh.TabIndex = 1;
            this.numericUpDown_GuessHigh.ThousandsSeparator = true;
            this.numericUpDown_GuessHigh.Value = new decimal(new int[] {
            949999,
            0,
            0,
            0});
            this.numericUpDown_GuessHigh.ValueChanged += new System.EventHandler(this.numericUpDown_GuessHigh_ValueChanged);
            // 
            // numericUpDown_GuessLow
            // 
            this.numericUpDown_GuessLow.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_GuessLow.Location = new System.Drawing.Point(105, 15);
            this.numericUpDown_GuessLow.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_GuessLow.Maximum = new decimal(new int[] {
            950000,
            0,
            0,
            0});
            this.numericUpDown_GuessLow.Name = "numericUpDown_GuessLow";
            this.numericUpDown_GuessLow.Size = new System.Drawing.Size(93, 22);
            this.numericUpDown_GuessLow.TabIndex = 0;
            this.numericUpDown_GuessLow.ThousandsSeparator = true;
            this.numericUpDown_GuessLow.ValueChanged += new System.EventHandler(this.numericUpDown_GuessLow_ValueChanged);
            // 
            // button_ExportToCSV
            // 
            this.button_ExportToCSV.Location = new System.Drawing.Point(496, 190);
            this.button_ExportToCSV.Margin = new System.Windows.Forms.Padding(4);
            this.button_ExportToCSV.Name = "button_ExportToCSV";
            this.button_ExportToCSV.Size = new System.Drawing.Size(191, 28);
            this.button_ExportToCSV.TabIndex = 2;
            this.button_ExportToCSV.Text = "Export Bets to CSV";
            this.button_ExportToCSV.UseVisualStyleBackColor = true;
            this.button_ExportToCSV.Click += new System.EventHandler(this.button_ExportToCSV_Click);
            // 
            // panel_BetOptions
            // 
            this.panel_BetOptions.Controls.Add(this.label12);
            this.panel_BetOptions.Controls.Add(this.textBox_BetCount);
            this.panel_BetOptions.Controls.Add(this.label23);
            this.panel_BetOptions.Controls.Add(this.label19);
            this.panel_BetOptions.Controls.Add(this.label24);
            this.panel_BetOptions.Controls.Add(this.textBox_StopMaxBalance);
            this.panel_BetOptions.Controls.Add(this.textBox_IncreaseOnLoss);
            this.panel_BetOptions.Controls.Add(this.label_cur3);
            this.panel_BetOptions.Controls.Add(this.label22);
            this.panel_BetOptions.Controls.Add(this.label_cur1);
            this.panel_BetOptions.Controls.Add(this.label17);
            this.panel_BetOptions.Controls.Add(this.textBox_MaxBet);
            this.panel_BetOptions.Controls.Add(this.textBox_IncreaseOnWin);
            this.panel_BetOptions.Controls.Add(this.label16);
            this.panel_BetOptions.Controls.Add(this.label_afterMaxBet);
            this.panel_BetOptions.Controls.Add(this.label13);
            this.panel_BetOptions.Controls.Add(this.checkBox_ResetOnLoseMax);
            this.panel_BetOptions.Controls.Add(this.textBox_BaseBet);
            this.panel_BetOptions.Controls.Add(this.checkBox_StopOnLoseMax);
            this.panel_BetOptions.Controls.Add(this.label_cur2);
            this.panel_BetOptions.Controls.Add(this.checkBox_ResetOnLoss);
            this.panel_BetOptions.Controls.Add(this.label20);
            this.panel_BetOptions.Controls.Add(this.checkBox_ResetOnWin);
            this.panel_BetOptions.Location = new System.Drawing.Point(1, 20);
            this.panel_BetOptions.Margin = new System.Windows.Forms.Padding(4);
            this.panel_BetOptions.Name = "panel_BetOptions";
            this.panel_BetOptions.Size = new System.Drawing.Size(487, 198);
            this.panel_BetOptions.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "# Bets";
            this.toolTip_labels.SetToolTip(this.label12, "Maximum number of bets to place, or blank for no limit.");
            // 
            // textBox_BetCount
            // 
            this.textBox_BetCount.Location = new System.Drawing.Point(101, 73);
            this.textBox_BetCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_BetCount.MaxLength = 20;
            this.textBox_BetCount.Name = "textBox_BetCount";
            this.textBox_BetCount.Size = new System.Drawing.Size(100, 22);
            this.textBox_BetCount.TabIndex = 2;
            this.textBox_BetCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_BetCount.TextChanged += new System.EventHandler(this.OptionChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(164, 172);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 17);
            this.label23.TabIndex = 25;
            this.label23.Text = "% After Loss";
            this.toolTip_labels.SetToolTip(this.label23, "Increase your next bet by this percentage if you lost your last bet.");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(53, 108);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "Goal";
            this.toolTip_labels.SetToolTip(this.label19, "Stop betting once your balance reaches this amount, or blank for no goal.");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 172);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 17);
            this.label24.TabIndex = 23;
            this.label24.Text = "Increase by";
            this.toolTip_labels.SetToolTip(this.label24, "Increase your next bet by this percentage if you lost your last bet.");
            // 
            // textBox_StopMaxBalance
            // 
            this.textBox_StopMaxBalance.Location = new System.Drawing.Point(101, 105);
            this.textBox_StopMaxBalance.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_StopMaxBalance.MaxLength = 20;
            this.textBox_StopMaxBalance.Name = "textBox_StopMaxBalance";
            this.textBox_StopMaxBalance.Size = new System.Drawing.Size(100, 22);
            this.textBox_StopMaxBalance.TabIndex = 3;
            this.textBox_StopMaxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_StopMaxBalance.TextChanged += new System.EventHandler(this.OptionChanged);
            // 
            // textBox_IncreaseOnLoss
            // 
            this.textBox_IncreaseOnLoss.Location = new System.Drawing.Point(101, 169);
            this.textBox_IncreaseOnLoss.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_IncreaseOnLoss.MaxLength = 6;
            this.textBox_IncreaseOnLoss.Name = "textBox_IncreaseOnLoss";
            this.textBox_IncreaseOnLoss.Size = new System.Drawing.Size(53, 22);
            this.textBox_IncreaseOnLoss.TabIndex = 5;
            this.textBox_IncreaseOnLoss.Text = "100";
            this.textBox_IncreaseOnLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_IncreaseOnLoss.TextChanged += new System.EventHandler(this.OptionChanged);
            // 
            // label_cur3
            // 
            this.label_cur3.AutoSize = true;
            this.label_cur3.Location = new System.Drawing.Point(209, 108);
            this.label_cur3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cur3.Name = "label_cur3";
            this.label_cur3.Size = new System.Drawing.Size(35, 17);
            this.label_cur3.TabIndex = 14;
            this.label_cur3.Text = "BTC";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(164, 140);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 17);
            this.label22.TabIndex = 22;
            this.label22.Text = "% After Win";
            this.toolTip_labels.SetToolTip(this.label22, "Increase your next bet by this percentage if you won your last bet.");
            // 
            // label_cur1
            // 
            this.label_cur1.AutoSize = true;
            this.label_cur1.Location = new System.Drawing.Point(209, 12);
            this.label_cur1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cur1.Name = "label_cur1";
            this.label_cur1.Size = new System.Drawing.Size(35, 17);
            this.label_cur1.TabIndex = 4;
            this.label_cur1.Text = "BTC";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 140);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Increase by";
            this.toolTip_labels.SetToolTip(this.label17, "Increase your next bet by this percentage if you won your last bet.");
            // 
            // textBox_MaxBet
            // 
            this.textBox_MaxBet.Location = new System.Drawing.Point(101, 41);
            this.textBox_MaxBet.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MaxBet.MaxLength = 20;
            this.textBox_MaxBet.Name = "textBox_MaxBet";
            this.textBox_MaxBet.Size = new System.Drawing.Size(100, 22);
            this.textBox_MaxBet.TabIndex = 1;
            this.textBox_MaxBet.Text = "0.04";
            this.textBox_MaxBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MaxBet.TextChanged += new System.EventHandler(this.OptionChanged);
            // 
            // textBox_IncreaseOnWin
            // 
            this.textBox_IncreaseOnWin.Location = new System.Drawing.Point(101, 137);
            this.textBox_IncreaseOnWin.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_IncreaseOnWin.MaxLength = 6;
            this.textBox_IncreaseOnWin.Name = "textBox_IncreaseOnWin";
            this.textBox_IncreaseOnWin.Size = new System.Drawing.Size(53, 22);
            this.textBox_IncreaseOnWin.TabIndex = 4;
            this.textBox_IncreaseOnWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_IncreaseOnWin.TextChanged += new System.EventHandler(this.OptionChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 44);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Max Bet";
            this.toolTip_labels.SetToolTip(this.label16, "The maximum size of any bet, or blank for no maximum.");
            // 
            // label_afterMaxBet
            // 
            this.label_afterMaxBet.AutoSize = true;
            this.label_afterMaxBet.Location = new System.Drawing.Point(261, 105);
            this.label_afterMaxBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_afterMaxBet.Name = "label_afterMaxBet";
            this.label_afterMaxBet.Size = new System.Drawing.Size(150, 17);
            this.label_afterMaxBet.TabIndex = 19;
            this.label_afterMaxBet.Text = "After Losing Max Bet...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Base Bet";
            this.toolTip_labels.SetToolTip(this.label13, "Required. The starting bet size.");
            // 
            // checkBox_ResetOnLoseMax
            // 
            this.checkBox_ResetOnLoseMax.AutoSize = true;
            this.checkBox_ResetOnLoseMax.Location = new System.Drawing.Point(285, 155);
            this.checkBox_ResetOnLoseMax.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ResetOnLoseMax.Name = "checkBox_ResetOnLoseMax";
            this.checkBox_ResetOnLoseMax.Size = new System.Drawing.Size(119, 21);
            this.checkBox_ResetOnLoseMax.TabIndex = 9;
            this.checkBox_ResetOnLoseMax.Text = "Reset to Base";
            this.toolTip_labels.SetToolTip(this.checkBox_ResetOnLoseMax, "If you lose a maximum sized bet, reset your next bet size to the base bet amount." +
        "");
            this.checkBox_ResetOnLoseMax.UseVisualStyleBackColor = true;
            this.checkBox_ResetOnLoseMax.CheckedChanged += new System.EventHandler(this.OptionChanged);
            // 
            // textBox_BaseBet
            // 
            this.textBox_BaseBet.Location = new System.Drawing.Point(101, 9);
            this.textBox_BaseBet.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_BaseBet.MaxLength = 20;
            this.textBox_BaseBet.Name = "textBox_BaseBet";
            this.textBox_BaseBet.Size = new System.Drawing.Size(100, 22);
            this.textBox_BaseBet.TabIndex = 0;
            this.textBox_BaseBet.Text = "0.01";
            this.textBox_BaseBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_BaseBet.TextChanged += new System.EventHandler(this.OptionChanged);
            // 
            // checkBox_StopOnLoseMax
            // 
            this.checkBox_StopOnLoseMax.AutoSize = true;
            this.checkBox_StopOnLoseMax.Checked = true;
            this.checkBox_StopOnLoseMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_StopOnLoseMax.Location = new System.Drawing.Point(285, 127);
            this.checkBox_StopOnLoseMax.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_StopOnLoseMax.Name = "checkBox_StopOnLoseMax";
            this.checkBox_StopOnLoseMax.Size = new System.Drawing.Size(59, 21);
            this.checkBox_StopOnLoseMax.TabIndex = 8;
            this.checkBox_StopOnLoseMax.Text = "Stop";
            this.toolTip_labels.SetToolTip(this.checkBox_StopOnLoseMax, "If you lose a maximum sized bet, stop betting.");
            this.checkBox_StopOnLoseMax.UseVisualStyleBackColor = true;
            this.checkBox_StopOnLoseMax.CheckedChanged += new System.EventHandler(this.OptionChanged);
            // 
            // label_cur2
            // 
            this.label_cur2.AutoSize = true;
            this.label_cur2.Location = new System.Drawing.Point(209, 44);
            this.label_cur2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cur2.Name = "label_cur2";
            this.label_cur2.Size = new System.Drawing.Size(35, 17);
            this.label_cur2.TabIndex = 7;
            this.label_cur2.Text = "BTC";
            // 
            // checkBox_ResetOnLoss
            // 
            this.checkBox_ResetOnLoss.AutoSize = true;
            this.checkBox_ResetOnLoss.Location = new System.Drawing.Point(285, 62);
            this.checkBox_ResetOnLoss.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ResetOnLoss.Name = "checkBox_ResetOnLoss";
            this.checkBox_ResetOnLoss.Size = new System.Drawing.Size(72, 21);
            this.checkBox_ResetOnLoss.TabIndex = 7;
            this.checkBox_ResetOnLoss.Text = "Losing";
            this.toolTip_labels.SetToolTip(this.checkBox_ResetOnLoss, "Reset your next bet to the base bet amount after losing a bet.");
            this.checkBox_ResetOnLoss.UseVisualStyleBackColor = true;
            this.checkBox_ResetOnLoss.CheckedChanged += new System.EventHandler(this.OptionChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(261, 12);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(168, 17);
            this.label20.TabIndex = 16;
            this.label20.Text = "Reset to Base Bet After...";
            // 
            // checkBox_ResetOnWin
            // 
            this.checkBox_ResetOnWin.AutoSize = true;
            this.checkBox_ResetOnWin.Checked = true;
            this.checkBox_ResetOnWin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ResetOnWin.Location = new System.Drawing.Point(285, 33);
            this.checkBox_ResetOnWin.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ResetOnWin.Name = "checkBox_ResetOnWin";
            this.checkBox_ResetOnWin.Size = new System.Drawing.Size(81, 21);
            this.checkBox_ResetOnWin.TabIndex = 6;
            this.checkBox_ResetOnWin.Text = "Winning";
            this.toolTip_labels.SetToolTip(this.checkBox_ResetOnWin, "Reset your next bet to the base bet amount after winning a bet.");
            this.checkBox_ResetOnWin.UseVisualStyleBackColor = true;
            this.checkBox_ResetOnWin.CheckedChanged += new System.EventHandler(this.OptionChanged);
            // 
            // button_StopStartBets
            // 
            this.button_StopStartBets.Location = new System.Drawing.Point(496, 26);
            this.button_StopStartBets.Margin = new System.Windows.Forms.Padding(4);
            this.button_StopStartBets.Name = "button_StopStartBets";
            this.button_StopStartBets.Size = new System.Drawing.Size(191, 28);
            this.button_StopStartBets.TabIndex = 1;
            this.button_StopStartBets.Text = "Begin Betting";
            this.button_StopStartBets.UseVisualStyleBackColor = true;
            this.button_StopStartBets.Click += new System.EventHandler(this.button_StopStartBets_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 530);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "999dice.com Sample Bot";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel_GuessOptions.ResumeLayout(false);
            this.panel_GuessOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GuessHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GuessLow)).EndInit();
            this.panel_BetOptions.ResumeLayout(false);
            this.panel_BetOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Balance;
        private System.Windows.Forms.Button button_SetupLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_BetCount;
        private System.Windows.Forms.Label label_BetProfits;
        private System.Windows.Forms.Label label_BetWins;
        private System.Windows.Forms.Label label_BetWinsPercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Emergency;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DepositAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_AccountId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_Withdraw;
        private System.Windows.Forms.Label label_SavedEmail;
        private System.Windows.Forms.Label label_SavedEmergencyAddress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_IncreaseOnLoss;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_IncreaseOnWin;
        private System.Windows.Forms.Label label_afterMaxBet;
        private System.Windows.Forms.CheckBox checkBox_ResetOnLoseMax;
        private System.Windows.Forms.CheckBox checkBox_StopOnLoseMax;
        private System.Windows.Forms.CheckBox checkBox_ResetOnLoss;
        private System.Windows.Forms.CheckBox checkBox_ResetOnWin;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label_cur2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_cur1;
        private System.Windows.Forms.Label label_cur3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_BetCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_StopStartBets;
        private System.Windows.Forms.Panel panel_BetOptions;
        private System.Windows.Forms.Button button_ExportToCSV;
        private System.Windows.Forms.Panel panel_GuessOptions;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numericUpDown_GuessHigh;
        private System.Windows.Forms.NumericUpDown numericUpDown_GuessLow;
        private System.Windows.Forms.Label label_PayoutMultiplier;
        private System.Windows.Forms.Label label_ChanceToWin;
        private System.Windows.Forms.TextBox textBox_StopMaxBalance;
        private System.Windows.Forms.TextBox textBox_MaxBet;
        private System.Windows.Forms.TextBox textBox_BaseBet;
        private System.Windows.Forms.ToolTip toolTip_labels;
    }
}