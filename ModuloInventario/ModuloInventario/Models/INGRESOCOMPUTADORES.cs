using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class INGRESOCOMPUTADORES
    {
        [Key]
        public int SECUENCIAL { get; set; }
        public int CODIGOINTERNO { get; set; }
        public string CUADADDEUBICACION { get; set; }
        public int SECUENCIALITEM { get; set; }
        public string DESCRIPCION { get; set; }
        public float MEMORIARAM { get; set; }
        public string PROCESADOR { get; set; }
        public float DISCODURO { get; set; }
        public float SISTEMAOPERATIVO { get; set; }
        public bool LICENCIADO { get; set; }
        public bool OFFICE { get; set; }
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
