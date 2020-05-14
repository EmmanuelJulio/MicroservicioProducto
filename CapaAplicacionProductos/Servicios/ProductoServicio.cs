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
        bool EliminarProducto(int productoID);
        List<ProductoDto> GetAllProducto();

    }
    public class ProductoServicio: IProductoService
    {


        private readonly IGenericsRepository<Entidad> repository;
        private readonly IProductoQuery _Query;

        public ProductoServicio(IGenericsRepository<Entidad> repository,IProductoQuery query)
        {
            this.repository = repository;
            _Query = query;
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

            repository.Agregar(entity);
            return entity;



        }

        public bool EliminarProducto(int productoID)
        {

            return repository.DeleteById(productoID);
             
        }

        public List<ProductoDto> GetAllProducto()
        {
            return _Query.GetAllProducto();
        }
    }
}
