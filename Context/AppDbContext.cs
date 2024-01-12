using Microsoft.EntityFrameworkCore;
using SiteLanche.Models;

namespace SiteLanche.Contexto
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptions-Builder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=desktop-p0f4fea\\sqlexpress;Initial Catalog=LanchesDataBase;Integrated Security=True");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}
