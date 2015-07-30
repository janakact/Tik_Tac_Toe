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
            callUpdate();       //Update Interface

            updateAIMove();     //call an AI move
            callUpdate();       //Update Interface
            isUserChance = true;
            return true;
        }

        private bool updateAIMove()
        {
            //Make a clone
            int[,] grid = (int[,]) table.Clone();

            int highestQ = -1;
            int move = 0;
            //Loop through and find the best move
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++ )
                {
                    if (grid[i,j] == 0)
                    {
                        int q = getMoveQuality(i * 3 + j, true, grid);
                        if(q>highestQ)
                        {
                            highestQ = q;
                            move = i * 3 + j;
                        }
                    }
                }
            if(highestQ!=-1)
            {
                updateMove(move / 3, move % 3, userIndex * (-1));
                return true;
            }
            return false;
        }


        //Returns 0 = lose, 1=both, 2=win sure
        private int getMoveQuality(int move, bool activeTurn, int[,] grid)
        {
            //Assume that grid[move] ==0 
            if(activeTurn)      //If it is a AI move
            {
                grid[move / 3, move % 3] = userIndex * (-1);
                int win = calculateWinner(grid);
                if (win == userIndex * (-1)) { grid[move / 3, move % 3] = 0; return 2; } //Clear and return
                if (win == userIndex) { grid[move/3, move%3] =0; return 0;}

                int lowest = 1; //Lowest value
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                    {
                        if (grid[i, j] == 0)
                        {
                            int q = getMoveQuality(i*3+j,false,grid);
                            if (q < lowest) lowest = q;
                        }
                    }
                //clear and return
                grid[move / 3, move % 3] = 0; 
                return lowest;
            }
            else{   //User move
                grid[move/3, move%3] = userIndex;
                int win = calculateWinner(grid);
                if (win == userIndex * (-1)) { grid[move / 3, move % 3] = 0; return 2; } //Clear and return
                if (win == userIndex) { grid[move/3, move%3] =0; return 0;}


                int highest = 1; //Lowest value
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                    {
                        if (grid[i, j] == 0)
                        {
                            int q = getMoveQuality(i*3+j,false,grid);
                            if (q > highest) highest = q;
                        }
                    }
                //clear and return
                grid[move / 3, move % 3] = 0; 
                return highest;
            }
        }
    }
}
