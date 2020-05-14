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

        [HttpPost("Post")]
        public IActionResult Post([FromQuery] ProductoDto productoDto)
        {
            try
            {
                return new  JsonResult(servicio.createProducto(productoDto)) { StatusCode = 201};

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }        
        }

        //busca un producto por su precio
        [HttpGet]
        public IActionResult GETSearchPrice([FromQuery] int precio)
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

        //devuelve una lista de productos

        [HttpGet("GetProducts")]
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
        [HttpDelete("DeleteProducto")]
        public IActionResult DeleteProducto(ProductoDto producto)
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
    }
}