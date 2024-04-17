using Microsoft.EntityFrameworkCore;
using SitePizzaria.Models;

namespace SitePizzaria.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<PizzaModel> Pizzas { get; set; }
    }
}
