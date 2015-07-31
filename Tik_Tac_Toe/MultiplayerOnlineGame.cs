using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace Tik_Tac_Toe
{
    class MultiplayerOnlineGame:Game
    {
        //logger
        private static readonly ILog logger = LogManager.GetLogger(typeof(SinglePlayerGame));

        public override bool updateMove(int row, int col)
        {
            if (table[row, col] != 0)
            {
                logger.Warn("Requested a imposible move");
                return false;
            }
            return false;
        }
    }
}
