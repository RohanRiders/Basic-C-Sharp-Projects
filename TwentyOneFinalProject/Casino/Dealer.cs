using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int  Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //You do this when dealing with a stream, which is unmanged code.
                                                                               //In that case you need to make sure everything get disposed of or you will run out of memory. 
            Console.WriteLine(card);
            //The "using" helps manage the clean up of memory when you are done with it. Garbage collection. 
            using (StreamWriter file = new StreamWriter(@"C:\Users\trason.carver\Documents\Logs\log.text", true)) //This allows you to log whatever you'd like, in this case we are logging "card". 
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            } //This closing brace is when clean up occurs.
            Deck.Cards.RemoveAt(0);
        }
    }
}
