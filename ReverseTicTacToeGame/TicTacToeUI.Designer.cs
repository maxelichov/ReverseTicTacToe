namespace ReverseTicTacToeGame
{
    partial class TicTacToeUI
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
            this.labelFirstPlayerScorre = new System.Windows.Forms.Label();
            this.labelSecondPlayerScore = new System.Windows.Forms.Label();
            this.labelFirstPlayerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstPlayerScorre
            // 
            this.labelFirstPlayerScorre.AutoSize = true;
            this.labelFirstPlayerScorre.Location = new System.Drawing.Point(431, 660);
            this.labelFirstPlayerScorre.Name = "labelFirstPlayerScorre";
            this.labelFirstPlayerScorre.Size = new System.Drawing.Size(0, 20);
            this.labelFirstPlayerScorre.TabIndex = 0;
            // 
            // labelSecondPlayerScore
            // 
            this.labelSecondPlayerScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSecondPlayerScore.AutoSize = true;
            this.labelSecondPlayerScore.Location = new System.Drawing.Point(678, 660);
            this.labelSecondPlayerScore.Name = "labelSecondPlayerScore";
            this.labelSecondPlayerScore.Size = new System.Drawing.Size(55, 20);
            this.labelSecondPlayerScore.TabIndex = 1;
            this.labelSecondPlayerScore.Text = "label2:";
            // 
            // labelFirstPlayerScore
            // 
            this.labelFirstPlayerScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelFirstPlayerScore.AutoSize = true;
            this.labelFirstPlayerScore.Location = new System.Drawing.Point(451, 659);
            this.labelFirstPlayerScore.Name = "labelFirstPlayerScore";
            this.labelFirstPlayerScore.Size = new System.Drawing.Size(55, 20);
            this.labelFirstPlayerScore.TabIndex = 2;
            this.labelFirstPlayerScore.Text = "label1:";
            // 
            // TicTacToeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.labelFirstPlayerScore);
            this.Controls.Add(this.labelSecondPlayerScore);
            this.Controls.Add(this.labelFirstPlayerScorre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicTacToeUI";
            this.Text = "ReverseTicTacToe";
            this.Load += new System.EventHandler(this.TicTacToeUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstPlayerScorre;
        private System.Windows.Forms.Label labelSecondPlayerScore;
        private System.Windows.Forms.Label labelFirstPlayerScore;
    }
}