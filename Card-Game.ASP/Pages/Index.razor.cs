using Card_Game.BLL;
using Card_Game.DAL;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Card_Game.ASP.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public DatabaseContext _db { get; set; }

        [Inject]
        private ICardDeckRepo CardDeckRepo { get; set; }

        private bool a = false;
        public IndexBase()
        {
        }

        protected override void OnInitialized()
        {
            LoadSampleData();

            base.OnInitialized();
        }

        private void LoadSampleData()
        {

            CardDeckRepo.CreateCardDeck("Wikinger");

            string file = System.IO.File.ReadAllText("generated(Card).json");
            var cards = JsonSerializer.Deserialize<List<Card>>(file);
            //_db.Card.AddRange(cards);

            //_db.SaveChanges();



            CardDeckRepo.CreateCardDeck("Winkinger2", cards);

        }

    }
}
