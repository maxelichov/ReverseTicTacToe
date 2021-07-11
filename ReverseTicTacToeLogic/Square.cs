using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTicTacToeLogic
{
    public class Square
    {
        private int m_Row;
        private int m_Col;
        private eSymbol m_Symbol = eSymbol.EMPTY;



        
        public Square(int i_Row, int i_Col)
        {
            m_Row = i_Row;
            m_Col = i_Col;
        }


        public int Row
        {
            set
            {
                m_Row = value;
            }
            get
            {
                return m_Row;
            }
        }


        public int Col
        {
            set
            {
                m_Col = value;
            }
            get
            {
                return m_Col;
            }
        }


        public eSymbol Symbol
        {
            set
            {
                m_Symbol = value;
            }

            get
            {
                return m_Symbol;
            }
        }
    }
}
