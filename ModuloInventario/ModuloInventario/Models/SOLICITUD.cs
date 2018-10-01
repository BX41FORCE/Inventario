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
        public string RESPONSABLE { get; set; }
        public string TIEMPO { get; set; }
        public string TIPO { get; set; }
        public string TIEMPOINICIO { get; set; }
        public string TIEMPOFIN { get; set; }
        public string DETALLE { get; set; }
        public bool ESTADO { get; set; }
    }
}
