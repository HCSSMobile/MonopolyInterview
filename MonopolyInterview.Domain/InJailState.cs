namespace MonopolyInterview.Domain
{
    public class InJailState : JailState
    {
        private int rollCount = 0;

        public override string TakeTurn(Player player, IRollable dice)
        {
            Square newSquare;
            rollCount++;
            int roll = dice.Roll();
            if (dice.IsDoubles())
            {
                newSquare = player.Move(roll);
            }
            else if (rollCount >= 3)
            {
                player.Balance -= 50;
                player.LeaveJail();
                newSquare = player.Move(roll);
            }
            else
            {
                newSquare = player.CurrentSquare;
            }

            return player.Name + " rolled a " + roll + " current square is now " + newSquare.Name + ", balance is $" +
                   player.Balance;
        }
    }
}
