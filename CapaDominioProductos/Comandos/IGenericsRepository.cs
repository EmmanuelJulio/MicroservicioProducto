using CapaDominioProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominioProductos.Comandos
{
    public interface IGenericsRepository<T>
    {
        void Agregar(T entity);
        T Agregarr(T entity);
        T GetBy(int id) ;
        void Delete(T entity);
        bool DeleteById(int productoID);
    }
}
