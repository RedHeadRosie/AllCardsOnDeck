using System;
using System.Collections.Generic;

namespace AllCardsOnDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the deck of cards as a list of strings
            var cards = new List<string>() { "King of Hearts" };

            cards.Add("Queen of Hearts");
            cards.Add("Jack of Hearts");
            cards.Add("10 of Hearts");
            cards.Add("9 of Hearts");
            cards.Add("8 of Hearts");
            cards.Add("7 of Hearts");
            cards.Add("6 of Hearts");
            cards.Add("5 of Hearts");
            cards.Add("4 of Hearts");
            cards.Add("3 of Hearts");
            cards.Add("2 of Hearts");
            cards.Add("Ace of Hearts");
            cards.Add("King of Spades");
            cards.Add("Queen of Spades");
            cards.Add("Jack of Spades");
            cards.Add("10 of Spades");
            cards.Add("9 of Spades");
            cards.Add("8 of Spades");
            cards.Add("7 of Spades");
            cards.Add("6 of Spades");
            cards.Add("5 of Spades");
            cards.Add("4 of Spades");
            cards.Add("3 of Spades");
            cards.Add("2 of Spades");
            cards.Add("Ace of Spades");
            cards.Add("King of Diamonds");
            cards.Add("Queen of Diamonds");
            cards.Add("Jack of Diamonds");
            cards.Add("10 of Diamonds");
            cards.Add("9 of Diamonds");
            cards.Add("8 of Diamonds");
            cards.Add("7 of Diamonds");
            cards.Add("6 of Diamonds");
            cards.Add("5 of Diamonds");
            cards.Add("4 of Diamonds");
            cards.Add("3 of Diamonds");
            cards.Add("2 of Diamonds");
            cards.Add("Ace of Diamonds");
            cards.Add("King of Clubs");
            cards.Add("Queen of Clubs");
            cards.Add("Jack of Clubs");
            cards.Add("10 of Clubs");
            cards.Add("9 of Clubs");
            cards.Add("8 of Clubs");
            cards.Add("7 of Clubs");
            cards.Add("6 of Clubs");
            cards.Add("5 of Clubs");
            cards.Add("4 of Clubs");
            cards.Add("3 of Clubs");
            cards.Add("2 of Clubs");
            cards.Add("Ace of Clubs");



            //shuffle the cards using youtube method
            var decreasingIndex = cards.Count - 1; //sets the var as the last element
                                                   //creates a random number and then subtracts 1 as the index number goes from 0 to length-1


            while (decreasingIndex >= 0)
            {
                Random r = new Random();
                var randomIndex = r.Next(0, cards.Count);

                var placeHolder1 = cards[decreasingIndex];
                var placeHolder2 = cards[randomIndex];

                cards[decreasingIndex] = placeHolder2;
                cards[randomIndex] = placeHolder1;

                //if we aren't at the first card, then look at the next one down the line and continue the shuffle
                decreasingIndex = decreasingIndex - 1;


            }



            //display top two cards
            var firstTopCard = cards[0];
            var secondTopCard = cards[1];
            Console.WriteLine($"The top two cards are {firstTopCard} and {secondTopCard}");

        }
    }
}
