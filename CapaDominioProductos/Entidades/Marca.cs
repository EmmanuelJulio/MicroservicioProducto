using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CapaDominioProductos.Entidades
{
   public  class Marca
    {
        [Key]
        private int marcaID;
        private string nombre;

        public int MarcaID { get => marcaID; set => marcaID = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
