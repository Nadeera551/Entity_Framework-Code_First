using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Models
{
    public class BookStoresDBContext : DbContext
    {
        public DbSet<Publisher>Publishers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=DESKTOP-3OE8PHC;Initial Catalog=BookStoresDB;Integrated Security=True");
        }
    }
}
