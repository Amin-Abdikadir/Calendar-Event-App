using Microsoft.EntityFrameworkCore;
using CalendarApp.Models; 

namespace CalendarApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define your DbSets (tables) here
        public DbSet<CalendarEvent> CalendarEvents { get; set; }
    }
}