using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card //This is going to be a struct because it is a solid candidate as a struct. Its not inheriting anything and the values don't want to be changed. 
    {
        
        public Suit Suit { get; set; }
        public Face Face { get; set; }

    }
    public enum Suit
    {
        Clubs, 
        Diamonds, 
        Hearts, 
        Spades
    }

    public enum Face
    {
        Two, 
        Three, 
        Four, 
        Five, 
        Six, 
        Seven,
        Eight, 
        Nine, 
        Ten, 
        Jack, 
        Queen, 
        King, 
        Ace


    }
}
