﻿// <auto-generated />
using System;
using CapaAccesoDatosProductos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CapaAccesoDatosProductos.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CapaDominioProductos.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("CapaDominioProductos.Entidades.ImagenProducto", b =>
                {
                    b.Property<int>("ImagenproductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImagenproductoID");

                    b.ToTable("imagenproducto");
                });

            modelBuilder.Entity("CapaDominioProductos.Entidades.Marca", b =>
                {
                    b.Property<int>("MarcaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaID");

                    b.ToTable("marca");
                });

            modelBuilder.Entity("CapaDominioProductos.Entidades.PrecioProducto", b =>
                {
                    b.Property<int>("PrecioproductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Precioreal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precioventa")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PrecioproductoID");

                    b.ToTable("precioproducto");
                });

            modelBuilder.Entity("CapaDominioProductos.Entidades.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImagenID")
                        .HasColumnType("int");

                    b.Property<int?>("ImagenProductoNavigatorImagenproductoID")
                        .HasColumnType("int");

                    b.Property<int>("MarcaID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrecioID")
                        .HasColumnType("int");

                    b.Property<int?>("PrecioProductoNavigatorPrecioproductoID")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductoID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("ImagenProductoNavigatorImagenproductoID");

                    b.HasIndex("MarcaID");

                    b.HasIndex("PrecioProductoNavigatorPrecioproductoID");

                    b.ToTable("productos");
                });

            modelBuilder.Entity("CapaDominioProductos.Entidades.Producto", b =>
                {
                    b.HasOne("CapaDominioProductos.Entidades.Categoria", "CategoriaNavigator")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapaDominioProductos.Entidades.ImagenProducto", "ImagenProductoNavigator")
                        .WithMany()
                        .HasForeignKey("ImagenProductoNavigatorImagenproductoID");

                    b.HasOne("CapaDominioProductos.Entidades.Marca", "MarcaNavigator")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapaDominioProductos.Entidades.PrecioProducto", "PrecioProductoNavigator")
                        .WithMany()
                        .HasForeignKey("PrecioProductoNavigatorPrecioproductoID");
                });
#pragma warning restore 612, 618
        }
    }
}