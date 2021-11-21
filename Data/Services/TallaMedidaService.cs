
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class TallaMedidaService
    {
        private readonly ArtesaniasDbContext _context;

        public TallaMedidaService(ArtesaniasDbContext context)
        {
            _context = context;
        }

        public List<TallaMedidaModel> ListaTallaMedida()
        {
                var query = _context.CatTalla_Medida
                .Include(x => x.Articulos)
                .ToList();

            var lista = query.Select(x => new TallaMedidaModel
            {
                IdTalla_Medida = x.IdTalla_Medida,
                Descripcion = x.Descripcion,
                CantidadArticulos= x.Articulos.Count,
            }).ToList();

            return lista;

        }
        public TallaMedidaModel TallaMedida(int idtallaMedida)
        {
            var query = _context.CatTalla_Medida
               .Include(x => x.Articulos)
                .Where(x => x.IdTalla_Medida == idtallaMedida)
                .ToList();

            var model = query.Select(x => new TallaMedidaModel
            {
                IdTalla_Medida = x.IdTalla_Medida,
                Descripcion = x.Descripcion,
                CantidadArticulos = x.Articulos.Count,

            }).FirstOrDefault();

            return model;
            ;
        }

        public MsgResult Crear(TallaMedidaModel model)
        {
            var res = new MsgResult();

            var entity = new Talla_Medida
            {
                Descripcion = model.Descripcion,
            };

            _context.CatTalla_Medida.Add(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Dato registrado correctamente";
                res.Code = entity.IdTalla_Medida;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar datos";
                res.Error = ex;
            }
            return res;
        }

        public MsgResult Modificar(TallaMedidaModel model)
        {
            var res = new MsgResult();

            var entity = _context.CatTalla_Medida.FirstOrDefault(x => x.IdTalla_Medida == model.IdTalla_Medida);
            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "Ese dato no existe";
                return res;
            }
            entity.Descripcion = model.Descripcion;

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


        public MsgResult Eliminar(int idtallaMedida)
        {
            var res = new MsgResult();

            var entity = _context.CatTalla_Medida
            .Include(x => x.Articulos)
            .FirstOrDefault(x => x.IdTalla_Medida == idtallaMedida);

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

            _context.CatTalla_Medida.Remove(entity);

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

