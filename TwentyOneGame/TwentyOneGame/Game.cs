using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //Abstract classes have both abstract methods and virtual methods.
    public abstract class Game
    {
        //Properties
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //Abstract methods cannot be implemented but instead 
        //MUST have some implementation though inheriting or polymorphism
        public abstract void Play();

        //Virtual methods are inherited and can be implemented, with the possibility of being overridden.
        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
