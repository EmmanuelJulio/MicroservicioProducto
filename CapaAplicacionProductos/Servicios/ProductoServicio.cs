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
        Producto createProducto(ProductoDto productoDto);
        List<ProductoDto> BusquedaProducto(int precio);
        
        Producto ActualizarProducto(ProductoDto producto);
        Producto EliminarProducto(ProductoDto producto);
        bool EliminarProducto(int productoID);
        
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

        public Producto ActualizarProducto(ProductoDto producto)
        {
            var entity = new Producto()
            {
                Id = producto.id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                PrecioID = producto.PrecioID,
                ImagenID = producto.ImagenID,
                CategoriaID = producto.CategoriaID,
                Stock = producto.Stock,
                MarcaID = producto.MarcaID


            };
            repository.Update<Producto>(entity);
            return entity;
        }
        public Producto EliminarProducto(ProductoDto producto)
        {
            var entity = new Producto()
            {
                Id = producto.id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                PrecioID = producto.PrecioID,
                ImagenID = producto.ImagenID,
                CategoriaID = producto.CategoriaID,
                Stock = producto.Stock,
                MarcaID = producto.MarcaID


            };
            repository.Delete<Producto>(entity);
            return entity;
        }

        public List<ProductoDto> BusquedaProducto(int precio)
        {
            return _Query.BusquedaProducto(precio);
        }

        public Producto createProducto(ProductoDto productoDto)
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
            return entity;



        }

        public bool EliminarProducto(int productoID)
        {

            return repository.DeleteById<Producto>(productoID);
             
        }

        public List<ProductoDto> GetAllProducto()
        {
            return _Query.GetAllProducto();
        }

        public Producto BusquedaProductoID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
