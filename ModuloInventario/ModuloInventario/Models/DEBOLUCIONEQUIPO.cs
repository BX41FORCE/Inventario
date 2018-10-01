using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class DEBOLUCIONEQUIPO
    {
        [Key]
        public int SECUENCIAL { get; set; }
        public string TIPO { get; set; }
        public string TIEMPOENTREGA { get; set; }
        public string DETALLE { get; set; }
    }
}
