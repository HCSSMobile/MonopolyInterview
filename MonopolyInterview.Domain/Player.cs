namespace MonopolyInterview.Domain
{
    public class Player
    {
        public string Name { get; private set; }
        public Square CurrentSquare { get; set; }
        public int Balance { get; set; }

        public Player(string name, Square startingSquare, int startingBalance)
        {
            this.Name = name;
            CurrentSquare = startingSquare;
            Balance = startingBalance;
        }
        public string TakeTurn(IRollable dice)
        {
            var roll = dice.Roll();
            var newSquare = CurrentSquare.Move(this, roll);
            return Name + " rolled a " + roll + " current square is now " + newSquare.Name + ", balance is $" + Balance;
        }
    }
}
