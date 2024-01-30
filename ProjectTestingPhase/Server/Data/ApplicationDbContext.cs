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
        public DbSet<Bills> Bills{ get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Car> Cars{ get; set; }
        public DbSet<Chat> Chats{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Driver{ get; set; }
        public DbSet<Feedback> Feedbacks{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Driver)
                .WithMany()
                .HasForeignKey(f => f.DriverId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
