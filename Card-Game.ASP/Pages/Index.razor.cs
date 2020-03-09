using Card_Game.BLL.Entitys;
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
            if (_db.CardDeck.Count() == 0)
            {
                string file = System.IO.File.ReadAllText("generated.json");
                var cardDecks = JsonSerializer.Deserialize<List<CardDeck>>(file);
                _db.AddRange(cardDecks);
                _db.SaveChanges();
            }
        }

    }
}
