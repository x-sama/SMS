using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.Datastor.SQL;

public class MarketContext : DbContext
{
    public MarketContext(DbContextOptions options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Transaction> Transactions { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryId);

        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Electronic", Description = "Computers, Phones and all electronic machines from office to home." },
            new Category { CategoryId = 2, Name = "Men's Fashion", Description = "all what a men need to steal eyes." },
            new Category { CategoryId = 3, Name = "Women's Fashion", Description = "Women's Fashion ... we got her cover " },
            new Category { CategoryId = 4, Name = "Home & Pets", Description = "Home and pet " }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Iphone 8", Price = 9500, Quantity = 100 },
            new Product { ProductId = 2, CategoryId = 1, Name = "hp laptop", Price = 3700, Quantity = 25 },
            new Product { ProductId = 3, CategoryId = 1, Name = "Keyboard", Price = 550, Quantity = 200 },
            new Product { ProductId = 4, CategoryId = 2, Name = "Hat", Price = 50, Quantity = 20 },
            new Product { ProductId = 5, CategoryId = 2, Name = "Watch", Price = 1500, Quantity = 45 },
            new Product { ProductId = 6, CategoryId = 2, Name = "jeans", Price = 300, Quantity = 300 },
            new Product { ProductId = 7, CategoryId = 3, Name = "silver ring", Price = 250, Quantity = 70 },
            new Product { ProductId = 8, CategoryId = 3, Name = "Bras", Price = 34, Quantity = 500 },
            new Product { ProductId = 9, CategoryId = 3, Name = "Pajamas sets", Price = 220, Quantity = 20 },
            new Product { ProductId = 10, CategoryId = 4, Name = "Wall Stickers", Price = 270, Quantity = 50 },
            new Product { ProductId = 11, CategoryId = 4, Name = "Dog Toys", Price = 20, Quantity = 200 },
            new Product { ProductId = 12, CategoryId = 4, Name = "Umbrellas", Price = 70, Quantity = 60 }
        );
    }
}

















