namespace KataTennisGame
{
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