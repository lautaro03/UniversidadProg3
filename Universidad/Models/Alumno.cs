using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Models
{
    public class Alumno : ModelBase
    {

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public DateTime FecNacimiento { get; set; }

        public ICollection<CursadaAlumno> Cursadas { get; set; }

        public Alumno()
        {
            this.Cursadas = new HashSet<CursadaAlumno>();
        }
    }
}
