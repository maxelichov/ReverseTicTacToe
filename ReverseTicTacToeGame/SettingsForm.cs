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



        internal string GetHumanName()
        {
            return tbSecondPlayerName.Text;
        }

        internal string GetComputerName()
        {
            return k_DefaultSecondPlayer;
        }
        

        internal eOpponnent Opponnent()
        {
            eOpponnent opponnent;

            if(cbSecondPlyer.Checked == true)
            {
                opponnent = eOpponnent.Human;
            }
            else
            {
                opponnent = eOpponnent.Computer;
            }

            return opponnent;
        }
           

      
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
               return tbFirstPlayerName.Text;
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
                tbSecondPlayerName.Enabled = true;
                tbSecondPlayerName.Text = string.Empty;
            }

            else
            {
                tbSecondPlayerName.Text = k_DefaultSecondPlayer;
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
                tbSecondPlayerName.Text = string.Empty;
                tbSecondPlayerName.Enabled = true;
            }
        }
    }
}
