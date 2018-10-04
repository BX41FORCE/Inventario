namespace ModuloInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTARIO.mantenimientoVarios")]
    public partial class mantenimientoVarios
    {
        [Key]
        public int SECUENCIAL { get; set; }

        [Required]
        [StringLength(20)]
        public string TIPO { get; set; }

        [Required]
        [StringLength(30)]
        public string RESPONSABLE { get; set; }

        [Required]
        [StringLength(20)]
        public string CODIGOINTERNO { get; set; }
    }
}
