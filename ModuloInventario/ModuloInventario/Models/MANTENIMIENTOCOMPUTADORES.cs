using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class MANTENIMIENTOCOMPUTADORES
    {
        [Key]
        public int SECUENCIAL { get; set; }
        public string TIPO { get; set; }
        public string RESPONDABLE { get; set; }
        public string CODIGOINTERNO { get; set; }
    }
}
