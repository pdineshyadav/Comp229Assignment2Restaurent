namespace Comp229Assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuContext : DbContext
    {
        public MenuContext()
            : base("name=MenuConnection")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Dessert> Desserts { get; set; }
        public virtual DbSet<Soup> Soups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerName)
                .IsUnicode(false);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerImage)
                .IsFixedLength();

            modelBuilder.Entity<Dessert>()
                .Property(e => e.DessertName)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.DessertShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.DessertLongDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.DessertImage)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.SoupName)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.SoupShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.SoupLongDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.SoupImage)
                .IsUnicode(false);
        }
    }
}
