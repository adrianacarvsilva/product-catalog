using Microsoft.EntityFrameworkCore;
using Models;
using ProductCatalog.Data.Maps;

namespace ProductCatalog.Data{
    public class StoreDataContext: DbContext
    {
        public DbSet<Product> Products {get;set;}
          public DbSet<Category> Categories {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-GDRTVL28\SQLEXPRESS;Database=prodcat;User ID= sa;Password=sa");
        }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new CategoryMap());
        }
    }
}
