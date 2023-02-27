using BowlingBall.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Implementation
{
    public class ScoreHandlerFactory : IScoreHandlerFactory
    {
        public IScoreHandler GetScoreHandler(ScoreType scoreType)
        {
            IScoreHandler handler;
            switch (scoreType)
            {
                case ScoreType.strike:
                    handler = new Strike();
                    break;
                case ScoreType.spare:
                    handler = new Spare();
                    break;
                case ScoreType.standard:
                    handler = new Standard();
                    break;
                default:
                    handler = null;
                    break;
            }
            return handler;
        }
    }
}
