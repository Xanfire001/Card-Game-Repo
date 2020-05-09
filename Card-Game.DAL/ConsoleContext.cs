using Card_Game.BLL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.DAL
{
    public class ConsoleContext : DbContext
    {
        public DbSet<Card> Card { get; set; }
        public DbSet<CardDeck> CardDeck { get; set; }     

        public ConsoleContext()
        {

        }
        public ConsoleContext(DbContextOptions<ConsoleContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Card-Game-Console;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}