using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.DBContext
{
    public class INGRESOVARIOS
    {
        [Key]
        public int SECUENCIAL { get; set; }
        public int CODIGOINTERNO { get; set; }
        public string CUADADDEUBICACION { get; set; }
        public int SECUENCIALITEM { get; set; }
        public string DESCRIPCION { get; set; }
        public bool MARCA { get; set; }
        public string MODELO { get; set; }
        public string SERIE { get; set; }
        public string PARTICULARIDAD { get; set; }
        public bool ESTADO { get; set; }
        public int NODEFACTURA { get; set; }
        public float VALORFACTURA { get; set; }
        public int FECHAADQUISICION { get; set; }
        public string OBSERVACIONES { get; set; }
    }
}
