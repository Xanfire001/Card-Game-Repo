using System;
using System.Collections.Generic;
using System.Text;
using Card_Game.BLL;

namespace Card_Game.DAL
{
    public class CardDeckRepo : ICardDeckRepo
    {
        public DatabaseContext Db { get; set; }
        public CardDeckRepo(DatabaseContext db)
        {
            Db = db;
        }
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
