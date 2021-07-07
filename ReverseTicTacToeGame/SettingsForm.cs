using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseTicTacToeGame
{
    public partial class SettingsForm : Form
    {


        private const string k_DefaultSecondPlayer = "Computer";

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }


        internal SettingsForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ShowInTaskbar = false; // what is this?
            this.CenterToScreen();
            InitializeComponent();
        }



        internal string FirstPlayerName
        {
           get
           {
               return FirstPlayerTextBox.Text;
            }
           
        }

        internal bool PlayingAgaintTheComputer
        {
            get
            {
                return this.cbSecondPlyer.Checked;
            }
        }

        internal int BoardSize
        {
            get
            {
                return (int)nUDRows.Value;
            }
        }


        private void checkGameMode(object sender, EventArgs e)
        {
            if (cbSecondPlyer.Checked == true)
            {
                SecondPlayerTextBox.Enabled = true;
                SecondPlayerTextBox.Text = string.Empty;
            }

            else
            {
                SecondPlayerTextBox.Text = k_DefaultSecondPlayer;
            }
        }

        private void startButtonClicked(object sender, EventArgs e)
        {
            TicTacToeUI TicTacToGameUI = new TicTacToeUI(this);
            this.Hide();
            TicTacToGameUI.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void nUDRows_ValueChanged(object sender, EventArgs e)
        {
            nUDCols.Value = nUDRows.Value;
        }

        private void nUDCols_ValueChanged(object sender, EventArgs e)
        {
            nUDRows.Value = (sender as NumericUpDown).Value;
        }

        private void cbSecondPlyer_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                SecondPlayerTextBox.Text = string.Empty;
            }
        }
    }
}
