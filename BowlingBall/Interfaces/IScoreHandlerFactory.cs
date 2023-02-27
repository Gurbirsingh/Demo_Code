using BowlingBall.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Interfaces
{
    public interface IScoreHandlerFactory
    {
        IScoreHandler GetScoreHandler(ScoreType eventType);
        
    }
}
