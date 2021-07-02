using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTicTacToeLogic
{
    public class GameLogic
    {
        // $G$ CSS-999 (-3) this member should be readonly
        private NextMove m_Move = new NextMove();
        private Board m_GameBoard;


        private readonly int r_BoardSize;
        private Dictionary<int, List<Square>> m_RowDict;
        private Dictionary<int, List<Square>> m_ColDict;
        private Dictionary<int, List<Square>> m_DiagonalDict;
        private Random generateRowAndCol = new Random();

        public GameLogic(int i_BoardSize)
        {
            r_BoardSize = i_BoardSize;
            m_GameBoard = new Board(i_BoardSize);
            m_RowDict = new Dictionary<int, List<Square>>();
            m_ColDict = new Dictionary<int, List<Square>>();
            m_DiagonalDict = new Dictionary<int, List<Square>>();

            initDictionaries();
        }

        public NextMove getNextMoveForComputer()
        {
            int row;
            int col;

            do
            {
                row = generateRowAndCol.Next(1, r_BoardSize + 1);
                col = generateRowAndCol.Next(1, r_BoardSize + 1);
            } while (CheckIfTheSquareIsOcupied(row, col));

            m_Move.Row = row;
            m_Move.Col = col;

            return m_Move;
        }


        private void initDictionaries()
        {
            for (int i = 0; i < m_GameBoard.GetBoardSize(); i++)
            {
                m_RowDict.Add(i, m_GameBoard.GetRow(i));
                m_ColDict.Add(i, m_GameBoard.GetCol(i));
            }

            m_DiagonalDict.Add((int)eDiagonal.PRIMARY_DIAGONAL, m_GameBoard.GetDiagonal((int)eDiagonal.PRIMARY_DIAGONAL));
            m_DiagonalDict.Add((int)eDiagonal.SECONDARY_DIAGONAL, m_GameBoard.GetDiagonal((int)eDiagonal.SECONDARY_DIAGONAL));
        }


        public StringBuilder GetBoardFromLogic()
        {
            return m_GameBoard.BuildBoard();
        }

        public static bool CheckIfBoardSizeIsValid(int i_boardSize)
        {
            return Board.IsBoardSizeValid(i_boardSize);
        }

        public bool CheckForADraw(int i_NumOfTurnPlayed)
        {
            return m_GameBoard.CheckForDraw(i_NumOfTurnPlayed);
        }

        public void ImplementMove(NextMove i_Move, int i_Turn)
        {
            if (i_Turn % 2 == 0) // player1 turn.
            {
                m_GameBoard[i_Move.Row - 1, i_Move.Col - 1].Symbol = eSymbol.X;
            }
            else // player 2 turn
            {
                m_GameBoard[i_Move.Row - 1, i_Move.Col - 1].Symbol = eSymbol.O;
            }
        }

        public void CleanBoard()
        {
            m_GameBoard.Clean();
        }

        public bool CheckForSequence()
        {
            bool sequenceFound = false;
            List<Square> rowToCheck;
            List<Square> colToCheck;
            List<Square> primaryDiagonalToCheck;
            List<Square> secondaryDiagonalToCheck;

            m_DiagonalDict.TryGetValue((int)eDiagonal.PRIMARY_DIAGONAL, out primaryDiagonalToCheck);
            m_DiagonalDict.TryGetValue((int)eDiagonal.SECONDARY_DIAGONAL, out secondaryDiagonalToCheck);

            if (m_GameBoard.CheckForSequence(primaryDiagonalToCheck)
                || m_GameBoard.CheckForSequence(secondaryDiagonalToCheck))
            {
                return true;
            }

            for (int i = 0; i < r_BoardSize; i++)
            {
                m_RowDict.TryGetValue(i, out rowToCheck);
                m_ColDict.TryGetValue(i, out colToCheck);
                m_GameBoard.CheckForSequence(rowToCheck);
                m_GameBoard.CheckForSequence(colToCheck);

                if (m_GameBoard.CheckForSequence(rowToCheck) || m_GameBoard.CheckForSequence(colToCheck))
                {
                    return true;
                }
            }

            return sequenceFound;
        }
        public int GetBoardSize()
        {
            return r_BoardSize;
        }

        public bool CheckIfTheSquareIsOcupied(int i_Row, int i_col)
        {
            return m_GameBoard.SquareIsOcupied(i_Row, i_col);
        }

    }
}
