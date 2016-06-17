using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyInterview.Domain
{
    public class Die : IRollable
    {
        private static readonly Random Generator = new Random();
        public int Sides { get; }
        public int LastRoll { get; private set; }

        public Die(int numSides)
        {
            Sides = numSides;
        }

        public int Roll()
        {
            LastRoll = Generator.Next(1, Sides + 1);
            return LastRoll;
        }

        public bool IsDoubles()
        {
            return false;
        }
    }
}
