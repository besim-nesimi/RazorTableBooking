using Microsoft.EntityFrameworkCore;
using TableBooking.Models;

namespace TableBooking.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<TableModel> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableModel>().HasData(new TableModel()
            {
                Id = 1,
                NumberOfSeats = 4,
                TableNumber = 100,
                IsBooked = false,
            }, new TableModel()
            {
                Id = 2,
                NumberOfSeats = 6,
                TableNumber = 101,
                IsBooked = false,
            },
            new TableModel()
            {
                Id = 3,
                NumberOfSeats = 8,
                TableNumber = 102,
                IsBooked = false,

            }, new TableModel()
            {
                Id = 4,
                NumberOfSeats = 4,
                TableNumber = 103,
                IsBooked = false,

            }, new TableModel()
            {
                Id = 5,
                NumberOfSeats = 4,
                TableNumber = 104,
                IsBooked = false,

            }, new TableModel
            {
                Id = 6,
                NumberOfSeats = 8,
                TableNumber = 105,
                IsBooked = false,
            });
        }
    }
}
