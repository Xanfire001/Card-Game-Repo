using Card_Game.BLL;
using System;
using System.Collections.Generic;

namespace Card_Game.ConsoleApp.Views
{
    public class Ui
    {
        internal void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Stonehearth");
            Console.WriteLine("---------------------------------------------------");
        }

        internal string MainMenuSelection()
        {
            Console.WriteLine();
            Console.WriteLine("1: Create Deck");
            Console.WriteLine("2: Delete Deck");
            Console.WriteLine("3: Add Cards to Deck");
            Console.WriteLine("4: Show All Cards");
            Console.WriteLine("5: Show Cards in Deck");
            Console.Write("Please enter a number for a specific action: ");
            return Console.ReadLine();
        }

        internal string GetCardDeckName()
        {
            Console.WriteLine();
            Console.Write("Please enter the Name of your Deck: ");
            return Console.ReadLine();
        }

        internal string ShowAllCardDecks(List<CardDeck> decklist)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------My Decks----------------");
            Console.WriteLine("-------------------------------------");
            foreach (var deck in decklist)
            {
                Console.WriteLine("ID       Name");
                Console.WriteLine($"{deck.Id}: {deck.Name}");
            }
            Console.Write("Please choose a deck:");
            return Console.ReadLine();
        }

        internal void ShowAllCards(List<Card> cards)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------My Cards----------------");
            Console.WriteLine("-------------------------------------");
            foreach (var card in cards)
            {
                Console.WriteLine($"{card.Id}: {card.Name}");
            }
        }

        internal string SelectCard()
        {
            Console.WriteLine("Please select the card you want to add to your deck");
            return Console.ReadLine();
        }

        internal void ReturnToMainMenu()
        {
            Console.WriteLine("Please press any key to return to the Main Menu");
            Console.ReadKey();
        }
    }
}
