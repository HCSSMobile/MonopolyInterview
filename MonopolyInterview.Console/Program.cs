using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyInterview.Domain;

namespace MonopolyInterview.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string playersInput, roundsInput;
            int players, rounds;
            do
            {
                System.Console.Write("How many players?: ");
                playersInput = System.Console.ReadLine();
            } while (int.TryParse(playersInput, out players));

            do
            {
                System.Console.Write("How many rounds?: ");
                roundsInput = System.Console.ReadLine();
            } while (int.TryParse(roundsInput, out rounds));

            var game = new Game(players);

            for(var i=0;i<rounds;i++)
                System.Console.WriteLine(game.PlayRound());

            var winner = game.GetWinner();

            System.Console.WriteLine();
            System.Console.WriteLine(winner.Name + " is the winner with $"+winner.Balance);
            System.Console.ReadLine();
        }

    }
}
