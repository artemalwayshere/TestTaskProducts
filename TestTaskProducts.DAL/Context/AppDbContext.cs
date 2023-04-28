using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestTaskProducts.DAL.Models;

namespace TestTaskProducts.DAL.Context
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration _сonfiguration;

        public AppDbContext(DbContextOptions<AppDbContext> options,
            IConfiguration configuration) : base(options)
        {
            _сonfiguration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_сonfiguration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
