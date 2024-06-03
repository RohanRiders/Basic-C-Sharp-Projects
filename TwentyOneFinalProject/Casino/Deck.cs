using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>(); //An empty list of cards

            for (int i = 0; i < 13; i++) //iterate through the 13 face cards
            {
                for (int j = 0; j < 4; j++) //iterate through each suit of each face card. 
                {
                    Card card = new Card();
                    card.Face = (Face)i; //This is an example of casting but the other way around. With the index being what you're casting from.  
                    card.Suit = (Suit)j; //This is another example of casting. 
                    Cards.Add(card); //Add the card to the card list.
                }
            }
        }
        public List<Card> Cards { get; set; }
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomindex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomindex]);
                    Cards.RemoveAt(randomindex);
                }
                Cards = TempList;
            }
        }
    }
}
