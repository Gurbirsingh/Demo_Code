using BowlingBall.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Implementation
{
    public class Roll: IRoll
    {
        public int[] rolls { get; set; }
        //public static int[] rolls = new int[21];
        private int current = 0;
        public Roll() {
            rolls=new int[21];
        }

        public void RollTheBall(int pins)
        {
            rolls[current++] = pins;
        }

    }
}
