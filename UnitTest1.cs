using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataTennisGame
{
    public class TennisGameTest
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void Setup()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void LoveAll()
        {
            var expectedScore = "Love All";
            ScoreShouldBe(expectedScore);
        }

        private void ScoreShouldBe(string expectedScore)
        {
            Assert.AreEqual(expectedScore, _tennisGame.GetScore());
        }

        [Test]
        public void FifteenLove()
        {
            _tennisGame.FirstPlayerGotScore();
            Assert.AreEqual("Fifteen Love", _tennisGame.GetScore());
        }
    }
}