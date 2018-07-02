using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Models
{
    public class Catedra : ModelBase
    {

        public DateTime Inicio { get; set; }

        public DateTime Fin{ get; set; }

        public short Horario { get; set; }

        public Materia Materia { get; set; }

        public Profesor Profesor { get; set; }

        public ICollection<CursadaAlumno> Cursadas { get; set; }

        public Catedra()
        {
            this.Cursadas = new HashSet<CursadaAlumno>();
        }

    }
}
