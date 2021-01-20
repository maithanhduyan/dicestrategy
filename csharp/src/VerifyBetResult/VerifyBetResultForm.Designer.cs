
namespace VerifyBetResult
{
    partial class VerifyBetResultForm
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
            this.txtServerSeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientSeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBetNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBetResult = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCalculateBetResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerSeedHash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Seed";
            // 
            // txtServerSeed
            // 
            this.txtServerSeed.Location = new System.Drawing.Point(157, 19);
            this.txtServerSeed.Name = "txtServerSeed";
            this.txtServerSeed.Size = new System.Drawing.Size(486, 22);
            this.txtServerSeed.TabIndex = 1;
            this.txtServerSeed.Text = "a84bb8b7a1412b6a56fea1a4ea9375220121d85b475002fce064e35a871dbf93";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client Seed";
            // 
            // txtClientSeed
            // 
            this.txtClientSeed.Location = new System.Drawing.Point(157, 113);
            this.txtClientSeed.Name = "txtClientSeed";
            this.txtClientSeed.Size = new System.Drawing.Size(486, 22);
            this.txtClientSeed.TabIndex = 1;
            this.txtClientSeed.Text = "579964599";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bet Number";
            // 
            // txtBetNumber
            // 
            this.txtBetNumber.Location = new System.Drawing.Point(157, 157);
            this.txtBetNumber.Name = "txtBetNumber";
            this.txtBetNumber.Size = new System.Drawing.Size(486, 22);
            this.txtBetNumber.TabIndex = 1;
            this.txtBetNumber.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bet Result";
            // 
            // txtBetResult
            // 
            this.txtBetResult.Location = new System.Drawing.Point(157, 208);
            this.txtBetResult.Name = "txtBetResult";
            this.txtBetResult.Size = new System.Drawing.Size(486, 22);
            this.txtBetResult.TabIndex = 1;
            this.txtBetResult.Text = "551933";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(346, 258);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCalculateBetResult
            // 
            this.lblCalculateBetResult.AutoSize = true;
            this.lblCalculateBetResult.Location = new System.Drawing.Point(114, 293);
            this.lblCalculateBetResult.Name = "lblCalculateBetResult";
            this.lblCalculateBetResult.Size = new System.Drawing.Size(77, 17);
            this.lblCalculateBetResult.TabIndex = 3;
            this.lblCalculateBetResult.Text = "Bet Result:";
            this.lblCalculateBetResult.Click += new System.EventHandler(this.lblCalculateBetResult_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Server Seed Hash";
            // 
            // txtServerSeedHash
            // 
            this.txtServerSeedHash.Location = new System.Drawing.Point(157, 62);
            this.txtServerSeedHash.Name = "txtServerSeedHash";
            this.txtServerSeedHash.Size = new System.Drawing.Size(486, 22);
            this.txtServerSeedHash.TabIndex = 1;
            this.txtServerSeedHash.Text = "0022f3ab7ff6b5160eb66451ba6cb9bb64ebfd89d4387d776e180d44520e0dc1";
            // 
            // VerifyBetResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 315);
            this.Controls.Add(this.lblCalculateBetResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtBetResult);
            this.Controls.Add(this.txtBetNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientSeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerSeedHash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServerSeed);
            this.Controls.Add(this.label1);
            this.Name = "VerifyBetResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify Bet Result";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientSeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBetNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBetResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCalculateBetResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServerSeedHash;
    }
}

