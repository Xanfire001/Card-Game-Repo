using Card_Game.BLL.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.BLL
{
    public interface ICardDeckRepo
    {
        void CreateCardDeck(string name);
        void CreateCardDeck(string name, List<Card> cards);
        void DeleteCardDeck(int id);
        List<CardDeck> GetAllCardDecks();
        List<Card> GetAllCardsInDeck(int id);
        void AddCardToDeck(Card card, int deckID);
        void AddCardToCardList(Card card, CardDeck deck);
    }
}
