using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace boat
{
    class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = UserData.db");
        }

        public DbSet<TypeBoat> TypeBoats {get;set;}
        public  DbSet<Boat> Boats {get;set;}
        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Order>()
                .HasMany(c => c.Boats)
                .WithMany(s => s.Order)
                .UsingEntity<OrderBoat>(
                   j => j
                    .HasOne(pt => pt.Boat)
                    .WithMany(t => t.OrderBoat)
                    .HasForeignKey(pt => pt.BoatId),
                j => j
                    .HasOne(pt => pt.Order)
                    .WithMany(p => p.OrderBoat)
                    .HasForeignKey(pt => pt.OrderId)
                );
        }

    }
}
