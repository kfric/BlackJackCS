using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    // Card
    class Card
    {
        // Properties: The Rank of the card, the Suit of the card
        public string Rank { get; set; }
        public string Suit { get; set; }


        // Behaviors:
        // The Value of the card according to the table in the "P"roblem part
        public int Value() // needs to return the value of the cards as an int
        {
            return 0; // return as 0 until we figure out how to add values. only need the rank and suit rn
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // Create a new deck 
            // PEDAC ^^^^ - Properties: A list of 52 cards
            //  Algorithm for making a list of 52 cards

            // Make a blank list of cards
            var deck = new List<Card>();

            // Suits is a list of "Club", "Diamond", "Heart", or "Spade"
            var Suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };

            // Faces is a list of 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King, or Ace
            var Rank = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };


            // Ask the deck to make a new shuffled 52 cards
            var numberOfCards = deck.Count;
            for (var end = numberOfCards - 1; end >= 0; end--)
            {
                var somePlace = new Random().Next(0, end); // picks a random card from deck between 0 and end of deck
                var copiedCard = deck[end];
                deck[end] = deck[somePlace];
                deck[somePlace] = copiedCard;
            }
            // Create a player hand

            // Create a dealer hand

            // Ask the deck for a card and place it in the player hand

            // Ask the deck for a card and place it in the player hand

            // Ask the deck for a card and place it in the dealer hand

            // Ask the deck for a card and place it in the dealer hand

            // Show the player the cards in their hand and the TotalValue of their Hand

            // If they have BUSTED, then goto step 15

            // Ask the player if they want to HIT or STAND

            // If HIT

            // Ask the deck for a card and place it in the player hand, repeat step 10
            // If STAND continue on

            // If the dealer has busted then goto step 17

            // If the dealer has less than 17

            // Add a card to the dealer hand and go back to 14
            // Show the dealer's hand TotalValue

            // If the player busted show "DEALER WINS"

            // If the dealer busted show "PLAYER WINS"

            // If the dealer's hand is more than the player's hand then show "DEALER WINS", else show "PLAYER WINS"

            // If the value of the hands are even, show "DEALER WINS"  
        }

    }
}