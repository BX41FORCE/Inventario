using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class SOLICITUD
    {
        [Key]
        public int SECUENCIAL { get; set; }
        [Required]
        public string RESPONSABLE { get; set; }
        [Required]
        public string TIEMPO { get; set; }
        [Required]
        public string TIPO { get; set; }
        [Required]
        public string TIEMPOINICIO { get; set; }
        [Required]
        public string TIEMPOFIN { get; set; }
        [Required]
        public string DETALLE { get; set; }
        [Required]
        public bool ESTADO { get; set; }
    }
}
