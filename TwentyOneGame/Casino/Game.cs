using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //Abstract classes have both abstract methods and virtual methods.
    public abstract class Game
    {
        //Properties
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        /// <summary>
        /// This expanded get set is the same as the concise one.
        /// Except it now is linked to an empty list so it won't return a null
        /// </summary>
        //public List<Player> Players { get; set; }
        public List<Player> Players { get { return _players; } set { _players = value; } }
        //public Dictionary<Player, int> Bets { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public string Name { get; set; }

        //Abstract methods cannot be implemented but instead 
        //MUST have some implementation though inheriting or polymorphism
        public abstract void Play();

        //Virtual methods are inherited and can be implemented, with the possibility of being overridden.
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
