using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using Entity.EFModel;
namespace DAL.Models;

public partial class ModeloParcialContext : DbContext
{
    public ModeloParcialContext()
    {
    }

    public ModeloParcialContext(DbContextOptions<ModeloParcialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Entrada> Entrada { get; set; }

    public virtual DbSet<Estadio> Estadio { get; set; }

    public virtual DbSet<Evento> Evento { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.IdEntrada);

            entity.Property(e => e.IdEntrada).HasColumnName("ID_Entrada");
            entity.Property(e => e.Asiento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Asignacion");
            entity.Property(e => e.IdEvento).HasColumnName("ID_Evento");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.IdEvento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entrada_Evento");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_Entrada_Usuario");
        });

        modelBuilder.Entity<Estadio>(entity =>
        {
            entity.HasKey(e => e.IdEstadio);

            entity.Property(e => e.IdEstadio).HasColumnName("ID_Estadio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.IdEvento);

            entity.Property(e => e.IdEvento).HasColumnName("ID_Evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Evento");
            entity.Property(e => e.IdEstadio).HasColumnName("ID_Estadio");
            entity.Property(e => e.NombreEvento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_Evento");

            entity.HasOne(d => d.IdEstadioNavigation).WithMany(p => p.Evento)
                .HasForeignKey(d => d.IdEstadio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evento_Estadio");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTipo);

            entity.ToTable("Tipo_Usuario");

            entity.Property(e => e.IdTipo).HasColumnName("ID_Tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.HasIndex(e => e.Dni, "UQ_Usuario_DNI").IsUnique();

            entity.HasIndex(e => e.NombreUsuario, "UQ_Usuario_Nombre_Usuario").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdTipo).HasColumnName("ID_Tipo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Usuario");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Usuario)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Tipo_Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
