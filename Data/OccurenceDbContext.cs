using Microsoft.EntityFrameworkCore;
using on_data_server_dotnet.Models;
using OnData.Data;

namespace on_data_server_dotnet.Data
{
    public class OccurrenceDbContext : DbContext
    {
        public OccurrenceDbContext(DbContextOptions<OccurrenceDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and other model settings here if needed
        }

        public DbSet<Occurrence> Occurrences { get; set; }
    }
}