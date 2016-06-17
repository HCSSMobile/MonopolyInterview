namespace MonopolyInterview.Domain
{
    internal class IncomeTaxSquare : Square
    {
        public IncomeTaxSquare() : base("Income Tax Square")
        {
        }

        protected override Square LandOn(Player player)
        {
            if (player.Balance >= 2000)
            {
                player.Balance -= 200;
            }
            else
            {
                player.Balance -= player.Balance / 10;
            }

            return base.LandOn(player);
        }
    }
}