using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.BLL
{
    public class CardDeckService : ICardDeckService
    {
        private ICardDeckRepo cardDeckRepo;

        public CardDeckService(ICardDeckRepo cardDeckRepo)
        {
            this.cardDeckRepo = cardDeckRepo;
        }

        public void CreateCardDeck(string name)
        {
            //Backend Validiation kann z.B hier durchgeführt werden

            cardDeckRepo.CreateCardDeck(name);
        }


        public void CreateCardDeck(string name, List<Card> cards)
        {
            //Backend Validiation kann z.B hier durchgeführt werden

            cardDeckRepo.CreateCardDeck(name, cards);
        }
    }
}
