namespace ModuloInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTARIO.asignacionComputadores")]
    public partial class asignacionComputadores
    {
        [Key]
        public int SECUENCIAL { get; set; }

        [Required]
        [StringLength(40)]
        public string RESPONSABLE { get; set; }

        [Required]
        [StringLength(20)]
        public string CODIGOINTERNO { get; set; }

        [Column(TypeName = "date")]
        public DateTime TIEMPOINICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime TIEMPOFIN { get; set; }
    }
}
