﻿using System.Collections.Generic;

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
