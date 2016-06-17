namespace MonopolyInterview.Domain
{
    internal class GoSquare : Square
    {
        public GoSquare() : base("Go Square")
        {
        }

        protected override void PassOver(Player player)
        {
            base.PassOver(player);
            player.Balance += 200;
        }
    }
}