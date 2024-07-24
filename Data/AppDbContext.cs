using Microsoft.EntityFrameworkCore;
using TravelPlanner.Models;

namespace TravelPlanner.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<TripUser> TripUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TripUser>().HasKey(tu => new { tu.TripId, tu.UserId });

            modelBuilder.Entity<TripUser>()
                .HasOne(tu => tu.Trip)
                .WithMany(t => t.TripUsers)
                .HasForeignKey(tu => tu.TripId);

            modelBuilder.Entity<TripUser>()
                .HasOne(tu => tu.User)
                .WithMany(u => u.TripUsers)
                .HasForeignKey(tu => tu.UserId);
        }
    }
}