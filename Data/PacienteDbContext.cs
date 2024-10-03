using Microsoft.EntityFrameworkCore;
using OnData.Models;

namespace OnData.Data
{
    public class PacienteDbContext : DbContext
    {
        public PacienteDbContext(DbContextOptions<PacienteDbContext> options) : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
    }
}

