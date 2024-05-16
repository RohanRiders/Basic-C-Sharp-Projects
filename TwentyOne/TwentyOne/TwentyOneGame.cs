using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        public override void Play() //The keywork override satisfies the contract set by the abastracted method in the inheriting class 'Game'. 
        {
            throw new NotImplementedException(); 
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 players: ");
            base.ListPlayers(); //notice the '.base' because it is being inherited from the games class. 
        }
    }
}
