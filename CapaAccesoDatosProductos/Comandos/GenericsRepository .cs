using CapaAccesoDatosProductos.Querys;
using CapaDominioProductos.Comandos;
using CapaDominioProductos.Entidades;
using Microsoft.EntityFrameworkCore;
using SqlKata.Compilers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CapaAccesoDatosProductos.Comandos
{
    public class GenericsRepository<T> : IGenericsRepository<T> where T : Entidad, new()
    {
        private readonly IDbConnection connection;
        private readonly Compiler compiler;
        private readonly Contexto contexto;

        public GenericsRepository(IDbConnection connection, Compiler compiler, Contexto contexto)
        {
            this.connection = connection;
            this.compiler = compiler;
            this.contexto = contexto;
        }

        public void Agregar(T entity) 
        {
            contexto.Add(entity);
            contexto.SaveChanges();
        }

        public T1 Agregarr<T1>(T1 entity) where T1 : class
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity) 
        {
            contexto.Set<T>().Remove(entity);
            contexto.SaveChanges();
        }

        public bool DeleteById(int id) 
        {
            try
            {
                //using (contexto)
                //{
                //    Producto p = contexto.productos.Find(id);
                //    contexto.productos.Remove(p);

                //}
                var Entidad = contexto.Set<T>().FirstOrDefault(x => x.Id == id);
                ////var entidad = new T() { Id = id };
                contexto.Entry(Entidad).State = EntityState.Deleted;
                contexto.SaveChanges();
                //ProductoQuery query = new ProductoQuery(connection, compiler);
               // Producto p = query.BusquedaProductoByID(id);
               // contexto.productos.Remove(p);
                


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public T GetBy(int id) 
        {
            DbSet<T> table = contexto.Set<T>();
            return table.Find(id);
        }

       

        T IGenericsRepository<T>.Agregarr(T entity)
        {
            contexto.Add(entity);
            contexto.SaveChanges();
            return entity; ;
        }
    }
}
