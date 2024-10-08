using Microsoft.EntityFrameworkCore;
using OnData.Models;

namespace OnData.Data
{
    public class OnDataDbContext : DbContext
    {
        public OnDataDbContext(DbContextOptions<OnDataDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Map boolean to NUMBER(1)
            modelBuilder.Entity<Ocorrencia>()
            .Property(b => b.Aprovado)
            .HasConversion(
               v => v ? 1 : 0,
               v => v == 1
            );


            // Other mappings...
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Ocorrencia> Ocorrencias { get; set; }

    }
}

