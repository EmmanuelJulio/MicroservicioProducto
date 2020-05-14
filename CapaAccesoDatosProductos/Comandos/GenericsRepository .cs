using CapaDominioProductos.Comandos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAccesoDatosProductos.Comandos
{
    public class GenericsRepository : IGenericsRepository
    {
        private readonly Contexto contexto;
        public GenericsRepository(Contexto contexto)
        {
            this.contexto = contexto;
        }

        public void Agregar<T>(T entity) where T : class
        {
            contexto.Add(entity);
            contexto.SaveChanges();
        }
      

        public void Delete<T>(T entity) where T : class
        {
            contexto.Set<T>().Remove(entity);
            contexto.SaveChanges();
        }

        public T GetBy<T>(int id) where T : class
        {
            DbSet<T> table = contexto.Set<T>();
            return table.Find(id);
        }

        T IGenericsRepository.Agregarr<T>(T entity)
        {
            contexto.Add(entity);
            contexto.SaveChanges();
            return entity;
        }
    }
}
