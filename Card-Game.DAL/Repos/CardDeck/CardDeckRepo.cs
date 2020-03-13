using System;
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
        public CardDeckRepo(ConsoleContext db)
        {
            Db = db;
        }

        public ConsoleContext Db { get; }

        public void CreateCardDeck(string name)
        {
            try
            {
                var cardDeck = new CardDeck(name);
                Db.CardDeck.Add(cardDeck);
                Db.SaveChanges();
            }
            catch(Exception)
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
            catch(Exception)
            {
                throw;
            }
        }
        
        public void DeleteCardDeck(int id)
        {
            Db.CardDeck
                .Where(s => s.Id == id)
                .Include(s => s.CardList)
                .FirstOrDefault();
        }

        public List<CardDeck> GetAllCardDecks()
        {
            List<CardDeck> decklist = new List<CardDeck>();
            foreach(var deck in Db.CardDeck)
            {
                decklist.Add(deck);
            }
            return decklist;
        }
    }
}
