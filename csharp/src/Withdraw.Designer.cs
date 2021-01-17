namespace Dice.Sample.Bot
{
    partial class Withdraw
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
            this.label_Balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Withdraw = new System.Windows.Forms.Button();
            this.button_WithdrawAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance:";
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.Location = new System.Drawing.Point(140, 26);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(13, 13);
            this.label_Balance.TabIndex = 1;
            this.label_Balance.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Withdrawal Address:";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(143, 67);
            this.textBox_Address.MaxLength = 42;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(168, 20);
            this.textBox_Address.TabIndex = 1;
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(143, 44);
            this.textBox_Amount.MaxLength = 20;
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(127, 20);
            this.textBox_Amount.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // button_Withdraw
            // 
            this.button_Withdraw.Location = new System.Drawing.Point(74, 102);
            this.button_Withdraw.Name = "button_Withdraw";
            this.button_Withdraw.Size = new System.Drawing.Size(75, 23);
            this.button_Withdraw.TabIndex = 2;
            this.button_Withdraw.Text = "Withdraw";
            this.button_Withdraw.UseVisualStyleBackColor = true;
            this.button_Withdraw.Click += new System.EventHandler(this.button_Withdraw_Click);
            // 
            // button_WithdrawAll
            // 
            this.button_WithdrawAll.Location = new System.Drawing.Point(159, 102);
            this.button_WithdrawAll.Name = "button_WithdrawAll";
            this.button_WithdrawAll.Size = new System.Drawing.Size(75, 23);
            this.button_WithdrawAll.TabIndex = 3;
            this.button_WithdrawAll.Text = "Withdraw All";
            this.button_WithdrawAll.UseVisualStyleBackColor = true;
            this.button_WithdrawAll.Click += new System.EventHandler(this.button_WithdrawAll_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 144);
            this.Controls.Add(this.button_WithdrawAll);
            this.Controls.Add(this.button_Withdraw);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Balance);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Withdraw";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Withdraw";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Withdraw_FormClosed);
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Withdraw;
        private System.Windows.Forms.Button button_WithdrawAll;
    }
}