using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Legacy Hotel and Casino. Let's start by you telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("\nAnd how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "ok" || answer == "okay" || answer == "sure" || answer == "yeah" || answer == "y" || answer == "yep" || answer == "yup" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOne();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("It looks like you're out. Thank you for playing {0}, please come again.", player.Name);
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.ReadLine();
        }
    }
}
