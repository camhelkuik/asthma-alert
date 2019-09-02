using AsthmaAlertApi.Models;
using Microsoft.EntityFrameworkCore;

namespace  AsthmaAlertApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        public DbSet<TrackingItem> TrackingItems { get; set; }

        public DbSet<DailyAq> DailyAqs { get; set; }
    }
}