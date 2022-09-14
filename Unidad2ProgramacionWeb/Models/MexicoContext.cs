﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Unidad2ProgramacionWeb.Models
{
    public partial class MexicoContext : DbContext
    {
        public MexicoContext()
        {
        }

        public MexicoContext(DbContextOptions<MexicoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estado> Estados { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=Mexico;user=root;password=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.17-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("estados");

                entity.Property(e => e.Abrev)
                    .HasMaxLength(10)
                    .HasColumnName("abrev")
                    .HasComment("NOM_ABR - Nombre abreviado de la entidad");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .HasColumnName("nombre")
                    .HasComment("NOM_ENT - Nombre de la entidad");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
