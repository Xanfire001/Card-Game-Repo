using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.BLL
{
    public class CardService : ICardService
    {

        private ICardRepo _CardRepo;

        public CardService(ICardRepo cardRepo)
        {
            _CardRepo = cardRepo;
        }
        public List<Card> GetAllCards()
        {
            return _CardRepo.GetAllCards();
        }
    }
}
