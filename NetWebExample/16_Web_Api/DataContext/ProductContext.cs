using _16_Web_Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace _16_Web_Api.DataContext
{
    public class ProductContext(DbContextOptions<ProductContext> options):DbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var listComparer = new ValueComparer<List<string>>((a, b) => a!.SequenceEqual(b!),
                v => v.Aggregate(0, (hash, s) => HashCode.Combine(hash, s.GetHashCode())),
                v => v.ToList()
                );
            modelBuilder.Entity<Product>().Property(p => p.Tags).HasConversion(v => string.Join(',', v),v => v.Split(','
                , StringSplitOptions.RemoveEmptyEntries).ToList(), listComparer);
            modelBuilder.Entity<Product>().Property(p => p.Images).HasConversion(v => string.Join(',', v),v => v.Split(','
                , StringSplitOptions.RemoveEmptyEntries).ToList(), listComparer);
               
        }
    }
}
