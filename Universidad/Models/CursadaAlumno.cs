using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Models
{
    public class CursadaAlumno
    {
        [Key]
        [ForeignKey("AlumnoID")]
        public int AlumnoID { get; set; }

        [Key]
        [ForeignKey("CatedraID")]
        public int CatedraID { get; set; }

        public short Nota1erParcial { get; set; }

        public short Nota2doParcial { get; set; }

        public short NotaFinal { get; set; }
    }
}
