using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloInventario.Models
{
    public class InventarioContext: DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options)
        {
        }

        public DbSet<INGRESOCOMPUTADORES> ingresoComputadores { get; set; }
        public DbSet<INGRESOVARIOS> ingresoVarios { get; set; }
        public DbSet<ASIGNACIONCOMPUTADORES> asignacionComputadores { get; set; }
        public DbSet<ASIGNACIONVARIOS> asignacionVarios { get; set; }
        public DbSet<BAJADEEQUIPOSCOMPUTADORES> bajaComputadores { get; set; }
        public DbSet<BAJADEEQUIPOSVARIOS> bajaVarios { get; set; }
        public DbSet<MANTENIMIENTOCOMPUTADORES> mantenimientoComputadores { get; set; }
        public DbSet<MANTENIMIENTOVARIOS> mantenimientoVarios { get; set; }
        public DbSet<ITEM> item { get; set; }
        public DbSet<SOLICITUD> solicitud { get; set; }
        public DbSet<DEBOLUCIONEQUIPO> debolucion { get; set; }
    }
}
