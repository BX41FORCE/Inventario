﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class BAJADEEQUIPOSVARIOS
    {
        [Key]
        public int SECUENCIAL { get; set; }
        public string TIPO { get; set; }
        public string RESPONSABLE { get; set; }
        public string CODIGOINTERNO { get; set; }
    }
}
