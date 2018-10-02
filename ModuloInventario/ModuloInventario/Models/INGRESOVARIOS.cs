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
        [Required]
        public string CODIGOINTERNO { get; set; }
        [Required]
        public string CUADADDEUBICACION { get; set; }
        [Required]
        public string ITEM { get; set; }
        [Required]
        public string DESCRIPCION { get; set; }
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
