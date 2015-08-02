using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Tik_Tac_Toe
{
    public class SinglePlayerGame : Game
    {
        //Difficulties
        public const int   EasyLevel = 0,
                           MediumLevel = 1,
                           HardLevel = 2;

        //True if it is user's time to make a move
        public bool isUserChance;
        public int userIndex;

        bool userFirst;
        int difficulty;

        //logger
        private static readonly ILog logger = LogManager.GetLogger(typeof(SinglePlayerGame));

        public SinglePlayerGame(String playerName, int userIndex, int difficulty)
        {
            logger.Info("Creating Single Player Game. difficulty:"+difficulty);
            userFirst = true;
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
            return true;
        }

        private bool updateAIMove()
        {
            if (isUserChance) return false;
            //Make a clone
            int[,] grid = (int[,]) table.Clone();

            logger.Info("Making a ai move");
            int highestQ = -1;
            //int move = 0;
            List<int> moveList = new List<int>(); //List of a 
            //Loop through and find the best move
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++ )
                {
                    if (grid[i,j] == 0)
                    {
                        int q = getMoveQuality(i * 3 + j, true, grid);
                        logger.Debug("value for " + i*3+j + " = " + q);
                        if(q>highestQ)
                        {
                            highestQ = q;
                            moveList.Clear();
                            moveList.Add( i * 3 + j);
                        }
                        else if(q==highestQ)
                        {
                            moveList.Add(i * 3 + j);
                        }
                    }
                }
            if(highestQ!=-1)
            {
                int move = moveList[(new Random()).Next(0, moveList.Count)];

                if (highestQ < (3-difficulty)) //Make a random move
                {
                    move = (new Random()).Next(0, 9);
                    while(grid[move/3,move%3]!=0)
                        move = (new Random()).Next(0, 9);
                }

                updateMove(move / 3, move % 3, userIndex * (-1));
                callUpdate();       //Update Interface
                isUserChance = true;

                return true;
            }
            return false;
        }


        //Returns 0 = lose sure, 1=both, 2=win sure 
        private int getMoveQuality(int move, bool activeTurn, int[,] grid)
        {
            //Assume that grid[move] ==0 
            if(activeTurn)      //If it is a AI move
            {

                int win;
                grid[move / 3, move % 3] = userIndex * (-1);
                win = calculateWinner(grid);
                if (win == userIndex * (-1)) { grid[move / 3, move % 3] = 0; return 2; } //Clear and return

                if (win == 2) { grid[move / 3, move % 3] = 0; return 1; } 

                int lowest = 2; //Lowest value
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
                if (win == userIndex) { grid[move/3, move%3] =0; return 0;} //If user win return
                if (win == 2) { grid[move / 3, move % 3] = 0; return 1; } 


                int highest = 0; //highest value
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                    {
                        if (grid[i, j] == 0)
                        {
                            int q = getMoveQuality(i*3+j,true,grid);
                            if (q > highest) highest = q;
                        }
                    }
                //clear and return
                grid[move / 3, move % 3] = 0; 
                return highest;
            }
        }

        public override void reset(bool full)
        {
            base.reset(full);
            isUserChance = userFirst;
            userFirst = !userFirst;

            if(!isUserChance)
            {
                updateAIMove();     //call an AI move
            }
        }
    }
}
