﻿using ModuloInevntario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuloInevntario.ViewModels
{
    public class IndexViewModel : BaseModelo
    {
        public List<ingresoComputadores> ingresoComputador { get; set; }
    }
}