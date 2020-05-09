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

        public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=aspnet-Card-Game.ASP-DAEA33CE-8CAF-408B-B1A7-93F83AD60EE2;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
