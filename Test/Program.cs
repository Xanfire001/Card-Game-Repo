using Microsoft.EntityFrameworkCore;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyContext();
        }
    }

    public class MyContext : DbContext
    {
        public MyContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Card-Game-Console;Trusted_Connection=True;MultipleActiveResultSets=true;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
