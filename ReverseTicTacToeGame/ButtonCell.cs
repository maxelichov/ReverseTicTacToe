using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReverseTicTacToeLogic;

namespace ReverseTicTacToeGame
{
    internal class ButtonCell : Button
    {
        private NextMove m_CellCoordinates;

        internal ButtonCell(byte i_Row, byte i_Col)
        {
            m_CellCoordinates.Row = i_Row;
            m_CellCoordinates.Col = i_Col;
        }

        internal NextMove CellCoordinates
        {
            get
            {
                return m_CellCoordinates;
            }
        }
    }

}
