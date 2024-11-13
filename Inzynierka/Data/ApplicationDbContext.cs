using Inzynierka.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inzynierka.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<ServiceRecords> ServiceRecords { get; set; }
        public DbSet<Reservations> Reservations { get; set; }

    }
}
