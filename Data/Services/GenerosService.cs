using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class GenerosService
    {
        private readonly ArtesaniasDbContext _context;

        public GenerosService(ArtesaniasDbContext context)
        {
            _context = context;
        }

        public List<GeneroModel> ListaGeneros()
        {
            var query = _context.CatGenero
            .Include(x => x.Articulos)
            .ToList();

            var lista = query.Select(x => new GeneroModel
            {
                IdGenero = x.IdGenero,
                Nombre_Genero = x.Nombre_Genero,
                CantidadArticulos = x.Articulos.Count,
            }).ToList();

            return lista;

        }
        public GeneroModel Genero(int idgenero)
        {
            var query = _context.CatGenero
               .Include(x => x.Articulos)
                .Where(x => x.IdGenero == idgenero)
                .ToList();

            var model = query.Select(x => new GeneroModel
            {
                IdGenero = x.IdGenero,
                Nombre_Genero = x.Nombre_Genero,
                CantidadArticulos = x.Articulos.Count,

            }).FirstOrDefault();

            return model;
            ;
        }

        public MsgResult Crear(GeneroModel model)
        {
            var res = new MsgResult();

            var entity = new Genero
            {
                Nombre_Genero = model.Nombre_Genero,
            };

            _context.CatGenero.Add(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Dato registrado correctamente";
                res.Code = entity.IdGenero;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar datos";
                res.Error = ex;
            }
            return res;
        }

        public MsgResult Modificar(GeneroModel model)
        {
            var res = new MsgResult();

            var entity = _context.CatGenero.FirstOrDefault(x => x.IdGenero == model.IdGenero);
            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "Ese dato no existe";
                return res;
            }
            entity.Nombre_Genero = model.Nombre_Genero;

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Dato modificado correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al modificar datos";
                res.Error = ex;
            }
            return res;
        }


        public MsgResult Eliminar(int idgenero)
        {
            var res = new MsgResult();

            var entity = _context.CatGenero
            .Include(x => x.Articulos)
            .FirstOrDefault(x => x.IdGenero == idgenero);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "No se pueden eliminar los datos";
                res.Code = -1;
                return res;
            }

            if (entity.Articulos.Count > 0)
            {
                res.IsSuccess = false;
                res.Message = "No se puede eliminar el genero solicitado porque tiene articulos relacionados. " +
                    "Elimine primero los articulos para poder eliminar el genero";
                res.Code = -2;
                return res;
            }

            _context.CatGenero.Remove(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Dato eliminado correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al eliminar datos";
                res.Error = ex;
            }
            return res;
        }
    }
}
