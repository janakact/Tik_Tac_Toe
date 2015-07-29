using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tac_Toe
{
    class Game
    {
        protected int[,] table;
        private int nextPlayerId; // 1 or -1
        protected Player[] players = new Player[2];
        public event EventHandler Update;
        protected int winner = 0;

        public Game()
        {
            table = new int[3, 3];
            nextPlayerId = 1;
            callUpdate();
            players[0] = new Player("Player1");
            players[1] = new Player("Player2");
        }

        public Player getPlayer(int i)
        {
            if (i == 1) return players[1];
            else if (i == -1) return players[0];
            return null;
        }

        public void setPlayers(Player p1, Player p2)
        {
            players[0] = p1;
            players[1] = p2;
        }

        public int[,] getTable()
        {
            return table;
        }


        //Check for winner
        private int calculateWinner()
        {
            //Algorithm to check winners
            int total3 = 0, total4 = 0, total = 0;
            for (int i = 0; i < 3; i++)
            {
                int total1 = 0, total2 = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (table[i, j] != 0)
                        total += 1;

                    total1 += table[i, j];
                    total2 += table[j, i];
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
                total3 += table[i, i];
                total4 += table[i, 2 - i];

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
            return winner;
        }

        //Update points and calculate is there a winner
        private void updatePointsAndCalculateWinner()
        {
            int newWinner = calculateWinner();
            //if Someone has win increase his points
            if (newWinner != winner && newWinner != 0)
            {
                winner = newWinner;
                getPlayer(winner).points += 1;
            }
        }

        //Mark the move of the playerId
        protected void updateMove(int row, int col, int playerId)
        {
            table[row, col] = playerId;
        }

        //Mark the move
        public bool updateMove(int row, int col)
        {
            if (table[row, col] != 0)
                return false;

            updateMove(row, col, nextPlayerId);
            nextPlayerId *= (-1);
            updatePointsAndCalculateWinner();
            callUpdate();
            return true;
        }

        public void reset(bool full)
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
            callUpdate();
        }

        private void callUpdate()
        {
            if (Update != null)
            {
                Update(this, EventArgs.Empty);
            }
        }



    }


}