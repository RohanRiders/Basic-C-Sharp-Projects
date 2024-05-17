using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player) // this is how you overload an operator (adding a player and returning a game)
        {
            game.Players.Add(player); //
            return game;
        }

        public static Game operator- (Game game, Player player) //this is a minus overloaded operator. (removing a player and returning a game)
        {
            game.Players.Remove(player);
            return game;
        }

    }
}
