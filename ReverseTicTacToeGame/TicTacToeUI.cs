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
        private const string k_AnnounceAWinnerMessage = " Won The Round!";
        private const string k_AnotherRoundQuestion = "Would You Like To Play Another Round?";
        private const string k_AnnounceTieGame = "It's A Tie!";
        private const string k_winHeader = "Well Done!";
        private const string k_RoundEndedHeader = "The Round Has Ended";
        private const string k_TieHeader = "Tie";
        private const string k_QuitGameMessage = "The Game Has Ended With The Score:";
        private readonly GameLogic m_GameLogic;
        private readonly List<Player> m_PlayersWhosPlayingTheGame;
        private readonly List<ButtonCell> m_Buttons;
        private NextMove m_MoveToImplment;
        private int m_TurnsPlayed = 0;
        private eGameModeOptions m_GameMode;


        internal TicTacToeUI(SettingsForm i_SettingsForm)
        {
            this.CenterToScreen();
            InitializeComponent();
            m_PlayersWhosPlayingTheGame = new List<Player>();
            m_Buttons = new List<ButtonCell>();
            initGameSetting(i_SettingsForm);                // take info from settings form and pass that info to UI Form And Logic
            this.Resize += ticTacToe_ResizeUIForm;          // Add method to this form delegate
            m_GameLogic = new GameLogic(i_SettingsForm.BoardSize);
            m_MoveToImplment = new NextMove();
            initBoardButtons();
        }

        internal enum eTurn
        {
            FirstPlayerTurn = 0,
            SecondPlayerTurn = 1
        }

        private void ticTacToe_ResizeUIForm(object sender, EventArgs e)
        {

            int boardSize = m_GameLogic.GetBoardSize();
            int clientSizeHeight = labelFirstPlayerScore.Top / boardSize;
            int clientSizeWidth = ClientSize.Width / boardSize;

            foreach (Control control in this.Controls)
            {
                if (control is ButtonCell)
                {
                    (control as ButtonCell).Left = (int)(((control as ButtonCell).Row - 1) * clientSizeWidth);
                    (control as ButtonCell).Top = (int)(((control as ButtonCell).Col - 1) * clientSizeHeight);
                    control.Size = new Size(clientSizeWidth, clientSizeHeight);
                }
            }
        }

        private void initBoardButtons()
        {
            int boardSize = m_GameLogic.GetBoardSize();
            int height = labelFirstPlayerScore.Top / boardSize;
            int width = ClientSize.Width / boardSize;

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    ButtonCell buttonCell = new ButtonCell((int)(row + 1), (int)(col + 1));
                    buttonCell.Left = row * width;
                    buttonCell.Top = col * height;
                    buttonCell.Size = new Size(width, height);
                    buttonCell.Click += this.buttonCell_Clicked; // add method to button listeners list.
                    this.Controls.Add(buttonCell); // adds the  new buttons to be part of the UI Form controls. 
                    m_Buttons.Add(buttonCell);
                }
            }
        }

        
        internal enum ePlayers
        {
            FirstPlayer = 0,
            SecondPlayer = 1
        }

        private int currentPlayerTurn()
        {
            return m_TurnsPlayed % 2;
        }
        

        private void buttonCell_Clicked(object sender, EventArgs e)
        {
            // sender is the button who got clicked
            //we wil extract the row and col from the button to implement a game move accordingly
            
            ButtonCell buttonWhoGotClicked = sender as ButtonCell; 
            m_MoveToImplment.Row = buttonWhoGotClicked.Row;
            m_MoveToImplment.Col = buttonWhoGotClicked.Col;
            m_GameLogic.ImplementMove(m_MoveToImplment, m_TurnsPlayed);
            buttonWhoGotClicked.Text = m_PlayersWhosPlayingTheGame[currentPlayerTurn()].PlayerSymbol.ToString();
            buttonWhoGotClicked.Font = changeFontSize(buttonWhoGotClicked.Font, buttonWhoGotClicked.Font.Size * 4);
            buttonWhoGotClicked.Enabled = false;
            m_TurnsPlayed++;
            checkGameStatusAfterMove();
        }


        static private Font changeFontSize(Font font, float fontSize)
        {
            if (font != null)
            {
                float currentSize = font.Size;
                if (currentSize != fontSize)
                {
                    font = new Font(font.Name, fontSize,
                    font.Style, font.Unit,
                    font.GdiCharSet, font.GdiVerticalFont);
                }
            }
            
            return font;
        }

        

        private void checkGameStatusAfterMove()
        {
            
            DialogResult usersAnswer;

            if (m_GameLogic.CheckForSequence() == true)
            {
                m_PlayersWhosPlayingTheGame[currentPlayerTurn()].Score++;
                string playerWhoWonTheRound = m_PlayersWhosPlayingTheGame[currentPlayerTurn()].Name;
                string AnnounceAWinnerMessage = string.Format(@"{0}{1}

{2}", playerWhoWonTheRound, k_AnnounceAWinnerMessage,k_AnotherRoundQuestion);
                initPlayersScoreLabelOnForm();
              usersAnswer = MessageBox.Show(AnnounceAWinnerMessage, k_winHeader, MessageBoxButtons.YesNo);
               parseUserAnswer(usersAnswer);
            }

            else if(m_GameLogic.CheckForADraw(m_TurnsPlayed))
            {
                
                string tieMessage = string.Format(@"{0}
{1}", k_AnnounceTieGame, k_AnotherRoundQuestion);
               usersAnswer = MessageBox.Show(tieMessage, k_TieHeader, MessageBoxButtons.YesNo);
                parseUserAnswer(usersAnswer);
            }

           else if (m_GameMode == eGameModeOptions.SINGLE_PLAYER && (int)eTurn.SecondPlayerTurn == currentPlayerTurn())
            {
                computerTurn();
            }
        }


        private void parseUserAnswer(DialogResult i_IsUserWishesToContinue)
        {
            switch(i_IsUserWishesToContinue)
            {
                case DialogResult.Yes:
                    m_GameLogic.CleanBoard();
                    resetButtons();
                    m_TurnsPlayed = 0;
                    break;

                case DialogResult.No:
                    endGame();
                    break;
            }
        }

        private void resetButtons()
        {

            foreach(ButtonCell button in m_Buttons)
            {
                button.Font = SystemFonts.MessageBoxFont;
                button.Text = string.Empty;
                button.Enabled = true;
            }
        }
        

        private void computerTurn()
        {
            m_MoveToImplment = m_GameLogic.getNextMoveForComputer();
            m_GameLogic.ImplementMove(m_MoveToImplment,m_TurnsPlayed);
            updateButtons(m_MoveToImplment);
        }

        private ButtonCell findButton(NextMove i_MoveMadeByTheComputer)
        {
            ButtonCell buttonToReturn = null;

            foreach(ButtonCell button in m_Buttons)
            {
                if(button.Row == i_MoveMadeByTheComputer.Row && button.Col == i_MoveMadeByTheComputer.Col)
                {
                    buttonToReturn = button;
                    break;
                }
            }

            return buttonToReturn;
        }



        private void updateButtons(NextMove i_ComputerMove)
        {

            ButtonCell buttonWhoGotClickedByTheComputer = findButton(i_ComputerMove);
            buttonWhoGotClickedByTheComputer.Text = m_PlayersWhosPlayingTheGame[currentPlayerTurn()].PlayerSymbol.ToString();
            buttonWhoGotClickedByTheComputer.Font = changeFontSize(buttonWhoGotClickedByTheComputer.Font
                , buttonWhoGotClickedByTheComputer.Font.Size * 4);
            buttonWhoGotClickedByTheComputer.Enabled = false;
            m_TurnsPlayed++;
            checkGameStatusAfterMove();
        }

        private void initGameSetting(SettingsForm i_SettingsForm)
        {

           Player Player1 = new Player(i_SettingsForm.FirstPlayerName, eSymbol.X);
           m_PlayersWhosPlayingTheGame.Add(Player1);

            switch (i_SettingsForm.Opponnent())
            {
                case eOpponnent.Human:
                    Player humanPlayer = new Player (i_SettingsForm.GetHumanName(),eSymbol.O);
                    m_PlayersWhosPlayingTheGame.Add(humanPlayer);
                    m_GameMode = eGameModeOptions.MULTI_PLAYER;
                    break;

                case eOpponnent.Computer:
                    Player computerPlayer = new Player(i_SettingsForm.GetComputerName(), eSymbol.O);
                    m_PlayersWhosPlayingTheGame.Add(computerPlayer);
                    m_GameMode = eGameModeOptions.SINGLE_PLAYER;
                    break;
            }

            initPlayersScoreLabelOnForm();
        }


        private void initPlayersScoreLabelOnForm()
        {
            this.labelFirstPlayerScore.Text = string.Format("{0}{1}{2}{3}", m_PlayersWhosPlayingTheGame[(int)ePlayers.FirstPlayer].Name
                , ":", " ", m_PlayersWhosPlayingTheGame[(int)ePlayers.FirstPlayer].Score);
            this.labelSecondPlayerScore.Text = string.Format("{0}{1}{2}{3}", m_PlayersWhosPlayingTheGame[(int)ePlayers.SecondPlayer].Name,
                ":", " ", m_PlayersWhosPlayingTheGame[(int)ePlayers.SecondPlayer].Score);
        }


        private void endGame()
        {
            string finalMessage = string.Format(@"{0}
           
             {1}          {2}", k_QuitGameMessage, labelFirstPlayerScore.Text, labelSecondPlayerScore.Text);
            MessageBox.Show(finalMessage);
            this.Close();
        }

        private void TicTacToeUI_Load(object sender, EventArgs e)
        {

        }
    }
}
