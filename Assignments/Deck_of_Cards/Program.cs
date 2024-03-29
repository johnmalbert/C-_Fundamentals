﻿using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#################################################################");
            Console.WriteLine("Welcome. This console app is pretty cool. A deck of 52 cards is created. \nNext, Five cards are dealt from the deck. The deck is then reset with 52 new cards. \nThe deck can also be shuffled, using a random array of 52 numbers. \nA player is created, then draws five cards.\nPlayers can also discard a card from their hand, by index number.");
            Deck d = new Deck();
            Console.WriteLine();
            Console.WriteLine("New deck created!");
            Console.WriteLine($"Dealing five cards from the deck:");
            Console.WriteLine();
            Card dealt = d.Deal();
            Card d2 = d.Deal();
            Card d3 = d.Deal();
            Card d4 = d.Deal();
            Card d5 = d.Deal();
            Console.WriteLine($"Dealt cards: {dealt}, {d2}, {d3}, {d4}, {d5}.");
            Console.WriteLine();
            Console.WriteLine("Resetting the deck");
            d.Reset();
            Console.WriteLine();
            d.ShuffleDeck();
            Console.WriteLine();
            Console.WriteLine("New player created, named Johnny.");
            Player player1 = new Player("Johnny");
            player1.Draw(d);
            player1.Draw(d);
            player1.Draw(d);
            player1.Draw(d);
            player1.Draw(d);
            player1.Draw(d);
            player1.PrintHand();

            player1.Discard(2);
        }
    }
        // Create a class called "Card"
    class Card
    {
        public string stringVal;
        public string suit;
        public int val;

        public Card(string s, string Suit, int value)
        {
            stringVal = s;
            suit = Suit;
            val = value;
        }        
        public override string ToString()
        {
            return $"{stringVal} of {suit}";
        }
    }
    class Deck 
    {
        public List<Card> Cards;

        public Deck()
        {
            Cards = new List<Card>()
            {
                new Card("Ace", "Spades", 1),
                new Card("Ace", "Hearts", 1),
                new Card("Ace", "Diamonds", 1),
                new Card("Ace", "Clubs", 1),
                new Card("2", "Spades", 2),
                new Card("2", "Hearts", 2),
                new Card("2", "Diamonds", 2),
                new Card("2", "Clubs", 2),
                new Card("3", "Spades", 3),
                new Card("3", "Hearts", 3),
                new Card("3", "Diamonds", 3),
                new Card("3", "Clubs", 3),
                new Card("4", "Spades", 4),
                new Card("4", "Hearts", 4),
                new Card("4", "Diamonds", 4),
                new Card("4", "Clubs", 4),
                new Card("5", "Spades", 5),
                new Card("5", "Hearts", 5),
                new Card("5", "Diamonds", 5),
                new Card("5", "Clubs", 5),
                new Card("6", "Spades", 6),
                new Card("6", "Hearts", 6),
                new Card("6", "Diamonds", 6),
                new Card("6", "Clubs", 6),
                new Card("7", "Spades", 7),
                new Card("7", "Hearts", 7),
                new Card("7", "Diamonds", 7),
                new Card("7", "Clubs", 7),
                new Card("8", "Spades", 8),
                new Card("8", "Hearts", 8),
                new Card("8", "Diamonds", 8),
                new Card("8", "Clubs", 8),
                new Card("9", "Spades", 9),
                new Card("9", "Hearts", 9),
                new Card("9", "Diamonds", 9),
                new Card("9", "Clubs", 9),
                new Card("10", "Spades", 10),
                new Card("10", "Hearts", 10),
                new Card("10", "Diamonds", 10),
                new Card("10", "Clubs", 10),
                new Card("Jack", "Spades", 11),
                new Card("Jack", "Hearts", 11),
                new Card("Jack", "Diamonds", 11),
                new Card("Jack", "Clubs", 11),
                new Card("Queen", "Spades", 12),
                new Card("Queen", "Hearts", 12),
                new Card("Queen", "Diamonds", 12),
                new Card("Queen", "Clubs", 12),
                new Card("King", "Spades", 13),
                new Card("King", "Hearts", 13),
                new Card("King", "Diamonds", 13),
                new Card("King", "Clubs", 13),
            };
        }
        public Card Deal()
        {
            //Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
            if(this.Cards.Count > 0)
            {
                Card card_to_deal = this.Cards[0];
                this.Cards.RemoveAt(0);
                // Console.WriteLine($"Dealt the {card_to_deal}");
                return card_to_deal;                
            }
            else 
            {
                Console.WriteLine("No cards left in deck");
                return null;
            }
        }
        public void Reset()
        {
            //remove all the cards from deck
            this.Cards = null;
            //create a new deck
            Cards = new List<Card>()
            {
                new Card("Ace", "Spades", 1),
                new Card("Ace", "Hearts", 1),
                new Card("Ace", "Diamonds", 1),
                new Card("Ace", "Clubs", 1),
                new Card("2", "Spades", 2),
                new Card("2", "Hearts", 2),
                new Card("2", "Diamonds", 2),
                new Card("2", "Clubs", 2),
                new Card("3", "Spades", 3),
                new Card("3", "Hearts", 3),
                new Card("3", "Diamonds", 3),
                new Card("3", "Clubs", 3),
                new Card("4", "Spades", 4),
                new Card("4", "Hearts", 4),
                new Card("4", "Diamonds", 4),
                new Card("4", "Clubs", 4),
                new Card("5", "Spades", 5),
                new Card("5", "Hearts", 5),
                new Card("5", "Diamonds", 5),
                new Card("5", "Clubs", 5),
                new Card("6", "Spades", 6),
                new Card("6", "Hearts", 6),
                new Card("6", "Diamonds", 6),
                new Card("6", "Clubs", 6),
                new Card("7", "Spades", 7),
                new Card("7", "Hearts", 7),
                new Card("7", "Diamonds", 7),
                new Card("7", "Clubs", 7),
                new Card("8", "Spades", 8),
                new Card("8", "Hearts", 8),
                new Card("8", "Diamonds", 8),
                new Card("8", "Clubs", 8),
                new Card("9", "Spades", 9),
                new Card("9", "Hearts", 9),
                new Card("9", "Diamonds", 9),
                new Card("9", "Clubs", 9),
                new Card("10", "Spades", 10),
                new Card("10", "Hearts", 10),
                new Card("10", "Diamonds", 10),
                new Card("10", "Clubs", 10),
                new Card("Jack", "Spades", 11),
                new Card("Jack", "Hearts", 11),
                new Card("Jack", "Diamonds", 11),
                new Card("Jack", "Clubs", 11),
                new Card("Queen", "Spades", 12),
                new Card("Queen", "Hearts", 12),
                new Card("Queen", "Diamonds", 12),
                new Card("Queen", "Clubs", 12),
                new Card("King", "Spades", 13),
                new Card("King", "Hearts", 13),
                new Card("King", "Diamonds", 13),
                new Card("King", "Clubs", 13),
            };
        }

        public void ShuffleDeck()
        {
            int[] randomArray = Shuffle(this.Cards.Count);
            Deck Shuffled = new Deck();
            Shuffled.Cards.RemoveRange(0,52); // clear the deck to make room for the shuffled deck.
            foreach(int number in randomArray)
            {
                if(number == -1)
                {
                    Shuffled.Cards.Add(this.Cards[0]); //for some reason Shuffle returns a -1 intead of a 0...
                }
                else
                {
                    Shuffled.Cards.Add(this.Cards[number]);
                }
            }
            this.Cards = null;
            this.Cards = Shuffled.Cards;
            Console.WriteLine("Shuffled the deck.");
        }
        public static int[] Shuffle(int num)
        //this function returns an array of shuffled numbers
        {
            Random rand = new Random();
            int[] arr = new int[num];
            arr[0] = rand.Next(1,num + 1);
            // populate each value of the array:
            for(int i = 0; i < num; i++)
            {
                // if the random number already exists in the array, get a new random number
                int check = rand.Next(0,num + 1) - 1;
                for(int j = 0; j < num; j++){
                    // Console.WriteLine($"Checking {arr[j]} and {check}");
                    if(arr[j] == check){
                        check = rand.Next(0,num + 1) - 1;
                        // Console.WriteLine("Changed check");
                        j = -1;
                    }
                }
                arr[i] = check;
                // if it doesn't exist, assign it to the next position in the array
            }
            return arr;
        }
    }
    class Player
    {
        // Give the Player class a name property.
        public string name;

        // Give the Player a hand property that is a List of type Card.
        public List<Card> hand = new List<Card>();
 
        //constructor
        public Player(string player_name)
        {
            name = player_name;
        }

        // Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card. Note this method will require reference to a deck object
        public Card Draw(Deck d)
        {
            //get the top card
            Card dealtCard = d.Deal();
            this.hand.Add(dealtCard);
            return dealtCard;
        }
        // Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
        public Card Discard(int index)
        {
            //get the card at the index, if possible.
            try
            {
                Card discardCard = this.hand[index];
                this.hand.Remove(discardCard);
                Console.WriteLine($"{this.name} is discarding the {discardCard}");
                return discardCard;
            }
            catch
            {
                Console.WriteLine("No such card at that index in your hand.");
                return null;
            }
        }

        public void PrintHand()
        {   
            Console.WriteLine($"{this.name}'s hand:");
            foreach(var card in this.hand)
            {
                Console.WriteLine(card);
            }
        }
    }
// 
}