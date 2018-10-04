namespace ModuloInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTARIO.ingresoVarios")]
    public partial class ingresoVarios
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
