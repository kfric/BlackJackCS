using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //greeting to show that the program is running
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ready to play Blackjack?");
            Console.WriteLine("-------------------------");

            //asking to continue...
            Console.WriteLine("Y to play");
            var answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                Console.WriteLine("----GOOD LUCK----");
            }

            //create blank list, or deck to hold the cards with their 2 values
            var deck = new List<string>();

            //need to shuffle cards
            //create 2 lists to hold a card's 2 values
            var suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };

            foreach (var rank in ranks)
            {
                foreach (var suit in suits)
                {
                    var card = $"{rank} of {suit}";
                    deck.Add(card);
                }
            }

            // need shuffle cards
            var numberOfCards = deck.Count;
            for (var end = numberOfCards - 1; end >= 0; end--)
            {
                var somePlace = new Random().Next(0, end);
                var copiedCard = deck[end];
                deck[end] = deck[somePlace];
                deck[somePlace] = copiedCard;
            }

            // need to create a list for player and list for house to store all of their cards as the may hit to add
            var playerHand = new List<string>();
            var houseHand = new List<string>();

            // need to give int values to ace, jack, queen, king



            // need to deal 2 cards to player and display
            var playerCards = $"{deck[0]} and {deck[1]}";
            Console.WriteLine($"You were dealt a {playerCards}");


            // need to deal 2 cards to the house, but will NOT be displayed
            var houseCards = $"{deck[2]} and {deck[3]}";


            // need to ask the player if they want to hit or stand
            Console.WriteLine("Do you want to HIT?");
            var hitAnswer = Console.ReadLine();
            if (hitAnswer == "y" || hitAnswer == "Y" || hitAnswer == "Hit" || hitAnswer == "hit" || hitAnswer == "HIT")
            {
                Console.WriteLine("----DEALING ANOTHER CARD----");
            }

            // if player hit we need to add next card from deck to their hand
            playerHand.Add($"{playerCards} and {deck[0]}");
            Console.WriteLine($"{playerHand}");







            // // if the player does not choose to start the game
            // if (hitAnswer != "y" || hitAnswer != "Y" || hitAnswer != "Hit" || hitAnswer != "hit" || hitAnswer != "HIT")
            // {
            //     Console.WriteLine("----GAME OVER----");
            // }





        }
    }
}