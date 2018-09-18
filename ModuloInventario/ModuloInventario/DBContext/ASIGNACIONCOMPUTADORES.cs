using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.DBContext
{
    public class ASIGNACIONCOMPUTADORES
    {
        public int  SECUENCIAL { get; set; }
        public string RESPONSABLE { get; set; }
        public int SECUANCIALPERSONA { get; set; }
        public int SECUANCIALINGRESOCOMPUTADORES { get; set; }
        public int TIEMPOINICIO { get; set; }
        public int TIEMPOFIN { get; set; }
    }
}
