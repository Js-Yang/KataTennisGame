using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataTennisGame
{
    public class Class1
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

    public class TennisGame
    {
        private int _firstPlayerScore;

        public string GetScore()
        {
            if (_firstPlayerScore == 1)
            {
                return "Fifteen Love";
            }

            return "Love All";
        }

        public void FirstPlayerGotScore()
        {
            _firstPlayerScore++;
        }
    }
}