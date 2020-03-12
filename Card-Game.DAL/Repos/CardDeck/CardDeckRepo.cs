using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Card_Game.BLL;
using Microsoft.EntityFrameworkCore;

namespace Card_Game.DAL
{
    public class CardDeckRepo : ICardDeckRepo
    {
        public CardDeckRepo(DatabaseContext db)
        {
            Db = db;
        }

        public DatabaseContext Db { get; }

        public void CreateCardDeck(string name)
        {
            var cardDeck = new CardDeck(name);
            Db.CardDeck.Add(cardDeck);
            Db.SaveChanges();
        }

        public void CreateCardDeck(string name, List<BLL.Card> cards)
        {
            var cardDeck = new CardDeck(name, cards);
            Db.CardDeck.Add(cardDeck);
            Db.SaveChanges();
        }
    }
}
