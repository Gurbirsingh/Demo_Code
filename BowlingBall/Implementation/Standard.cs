using BowlingBall.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Implementation
{
    public class Standard : IScoreHandler
    {
        public int GetScore(int[] rolls, int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1];
        }
    }
}
