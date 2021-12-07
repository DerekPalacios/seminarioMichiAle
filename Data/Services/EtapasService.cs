using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class EtapasService
    {
        private readonly ArtesaniasDbContext _context;

        public EtapasService(ArtesaniasDbContext context)
        {
            _context = context;
        }

        public List<EtapaModel> ListaEtapas()
        {
            var query = _context.CatEtapa
            .Include(x => x.Articulos)
            .ToList();

            var lista = query.Select(x => new EtapaModel
            {
                Id = x.Id,
                Nombre_Etapa = x.Nombre_Etapa,
                CantidadArticulos = x.Articulos.Count,
            }).ToList();

            return lista;

        }
        public EtapaModel Etapa(int idetapa)
        {
            var query = _context.CatEtapa
               .Include(x => x.Articulos)
                .Where(x => x.Id == idetapa)
                .ToList();

            var model = query.Select(x => new EtapaModel
            {
                Id = x.Id,
                Nombre_Etapa = x.Nombre_Etapa,
                CantidadArticulos = x.Articulos.Count,

            }).FirstOrDefault();

            return model;
            ;
        }

        public MsgResult Crear(EtapaModel model)
        {
            var res = new MsgResult();

            var entity = new Etapa
            {
                Nombre_Etapa = model.Nombre_Etapa,
            };

            _context.CatEtapa.Add(entity);

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

        public MsgResult Modificar(EtapaModel model)
        {
            var res = new MsgResult();

            var entity = _context.CatEtapa.FirstOrDefault(x => x.Id == model.Id);
            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "Ese dato no existe";
                return res;
            }
            entity.Nombre_Etapa = model.Nombre_Etapa;

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


        public MsgResult Eliminar(int idetapa)
        {
            var res = new MsgResult();

            var entity = _context.CatEtapa
            .Include(x => x.Articulos)
            .FirstOrDefault(x => x.Id == idetapa);

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
                res.Message = "No se puede eliminar la descripcion solicitada porque tiene articulos relacionados. " +
                    "Elimine primero los articulos para poder eliminar la descripcion";
                res.Code = -2;
                return res;
            }
            _context.CatEtapa.Remove(entity);

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

