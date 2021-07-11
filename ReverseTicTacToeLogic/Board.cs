using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReverseTicTacToeLogic
{
    public class Board
    {
        // $G$ CSS-999 (-3) this member should be readonly
        private Square[,] m_GameBoard;


        private readonly int r_BoardSize;
        private StringBuilder m_ViewBoard;
        private readonly List<List<Square>> m_BoardRows;
        private readonly List<List<Square>> m_BoardCols;
        private readonly List<List<Square>> m_BoardDiagonal;

        public Board(int i_Size)
        {
            r_BoardSize = i_Size;
            m_GameBoard = new Square[i_Size, i_Size];
            m_BoardRows = new List<List<Square>>(r_BoardSize);
            m_BoardCols = new List<List<Square>>(r_BoardSize);
            m_BoardDiagonal = new List<List<Square>>(2);

            InitBoard();
            InitRowList();
            InitColList();
            InitDiagonalList();
        }

        public bool SquareIsOcupied(int i_Row, int i_Col)
        {
            return (m_GameBoard[i_Row - 1, i_Col - 1].Symbol != eSymbol.EMPTY);
        }

        public static bool IsBoardSizeValid(int i_BoardSize)
        {
            int minSize = (int)Enum.GetValues(typeof(eBoardSize)).Cast<eBoardSize>().First();
            int maxSize = (int)Enum.GetValues(typeof(eBoardSize)).Cast<eBoardSize>().Last();

            return (i_BoardSize >= minSize && i_BoardSize <= maxSize);
        }

        public bool CheckForDraw(int i_NumOfTurnPlayed)
        {
            int matrixOrder = r_BoardSize;

            return (i_NumOfTurnPlayed == matrixOrder * matrixOrder);
        }

        public void InitRowList()
        {
            for (int i = 0; i < r_BoardSize; i++)
            {
                List<Square> boardRow = new List<Square>();

                for (int j = 0; j < r_BoardSize; j++)
                {
                    boardRow.Add(m_GameBoard[i, j]);
                }

                m_BoardRows.Add(boardRow);
            }
        }

        public void InitColList()
        {
            for (int col = 0; col < r_BoardSize; col++)
            {
                List<Square> boardCol = new List<Square>();

                for (int row = 0; row < r_BoardSize; row++)
                {
                    boardCol.Add(m_GameBoard[row, col]);
                }

                m_BoardCols.Add(boardCol);
            }
        }

        public void InitDiagonalList()
        {
            List<Square> leftDiagonalList = new List<Square>();
            List<Square> rightDiagonalList = new List<Square>();

            for (int row = 0; row < r_BoardSize; row++)
            {
                for (int col = 0; col < r_BoardSize; col++)
                {
                    // left diagonal
                    if (row == col)
                    {
                        leftDiagonalList.Add(m_GameBoard[row, col]);
                    }

                    //right diagonal
                    if ((row + col) == (r_BoardSize - 1))
                    {
                        rightDiagonalList.Add(m_GameBoard[row, col]);
                    }
                }
            }

            m_BoardDiagonal.Add(leftDiagonalList);
            m_BoardDiagonal.Add(rightDiagonalList);
        }

        public void InitBoard()
        {
            for (int i = 0; i < r_BoardSize; i++)
            {
                for (int j = 0; j < r_BoardSize; j++)
                {
                    m_GameBoard[i, j] = new Square(i + 1, j + 1);
                }
            }
        }

        public int GetBoardSize()
        {
            return r_BoardSize;
        }

        public StringBuilder BuildBoard()
        {
            StringBuilder boardToPrint = new StringBuilder();
            StringBuilder seperationLine = new StringBuilder();

            seperationLine.Append('=', (m_GameBoard.GetLength(0) * 4) + 1);

            for (int i = 0; i < m_GameBoard.GetLength(0); i++)
            {
                boardToPrint.Append("   " + (i + 1));
            }

            boardToPrint.AppendLine();
            for (int i = 0; i < m_GameBoard.GetLength(0); i++)
            {
                boardToPrint.Append(i + 1);
                for (int j = 0; j < m_GameBoard.GetLength(1); j++)
                {
                    boardToPrint.Append("| ");
                    boardToPrint.Append((char)m_GameBoard[i, j].Symbol + " ");
                }

                boardToPrint.Append("|");
                boardToPrint.AppendLine();
                boardToPrint.Append(" " + seperationLine);
                boardToPrint.AppendLine();
            }

            return boardToPrint;
        }

        public List<Square> GetRow(int i_Row)
        {
            return m_BoardRows[i_Row];
        }


        public List<Square> GetCol(int i_Col)
        {
            return m_BoardCols[i_Col];
        }

        public List<Square> GetDiagonal(int i_DiagonalNum)
        {
            return m_BoardDiagonal[i_DiagonalNum];
        }

        public Square this[int i_Row, int i_Column]
        {
            get
            {
                return m_GameBoard[i_Row, i_Column];
            }
            set
            {
                m_GameBoard[i_Row, i_Column] = value;
            }
        }


        
        public bool MoveIsValid(NextMove io_Move)
        {
            return m_GameBoard[io_Move.Row - 1, io_Move.Col - 1].Symbol == eSymbol.EMPTY;
        }

        public void Clean()
        {
            for (int row = 0; row < r_BoardSize; row++)
            {
                for (int col = 0; col < r_BoardSize; col++)
                {
                    if (m_GameBoard[row, col].Symbol != eSymbol.EMPTY)
                    {
                        m_GameBoard[row, col].Symbol = eSymbol.EMPTY;
                    }
                }
            }
        }

        // $G$ CSS-028 (-3) method shouldn't include more then one return command.
        // $G$ CSS-013 (-3) Input parameters names should start with i_PascaleCase.
        public bool CheckForSequence(List<Square> io_CheckSequenceInList)
        {
            bool sequenceFound = true;
            eSymbol auxSquareSymbol = io_CheckSequenceInList[0].Symbol;

            for (int i = 1; i < r_BoardSize; i++)
            {
                if (auxSquareSymbol == eSymbol.EMPTY)
                {
                    return false;
                }

                else
                {
                    if (auxSquareSymbol != io_CheckSequenceInList[i].Symbol)
                    {
                        return false;
                    }
                }
            }

            return sequenceFound;
        }
    }
}
