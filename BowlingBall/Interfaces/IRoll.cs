using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Interfaces
{
    public interface IRoll
    {
        int[] rolls { get; set; }
        void RollTheBall(int pins);
    }
}
