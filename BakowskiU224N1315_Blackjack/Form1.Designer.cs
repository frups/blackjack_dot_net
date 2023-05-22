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
            this.SuspendLayout();
            // 
            // fraPlayerHand
            // 
            this.fraPlayerHand.Location = new System.Drawing.Point(12, 96);
            this.fraPlayerHand.Name = "fraPlayerHand";
            this.fraPlayerHand.Size = new System.Drawing.Size(450, 400);
            this.fraPlayerHand.TabIndex = 0;
            this.fraPlayerHand.TabStop = false;
            this.fraPlayerHand.Text = "fraPlayerHand";
            // 
            // fraDealerHand
            // 
            this.fraDealerHand.Location = new System.Drawing.Point(469, 96);
            this.fraDealerHand.Name = "fraDealerHand";
            this.fraDealerHand.Size = new System.Drawing.Size(450, 400);
            this.fraDealerHand.TabIndex = 1;
            this.fraDealerHand.TabStop = false;
            this.fraDealerHand.Text = "fraDealerHand";
            // 
            // btnTwist
            // 
            this.btnTwist.Location = new System.Drawing.Point(12, 23);
            this.btnTwist.Name = "btnTwist";
            this.btnTwist.Size = new System.Drawing.Size(75, 23);
            this.btnTwist.TabIndex = 2;
            this.btnTwist.Text = "btnTwist";
            this.btnTwist.UseVisualStyleBackColor = true;
            this.btnTwist.Click += new System.EventHandler(this.btnTwist_Click);
            // 
            // btnStick
            // 
            this.btnStick.Location = new System.Drawing.Point(12, 52);
            this.btnStick.Name = "btnStick";
            this.btnStick.Size = new System.Drawing.Size(75, 23);
            this.btnStick.TabIndex = 3;
            this.btnStick.Text = "btnStick";
            this.btnStick.UseVisualStyleBackColor = true;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(125, 43);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(74, 13);
            this.lblPlayerScore.TabIndex = 4;
            this.lblPlayerScore.Text = "lblPlayerScore";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 507);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.btnStick);
            this.Controls.Add(this.btnTwist);
            this.Controls.Add(this.fraDealerHand);
            this.Controls.Add(this.fraPlayerHand);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

