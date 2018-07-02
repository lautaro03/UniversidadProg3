using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Models
{
    public class Carrera : ModelBase
    {

        public string Nombre { get; set; }

        public ICollection<Materia> Materias { get; set; }

        public Carrera()
        {
            this.Materias = new HashSet<Materia>();
        }
    }
}
