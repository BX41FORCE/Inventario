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
        [Required]
        public string TIPO { get; set; }
        [Required]
        public string TIEMPOENTREGA { get; set; }
        [Required]
        public string DETALLE { get; set; }
    }
}
