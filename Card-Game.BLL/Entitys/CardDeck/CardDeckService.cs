using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.BLL
{
    public class CardDeckService : ICardDeckService
    {
        private ICardDeckRepo cardDeckRepo;

        public CardDeckService(ICardDeckRepo cardDeckRepo)
        {
            this.cardDeckRepo = cardDeckRepo;
        }

        public void Huhu()
        {
            cardDeckRepo.CreateCardDeck("Worked");
        }


        public void CreateCardDeck(string name)
        {
            //Backend Validiation kann z.B hier durchgeführt werden
            try
            {
                cardDeckRepo.CreateCardDeck(name);
            }
            catch
            {
                throw;
            }
        }

        public void CreateCardDeck(string name, List<Card> cards)
        {
            //Backend Validiation kann z.B hier durchgeführt werden

            cardDeckRepo.CreateCardDeck(name, cards);
        }

        public void DeleteCardDeck(int id)
        {
            cardDeckRepo.DeleteCardDeck(id);
        }

        public List<CardDeck> GetAllCardDecks()
        {
            return cardDeckRepo.GetAllCardDecks();
        }

        public List<Card> GetAllCardsInDeck(int id)
        {
            return cardDeckRepo.GetAllCardsInDeck(id);
        }

        public void AddCardToDeck(Card card, int deckID)
        {
            cardDeckRepo.AddCardToDeck(card, deckID);
        }
    }
}
