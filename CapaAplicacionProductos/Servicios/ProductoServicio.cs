using CapaDominioProductos.Comandos;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using CapaDominioProductos.Querys;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CapaAplicacionProductos.Servicios
{
    public interface IProductoService
    {
        ProductoDto createProducto(ProductoDto productoDto);
        List<ProductoDto> BusquedaProducto(int precio);
        Producto EliminarProducto(ProductoDto producto);
        List<ProductoDto> GetAllProducto();

    }
    public class ProductoServicio: IProductoService
    {


        private readonly IGenericsRepository repository;
        private readonly IProductoQuery _Query;

        public ProductoServicio(IGenericsRepository repository,IProductoQuery query)
        {
            this.repository = repository;
            _Query = query;
        }


        public List<ProductoDto> BusquedaProducto(int precio)
        {
            return _Query.BusquedaProducto(precio);
        }

        public ProductoDto createProducto(ProductoDto productoDto)
        {

            var entity = new Producto()
            {
                Nombre = productoDto.Nombre ,
                Descripcion =productoDto.Descripcion ,
                PrecioID = productoDto.PrecioID,
                ImagenID = productoDto.ImagenID,
                CategoriaID = productoDto.CategoriaID,
                Stock = productoDto.Stock,
                MarcaID = productoDto.MarcaID


            };

            repository.Agregar<Producto>(entity);
            return new ProductoDto {
                Nombre = entity.Nombre ,
                Descripcion = entity.Descripcion,
                PrecioID= entity.PrecioID,
                ImagenID = entity.ImagenID ,
                CategoriaID = entity.CategoriaID,
                MarcaID = entity.MarcaID,
                Stock = entity.Stock

            };



        }

        public Producto EliminarProducto(ProductoDto producto)
        {
            var entity = new Producto()
            {
                
                CategoriaID = producto.CategoriaID,
                Nombre = producto.Nombre ,
                Descripcion = producto.Descripcion,
                PrecioID = producto.PrecioID,
                ImagenID = producto.ImagenID,
                MarcaID =  producto.MarcaID,
                Stock = producto.Stock
                
            };
            repository.Delete<Producto>(entity);
            return entity;
        }

        public List<ProductoDto> GetAllProducto()
        {
            return _Query.GetAllProducto();
        }
    }
}
