using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReverseTicTacToeLogic;

namespace ReverseTicTacToeGame
{
    public partial class TicTacToeUI : Form
    {

        private const string k_AnnounceAWinnerMessage = "The winner is: ";
        private const string k_AnotherRoundQuestion = "Play another round?";
        private GameLogic m_GameLogic;




        internal TicTacToeUI(SettingsForm i_SettingForm)
        {
            this.CenterToScreen();
            InitializeComponent();
            initGameSetting(i_SettingForm);
            
        }


        private void initGameSetting(SettingsForm i_SettingsForm)
        {
            m_GameLogic = new GameLogic(i_SettingsForm.BoardSize);
            
        }

        private void TicTacToeUI_Load(object sender, EventArgs e)
        {

        }
    }
}
