using Card_Game.BLL.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.BLL
{
    public interface ICardDeckRepo
    {
        public void CreateCardDeck(string name);
        public void CreateCardDeck(string name, List<Card> cards);


    }
}
