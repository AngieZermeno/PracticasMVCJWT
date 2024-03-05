using ApiJWT.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiJWT.Aplicacion
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Maestro> Maestro { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<AlumnoMateria> AlumnoMateria { get; set; }
        public DbSet<Horario> Horario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<AlumnoMateria>().HasKey(x => new { x.Alumno, x.Materia });
        }
    }
}
