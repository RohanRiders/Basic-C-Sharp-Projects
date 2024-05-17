using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //Abstraction is applied here. You can no longer instantiate the class. 
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //An abstract method can only exist in an abstract class. It simply states that any inheriting class must implement it somewhere. 

        public virtual void ListPlayers() //A virtual method inside of an abstract class it means this method gets inherited but has the ability to be overriden. 
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
