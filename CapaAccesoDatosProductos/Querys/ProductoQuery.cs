using CapaDominioProductos.DTOs;
using CapaDominioProductos.Querys;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CapaAccesoDatosProductos.Querys
{
   public class ProductoQuery : IProductoQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler compiler;

        public ProductoQuery(IDbConnection connection, Compiler compiler)
        {
            this.connection = connection;
            this.compiler = compiler;
        }

        public List<ProductoDto> GetAllProducto()
        {
            var db = new QueryFactory(connection, compiler);
            var query = db.Query("Productos");
            var result = query.Get<ProductoDto>();
            return result.ToList();
        }
        public List<ProductoDto> BusquedaProducto(int precio)
        {
            var db = new QueryFactory(connection, compiler);
            var query = db.Query("Productos").Select("Nombre"
                , "Descripcion"
                , "PrecioID"
                , "ImagenID"
                , "CategoriaID")
                .Where("PrecioID", "=", precio);
            var result = query.Get<ProductoDto>().ToList();
            return result;
        }
    }
}
