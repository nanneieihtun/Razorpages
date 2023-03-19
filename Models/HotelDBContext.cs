using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Models
{
    public class HotelDBContext :DbContext
    {
        public HotelDBContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<PhotoList> PhotoLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<PhotoList>().ToTable("PhotoList");
        }
    }
}
