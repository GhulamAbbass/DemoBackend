using Microsoft.EntityFrameworkCore;

namespace TrackingWorldDemo.Models
{
    public class FleetContext:DbContext
    {
        public FleetContext(DbContextOptions<FleetContext> options):base(options)
        {
    

        }
        public DbSet<Vehicle> vehicles{get; set;}
    }
}