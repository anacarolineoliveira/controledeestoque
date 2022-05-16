﻿// <auto-generated />
using System;
using ControleDeEstoque.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleDeEstoque.Migrations
{
    [DbContext(typeof(MercadoContext))]
    partial class MercadoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleDeEstoque.Models.Alimentos", b =>
                {
                    b.Property<int>("AlimentosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Promotor")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dt_Validade");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("AlimentosId");

                    b.ToTable("Tbl_Estoque");
                });
#pragma warning restore 612, 618
        }
    }
}