using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOneFinalProject
{
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public bool Stay { get; set; } //The dealer in the game TwentyOne has the option to stay or hit. 
        public bool isBusted { get; set; }

        
    }
}
