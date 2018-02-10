using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataTennisGame
{
    public class Class1
    {
        [Test]
        public void LoveAll()
        {
            var tennisGame = new TennisGame();
            var score = tennisGame.GetScore();
            Assert.AreEqual("Love All", score);
        }

        [Test]
        public void FiteenLove()
        {
            var tennisGame = new TennisGame();
            tennisGame.FirstPlayerGotScore();
            var score = tennisGame.GetScore();
            Assert.AreEqual("Fiteen Love", score);
        }
    }

    public class TennisGame
    {
        private int _player1Score;

        public string GetScore()
        {
            return "Love All";
        }

        public void FirstPlayerGotScore()
        {
            _player1Score++;
        }
    }
}