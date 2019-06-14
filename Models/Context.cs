using Microsoft.EntityFrameworkCore;
using TrackingWorldDemo.Models;

namespace TrackingWorldDemo.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
    

        }
        public DbSet<Vehicle> vehicles{get; set;}
    }
}