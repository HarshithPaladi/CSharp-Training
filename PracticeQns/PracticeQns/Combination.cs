using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQns
{
    public class Combination
    {
        public IOrderedEnumerable<KeyValuePair<string, int>> GetFrequency(string[] ranksOfCards)
        {
            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (string rank in ranksOfCards)
            {
                if (frequency.ContainsKey(rank))
                    frequency[rank]++;
                else
                    frequency[rank] = 1;
            }

            return frequency.OrderBy((key) => -key.Value);
        }
        public int[] ChangeCardsIntoNumericals(string[] cards)
        {
            int[] cardsChanged = new int[cards.Length];

            for (int cardIndex = 0; cardIndex < cards.Length; cardIndex++)
            {

                string card = cards[cardIndex].Substring(0, cards[cardIndex].Length - 1);

                cardsChanged[cardIndex] = card switch
                {
                    "A" => 14,
                    "K" => 13,
                    "Q" => 12,
                    "J" => 11,
                    _ => Convert.ToInt32(card),
                };
            }
            return cardsChanged;
        }

        public bool HasSameSuit(string[] cards)
        {

            char firstCardSuit = cards[0][cards[0].Length - 1];
            return cards.All((card) => card[card.Length - 1] == firstCardSuit);
        }

        public string[] GetRanks(string[] cards)
        {
            string[] ranks = new string[cards.Length];

            for (int cardIndex = 0; cardIndex < cards.Length; cardIndex++)
            {
                ranks[cardIndex] = cards[cardIndex].Substring(0, cards[cardIndex].Length - 1);
            }

            return ranks;




        }

        public bool IsSequential(string[] cards)
        {
            //Ace, King, Queen, Jack, 10, 9, 8, 7, 6, 5, 4, 3, 2.
            //this is the sequence

            //to simplify we assume Ace-14 King -13 Queen-12 Jack -11
            int[] cardsChanged = ChangeCardsIntoNumericals(cards);
            Array.Sort(cardsChanged);

            for (int cardsChangedIndex = 0; cardsChangedIndex < cards.Length - 1; cardsChangedIndex++)
            {
                int difference = Math.Abs(cardsChanged[cardsChangedIndex] - cardsChanged[cardsChangedIndex + 1]);
                if (difference != 1)
                    return false;
            }
            return true;

        }

        public bool IsRoyalFlush(string[] cards)
        {
            Array.Sort(cards);

            if (HasSameSuit(cards) && cards[0][0] == '1' && cards[1][0] == 'A' && cards[2][0] == 'J'
                && cards[3][0] == 'K' && cards[4][0] == 'Q')
            {
                return true;
            }

            return false;
            // 10c ac jc kc qc
        }



        public bool IsStraightFlush(string[] cards)
        {
            if (HasSameSuit(cards) && IsSequential(cards))
            {

                return true;
            }
            return false;
        }

        public bool IsFourOfAKind(string[] cards)
        {
            //10d 11h 10d 10d 10d
            //10d 10d 10d 11c 11c
            //10d 10d 10d 10d 11c
            string[] ranksOfCards = GetRanks(cards);
            //10 ,11 
            //10 11

            var frequencySorted = GetFrequency(ranksOfCards);

            if (frequencySorted.ElementAt(0).Value == 4 && frequencySorted.ElementAt(1).Value == 1)
                return true;

            return false;

        }

        public bool IsFullHouse(string[] cards)
        {
            string[] ranksOfCards = GetRanks(cards);

            if (ranksOfCards.Distinct().Count() == 2)
                return true;

            return false;
        }

        public bool IsFlush(string[] cards)
        {
            if (HasSameSuit(cards) && !IsSequential(cards))
                return true;
            return false;
        }

        public bool IsStraight(string[] cards)
        {
            if (!HasSameSuit(cards) && IsSequential(cards))
                return true;
            return false;
        }


        public bool IsThreeOfAKind(string[] cards)
        {
            string[] ranksOfCards = GetRanks(cards);

            var frequencySorted = GetFrequency(ranksOfCards);

            if (frequencySorted.ElementAt(0).Value == 3)
                return true;

            return false;

        }

        public bool IsTwoPairs(string[] cards)
        {
            string[] ranksOfCards = GetRanks(cards);
            // 10c 2c 8h 8s 2d

            var frequencySorted = GetFrequency(ranksOfCards);


            //foreach (var pair in frequencySorted) Console.WriteLine(pair.Key + " " + pair.Value);

            if (frequencySorted.ElementAt(0).Value == 2 && frequencySorted.ElementAt(1).Value == 2)
                return true;

            return false;

        }

        public bool IsPairs(string[] cards)
        {
            string[] ranksOfCards = GetRanks(cards);
            // 10c 2c 8h 8s 2d

            var frequencySorted = GetFrequency(ranksOfCards);

            //foreach (var pair in frequencySorted) Console.WriteLine(pair.Key + " " + pair.Value);

            if (frequencySorted.ElementAt(0).Value == 2)
                return true;

            return false;

        }




        public string GetCombination(string[] cards)
        {
            string result = "High Card";

            if (IsRoyalFlush(cards))
            {
                result = "Royal Flush";
            }

            else if (IsStraightFlush(cards))
            {
                result = "Straight Flush";
            }

            else if (IsFourOfAKind(cards))
            {
                result = "Four Of A Kind";
            }
            else if (IsFullHouse(cards))
            {
                result = "Full House";
            }
            else if (IsFlush(cards))
            {
                result = "Flush";
            }
            else if (IsStraight(cards))
            {
                result = "Straight";
            }
            else if (IsThreeOfAKind(cards))
            {
                result = "Three Of A Kind";
            }
            else if (IsTwoPairs(cards))
            {
                result = "Two Pairs";
            }
            else if (IsPairs(cards))
            {
                result = "Pairs";
            }

            return result;

        }
        public void CombinationRunner()
        {
            Console.WriteLine(GetCombination(new string[] { "Ac", "Kc", "Jc", "Qc", "10c" }));
            Console.WriteLine(GetCombination(new string[] { "2c", "3c", "4c", "5c", "6c" }));
            Console.WriteLine(GetCombination(new string[] { "10s", "10c", "8d", "10d", "10h" }));
            Console.WriteLine(GetCombination(new string[] { "10s", "8c", "8d", "10d", "10h" }));
            Console.WriteLine(GetCombination(new string[] { "10s", "2c", "8d", "10d", "10h" }));

        }
    }
}
