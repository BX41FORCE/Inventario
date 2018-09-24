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
        public int SECUENCIALPERSONA { get; set; }
        public string TIEMPO { get; set; }
        public string TIPO { get; set; }
        public int TIEMPOINICIO { get; set; }
        public int TIEMPOFIN { get; set; }
        public string DETALLE { get; set; }
        public bool ESTADO { get; set; }
    }
}
