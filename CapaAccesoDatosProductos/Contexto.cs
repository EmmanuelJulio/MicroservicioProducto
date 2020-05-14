using CapaDominioProductos.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAccesoDatosProductos
{
    public class Contexto:DbContext
    {

        public DbSet<Producto> productos { get; set; }
        public DbSet<Categoria> categorias { get; set; }
 
        public DbSet<ImagenProducto> imagenproducto { get; set; }
        public DbSet<Marca> marca { get; set; }
        public DbSet<PrecioProducto> precioproducto { get; set; }



        public Contexto(DbContextOptions<Contexto> opciones)

           : base(opciones)
        {
        }


    }
}
