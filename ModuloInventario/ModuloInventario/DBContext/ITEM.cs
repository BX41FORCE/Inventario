using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.DBContext
{
    public class ITEM
    {
        public int SECUENCIAL { get; set; }
        public string CODIGO { get; set; }
        public string TIPOITEM { get; set; }
        public string CATEGORIAITEM { get; set; }
    }
}
