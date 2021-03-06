﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Card_Game.BLL;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Card_Game.DAL
{
    public class CardDeckRepo : ICardDeckRepo
    {
        public ConsoleContext Db { get; }
        public CardDeckRepo(ConsoleContext db)
        {
            Db = db;
        }

        public void CreateCardDeck(string name)
        {
            try
            {
                var cardDeck = new CardDeck(name);
                Db.CardDeck.Add(cardDeck);
                Db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateCardDeck(string name, List<BLL.Card> cards)
        {
            try
            {
                var cardDeck = new CardDeck(name, cards);
                Db.CardDeck.Add(cardDeck);
                Db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteCardDeck(int id)
        {
            try
            {
                CardDeck deckToDelete = SearchDeck(id);
                Db.CardDeck.Remove(deckToDelete);
                Db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private CardDeck SearchDeck(int id)
        {
            try
            {
                return Db.CardDeck
                        .Where(s => s.Id == id)
                        .Include(s => s.CardList)
                        .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CardDeck> GetAllCardDecks()
        {
            try
            {
                List<CardDeck> decklist = new List<CardDeck>();
                foreach (var deck in Db.CardDeck)
                {
                    decklist.Add(deck);
                }
                return decklist;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Card> GetAllCardsInDeck(int id)
        {
            try
            {
                CardDeck deckToSelect = SearchDeck(id);
                return deckToSelect.CardList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddCardToDeck(Card card, int deckID)
        {
            try
            {
                var deck = SearchDeck(deckID);
                AddCardToCardList(AddNewCard(card), deck);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddCardToCardList(Card card, CardDeck deck)
        {
            try
            {
                deck.CardList.Add(card);
                Db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Card AddNewCard(Card card)
        {
            try
            {
                Card copyCard = new Card(card.Name);
                Db.Add(copyCard);
                Db.SaveChanges();
                return copyCard;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
