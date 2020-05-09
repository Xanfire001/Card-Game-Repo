using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.BLL.Entitys
{
    public interface ICardList
    {
        #region Properties     
        List<Card> CardList {get; set;}
        #endregion

        #region Methods
        public void AddCardToDeck();

        public void RemoveCardFromDeck();
        #endregion
    }
}
