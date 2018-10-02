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
        [Required]
        public string CODIGOINTERNO { get; set; }
        [Required]
        public string CUADADDEUBICACION { get; set; }
        [Required]
        public string ITEM { get; set; }
        [Required]
        public string DESCRIPCION { get; set; }
        [Required]
        public int MEMORIARAM { get; set; }
        [Required]
        public string PROCESADOR { get; set; }
        [Required]
        public int DISCODURO { get; set; }
        [Required]
        public string SISTEMAOPERATIVO { get; set; }
        [Required]
        public bool LICENCIADO { get; set; }
        [Required]
        public bool OFFICE { get; set; }
        [Required]
        public string MARCA { get; set; }
        [Required]
        public string MODELO { get; set; }
        [Required]
        public string SERIE { get; set; }
        [Required]
        public string PARTICULARIDAD { get; set; }
        [Required]
        public bool ESTADO { get; set; }
        [Required]
        public string NODEFACTURA { get; set; }
        [Required]
        public int VALORFACTURA { get; set; }
        [Required]
        public string FECHAADQUISICION { get; set; }
        [Required]
        public string OBSERVACIONES { get; set; }
    }
}
