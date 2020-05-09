using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.BLL
{
    public interface ICardRepo
    {
        List<Card> GetAllCards();
    }
}
