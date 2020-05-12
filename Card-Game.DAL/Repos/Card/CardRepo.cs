using Card_Game.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.DAL
{
    public class CardRepo : ICardRepo
    {
        public ConsoleContext Db { get; }
        public CardRepo(ConsoleContext db)
        {
            Db = db;
            //Db.Add(new Card("Lagertha"));
            //Db.Add(new Card("Ragnar"));
            //Db.Add(new Card("Floki"));
            //Db.Add(new Card("Björn"));
            //Db.Add(new Card("Übbe"));
            //Db.Add(new Card("Ivar"));
            //Db.SaveChanges();
        }

        public List<Card> GetAllCards()
        {
            List<Card> cardList = new List<Card>();
            foreach(var card in Db.Card)
            {
                cardList.Add(card);
            }
            return cardList;
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
