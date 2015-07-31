using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tik_Tac_Toe;

namespace Tik_Tac_Toe_Test
{
    
    [TestClass]
    public class Test_Game //to Test the logical game
    {
        [TestMethod]
        public void CreateGame()
        {
            Game game = new MultiplayerOfflineGame();
            Assert.AreEqual(0, game.getPlayer(-1).points);
            Assert.AreEqual(0, game.getPlayer(1).points);
        }
    }
}
