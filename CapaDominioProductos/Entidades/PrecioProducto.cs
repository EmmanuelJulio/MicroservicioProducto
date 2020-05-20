using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CapaDominioProductos.Entidades
{
    public class PrecioProducto 
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal precioreal { get; set; }
        public decimal precioventa { get; set; }
        public DateTime fecha { get; set; }




    }
}
