using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaAplicacionProductos.Servicios;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Producto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService servicio;


        public ProductoController(IProductoService servicio)
        {
            this.servicio = servicio;
        }
        [Route ("IncertarProducto")]
        [HttpPost]
        public IActionResult Post(ProductoDto productoDto)
        {
            //try
            //{
                return new  JsonResult(servicio.createProducto(productoDto)) { StatusCode = 201};

            //}
            //catch (Exception e)
            //{
            //    return BadRequest(e.Message);
            //}        
        }

       [Route("FiltroPrecio")]
        [HttpGet]
        public IActionResult GETSearchPrice(int precio)
        {
            try
            {
                return new JsonResult(servicio.BusquedaProducto(precio)) { StatusCode = 200 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        
        [Route("TraerProductos")]
        [HttpGet]
        public IActionResult GetProducts()
        {
            try
            {
                return new JsonResult(servicio.GetAllProducto()) { StatusCode = 200 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }
        [Route("BorrarProducto")]
        [HttpDelete]
        public IActionResult DeleteProducto(int id)
        {
            try
            {
                return new JsonResult(servicio.EliminarProducto(id)) { StatusCode = 200 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }
        [Route("BorrarUnProducto")]
        [HttpDelete]
        public IActionResult EliminarProducto(ProductoDto producto)
        {
            try
            {
                return new JsonResult(servicio.EliminarProducto(producto)) { StatusCode = 200 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        [Route("ActualizarProducto")]
        [HttpPut]
        public IActionResult UpdateProducto(ProductoDto producto)
        {
            try
            {
                return new JsonResult(servicio.ActualizarProducto(producto)) { StatusCode = 200 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}