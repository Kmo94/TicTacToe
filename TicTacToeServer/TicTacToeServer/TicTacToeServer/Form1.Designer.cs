namespace TicTacToeServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayFriend = new System.Windows.Forms.Button();
            this.btnPlayCpu = new System.Windows.Forms.Button();
            this.tBoxPortNum = new System.Windows.Forms.TextBox();
            this.lblPortNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(78, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tic Tac Toe";
            // 
            // btnPlayFriend
            // 
            this.btnPlayFriend.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFriend.Location = new System.Drawing.Point(71, 251);
            this.btnPlayFriend.Name = "btnPlayFriend";
            this.btnPlayFriend.Size = new System.Drawing.Size(212, 72);
            this.btnPlayFriend.TabIndex = 5;
            this.btnPlayFriend.Text = "Host a Game";
            this.btnPlayFriend.UseVisualStyleBackColor = true;
            this.btnPlayFriend.Click += new System.EventHandler(this.btnPlayFriend_Click_1);
            // 
            // btnPlayCpu
            // 
            this.btnPlayCpu.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayCpu.Location = new System.Drawing.Point(71, 127);
            this.btnPlayCpu.Name = "btnPlayCpu";
            this.btnPlayCpu.Size = new System.Drawing.Size(212, 72);
            this.btnPlayCpu.TabIndex = 4;
            this.btnPlayCpu.Text = "Play Vs CPU";
            this.btnPlayCpu.UseVisualStyleBackColor = true;
            this.btnPlayCpu.Click += new System.EventHandler(this.btnPlayCpu_Click_1);
            // 
            // tBoxPortNum
            // 
            this.tBoxPortNum.Location = new System.Drawing.Point(220, 437);
            this.tBoxPortNum.Name = "tBoxPortNum";
            this.tBoxPortNum.Size = new System.Drawing.Size(99, 20);
            this.tBoxPortNum.TabIndex = 8;
            // 
            // lblPortNum
            // 
            this.lblPortNum.AutoSize = true;
            this.lblPortNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPortNum.Location = new System.Drawing.Point(27, 437);
            this.lblPortNum.Name = "lblPortNum";
            this.lblPortNum.Size = new System.Drawing.Size(163, 20);
            this.lblPortNum.TabIndex = 9;
            this.lblPortNum.Text = "Enter Port Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(409, 534);
            this.Controls.Add(this.lblPortNum);
            this.Controls.Add(this.tBoxPortNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayFriend);
            this.Controls.Add(this.btnPlayCpu);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayFriend;
        private System.Windows.Forms.Button btnPlayCpu;
        private System.Windows.Forms.TextBox tBoxPortNum;
        private System.Windows.Forms.Label lblPortNum;
    }
}

