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
        private readonly int r_Row;
        private readonly int r_Col;

        internal ButtonCell(int i_Row, int i_Col)
        {
            r_Row = i_Row;
            r_Col = i_Col;
        }

       public int Row
        {
            get
            {
                return r_Row;
            }
        }

        public int Col
        {
            get
            {
                return r_Col;
            }

              
        }

    }

}
