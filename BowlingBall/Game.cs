using BowlingBall.Implementation;
using BowlingBall.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    { 
        private readonly IRoll _roll;
        private readonly IScore _score;
        public Game(IRoll roll,IScore score)
        {
            _roll = roll;
            _score = score;
        }

        public void Roll(int pins)
        {
            _roll.RollTheBall(pins);            
        }

        public int GetScore()
        {
            return _score.GetScore(_roll.rolls);
        }        
    }
}
