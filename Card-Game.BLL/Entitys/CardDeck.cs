using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Card_Game.BLL.Entitys
{
    public class CardDeck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Card> CardList { get; set; }
    }
}
