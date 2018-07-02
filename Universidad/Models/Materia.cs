using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Models
{
    public class Materia : ModelBase
    {


        public string Nombre { get; set; }

        public int Anio { get; set; }

        //Valores validos "A" o "B"
        public string Cuatrimestre { get; set; }

        public Carrera Carrera { get; set; }

        public ICollection<Catedra> Catedras { get; set; }

        public Materia()
        {
            this.Catedras = new HashSet<Catedra>();
        }
    }
}
