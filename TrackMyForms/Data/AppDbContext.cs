using Microsoft.EntityFrameworkCore;
using TrackMyForms.Models;

namespace TrackMyForms.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<FormEntry> FormEntries { get; set; }
    }
}
