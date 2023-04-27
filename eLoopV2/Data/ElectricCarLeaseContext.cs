using Microsoft.EntityFrameworkCore;
using eLoopV2.Models;

namespace eLoopV2.Data
{
    public class ElectricCarLeaseContext : DbContext
    {
        public ElectricCarLeaseContext(DbContextOptions<ElectricCarLeaseContext> options) : base(options)
        {
        }

        public DbSet<ElectricCar> ElectricCars { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Lease>? Leases { get; set; }
        public DbSet<Availability>? Availabilities { get; set; }
        public DbSet<Reservation>? Reservations { get; set; }

        public DbSet<Location>? ElectricCarLocations { get; set; }


    }

}
