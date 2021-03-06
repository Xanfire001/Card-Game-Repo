﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.BLL
{
    public interface ICardDeckService
    {
        void CreateCardDeck(string name);
        void CreateCardDeck(string name, List<Card> cards);
        void DeleteCardDeck(int id);
        List<CardDeck> GetAllCardDecks();
        List<Card> GetAllCardsInDeck(int id);
        void AddCardToDeck(Card card, int deckID);
    }
}
