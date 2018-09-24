using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class ASIGNACIONCOMPUTADORES
    {
        [Key]
        public int  SECUENCIAL { get; set; }
        public string RESPONSABLE { get; set; }
        public int SECUANCIALPERSONA { get; set; }
        public int SECUANCIALINGRESOCOMPUTADORES { get; set; }
        public int TIEMPOINICIO { get; set; }
        public int TIEMPOFIN { get; set; }
    }
}
