namespace TicTacToeServer
{
    partial class ChooseXO
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
            this.btnChooseX = new System.Windows.Forms.Button();
            this.btnChooseO = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseX
            // 
            this.btnChooseX.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseX.Location = new System.Drawing.Point(12, 104);
            this.btnChooseX.Name = "btnChooseX";
            this.btnChooseX.Size = new System.Drawing.Size(216, 239);
            this.btnChooseX.TabIndex = 1;
            this.btnChooseX.Text = "X";
            this.btnChooseX.UseVisualStyleBackColor = true;
            this.btnChooseX.Click += new System.EventHandler(this.btnChooseX_Click_1);
            // 
            // btnChooseO
            // 
            this.btnChooseO.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseO.Location = new System.Drawing.Point(242, 104);
            this.btnChooseO.Name = "btnChooseO";
            this.btnChooseO.Size = new System.Drawing.Size(216, 239);
            this.btnChooseO.TabIndex = 2;
            this.btnChooseO.Text = "O";
            this.btnChooseO.UseVisualStyleBackColor = true;
            this.btnChooseO.Click += new System.EventHandler(this.btnChooseO_Click_1);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblChoose.Location = new System.Drawing.Point(183, 38);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(97, 31);
            this.lblChoose.TabIndex = 3;
            this.lblChoose.Text = "Choose";
            // 
            // ChooseXO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(470, 386);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnChooseO);
            this.Controls.Add(this.btnChooseX);
            this.Name = "ChooseXO";
            this.Text = "ChooseXO";
            this.Load += new System.EventHandler(this.ChooseXO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseX;
        private System.Windows.Forms.Button btnChooseO;
        private System.Windows.Forms.Label lblChoose;

    }
}