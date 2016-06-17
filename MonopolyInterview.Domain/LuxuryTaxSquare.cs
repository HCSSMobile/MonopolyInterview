namespace MonopolyInterview.Domain
{
    internal class LuxuryTaxSquare : Square
    {
        public LuxuryTaxSquare() : base("Luxury Tax Square")
        { }
        protected override Square LandOn(Player player)
        {
            player.Balance -= 75;
            return base.LandOn(player);
        }
    }
}