using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using log4net;

namespace Tik_Tac_Toe
{
    public abstract class Game
    {

        private static readonly ILog logger = LogManager.GetLogger(typeof(Game));

        //Game states define
        public const int GoingOn = 0,
                            Draw = 2,
                            Win = 10,
                            WaitingForConnection = 100,
                            Disconected = 200;

        protected int[,] table;
        

        private Player[] players = new Player[2];
        private int drawCount = 0;  //Number of drows
        private int winner = 0; // 0 game is going on,
        public event EventHandler Update;



        //States
        protected int state;

 
        public Game()
        {
            logger.Info("Creating Game");
            table = new int[3, 3];
            state = Game.GoingOn;
            logger.Info("Game Created");
        }

        //Abstract methods
        //Mark the move
        public abstract bool updateMove(int row, int col);

        public Player getPlayer(int i)
        {
            logger.Info("Player " + i + " is read");
            if (i == 1) return players[1];
            else if (i == -1) return players[0];
            return null;
        }

        public int getDrawCount()
        {
            return drawCount;
        }

        public void setPlayer(int i, Player player)
        {
            if(player==null)
            {
                logger.Error("Null player add request");
            }
            logger.Info("Player " + i + " added name:" + player.name + " points:" + player.points);
            if (i == 1) players[i] = player;
            else if (i == -1) players[0] = player;
        }

        public void setPlayers(Player p1, Player p2)
        {
            logger.Info("setting players");
            setPlayer(-1, p1);
            setPlayer(1, p2);
        }

        public int[,] getTable()
        {
            logger.Info("Read the table");
            return table;
        }


        //Check for winner
        protected static int calculateWinner(int[,] grid)
        {

            //logger.Info("Calculating winner");
            //Algorithm to check winners
            int total3 = 0, total4 = 0, total = 0;
            for (int i = 0; i < 3; i++)
            {
                int total1 = 0, total2 = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] != 0)
                        total += 1;

                    total1 += grid[i, j];
                    total2 += grid[j, i];
                }

                //check for cross lines
                if (total1 == -3 || total2 == -3)
                {
                    return -1;
                }
                if (total1 == 3 || total2 == 3)
                {
                    return 1;
                }
                total3 += grid[i, i];
                total4 += grid[i, 2 - i];

            }

            //check for rows and columns
            if (total3 == -3 || total4 == -3)
            {
                return -1;
            }
            if (total3 == 3 || total4 == 3)
            {
                return 1;
            }
            if (total == 9) return 2; // 2 stands for drow

            return 0;
        }

        public int getWinner()
        {
            logger.Info("Read the winner");
            return winner;
        }

        //Update points and calculate is there a winner
        protected void updatePointsAndCalculateWinner()
        {
            int newWinner = calculateWinner(table);
            //if Someone has win increase his points
            if (newWinner != winner)
            {
                logger.Info("Winner changed newWinner:"+newWinner);
                winner = newWinner;
                if (winner != 2 && winner != 0)
                {
                    getPlayer(winner).points += 1;
                    state = Game.Win;
                }

                if (winner == 2)
                {
                    drawCount++;
                    logger.Info("Draw Count increased") ;
                    state = Game.Draw;
                }
            }
        }

        //Mark the move of the playerId
        protected void updateMove(int row, int col, int playerId)
        {
            logger.Info("Move updated row:" + row + " col:" + col + " playerId:" + playerId);
            //if(getWinner==)
            table[row, col] = playerId;
            updatePointsAndCalculateWinner(); //Calculate points
        }

        //return state
        public int getState()
        {
            return state;
        }

        public virtual void reset(bool full)
        {
            table = new int[3, 3];
            winner = 0;

            //if it is a full reset clear the points also
            if (full)
            {
                getPlayer(1).points = 0;
                getPlayer(-1).points = 0;
            }

            //Finally update Interface
            logger.Info("Game Reset full:"+full);
            callUpdate();
        }

        public void setState(int s)
        {
            state = s;
        }

        protected void callUpdate()
        {
            if (Update != null)
            {
                logger.Info("Interface Update requests");
                Update(this, EventArgs.Empty);
            }
            else
                logger.Error("No listner to do the interface update");
        }



    }


}