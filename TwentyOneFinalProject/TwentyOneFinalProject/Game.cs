using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneFinalProject
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } } //value represents whatever the user is assigning the value as. 
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } //if someone says game.bets = dictionary, the dictionary becomes the value. 
        public string Name  { get; set; }        
        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
