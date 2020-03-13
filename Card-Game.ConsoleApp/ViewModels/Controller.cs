using System;
using System.Collections.Generic;
using System.Text;
using Card_Game.BLL;
using Card_Game.ConsoleApp.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Serilog;

namespace Card_Game.ConsoleApp
{
    public class Controller
    {
        private readonly ICardDeckService _cardDeckService;
        #region Properties
        private UI Ui { get; set; }

        #endregion
        public Controller(ICardDeckService cardDeckService)
        {
            _cardDeckService = cardDeckService;
            Ui = new UI();
        }

        public void Run()
        {
            Ui.Greeting();
            string selector = Ui.MainMenuSelection();
            switch (selector)
            {
                case "1":
                    CreateDeck();
                    break;
                case "2":
                    DeleteDeck();
                    break;
                case "3":
                    RenameDeck();
                    break;
                case "4":
                    ShowCardsInDeck();
                    break;
                case "5":
                    ShowAllCards();
                    break;
                case "6":
                    SelectDeck();
                    break;
                default:
                    Run();
                    break;
            }
        }

        private void SelectDeck()
        {
            throw new NotImplementedException();
        }

        private void AddCardsToDeck()
        {
            throw new NotImplementedException();
        }

        private void ShowAllCards()
        {
            throw new NotImplementedException();
        }

        private void ShowCardsInDeck()
        {
            throw new NotImplementedException();
        }

        private void RenameDeck()
        {
            throw new NotImplementedException();
        }

        private void DeleteDeck()
        {
            try
            {
                var deckToDelete = Ui.ShowAllCardDecks(_cardDeckService.GetAllCardDecks());
                

            }
            catch(Exception ex)
            {
                Log.Logger.Error(ex, "Something went wrong during deck deletion. Please try again or contact our support");
            }
        }

        public void CreateDeck()
        {
            try
            {
                _cardDeckService.CreateCardDeck(Ui.GetCardDeckName());
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "Something went wrong during deck creation. Please try again or contact our support");
            }
        }
    }
}