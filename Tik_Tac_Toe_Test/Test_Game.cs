using System;

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tik_Tac_Toe;

namespace Tik_Tac_Toe_Test
{
    
    [TestClass]
    public class Test_Game //to Test the logical game
    {

        #region MultiplayerOfflineGame
        Game game;
        [TestMethod]
        public void CreateGame_MultiplayerOffline()
        {
            game = new MultiplayerOfflineGame("Name1", "Name1");
            Assert.AreEqual(0, game.getPlayer(-1).points);
            Assert.AreEqual(0, game.getPlayer(1).points);
        }
        [TestMethod]
        public void AddPlayers()
        {
            game = new MultiplayerOfflineGame("Name1", "Name1");
            game.setPlayer(1, new Player("Me"));
            game.setPlayer(-1, new Player("You"));
            Assert.AreEqual("Me", game.getPlayer(1).name);
            Assert.AreEqual("You", game.getPlayer(-1).name);
        }

        #endregion

        #region SinglePlayerGame1
        [TestMethod]
        public void createGame_SinglePlayer()
        {
            game = new SinglePlayerGame("Player1", 1, 0);
            Assert.AreEqual(0, game.getPlayer(-1).points);
            Assert.AreEqual(0, game.getPlayer(1).points);
            Assert.AreEqual("Computer", game.getPlayer(-1).name);
            Assert.AreEqual("Player1", game.getPlayer(1).name);

            game = new SinglePlayerGame("Player1", -1, 0);
            Assert.AreEqual(0, game.getPlayer(-1).points);
            Assert.AreEqual(0, game.getPlayer(1).points);
            Assert.AreEqual("Computer", game.getPlayer(1).name);
            Assert.AreEqual("Player1", game.getPlayer(-1).name);

        }
        [TestMethod]
        public void UpdateMove_SinglePlayer()
        {
    
            game = new SinglePlayerGame("Player1", 1, 0);
            game.updateMove(0, 0);
            int[,] table = game.getTable();
            Assert.AreEqual(1, table[0, 0]);

            bool aiMove = false;
            for (int i = 0; i < 9; i++)
            {
                if (table[i / 3, i % 3] == -1)
                {
                    aiMove = true;
                    break;
                }
            }
            Assert.AreEqual(true, aiMove);
        }

        [TestMethod]
        public void HardLevelPlayerWinOrDraw_SinglePlayer()
        {

            game = new SinglePlayerGame("Player1", 1, SinglePlayerGame.HardLevel);
            Random rnd = new Random();
            List<int> zeroList = new List<int>();
            //User cannot any random game
            while(game.getWinner()==0 && zeroList.Count!=0)
            {
                
                for(int i=0; i<9; i++)
                    if(game.getTable()[i/3, i%3]==0) zeroList.Add(i);

                int move = zeroList[rnd.Next(0, zeroList.Count)];
                zeroList.RemoveRange(0, zeroList.Count);
                game.updateMove(move / 3, move % 3);
            }
            Assert.AreNotEqual(1, game.getWinner(), "Lol");
        }
        #endregion
    }
}
