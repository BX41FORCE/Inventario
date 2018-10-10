using ModuloInevntario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuloInevntario.ViewModels
{
    public class IndexViewModel : BaseModelo
    {
        public List<ingresoComputadores> ingresoComputador { get; set; }
        public List<ingresoVarios> ingresoVario { get; set; }
        public List<asignacionComputadores> asignacionComputador { get; set; }
        public List<asignacionVarios> asignacionVario { get; set; }
        public List<item> itemsCatalogo { get; set; }
        public List<mantenimientoComputadores> matenimientoComputador { get; set; }
        public List<mantenimientoVarios> manteniminetoVario { get; set; }
    }
}