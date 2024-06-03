using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOneFinalProject
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //You wouldn't use an Enum in this case because it doesn't play well with duplicate values. 
        {
            [Face.Two] = 2, 
            [Face.Three] = 3, 
            [Face.Four] = 4, 
            [Face.Five] = 5,
            [Face.Six] = 6, 
            [Face.Seven] = 7, 
            [Face.Eight] = 8, 
            [Face.Nine] = 9,
            [Face.Ten] = 10, 
            [Face.Jack] = 10, 
            [Face.Queen] = 10, 
            [Face.King] = 10,
            [Face.Ace] = 1

        };

        public static int[] GetAllPossibleHandValues(List<Card> Hand) //This will return an int array of the possible values
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); //We will check each card (x) and ask, is each face equivilant to each ace? 
            int[] result = new int[aceCount + 1]; //However many results there are means thats the count of aces and then we will add '1'. Thats how many possible results there are. 
            int value = Hand.Sum(x => _cardValues[x.Face]); //Take each value (x) and look it up in the _cardValue Dictionaries table [] and then Sum it. 
            result[0] = value; //Take our very first entry and assign 
            if (result.Length == 1) return result; //this is short and compact so the IF statement can be on one line. 
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10); //value is the lowest possible value for Ace, which is 1. For the other two possiblities its index(i) * 10. if there was two found it would be 2 * 10. 
                result[i] = value;
                
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand); //This gets all possible values from the passed in hand of cards. 
            int value = possibleValues.Max(); //We are then going to get the largest value. 
            if (value == 21) return true; //Then if the maximum passible value is 21 then you have a black jack. 
            else return false; //return false if not. 
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if(value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max(); //Take the items in player results and filter them where the item/int is less than 22 and get the me the largest one found. 
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
