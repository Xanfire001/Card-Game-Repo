using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Card_Game.BLL
{
    public class CardDeck
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Card> CardList { get; set; }
        #endregion

        #region Constructors

        public CardDeck() { }
        public CardDeck(string name)
        {
            Name = name;
        }
        public CardDeck(string name, List<Card> list)
        {
            Name = name;
            CardList = list;
        }
        #endregion
    }
}
