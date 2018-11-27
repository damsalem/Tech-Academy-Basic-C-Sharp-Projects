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
            Deck deck = new Deck();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            string userData = Console.ReadLine();
            bool isTrue = false;
            if (userData == "yeah" || userData == "yep" || userData == "y") { isTrue = true; };

            return isTrue;
        }
    }
}
