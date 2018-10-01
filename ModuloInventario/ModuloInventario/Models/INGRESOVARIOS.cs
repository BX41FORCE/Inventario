using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class INGRESOVARIOS
    {
        [Key]
        public int SECUENCIAL { get; set; }
        public string CODIGOINTERNO { get; set; }
        public string CUADADDEUBICACION { get; set; }
        public string ITEM { get; set; }
        public string DESCRIPCION { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public string SERIE { get; set; }
        public string PARTICULARIDAD { get; set; }
        public bool ESTADO { get; set; }
        public string NODEFACTURA { get; set; }
        public int VALORFACTURA { get; set; }
        public string FECHAADQUISICION { get; set; }
        public string OBSERVACIONES { get; set; }
    }
}
