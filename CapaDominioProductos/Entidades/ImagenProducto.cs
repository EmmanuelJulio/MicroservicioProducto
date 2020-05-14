using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapaDominioProductos.Entidades
{
    public class ImagenProducto
    {
        [Key]
        private int imagenproductoID;
        private string nombre;

        public int ImagenproductoID { get => imagenproductoID; set => imagenproductoID = value; }
        public string  Nombre { get => nombre; set => nombre = value; }
    }
}
