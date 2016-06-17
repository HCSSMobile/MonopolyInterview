using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyInterview.Domain
{
    public class FreeState : JailState
    {
        public override string TakeTurn(Player player, IRollable dice)
        {
            var roll = dice.Roll();
            var newSquare = player.Move(roll);
            return player.Name + " rolled a " + roll + " current square is now " + newSquare.Name + ", balance is $" + player.Balance;
        }
    }
}
