using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //game is a "super class" method because it inherits code from the Game class
            TwentyOne game = new TwentyOne();
            game.Players = new List<string>() { "Dani", "Tom", "Dave", "Trevan James" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
