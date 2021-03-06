﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class ASIGNACIONCOMPUTADORES
    {
        [Key]
        public int SECUENCIAL { get; set; }
        [Required]
        public string RESPONSABLE { get; set; }
        [Required]
        public string CODIGOINTERNO { get; set; }
        [Required]
        public string TIEMPOINICIO { get; set; }
        [Required]
        public string TIEMPOFIN { get; set; }
    }
}
