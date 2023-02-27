using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Interfaces
{
    public interface IScoreHandler
    {
        int GetScore(int[] rolls,int rollIndex);
    }
}
