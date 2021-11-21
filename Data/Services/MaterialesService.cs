using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Models;
using TiendaArtesaniasMarielos.Data.Entities;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class MaterialesService
    {
        private readonly ArtesaniasDbContext _context;
        public MaterialesService(ArtesaniasDbContext context)
        {
            _context = context;
        }


        public List<MaterialModel> ListaMateriales()
        {
            var query = _context.CatMaterial
                .Include(x => x.Articulos)
                .ToList();

            var lista = query.Select(x => new MaterialModel
            {
                IdMaterial = x.IdMaterial,
                Nombre_Material = x.Nombre_Material,
                CantidadProductos = 0
            }).ToList();

            return lista;

        }

        public MaterialModel Material(int idMaterial)
        {
            var query = _context.CatMaterial
                .Include(x => x.Articulos)
                .Where(x => x.IdMaterial == idMaterial)
                .ToList();

            var model = query.Select(x => new MaterialModel
            {
                IdMaterial = x.IdMaterial,
                Nombre_Material = x.Nombre_Material,
                CantidadProductos = 0

            }).FirstOrDefault();

            return model;
        }

        public MsgResult Crear(MaterialModel model)
        {
            var res = new MsgResult();

            var entity = new Material
            {
                Nombre_Material = model.Nombre_Material,
            };

            _context.CatMaterial.Add(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Material creado correctamente";
                res.Code = entity.IdMaterial;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar el material";
                res.Error = ex;
            }

            return res;
        }

        public MsgResult Modificar(MaterialModel model)
        {

            var res = new MsgResult();

            var entity = _context.CatMaterial.FirstOrDefault(x => x.IdMaterial == model.IdMaterial);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "No se puede modificar el material solicitado porque no existe";
                return res;
            }

            entity.Nombre_Material = model.Nombre_Material;


            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Material modificado correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al modificar el material";
                res.Error = ex;
            }

            return res;
        }

        public MsgResult Eliminar(int idMaterial)
        {
            var res = new MsgResult();

            var entity = _context.CatMaterial
                .Include(x => x.Articulos)
                .FirstOrDefault(x => x.IdMaterial == idMaterial);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "No se puede eliminar el material solicitado porque no existe";
                res.Code = -1;
                return res;
            }

            if (entity.Articulos.Count > 0)
            {
                res.IsSuccess = false;
                res.Message = "No se puede eliminar el material solicitado porque tiene artículos relacionados. " +
                    "Elimine primero los artículos para poder eliminar el material";
                res.Code = -2;
                return res;
            }


            _context.CatMaterial.Remove(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Material eliminado correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al eliminar el material";
                res.Error = ex;
            }

            return res;
        }


    }
}
