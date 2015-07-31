using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace Tik_Tac_Toe
{
    public class MultiplayerOfflineGame:Game
    {

        private static readonly ILog logger = LogManager.GetLogger(typeof(Game));
        private int nextPlayerId; // 1 or -1
        public MultiplayerOfflineGame():base()
        {
            logger.Info("creating a multiplayer game");
             nextPlayerId = 1;
        }

        public override bool updateMove(int row, int col)
        {
            if (table[row, col] != 0)
            {
                logger.Warn("Requested a imposible move");
                return false;
            }

            updateMove(row, col, nextPlayerId);
            nextPlayerId *= (-1);
            stateMessage = "Game is started";
            callUpdate();
            return true;
        }

        public override void reset(bool full)
        {
            base.reset(full);
            nextPlayerId = (new Random()).Next(0, 2);
            if (nextPlayerId == 0) nextPlayerId=-1;
        }
    }
}
