namespace ReverseTicTacToeGame
{
    partial class SettingsForm
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
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.FirstPlayerLabel = new System.Windows.Forms.Label();
            this.SecondPlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstPlayerTextBox = new System.Windows.Forms.TextBox();
            this.SecondPlayerTextBox = new System.Windows.Forms.TextBox();
            this.BoardSizeLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.nUDRows = new System.Windows.Forms.NumericUpDown();
            this.ColsLabel = new System.Windows.Forms.Label();
            this.nUDCols = new System.Windows.Forms.NumericUpDown();
            this.ButtonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCols)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Location = new System.Drawing.Point(29, 48);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(44, 13);
            this.PlayersLabel.TabIndex = 0;
            this.PlayersLabel.Text = "Players:";
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Location = new System.Drawing.Point(32, 106);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(48, 13);
            this.FirstPlayerLabel.TabIndex = 1;
            this.FirstPlayerLabel.Text = "Player 1:";
            // 
            // SecondPlayerCheckBox
            // 
            this.SecondPlayerCheckBox.AutoSize = true;
            this.SecondPlayerCheckBox.Location = new System.Drawing.Point(12, 141);
            this.SecondPlayerCheckBox.Name = "SecondPlayerCheckBox";
            this.SecondPlayerCheckBox.Size = new System.Drawing.Size(67, 17);
            this.SecondPlayerCheckBox.TabIndex = 3;
            this.SecondPlayerCheckBox.Text = "Player 2:";
            this.SecondPlayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // FirstPlayerTextBox
            // 
            this.FirstPlayerTextBox.Location = new System.Drawing.Point(102, 106);
            this.FirstPlayerTextBox.Name = "FirstPlayerTextBox";
            this.FirstPlayerTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstPlayerTextBox.TabIndex = 4;
            // 
            // SecondPlayerTextBox
            // 
            this.SecondPlayerTextBox.Enabled = false;
            this.SecondPlayerTextBox.Location = new System.Drawing.Point(102, 138);
            this.SecondPlayerTextBox.Name = "SecondPlayerTextBox";
            this.SecondPlayerTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondPlayerTextBox.TabIndex = 5;
            this.SecondPlayerTextBox.Text = "Computer";
            // 
            // BoardSizeLabel
            // 
            this.BoardSizeLabel.AutoSize = true;
            this.BoardSizeLabel.Location = new System.Drawing.Point(25, 192);
            this.BoardSizeLabel.Name = "BoardSizeLabel";
            this.BoardSizeLabel.Size = new System.Drawing.Size(58, 13);
            this.BoardSizeLabel.TabIndex = 6;
            this.BoardSizeLabel.Text = "BoardSize:";
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(25, 233);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(37, 13);
            this.RowsLabel.TabIndex = 7;
            this.RowsLabel.Text = "Rows:";
            // 
            // nUDRows
            // 
            this.nUDRows.Location = new System.Drawing.Point(68, 230);
            this.nUDRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nUDRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUDRows.Name = "nUDRows";
            this.nUDRows.Size = new System.Drawing.Size(36, 20);
            this.nUDRows.TabIndex = 8;
            this.nUDRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ColsLabel
            // 
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Location = new System.Drawing.Point(150, 233);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(30, 13);
            this.ColsLabel.TabIndex = 9;
            this.ColsLabel.Text = "Cols:";
            // 
            // nUDCols
            // 
            this.nUDCols.Location = new System.Drawing.Point(186, 230);
            this.nUDCols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nUDCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUDCols.Name = "nUDCols";
            this.nUDCols.Size = new System.Drawing.Size(36, 20);
            this.nUDCols.TabIndex = 10;
            this.nUDCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(50, 275);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(172, 25);
            this.ButtonStart.TabIndex = 11;
            this.ButtonStart.Text = "Start!";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 323);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.nUDCols);
            this.Controls.Add(this.ColsLabel);
            this.Controls.Add(this.nUDRows);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.BoardSizeLabel);
            this.Controls.Add(this.SecondPlayerTextBox);
            this.Controls.Add(this.FirstPlayerTextBox);
            this.Controls.Add(this.SecondPlayerCheckBox);
            this.Controls.Add(this.FirstPlayerLabel);
            this.Controls.Add(this.PlayersLabel);
            this.Name = "SettingsForm";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.Label FirstPlayerLabel;
        private System.Windows.Forms.CheckBox SecondPlayerCheckBox;
        private System.Windows.Forms.TextBox FirstPlayerTextBox;
        private System.Windows.Forms.TextBox SecondPlayerTextBox;
        private System.Windows.Forms.Label BoardSizeLabel;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.NumericUpDown nUDRows;
        private System.Windows.Forms.Label ColsLabel;
        private System.Windows.Forms.NumericUpDown nUDCols;
        private System.Windows.Forms.Button ButtonStart;
    }
}