using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Hand
    {
        // Properties: A list of individual Cards
        public List<Card> IndividualCards { get; set; } = new List<Card>();


        // Name
        // Input - new card
        // Work - receive new card and add to IndividualCards
        // Output - nothing
        public void Receive(Card newCard)
        {
            // Add a card to the hand
            IndividualCards.Add(newCard);
        }
        // Behaviors:
        // TotalValue representing the sum of the individual Cards in the list.
        // Input new card
        // Output nothing
        public int TotalValue()
        {
            return 0;
        }

    }
    // Card
    class Card
    {
        // Properties: The Rank of the card, the Suit of the card
        public string Rank { get; set; }
        public string Suit { get; set; }


        // Behaviors:
        // The Value of the card according to the table in the "P"roblem part
        public int Value() // Needs to return the value of the cards as an int
        {

            switch (Rank)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    return int.Parse(Rank);
                case "Jack":
                case "Queen":
                case "King":
                    return 10;
                case "Ace":
                    return 11;
                default: // in case input is not a defined card?
                    return 0;
            }
        }
        // Make new behavior that can describe a card (and it's two objects)
        // Name
        // Input - none
        // Work - Generate new string that describes card
        // Output - string
        public string Description()
        {
            var newDescriptionString = $"The {Rank} of {Suit} - worth {Value()} points."; // assign the rank and suit to an object

            return newDescriptionString; // return it so that it can be accessed
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // Create a new deck 
            // A list of 52 cards
            // Algorithm for making a list of 52 cards

            // Make a blank list of cards
            var deck = new List<Card>();

            // Suits is a list of "Club", "Diamond", "Heart", or "Spade"
            var Suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };

            // Faces is a list of 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King, or Ace
            var Ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            // Go through each suit one at a time
            foreach (var suit in Suits)
            {
                // Go through each rank at a time
                foreach (var rank in Ranks)
                {
                    // Build a new card and assign it a Suit and a Rank
                    var card = new Card { Suit = suit, Rank = rank };
                    // add that card to the deck
                    deck.Add(card);
                }
            }


            // Ask the deck to make a new shuffled 52 cards

            // get the count of the number of cards in the deck
            var numberOfCards = deck.Count;
            for (var end = numberOfCards - 1; end >= 0; end--)
            {
                var somePlace = new Random().Next(0, end); // Picks a random card from deck between 0 and end of deck
                var copiedCard = deck[end]; // Copy the car at the end of the deck
                deck[end] = deck[somePlace]; // replace card at end of deck with the random card
                deck[somePlace] = copiedCard; // change the card at the end of the deck to the random card
            }
            // Create a player hand
            var playerHand = new Hand();


            // Create a dealer hand
            var dealerHand = new Hand();

            // Ask the deck for a card
            var newCard = deck[0];
            deck.Remove(newCard); // remove that card from the deck so

            // place it in the player hand
            playerHand.Receive(newCard);

            // Ask the deck for a card
            newCard = deck[0]; // Override newCard
            deck.Remove(newCard);
            // Place it in the player hand
            playerHand.Receive(newCard);

            // Ask the deck for a card 
            newCard = deck[0];
            deck.Remove(newCard);
            // Place it in the dealer hand
            dealerHand.Receive(newCard);

            // Ask the deck for a card 
            newCard = deck[0];
            deck.Remove(newCard);
            // Place it in the dealer hand
            dealerHand.Receive(newCard);

            // Show the player the cards in their hand and display the TotalValue of their Hand
            Console.WriteLine("Your cards are: ");
            foreach (var card in playerHand.IndividualCards)
            {
                Console.WriteLine(card.Description());
            }

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