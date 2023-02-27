using BowlingBall.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Implementation
{
    public class Score : IScore
    {
        public readonly IScoreHandlerFactory _scoreHandlerFactory;
        public Score(IScoreHandlerFactory scoreHandlerFactory) { 
             _scoreHandlerFactory= scoreHandlerFactory;
        }
        public int GetScore(int[] rolls)
        {
            var score = 0;
            int rollIndex = 0;

            for (var frame = 0; frame < 10; frame++)
            {
                if (IsStrike(rolls,rollIndex))
                {
                    var handler= _scoreHandlerFactory.GetScoreHandler(ScoreType.strike);
                    score += handler.GetScore(rolls, rollIndex);                    
                    rollIndex += 1;
                }
                else if (IsSpare(rolls,rollIndex))
                {
                    var handler = _scoreHandlerFactory.GetScoreHandler(ScoreType.spare);
                    score += handler.GetScore(rolls, rollIndex);                    
                    rollIndex += 2;
                }
                else
                {
                    var handler = _scoreHandlerFactory.GetScoreHandler(ScoreType.standard);
                    score += handler.GetScore(rolls, rollIndex);
                    rollIndex += 2;
                }
            }
            return score;
        }
        private bool IsSpare(int[] rolls,int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
        }
        private bool IsStrike(int[] rolls,int rollIndex)
        {
            return rolls[rollIndex] == 10;
        }
    }
}
