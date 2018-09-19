using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.DBContext
{
    public class MANTENIMIENTOVARIOS
    {
        [Key]
        public int SECUENCIAL { get; set; }
        public string TIPO { get; set; }
        public int SECUANCIALPERSONA { get; set; }
        public int SECUANCIALINGRESOVARIOS { get; set; }
    }
}
