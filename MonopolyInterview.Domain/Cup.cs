using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyInterview.Domain
{
    public class Cup : IRollable
    {
        public IList<Die> Dice { get; }

        public Cup()
        {
            Dice = new List<Die>();
        }

        public Cup(int numDice) : this()
        {
            for(var i=0;i<numDice;i++)
                Dice.Add(new Die(6));
        }

        public int Roll()
        {
            return Dice.Sum(die => die.Roll());
        }

        public bool IsDoubles()
        {
            if (Dice.Count <= 1) return false;
            var firstValue = Dice[0].LastRoll;
            return Dice.All(die => die.LastRoll == firstValue);
        }
    }
}
