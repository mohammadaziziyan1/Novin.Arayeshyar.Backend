using Microsoft.EntityFrameworkCore;
using Novin.Arayeshyar.Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.infrastructure.Database
{
    public class ArayeshyarDB : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Barber> Barbers { get; set; }
        public DbSet<BarberOwner> BarberOwners { get; set; }
        public DbSet<BarberShop> BarberShops { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Makeup> MakeUps { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SystemManager> SystemManagers { get; set; }
        public ArayeshyarDB(DbContextOptions<ArayeshyarDB> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Address>().HasKey(m => m.PostalCode);
            modelBuilder.Entity<Barber>().HasKey(m => m.BarberCode);
            modelBuilder.Entity<BarberOwner>().HasKey(m => m.BarberOwnerCode);
            modelBuilder.Entity<BarberShop>().HasKey(m => m.BarberShopCode);
            modelBuilder.Entity<Cost>().HasKey(m => m.CostCode);
            modelBuilder.Entity<Customer>().HasKey(m => m.CustomerCode);
            modelBuilder.Entity<Makeup>().HasKey(m => m.MakeUpCode);
            modelBuilder.Entity<Order>().HasKey(m => m.OrderCode);
            modelBuilder.Entity<Reservation>().HasKey(m => m.ReservationCode);
            modelBuilder.Entity<Survey>().HasKey(m => m.SurveyCode);
            modelBuilder.Entity<SystemManager>().HasKey(m => m.ManagerCode);
        }
    }
}
