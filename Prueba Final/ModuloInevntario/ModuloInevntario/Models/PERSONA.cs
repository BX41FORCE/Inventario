namespace ModuloInevntario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAREAS.PERSONA")]
    public partial class PERSONA
    {
        [Key]
        public int SECUENCIAL { get; set; }

        [Required]
        [StringLength(30)]
        public string NOMBRE1 { get; set; }

        [Required]
        [StringLength(30)]
        public string NOMBRE2 { get; set; }

        [Required]
        [StringLength(30)]
        public string APELLIDO1 { get; set; }

        [Required]
        [StringLength(30)]
        public string APELLIDO2 { get; set; }

        [Required]
        [StringLength(1)]
        public string SEXO { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHANAC { get; set; }

        public int SECUENCIALPAIS { get; set; }

        public int NUMEROVERIFICADOR { get; set; }
    }
}
