namespace MonopolyInterview.Domain
{
    public class Player
    {
        public string Name { get; private set; }
        public Square CurrentSquare { get; set; }
        public int Balance { get; set; }
        private JailState jailState;

        public Player(string name, Square startingSquare, int startingBalance)
        {
            this.Name = name;
            CurrentSquare = startingSquare;
            Balance = startingBalance;
            jailState = new FreeState();
        }
        public string TakeTurn(IRollable die)
        {
            return jailState.TakeTurn(this, die);
        }

        public void LeaveJail()
        {
            jailState = new FreeState();
        }

        public void GoToJail(Square jailSquare)
        {
            jailState = new InJailState();
            CurrentSquare = jailSquare;
        }

        public Square Move(int spaces)
        {
            return CurrentSquare.Move(this, spaces);
        }
    }
}
