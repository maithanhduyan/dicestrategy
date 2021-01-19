
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
            this.txtServerSeed.Location = new System.Drawing.Point(117, 19);
            this.txtServerSeed.Name = "txtServerSeed";
            this.txtServerSeed.Size = new System.Drawing.Size(486, 22);
            this.txtServerSeed.TabIndex = 1;
            this.txtServerSeed.Text = "c27fe6bde36947ef9fdb8cb5cb4972c209549017c5d83f4b1ff93742aacb25de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client Seed";
            // 
            // txtClientSeed
            // 
            this.txtClientSeed.Location = new System.Drawing.Point(117, 62);
            this.txtClientSeed.Name = "txtClientSeed";
            this.txtClientSeed.Size = new System.Drawing.Size(486, 22);
            this.txtClientSeed.TabIndex = 1;
            this.txtClientSeed.Text = "605300059";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bet Number";
            // 
            // txtBetNumber
            // 
            this.txtBetNumber.Location = new System.Drawing.Point(117, 106);
            this.txtBetNumber.Name = "txtBetNumber";
            this.txtBetNumber.Size = new System.Drawing.Size(486, 22);
            this.txtBetNumber.TabIndex = 1;
            this.txtBetNumber.Text = "94999";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bet Result";
            // 
            // txtBetResult
            // 
            this.txtBetResult.Location = new System.Drawing.Point(117, 157);
            this.txtBetResult.Name = "txtBetResult";
            this.txtBetResult.Size = new System.Drawing.Size(486, 22);
            this.txtBetResult.TabIndex = 1;
            this.txtBetResult.Text = "376992";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(306, 207);
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
            this.lblCalculateBetResult.Location = new System.Drawing.Point(114, 242);
            this.lblCalculateBetResult.Name = "lblCalculateBetResult";
            this.lblCalculateBetResult.Size = new System.Drawing.Size(77, 17);
            this.lblCalculateBetResult.TabIndex = 3;
            this.lblCalculateBetResult.Text = "Bet Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 268);
            this.Controls.Add(this.lblCalculateBetResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtBetResult);
            this.Controls.Add(this.txtBetNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientSeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerSeed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
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
    }
}

