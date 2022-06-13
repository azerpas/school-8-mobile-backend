using Microsoft.EntityFrameworkCore;

namespace Tracker.Models
{
    public class PgsqlContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }

        public PgsqlContext(DbContextOptions<PgsqlContext> options) : base(options) { }
    }
}