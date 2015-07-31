using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using log4net;

namespace Tik_Tac_Toe
{
    class Game
    {

        private static readonly ILog logger = LogManager.GetLogger(typeof(Game));

        protected int[,] table;
        

        private int nextPlayerId; // 1 or -1
        protected Player[] players = new Player[2];
        protected int winner = 0; // 0 game is going on,
        public event EventHandler Update;

 
        public Game()
        {
            logger.Info("Creating Game");
            table = new int[3, 3];
            nextPlayerId = 1;
            setPlayers(new Player("Player1"), new Player("Player2"));
            logger.Info("Game Created");
        }

        public Player getPlayer(int i)
        {
            logger.Info("Player " + i + " is read");
            if (i == 1) return players[1];
            else if (i == -1) return players[0];
            return null;
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

            logger.Info("Calculating winner");
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
                if (newWinner != 2 && newWinner != 0)
                {
                    getPlayer(winner).points += 1;
                }
            }
        }

        //Mark the move of the playerId
        protected void updateMove(int row, int col, int playerId)
        {
            logger.Info("Move updated row:" + row + " col:" + col + " playerId:" + playerId);
            table[row, col] = playerId;
            updatePointsAndCalculateWinner(); //Calculate points
        }

        //Mark the move
        public virtual bool updateMove(int row, int col)
        {
            if (table[row, col] != 0)
            {
                logger.Warn("Requested a imposible move");
                return false;
            }

            updateMove(row, col, nextPlayerId);
            nextPlayerId *= (-1);
            callUpdate();
            return true;
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