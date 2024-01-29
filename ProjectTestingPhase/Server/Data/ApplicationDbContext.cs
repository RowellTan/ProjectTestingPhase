using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProjectTestingPhase.Server.Models;
using ProjectTestingPhase.Shared.Domain;
using System.Drawing;

namespace ProjectTestingPhase.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Bills> Bills { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarStatus> CarStatuses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<IncidentReport> IncidentReports { get; set; }
        public DbSet<UserRating> UserRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
                    .HasOne(c => c.Driver)
                    .WithMany()
                    .HasForeignKey(c => c.DriverId)
                    .OnDelete(DeleteBehavior.Cascade);  // Cascade delete for Driver relationship

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Booking)
                .WithMany()
                .HasForeignKey(c => c.BookingId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Feedback>()
                 .HasOne(f => f.Customer)
                .WithMany()
                .HasForeignKey(f => f.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);  // Restrict delete for Customer relationship

            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Driver)
                .WithMany()
                .HasForeignKey(f => f.DriverId)
                .OnDelete(DeleteBehavior.Restrict);  // Restrict delete for Driver relationship

            modelBuilder.Entity<Feedback>()
                  .HasOne(f => f.Booking)
                  .WithMany()
                  .HasForeignKey(f => f.BookingId)
                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserRating>()
                  .HasOne(ur => ur.Driver)
                  .WithMany()
                  .HasForeignKey(ur => ur.DriverId)
                  .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserRating>()
                .HasOne(ur => ur.Customer)
                .WithMany()
                .HasForeignKey(ur => ur.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserRating>()
                .HasOne(ur => ur.Booking)
                .WithMany()
                .HasForeignKey(ur => ur.BookingId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
