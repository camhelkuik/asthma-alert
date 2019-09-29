using AsthmaAlertApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace  AsthmaAlertApi.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<TrackingItem> TrackingItems { get; set; }

        public DbSet<DailyAq> DailyAqs { get; set; }

        public DbSet<DustDander> DustDanders { get; set; }
    }
}