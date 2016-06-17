namespace MonopolyInterview.Domain
{
    public abstract class JailState
    {
        public abstract string TakeTurn(Player player, IRollable dice);
    }
}
