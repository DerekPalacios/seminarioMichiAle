
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class TallaService
    {
        private readonly ArtesaniasDbContext _context;

        public TallaService(ArtesaniasDbContext context)
        {
            _context = context;
        }

        public List<TallaModel> ListaTalla()
        {
                var query = _context.CatTalla
                .Include(x => x.Articulos)
                .ToList();

            var lista = query.Select(x => new TallaModel
            {
                Id = x.Id,
                Nombre_Talla = x.Nombre_Talla,
                CantidadArticulos= x.Articulos.Count,
            }).ToList();

            return lista;

        }
        public TallaModel Talla(int idtalla)
        {
            var query = _context.CatTalla
               .Include(x => x.Articulos)
                .Where(x => x.Id == idtalla)
                .ToList();

            var model = query.Select(x => new TallaModel
            {
                Id = x.Id,
                Nombre_Talla = x.Nombre_Talla,
                CantidadArticulos = x.Articulos.Count,

            }).FirstOrDefault();

            return model;
            ;
        }

        public MsgResult Crear(TallaModel model)
        {
            var res = new MsgResult();

            var entity = new Talla
            {
                Nombre_Talla = model.Nombre_Talla,
            };

            _context.CatTalla.Add(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Dato registrado correctamente";
                res.Code = entity.Id;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar datos";
                res.Error = ex;
            }
            return res;
        }

        public MsgResult Modificar(TallaModel model)
        {
            var res = new MsgResult();

            var entity = _context.CatTalla.FirstOrDefault(x => x.Id == model.Id);
            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "Ese dato no existe";
                return res;
            }
            entity.Nombre_Talla = model.Nombre_Talla;

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


        public MsgResult Eliminar(int idtalla)
        {
            var res = new MsgResult();

            var entity = _context.CatTalla
            .Include(x => x.Articulos)
            .FirstOrDefault(x => x.Id == idtalla);

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
                res.Message = "No se puede eliminar la talla o medida solicitada porque tiene articulos relacionados. " +
                    "Elimine primero los articulos para poder eliminar la talla o medida";
                res.Code = -2;
                return res;
            }

            _context.CatTalla.Remove(entity);

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

