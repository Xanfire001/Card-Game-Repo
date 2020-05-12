using System;
using System.Collections.Generic;
using Card_Game.BLL;
using Card_Game.ConsoleApp.Views;
using Serilog;

namespace Card_Game.ConsoleApp
{
    public class Controller
    {
        private readonly ICardDeckService _cardDeckService;
        private readonly ICardService _cardService;
        #region Properties
        private Ui Ui { get; set; }
        #endregion
        public Controller(ICardDeckService cardDeckService, ICardService cardService, Ui ui)
        {
            _cardDeckService = cardDeckService;
            _cardService = cardService;
            Ui = ui;
        }

        public void Run()
        {
            Log.Logger.Information("Application successfully started");
            Ui.Greeting();
            string selector = Ui.MainMenuSelection();
            switch (selector)
            {
                case "1":
                    CreateDeck();
                    break;
                case "2":
                    SelectDeck(3);
                    break;
                case "3":
                    SelectDeck(1);
                    break;
                case "4":
                    ShowAllCards();
                    break;
                case "5":
                    SelectDeck(2);
                    break;
                default:
                    Run();
                    break;
            }
        }

        private void SelectDeck(int purpose)
        {
            var cardDeckList = _cardDeckService.GetAllCardDecks();
            var selectedDeck = Ui.ShowAllCardDecks(cardDeckList);
            if (CheckInput(selectedDeck, cardDeckList)) { }
            else
            {
                SelectDeck(purpose);
            }
            Log.Logger.Information("Deck selected");
            switch (purpose)
            {
                case 1:
                    AddCardToDeck(Int32.Parse(selectedDeck));
                    break;
                case 2:
                    ShowCardsInDeck(Int32.Parse(selectedDeck));
                    break;
                case 3:
                    DeleteDeck(Int32.Parse(selectedDeck));
                    break;
                default:
                    break;
            }
            Run();
        }

        private void SelectCard(List<Card> cardList, int deckID)
        {
            Ui.ShowAllCards(cardList);
            var tempCard = Ui.SelectCard();
            if (CheckInput(tempCard, cardList)) 
            {
                var selectedCard = Int32.Parse(tempCard);
                foreach (var card in cardList)
                {
                    if (card.Id == selectedCard)
                    {
                        _cardDeckService.AddCardToDeck(card, deckID);
                        Log.Logger.Information("Successfully added card to deck");
                    }
                }
            }
            else
            {
                SelectCard(cardList, deckID);
            }
        }

        private void AddCardToDeck(int id)
        {
            var cardList = _cardService.GetAllCards();
            SelectCard(cardList, id);
        }

        private void ShowAllCards()
        {
            throw new NotImplementedException();
        }

        private void ShowCardsInDeck(int id)
        {
            try
            {
                Ui.ShowAllCards(_cardDeckService.GetAllCardsInDeck(id));
                Ui.ReturnToMainMenu();
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "Cardlist couldn't be loaded.");
            }
        }

        private void RenameDeck()
        {
            throw new NotImplementedException();
        }

        private void DeleteDeck(int id)
        {
            try
            {
                _cardDeckService.DeleteCardDeck(id);
                Log.Logger.Information("Successfully deleted deck");
                Run();
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "Something went wrong during deck deletion. Please try again or contact our support");
            }
        }

        public void CreateDeck()
        {
            try
            {
                _cardDeckService.CreateCardDeck(Ui.GetCardDeckName());
                Log.Logger.Information("Successfully created new deck.");
                Run();
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "Something went wrong during deck creation. Please try again or contact our support");
            }
        }

        public bool CheckInput(string input, List<CardDeck> cardDeckList)
        {
            try
            {
                int temp = Int32.Parse(input);
                foreach (var cardDeck in cardDeckList)
                {
                    if (temp == cardDeck.Id)
                        return true;
                }
                Log.Logger.Information("Index out of range");
                return false;
            }
            catch
            {
                Log.Logger.Information("Invalid input");
                return false;
            }
        }

        public bool CheckInput(string input, List<Card> cardList)
        {
            try
            {
                int temp = Int32.Parse(input);
                foreach (var card in cardList)
                {
                    if (temp == card.Id)
                        return true;
                }
                Log.Logger.Information("Index out of range");
                return false;
            }
            catch
            {
                Log.Logger.Information("Invalid input");
                return false;
            }
        }
    }
}