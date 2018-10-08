namespace ModuloInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTARIO.item")]
    public partial class item
    {
        [Key]
        public int SECUENCIAL { get; set; }

        [Required]
        [StringLength(20)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(30)]
        public string TIPOITEM { get; set; }

        [Required]
        [StringLength(20)]
        public string CATEGORIAITEM { get; set; }
    }
}
