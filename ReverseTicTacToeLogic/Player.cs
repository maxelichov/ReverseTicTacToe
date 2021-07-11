using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTicTacToeLogic
{
    public class Player
    {
        private readonly string r_Name;
        private int m_Score;
        private readonly eSymbol m_PlayerSymbol;

        public Player(string i_Name, eSymbol i_Symbol)
        {
            r_Name = i_Name;
            m_PlayerSymbol = i_Symbol;
        }


        public eSymbol PlayerSymbol
        {
            get
            {
                return m_PlayerSymbol;
            }
        }

        public int Score
        {
            set
            {
                m_Score++;
            }

            get
            {
                return m_Score;
            }
        }

        public string Name
        {
            get
            {
                return r_Name;
            }
        }
    }

}
