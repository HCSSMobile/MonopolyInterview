namespace MonopolyInterview.Domain
{
    internal class GoToJailSquare : Square
    {
        private Square jailSquare;
        public GoToJailSquare(Square jailSquare) : base("Go to Jail Square")
        {
            this.jailSquare = jailSquare;
        }

        protected override Square LandOn(Player player)
        {
            player.GoToJail(jailSquare);
            return jailSquare;
        }
    }
}