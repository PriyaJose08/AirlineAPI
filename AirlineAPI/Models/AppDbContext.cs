using AirlineLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlineAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Flightsmaster> FlightMasters { get; set; }

    }
}
