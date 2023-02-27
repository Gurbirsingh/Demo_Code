using System;
using BowlingBall.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        private Game game;


        [TestInitialize]
        public void Init()
        {            
            game = new Game(new Roll(),new Score(new ScoreHandlerFactory()));
        }        

        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            RollMany(0, 20);
            Assert.AreEqual(0, game.GetScore());
        }

        [TestMethod]
        public void CanRollAllOnes()
        {
            RollMany(1, 20);
            Assert.AreEqual(20, game.GetScore());
        }

        [TestMethod]
        public void CanRollSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(0,17);
            Assert.AreEqual(16, game.GetScore());
        }

        [TestMethod]
        public void CanRollStrike()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(0, 16);
            Assert.AreEqual(24, game.GetScore());
        }
        [TestMethod]
        public void CanRollPerfectGame()
        {            
            RollMany(10, 12);
            Assert.AreEqual(300, game.GetScore());
        }

        private void RollMany(int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
