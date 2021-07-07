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
            this.cbSecondPlyer = new System.Windows.Forms.CheckBox();
            this.FirstPlayerTextBox = new System.Windows.Forms.TextBox();
            this.SecondPlayerTextBox = new System.Windows.Forms.TextBox();
            this.BoardSizeLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.nUDRows = new System.Windows.Forms.NumericUpDown();
            this.ColsLabel = new System.Windows.Forms.Label();
            this.nUDCols = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCols)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Location = new System.Drawing.Point(44, 74);
            this.PlayersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(64, 20);
            this.PlayersLabel.TabIndex = 0;
            this.PlayersLabel.Text = "Players:";
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Location = new System.Drawing.Point(48, 163);
            this.FirstPlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(69, 20);
            this.FirstPlayerLabel.TabIndex = 1;
            this.FirstPlayerLabel.Text = "Player 1:";
            // 
            // cbSecondPlyer
            // 
            this.cbSecondPlyer.AutoSize = true;
            this.cbSecondPlyer.Location = new System.Drawing.Point(18, 217);
            this.cbSecondPlyer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSecondPlyer.Name = "cbSecondPlyer";
            this.cbSecondPlyer.Size = new System.Drawing.Size(95, 24);
            this.cbSecondPlyer.TabIndex = 3;
            this.cbSecondPlyer.Text = "Player 2:";
            this.cbSecondPlyer.UseVisualStyleBackColor = true;
            this.cbSecondPlyer.CheckedChanged += new System.EventHandler(this.cbSecondPlyer_CheckedChanged);
            // 
            // FirstPlayerTextBox
            // 
            this.FirstPlayerTextBox.Location = new System.Drawing.Point(153, 163);
            this.FirstPlayerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstPlayerTextBox.Name = "FirstPlayerTextBox";
            this.FirstPlayerTextBox.Size = new System.Drawing.Size(148, 26);
            this.FirstPlayerTextBox.TabIndex = 4;
            // 
            // SecondPlayerTextBox
            // 
            this.SecondPlayerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SecondPlayerTextBox.Enabled = false;
            this.SecondPlayerTextBox.Location = new System.Drawing.Point(153, 212);
            this.SecondPlayerTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondPlayerTextBox.Name = "SecondPlayerTextBox";
            this.SecondPlayerTextBox.Size = new System.Drawing.Size(148, 26);
            this.SecondPlayerTextBox.TabIndex = 5;
            this.SecondPlayerTextBox.Text = "Computer";
            // 
            // BoardSizeLabel
            // 
            this.BoardSizeLabel.AutoSize = true;
            this.BoardSizeLabel.Location = new System.Drawing.Point(38, 295);
            this.BoardSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BoardSizeLabel.Name = "BoardSizeLabel";
            this.BoardSizeLabel.Size = new System.Drawing.Size(87, 20);
            this.BoardSizeLabel.TabIndex = 6;
            this.BoardSizeLabel.Text = "BoardSize:";
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(38, 358);
            this.RowsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(53, 20);
            this.RowsLabel.TabIndex = 7;
            this.RowsLabel.Text = "Rows:";
            // 
            // nUDRows
            // 
            this.nUDRows.Location = new System.Drawing.Point(102, 354);
            this.nUDRows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.nUDRows.Size = new System.Drawing.Size(54, 26);
            this.nUDRows.TabIndex = 8;
            this.nUDRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUDRows.ValueChanged += new System.EventHandler(this.nUDRows_ValueChanged);
            // 
            // ColsLabel
            // 
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Location = new System.Drawing.Point(225, 358);
            this.ColsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(44, 20);
            this.ColsLabel.TabIndex = 9;
            this.ColsLabel.Text = "Cols:";
            // 
            // nUDCols
            // 
            this.nUDCols.Location = new System.Drawing.Point(279, 354);
            this.nUDCols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.nUDCols.Size = new System.Drawing.Size(54, 26);
            this.nUDCols.TabIndex = 10;
            this.nUDCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUDCols.ValueChanged += new System.EventHandler(this.nUDCols_ValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(75, 423);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(258, 38);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(startButtonClicked);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 497);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.nUDCols);
            this.Controls.Add(this.ColsLabel);
            this.Controls.Add(this.nUDRows);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.BoardSizeLabel);
            this.Controls.Add(this.SecondPlayerTextBox);
            this.Controls.Add(this.FirstPlayerTextBox);
            this.Controls.Add(this.cbSecondPlyer);
            this.Controls.Add(this.FirstPlayerLabel);
            this.Controls.Add(this.PlayersLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.CheckBox cbSecondPlyer;
        private System.Windows.Forms.TextBox FirstPlayerTextBox;
        private System.Windows.Forms.TextBox SecondPlayerTextBox;
        private System.Windows.Forms.Label BoardSizeLabel;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.NumericUpDown nUDRows;
        private System.Windows.Forms.Label ColsLabel;
        private System.Windows.Forms.NumericUpDown nUDCols;
        private System.Windows.Forms.Button buttonStart;
    }
}