namespace ModuloInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTARIO.ingresoComputadores")]
    public partial class ingresoComputadores
    {
        [Key]
        public int SECUENCIAL { get; set; }

        [Required]
        [StringLength(20)]
        public string CODIGOINTERNO { get; set; }

        [Required]
        [StringLength(20)]
        public string CUADADDEUBICACION { get; set; }

        [Required]
        [StringLength(20)]
        public string DESCRIPCION { get; set; }

        public int MEMORIARAM { get; set; }

        [Required]
        [StringLength(40)]
        public string PROCESADOR { get; set; }

        public int DISCODURO { get; set; }

        public bool LICENCIADO { get; set; }

        public bool OFFICE { get; set; }

        [Required]
        [StringLength(15)]
        public string MARCA { get; set; }

        [Required]
        [StringLength(20)]
        public string MODELO { get; set; }

        [Required]
        [StringLength(30)]
        public string SERIE { get; set; }

        [Required]
        [StringLength(30)]
        public string PARTICULARIDAD { get; set; }

        public bool ESTADO { get; set; }

        public int NODEFACTURA { get; set; }

        public int VALORFACTURA { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHAADQUISICION { get; set; }

        [Required]
        [StringLength(100)]
        public string OBSERVACIONES { get; set; }
    }
}
