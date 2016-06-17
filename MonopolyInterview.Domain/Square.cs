using System;

namespace MonopolyInterview.Domain
{
    public class Square
    {
        public virtual string Name { get; private set; }
        public virtual Square NextSquare { get; set; }

        public Square(string name)
        {
            Name = name;
        }

        public virtual Square Move(Player player, int numSquares)
        {
            if (numSquares == 0)
            {
                PassOver(player);
                return LandOn(player);
            }

            if(player.CurrentSquare != this)
                this.PassOver(player);

            if (NextSquare == null)
                throw new ApplicationException("Moving from a square that has no next square");

            return NextSquare.Move(player, numSquares - 1);
        }

        protected virtual void PassOver(Player player)
        {
        }

        protected virtual Square LandOn(Player player)
        {
            player.CurrentSquare = this;
            return this;
        }
    }
}
