namespace BakowskiU224N1315_Blackjack
{
    partial class Form1
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
            this.fraPlayerHand = new System.Windows.Forms.GroupBox();
            this.fraDealerHand = new System.Windows.Forms.GroupBox();
            this.btnTwist = new System.Windows.Forms.Button();
            this.btnStick = new System.Windows.Forms.Button();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblPlayerAccount = new System.Windows.Forms.Label();
            this.lblEur = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fraPlayerHand
            // 
            this.fraPlayerHand.Location = new System.Drawing.Point(12, 96);
            this.fraPlayerHand.Name = "fraPlayerHand";
            this.fraPlayerHand.Size = new System.Drawing.Size(450, 400);
            this.fraPlayerHand.TabIndex = 0;
            this.fraPlayerHand.TabStop = false;
            this.fraPlayerHand.Text = "Player Hand";
            // 
            // fraDealerHand
            // 
            this.fraDealerHand.Location = new System.Drawing.Point(469, 96);
            this.fraDealerHand.Name = "fraDealerHand";
            this.fraDealerHand.Size = new System.Drawing.Size(450, 400);
            this.fraDealerHand.TabIndex = 1;
            this.fraDealerHand.TabStop = false;
            this.fraDealerHand.Text = "Dealer Hand";
            // 
            // btnTwist
            // 
            this.btnTwist.Enabled = false;
            this.btnTwist.Location = new System.Drawing.Point(781, 24);
            this.btnTwist.Name = "btnTwist";
            this.btnTwist.Size = new System.Drawing.Size(66, 66);
            this.btnTwist.TabIndex = 2;
            this.btnTwist.Text = "Twist";
            this.btnTwist.UseVisualStyleBackColor = true;
            this.btnTwist.Click += new System.EventHandler(this.btnTwist_Click);
            // 
            // btnStick
            // 
            this.btnStick.Enabled = false;
            this.btnStick.Location = new System.Drawing.Point(853, 24);
            this.btnStick.Name = "btnStick";
            this.btnStick.Size = new System.Drawing.Size(66, 66);
            this.btnStick.TabIndex = 3;
            this.btnStick.Text = "Stick";
            this.btnStick.UseVisualStyleBackColor = true;
            this.btnStick.Click += new System.EventHandler(this.btnStick_Click);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(16, 80);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(74, 13);
            this.lblPlayerScore.TabIndex = 4;
            this.lblPlayerScore.Text = "lblPlayerScore";
            this.lblPlayerScore.Visible = false;
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Location = new System.Drawing.Point(475, 80);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(76, 13);
            this.lblDealerScore.TabIndex = 5;
            this.lblDealerScore.Text = "lblDealerScore";
            this.lblDealerScore.Visible = false;
            // 
            // lblPlayerAccount
            // 
            this.lblPlayerAccount.AutoSize = true;
            this.lblPlayerAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPlayerAccount.Location = new System.Drawing.Point(105, 19);
            this.lblPlayerAccount.Name = "lblPlayerAccount";
            this.lblPlayerAccount.Size = new System.Drawing.Size(167, 24);
            this.lblPlayerAccount.TabIndex = 4;
            this.lblPlayerAccount.Text = "lblPlayerAccount";
            // 
            // lblEur
            // 
            this.lblEur.AutoSize = true;
            this.lblEur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEur.Location = new System.Drawing.Point(138, 19);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(21, 24);
            this.lblEur.TabIndex = 5;
            this.lblEur.Text = "€";
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBet.ForeColor = System.Drawing.Color.Black;
            this.txtBet.Location = new System.Drawing.Point(330, 16);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(30, 29);
            this.txtBet.TabIndex = 6;
            this.txtBet.Text = "2";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(330, 67);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(52, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(366, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "€";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.Color.Black;
            this.lblBet.Location = new System.Drawing.Point(278, 19);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(46, 24);
            this.lblBet.TabIndex = 9;
            this.lblBet.Text = "Bet:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAccount.Location = new System.Drawing.Point(15, 19);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(93, 24);
            this.lblAccount.TabIndex = 10;
            this.lblAccount.Text = "Account:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 507);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblEur);
            this.Controls.Add(this.lblPlayerAccount);
            this.Controls.Add(this.btnStick);
            this.Controls.Add(this.btnTwist);
            this.Controls.Add(this.fraDealerHand);
            this.Controls.Add(this.fraPlayerHand);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fraPlayerHand;
        private System.Windows.Forms.GroupBox fraDealerHand;
        private System.Windows.Forms.Button btnTwist;
        private System.Windows.Forms.Button btnStick;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Label lblPlayerAccount;
        private System.Windows.Forms.Label lblEur;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblAccount;
    }
}

