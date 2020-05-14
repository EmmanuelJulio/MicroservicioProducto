using CapaDominioProductos.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominioProductos.Querys
{
   public interface IProductoQuery
    {
        List<ProductoDto> GetAllProducto();
        List<ProductoDto> BusquedaProducto(int precio);
    }
}
