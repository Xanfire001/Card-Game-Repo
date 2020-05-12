using Card_Game.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Card_Game.ConsoleApp.Tests
{
    public class ControllerTests
    {
        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        public void CheckInput_ShouldReturnTrue(string input)
        {
            // Arrange
            List<Card> cardList = new List<Card> { new Card() { Name = "testCard1", Id = 1}, new Card() { Name = "testCard2", Id = 2 }, new Card() { Name = "testCard3", Id = 3 } };
            List<CardDeck> cardDeckList = new List<CardDeck> { new CardDeck() { Name = "testDeck1", Id = 1}, new CardDeck() { Name = "testDeck2", Id = 2 }, new CardDeck() { Name = "testDeck3", Id = 3 } };
            Controller controller = new Controller(null, null, null);
            bool expected = true;

            // Act
            bool actualCardList = controller.CheckInput(input, cardList);
            bool actualCardDeck = controller.CheckInput(input, cardDeckList);

            // Assert 
            Assert.Equal(expected, actualCardList);
            Assert.Equal(expected, actualCardDeck);
        }


        [Theory]
        [InlineData("dyfjsfg")]
        [InlineData("")]
        [InlineData("2451")]
        [InlineData("5")]
        [InlineData("D")]
        public void CheckInput_ShouldReturnFalse(string input)
        {
            // Arrange
            List<Card> cardList = new List<Card> { new Card() { Name = "testCard1", Id = 1 }, new Card() { Name = "testCard2", Id = 2 }, new Card() { Name = "testCard3", Id = 3 } };
            List<CardDeck> cardDeckList = new List<CardDeck> { new CardDeck() { Name = "testDeck1", Id = 1 }, new CardDeck() { Name = "testDeck2", Id = 2 }, new CardDeck() { Name = "testDeck3", Id = 3 } };
            Controller controller = new Controller(null, null, null);
            bool expected = false;

            // Act
            bool actualCardList = controller.CheckInput(input, cardList);
            bool actualCardDeck = controller.CheckInput(input, cardDeckList);

            // Assert 
            Assert.Equal(expected, actualCardList);
            Assert.Equal(expected, actualCardDeck);
        }
    }
}
