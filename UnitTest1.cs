using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataTennisGame
{
    public class Class1
    {
        [Test]
        public void LoveAll()
        {
            var tennisGame = new tennisGame();
            var score = tennisGame.GetScore();
            Assert.AreEqual("Love All", score);
        }

        [Test]
        public void FiteenLove()
        {
            var tennisGame = new tennisGame();
            var score = tennisGame.GetScore();
            Assert.AreEqual("Fiteen Love", score);
        }
    }

    public class tennisGame
    {
        public string GetScore()
        {
            return "Love All";
        }
    }
}