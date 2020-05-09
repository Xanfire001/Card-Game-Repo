using System;
using Card_Game.DAL;
using Card_Game.BLL;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Autofac.Extras.Moq;
using Moq;

namespace Card_Game.DAL.Tests
{
    public class CardDeckRepoTests
    {
        [Fact]
        public void AddCardToCardList_ShouldWork()
        {
            using (var mock = AutoMock.GetLoose())
            {
                
                List<Card> test = new List<Card>();
                CardDeck deck = new CardDeck("TestDeck", test);
                Card card = new Card("testCard");

                mock.Mock<ConsoleContext>()
                    .Setup(x => x.SaveChanges());

                var cls = mock.Create<CardDeckRepo>();

                cls.AddCardToCardList(card, deck);

                mock.Mock<ConsoleContext>()
                    .Verify(x => x.SaveChanges(), Times.Exactly(1));

                Assert.True(deck.CardList.Count == 1);
                Assert.Equal(card.Name, deck.CardList[0].Name);
            }
        }

        [Fact]
        public void AddNewCard_ShouldWork()
        {
            //Beispiel zum implementieren
        }
    }
}
