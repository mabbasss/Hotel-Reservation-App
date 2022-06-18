﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HotelReservation_EF.LoginEntity;

#nullable disable

namespace HotelReservation_EF
{
    public partial class LoginContext : DbContext
    {
        public LoginContext()
        {
        }

        public LoginContext(DbContextOptions<LoginContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Frontend> Frontend { get; set; }
        public virtual DbSet<Kitchen> Kitchen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MABBAS-LT-10909\\SQLEXPRESS;Initial Catalog=LOGIN_MANAGER;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Frontend>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK_Table");

                entity.ToTable("frontend");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pass_word");
            });

            modelBuilder.Entity<Kitchen>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__kitchen__7628B51D2FDAF8B5");

                entity.ToTable("kitchen");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pass_word");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}