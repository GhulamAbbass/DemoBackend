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
        public DbSet<User> User { get; set; }
        public DbSet<Product> Products{get; set;}
    }
}