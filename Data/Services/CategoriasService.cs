using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class CategoriasService
    {
        private readonly ArtesaniasDbContext _context;
        public CategoriasService(ArtesaniasDbContext context)
        {
            _context = context;
        }


        public List<CategoriaModel> ListaCategorias()
        {
            var query = _context.CatCategoria
                .Include(x => x.Articulos)
                .ToList();

            var lista = query.Select(x => new CategoriaModel
            {
                IdCategoria = x.IdCategoria,
                Nombre_Categoria = x.Nombre_Categoria,
                CantidadProductos = x.Articulos.Count,
            }).ToList();

            return lista;

        }

        public CategoriaModel Categoria(int idCategoria)
        {
            var query = _context.CatCategoria
                .Include(x => x.Articulos)
                .Where(x => x.IdCategoria == idCategoria)
                .ToList();

            var model = query.Select(x => new CategoriaModel
            {
                IdCategoria = x.IdCategoria,
                Nombre_Categoria = x.Nombre_Categoria,
                CantidadProductos = x.Articulos.Count,

            }).FirstOrDefault();

            return model;
        }

        public MsgResult Crear(CategoriaModel model)
        {
            var res = new MsgResult();

            var entity = new Categoria
            {
                Nombre_Categoria = model.Nombre_Categoria,
            };

            _context.CatCategoria.Add(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Categoria creada correctamente";
                res.Code = entity.IdCategoria;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar la categoria";
                res.Error = ex;
            }

            return res;
        }

        public MsgResult Modificar(CategoriaModel model)
        {

            var res = new MsgResult();

            var entity = _context.CatCategoria.FirstOrDefault(x => x.IdCategoria == model.IdCategoria);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "No se puede modificar la categoria solicitada porque no existe";
                return res;
            }

            entity.Nombre_Categoria = model.Nombre_Categoria;


            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Categoria modificada correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al modificar la categoria";
                res.Error = ex;
            }

            return res;
        }

        public MsgResult Eliminar(int idCategoria)
        {
            var res = new MsgResult();

            var entity = _context.CatCategoria
                .Include(x => x.Articulos)
                .FirstOrDefault(x => x.IdCategoria == idCategoria);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "No se puede eliminar la categoria solicitada porque no existe";
                res.Code = -1;
                return res;
            }

            if (entity.Articulos.Count > 0)
            {
                res.IsSuccess = false;
                res.Message = "No se puede eliminar la categoria solicitada porque tiene productos relacionados. " +
                    "Elimine primero los prodcutos para poder eliminar la categoría";
                res.Code = -2;
                return res;
            }


            _context.CatCategoria.Remove(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Categoria eliminada correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al eliminar la categoria";
                res.Error = ex;
            }

            return res;
        }

    }
}
