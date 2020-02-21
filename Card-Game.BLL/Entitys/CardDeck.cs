using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Card_Game.BLL.Entitys
{
    public class CardDeck : ICardList
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Card> CardList { get; set; }

        public void AddCardToDeck()
        {
            throw new NotImplementedException();
        }

        public void RemoveCardFromDeck()
        {
            throw new NotImplementedException();
        }
    }
}
