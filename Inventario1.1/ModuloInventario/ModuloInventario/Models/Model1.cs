namespace ModuloInventario.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DBConfig")
        {
        }

        public virtual DbSet<asignacionComputadores> asignacionComputadores { get; set; }
        public virtual DbSet<asignacionVarios> asignacionVarios { get; set; }
        public virtual DbSet<bajaComputadores> bajaComputadores { get; set; }
        public virtual DbSet<bajaVarios> bajaVarios { get; set; }
        public virtual DbSet<ingresoComputadores> ingresoComputadores { get; set; }
        public virtual DbSet<ingresoVarios> ingresoVarios { get; set; }
        public virtual DbSet<item> item { get; set; }
        public virtual DbSet<mantenimientoComputadores> mantenimientoComputadores { get; set; }
        public virtual DbSet<mantenimientoVarios> mantenimientoVarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<asignacionComputadores>()
                .Property(e => e.RESPONSABLE)
                .IsUnicode(false);

            modelBuilder.Entity<asignacionComputadores>()
                .Property(e => e.CODIGOINTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<asignacionVarios>()
                .Property(e => e.RESPONSABLE)
                .IsUnicode(false);

            modelBuilder.Entity<asignacionVarios>()
                .Property(e => e.CODIGOINTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<bajaComputadores>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<bajaComputadores>()
                .Property(e => e.RESPONSABLE)
                .IsUnicode(false);

            modelBuilder.Entity<bajaComputadores>()
                .Property(e => e.CODIGOINTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<bajaVarios>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<bajaVarios>()
                .Property(e => e.RESPONSABLE)
                .IsUnicode(false);

            modelBuilder.Entity<bajaVarios>()
                .Property(e => e.CODIGOINTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoComputadores>()
                .Property(e => e.CODIGOINTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoComputadores>()
                .Property(e => e.CUADADDEUBICACION)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoComputadores>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoComputadores>()
                .Property(e => e.PROCESADOR)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoComputadores>()
                .Property(e => e.MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoComputadores>()
                .Property(e => e.MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoComputadores>()
                .Property(e => e.SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoComputadores>()
                .Property(e => e.PARTICULARIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoComputadores>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoVarios>()
                .Property(e => e.CODIGOINTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoVarios>()
                .Property(e => e.CUADADDEUBICACION)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoVarios>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoVarios>()
                .Property(e => e.MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoVarios>()
                .Property(e => e.MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoVarios>()
                .Property(e => e.SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoVarios>()
                .Property(e => e.PARTICULARIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<ingresoVarios>()
                .Property(e => e.OBSERVACIONES)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .Property(e => e.TIPOITEM)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .Property(e => e.CATEGORIAITEM)
                .IsUnicode(false);

            modelBuilder.Entity<mantenimientoComputadores>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<mantenimientoComputadores>()
                .Property(e => e.RESPONSABLE)
                .IsUnicode(false);

            modelBuilder.Entity<mantenimientoComputadores>()
                .Property(e => e.CODIGOINTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<mantenimientoVarios>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<mantenimientoVarios>()
                .Property(e => e.RESPONSABLE)
                .IsUnicode(false);

            modelBuilder.Entity<mantenimientoVarios>()
                .Property(e => e.CODIGOINTERNO)
                .IsUnicode(false);
        }
    }
}
