using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class ITEM
    {
        [Key]
        public int SECUENCIAL { get; set; }
        [Required]
        public string CODIGO { get; set; }
        [Required]
        public string TIPOITEM { get; set; }
        [Required]
        public string CATEGORIAITEM { get; set; }
    }
}
