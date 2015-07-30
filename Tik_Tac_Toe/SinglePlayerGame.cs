using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tac_Toe
{
    class SinglePlayerGame : Game
    {
        //Difficulties
        public const int EasyLevel = 0;
        public const int MediumLevel = 1;
        public const int HardLevel = 2;

        //True if it is user's time to make a move
        bool isUserChance; 
        int userIndex;
        int difficulty;

        

        public SinglePlayerGame(String playerName, int userIndex, int difficulty)
        {
            isUserChance = true;
            this.userIndex = userIndex;
            setPlayer(userIndex, new Player(playerName));

            //AI
            this.difficulty = difficulty;
            setPlayer(userIndex * (-1), new Player("Computer"));
        }

        //Mark the move
        public override bool updateMove(int row, int col)
        {
            if (table[row, col] != 0 || !isUserChance)
                return false;
            //block doing another move
            isUserChance = false;

            updateMove(row, col, userIndex); //Mark the moves

            callUpdate(); //Update Interface

            //call an AI move

            return true;
        }

        private void updateAIMove()
        {
            int[,] grid = table;
            //
        }
    }
}
