using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Card_Game.BLL.Entitys
{
    public class CardDeck : ICardList
    {
        public List<Card> CardList { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public void AddCardToList()
        {
            throw new NotImplementedException();
        }

        public void RemoveCardFromList()
        {
            throw new NotImplementedException();
        }
    }
}
