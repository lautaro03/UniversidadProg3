using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Catedra> Catedras { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<CursadaAlumno> CursadaAlumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CursadaAlumno>().HasKey(table => new {
                table.AlumnoID,
                table.CatedraID
            });

            base.OnModelCreating(builder);
        }
    }
}
