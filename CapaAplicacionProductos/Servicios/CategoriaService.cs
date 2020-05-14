using CapaDominioProductos.Comandos;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CapaAplicacionProductos.Servicios
{
    public interface ICategoriaService
    {
        CategoriaDto createCategoria(string descripcion);
    }
    public class CategoriaService :ICategoriaService
    {
        private readonly IGenericsRepository<Entidad> repository;

        public CategoriaService(IGenericsRepository<Entidad> repository)
        {
            this.repository = repository;
        }

        public CategoriaDto createCategoria(string descripcion)
        {
            var entity = new Categoria()
            {
                Descripcion = descripcion
                
            };
            repository.Agregar(entity);
            return new CategoriaDto {Descripcion = entity.Descripcion };
        }
        
    }
}
