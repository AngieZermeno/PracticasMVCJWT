using Escuela.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Escuela.Api.Persistence
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Maestro> Maestro { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<DiasSemana> DiasSemana { get; set; }

    }
}
