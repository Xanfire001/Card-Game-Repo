using Card_Game.BLL.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Game.DAL
{
    class DatabaseContext : DbContext
    {
        public DbSet<CardDeck> Exercises { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
