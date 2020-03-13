using Card_Game.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.ConsoleApp.Views
{
    public class UI
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
            Console.WriteLine("3: Rename Deck");
            Console.WriteLine("4: Show Cards in Deck");
            Console.WriteLine("5: Show All Cards");
            Console.WriteLine("6: Add Cards to Deck");
            Console.Write("Please enter a number for a specific action: ");
            return Console.ReadLine();
        }

        internal string GetCardDeckName()
        {
            Console.WriteLine();
            Console.Write("Please enter the Name of your Deck: ");
            return Console.ReadLine();
        }

        internal int ShowAllCardDecks(List<CardDeck> decklist)
        {
            Console.WriteLine();
            Console.WriteLine("My Decks");
            Console.WriteLine("-------------------------------------");
            int i = 1;
            foreach (var deck in decklist)
            {
                Console.WriteLine($"{i}: {deck.Name}");
                i++;
            }
            Console.Write("Please choose a deck you want to delete: ");
            return Console.ReadLine();
        }

    }
}
