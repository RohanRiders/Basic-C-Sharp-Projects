using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Deck
    {
        public Deck() //When this constructor is called this is the behavior that takes place by default as soon as an object is created. 
        {

            //What we know is each deck has 52 cards, 13 faces with 4 suites. So for each face (13) we need to loop through it 4 times. 
            Cards = new List<Card>(); //An empty list of cards
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; 
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces) //Every iteration of faces it will loop through all the suits for that face. 
            {
                foreach (string suit in Suits) //During each loop we create a card and assign the values of suit and face to that card. 
                {
                    Card card = new Card();// This only exists with each loop 
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }


            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; }

    }
}
