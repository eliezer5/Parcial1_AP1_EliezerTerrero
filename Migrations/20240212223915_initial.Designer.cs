﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1_AP1_EliezerTerrero.DAL;

#nullable disable

namespace Parcial1_AP1_EliezerTerrero.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240212223915_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Parcial1_AP1_EliezerTerrero.Models.Metas", b =>
                {
                    b.Property<int>("MetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("MetaId");

                    b.ToTable("Metas");
                });
#pragma warning restore 612, 618
        }
    }
}
