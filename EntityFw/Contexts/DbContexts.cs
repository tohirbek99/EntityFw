using EntityFw.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFw.Contexts
{
    public class DbContexts: DbContext
    {
        public DbContexts(DbContextOptions<DbContexts> options)
            :base(options)
        {

        }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderTranslate> OrderTranslates { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTranslate> ProductTranslates { get; set; }
        public DbSet<Order_Details> Order_Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductTranslate>()
                .HasOne(l=>l.Language)
                .WithMany(p=>p.ProductTranslates)
                .HasForeignKey(l=>l.LanguageId);

            modelBuilder.Entity<OrderTranslate>()
                .HasOne(l=>l.Language)
                .WithMany(p=>p.OrderTranslates)
                .HasForeignKey(l=>l.LanguageId);

             modelBuilder.Entity<OrderTranslate>()
                .HasOne(o=>o.Order)
                .WithMany(p=>p.OrderTranslates)
                .HasForeignKey(o=>o.OrderId);

            modelBuilder.Entity<ProductTranslate>()
                .HasOne(p=>p.Product)
                .WithMany(l=>l.ProductTranslates)
                .HasForeignKey(p=>p.ProductId);

              modelBuilder.Entity<Order_Details>()
                .HasOne(p=>p.Product)
                .WithMany(l=>l.Order_Details)
                .HasForeignKey(p=>p.ProductId);

            modelBuilder.Entity<Order_Details>()
                .HasOne(o => o.Order)
                .WithMany(p => p.Order_Details)
                .HasForeignKey(o => o.OrderId);

        }

        }
}
