using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class MedidaService
    {
        private readonly ArtesaniasDbContext _context;

        public MedidaService(ArtesaniasDbContext context)
        {
            _context = context;
        }

        public List<MedidaModel> ListaMedidas()
        {
            var query = _context.CatMedida
            .Include(x => x.Articulos)
            .ToList();

            var lista = query.Select(x => new MedidaModel
            {
                Id = x.Id,
                Nombre_Medida = x.Nombre_Medida,
                CantidadArticulos = x.Articulos.Count,
            }).ToList();

            return lista;

        }
        public MedidaModel Medida(int idmedida)
        {
            var query = _context.CatMedida
               .Include(x => x.Articulos)
                .Where(x => x.Id == idmedida)
                .ToList();

            var model = query.Select(x => new MedidaModel
            {
                Id = x.Id,
                Nombre_Medida = x.Nombre_Medida,
                CantidadArticulos = x.Articulos.Count,

            }).FirstOrDefault();

            return model;
            ;
        }

        public MsgResult Crear(MedidaModel model)
        {
            var res = new MsgResult();

            var entity = new Medida
            {
                Nombre_Medida = model.Nombre_Medida,
            };

            _context.CatMedida.Add(entity);

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

        public MsgResult Modificar(MedidaModel model)
        {
            var res = new MsgResult();

            var entity = _context.CatMedida.FirstOrDefault(x => x.Id == model.Id);
            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "Ese dato no existe";
                return res;
            }
            entity.Nombre_Medida = model.Nombre_Medida;

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


        public MsgResult Eliminar(int idmedida)
        {
            var res = new MsgResult();

            var entity = _context.CatMedida
            .Include(x => x.Articulos)
            .FirstOrDefault(x => x.Id == idmedida);

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

            _context.CatMedida.Remove(entity);

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
