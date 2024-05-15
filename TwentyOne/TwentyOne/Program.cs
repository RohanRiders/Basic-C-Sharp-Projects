using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //Upon instantiating a new object of object/Class Deck it should have created 52 cards for you. This object has a property "Cards" with data type list that has 52 cards in it. 
            deck = Shuffle(deck); //This looks weird but we are taking in the variable deck, shuffling it, and reasigning it back to the veriable 'deck'. 
            // We want a function that takes in a deck of cards and returns a shuffled deck of cards. 

            foreach (Card card in deck.Cards) //The Cards list should have 52 card objects in it and we want to print them to the screen. 
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count); //Give me the total number of cards in the list.
            Console.ReadLine();

            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit); //Zero based indexing tells us that one card was added to the list. What if you added a foreach loop. 
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);


            /// ********************************************************************************** NOTES *******************************************************
            //deck.Cards = new List<Card>(); //You have to instantiate Cards which is of data type list, so you need to create a new list in order to use it. 
            //Card cardOne = new Card(); //This is an object with properties of Face and Suit.
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            //deck.Cards.Add(cardOne);
        }
        public static Deck Shuffle(Deck deck)
        {
            // We want to shuffle to make it random. 
            List<Card> TempList = new List<Card>(); 
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomindex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomindex]);
                deck.Cards.RemoveAt(randomindex);
            }
            deck.Cards = TempList;
            return deck;

        }
    }
}
