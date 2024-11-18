using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using sge.Aplicacion;
namespace sge.Repositorios;

    public class DataContext : DbContext
    {
      public DataContext()
      {}
      public DataContext(DbContextOptions<DataContext> options) : base(options)
      {
      }

      #nullable disable
      public DbSet<Usuario> Users { get; set; }
      public DbSet<Expediente> Expedientes { get; set; }
      public DbSet<Tramite> Tramites { get; set; }
      #nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=database.sqlite");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Expediente>()
        .HasMany<Tramite>() // No se necesita referencia de navegación en Tramite
        .WithOne() // Sin propiedad de navegación en Tramite
        .HasForeignKey(t => t.expedienteId) // Especifica la clave externa en Tramite
        .OnDelete(DeleteBehavior.Cascade);
    }
    }