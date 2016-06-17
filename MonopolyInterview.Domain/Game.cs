using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyInterview.Domain
{
    public class Game
    {
        public IList<Player> Players { get; }
        private IRollable dice;
        private Square startingSquare;

        public Game(int numberOfPlayers)
        {
            Players = new List<Player>();
            dice = new Cup(2);
            BuildBoard();
            for(var i=1;i<=numberOfPlayers;i++)
            {
                Players.Add(new Player("Player " + i, startingSquare,1500));
            }
        }

        private void BuildBoard()
        {
            startingSquare = new GoSquare();
            var currentSquare = startingSquare;
            var jailSquare = new JailSquare();
            for(var i = 1; i <= 40; i++)
            {
                switch(i)
                {
                    case 4: currentSquare.NextSquare = new IncomeTaxSquare();
                        break;
                    case 10: currentSquare.NextSquare = jailSquare;
                        break;
                    case 30: currentSquare.NextSquare = new GoToJailSquare(jailSquare);
                        break;
                    case 38: currentSquare.NextSquare = new LuxuryTaxSquare();
                        break;
                    default:
                        currentSquare.NextSquare = new Square("Square " + i);
                        break;
                }
                currentSquare = currentSquare.NextSquare;
            }
            currentSquare.NextSquare = startingSquare;
        }

        public string PlayRound()
        {
            var roundOutput = new StringBuilder();
            foreach (var player in Players)
            {
                roundOutput.AppendLine(player.TakeTurn(dice));
            }
            return roundOutput.ToString();
        }

        public Player GetWinner()
        {
            if (Players.Count < 1)
                return null;

            var winner = Players[0];
            foreach (var player in Players)
            {
                if (player.Balance > winner.Balance)
                    winner = player;
            }
            return winner;
        }

    }
}
