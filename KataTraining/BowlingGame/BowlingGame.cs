namespace KataTraining.BowlingGame
{
    public class BowlingGame
    {
        private List<int> _rolls = new List<int>(21);
        public int GetScore()
        {
            var rollIndex = 0;
            var score = 0;
            for (int turn = 0; turn < 10; turn++)
            {
                if (isStrike(rollIndex))
                {
                    score += calcSrike(rollIndex);
                    rollIndex++;

                }
                else if (isSpare(rollIndex)) //spare
                {
                    score += calcSpare(rollIndex);
                    rollIndex += 2;
                }
                else
                {
                    score += calcRegular(rollIndex);
                    rollIndex += 2;
                }
            }
            return score;
        }
        private bool isSpare(int rollIndex)
        {
            return _rolls[rollIndex] + _rolls[rollIndex + 1] == 10;
        }


        private int calcRegular(int rollIndex)
        {
            return _rolls[rollIndex] + _rolls[rollIndex + 1];
        }
        private bool isStrike(int rollIndex)
        {
            return _rolls[rollIndex] == 10;
        }

        private int calcSpare(int rollIndex)
        {
            return calcRegular(rollIndex) + _rolls[rollIndex + 2];
        }
        private int calcSrike(int rollIndex)
        {
            return _rolls[rollIndex] + _rolls[rollIndex + 1] + _rolls[rollIndex + 2];
        }

        public void Roll(int currentRoll)
        {
            _rolls.Add(currentRoll);
            return;
        }
    }
}