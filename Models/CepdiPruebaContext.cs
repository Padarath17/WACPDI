using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WACPDI.Models
{
    public partial class CepdiPruebaContext : DbContext
    {
        public CepdiPruebaContext()
        {
        }

        public CepdiPruebaContext(DbContextOptions<CepdiPruebaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Doctores> Doctores { get; set; }
        public virtual DbSet<DoctoresMedicamentos> DoctoresMedicamentos { get; set; }
        public virtual DbSet<Medicamentos> Medicamentos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=104.131.7.254; Database=CepdiPrueba; User Id=testvalue; Password=Test123#; TreatTinyAsBoolean=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctores>(entity =>
            {
                entity.HasKey(e => e.Iddoctor);

                entity.ToTable("doctores");

                entity.Property(e => e.Iddoctor)
                    .HasColumnName("iddoctor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApellidoMaterno)
                    .HasColumnName("apellido_materno")
                    .HasColumnType("varchar(105)");

                entity.Property(e => e.ApellidoPaterno)
                    .HasColumnName("apellido_paterno")
                    .HasColumnType("varchar(105)");

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasColumnType("varchar(65)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("varchar(65)");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasColumnType("varchar(65)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(105)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<DoctoresMedicamentos>(entity =>
            {
                entity.HasKey(e => e.IddoctoresMedicamentos);

                entity.ToTable("doctores_medicamentos");

                entity.Property(e => e.IddoctoresMedicamentos)
                    .HasColumnName("iddoctores_medicamentos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iddoctor)
                    .HasColumnName("iddoctor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idmedicamento)
                    .HasColumnName("idmedicamento")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Medicamentos>(entity =>
            {
                entity.HasKey(e => e.Idmedicamento);

                entity.ToTable("medicamentos");

                entity.Property(e => e.Idmedicamento)
                    .HasColumnName("idmedicamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Compuesto)
                    .HasColumnName("compuesto")
                    .HasColumnType("varchar(295)");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasColumnType("date");

                entity.Property(e => e.Miligramos).HasColumnName("miligramos");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(155)");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.Idusuarios);

                entity.ToTable("usuarios");

                entity.Property(e => e.Idusuarios)
                    .HasColumnName("idusuarios")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasColumnType("varchar(45)");
            });
        }
    }
}
