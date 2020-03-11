using System;
using System.Collections.Generic;
using System.Text;
using Card_Game.BLL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Serilog;

namespace Card_Game.ConsoleApp
{
    public class Controller
    {
        #region Properties
        private readonly ICardDeckService _cardDeckService;

        #endregion
        public Controller(ICardDeckService cardDeckService)
        {
            _cardDeckService = cardDeckService;
        }

        public void Run()
        {
            _cardDeckService.CreateCardDeck("Wikinger");
            Log.Information("test");
        }
    }
}