using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.DBContext
{
    public class ITEM
    {
        [Key]
        public int SECUENCIAL { get; set; }
        public string CODIGO { get; set; }
        public string TIPOITEM { get; set; }
        public string CATEGORIAITEM { get; set; }
    }
}
