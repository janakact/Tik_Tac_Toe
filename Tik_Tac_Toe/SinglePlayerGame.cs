using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tac_Toe
{
    class SinglePlayerGame : Game
    {
        bool isUserChance = false; //True if it is user's time to make a move

        public SinglePlayerGame():base()
        {

        }
        protected void updateMove(int row, int col, int playerId)
        {
            if (isUserChance)
            table[row, col] = playerId;
        }
    }
}
