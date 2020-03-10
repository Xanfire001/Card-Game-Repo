using Card_Game.BLL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.DAL
{
    public class DatabaseContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Card> Card { get; set; }
        public DbSet<CardDeck> CardDeck { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
