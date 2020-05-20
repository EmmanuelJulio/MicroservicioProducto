using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapaDominioProductos.Entidades
{
    public class Producto
    {

        public int Id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int precioID { get; set; }
        public int imagenID { get; set; }
        public int categoriaID { get; set; }
        public int marcaID { get; set; }
        public int stock { get; set; }
        public string Marca { get; set; }

    
        public virtual ImagenProducto ImagenProductoNavigator { get; set; }
        public virtual PrecioProducto PrecioProductoNavigator { get; set; }
        public virtual Categoria CategoriaNavigator { get; set; }
        
       
    }
}
