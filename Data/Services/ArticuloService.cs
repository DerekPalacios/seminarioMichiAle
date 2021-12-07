using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class ArticuloService
    {
        private readonly ArtesaniasDbContext _context;

        public ArticuloService(ArtesaniasDbContext context)
        {
            _context = context;
        }
        public List<ArticuloModel> ListaArticulos()
        {
            var model = _context.TblArticulo
               .Select(x=> new ArticuloModel
               {
                   Id = x.Id,
                   Codigo = x.Codigo,
                   IdCategoria = x.IdCategoria,
                   Nombre = x.Nombre,
                   IdTalla = x.IdTalla,
                   IdMedida = x.IdMedida,
                   IdEtapa = x.IdEtapa,
                   IdGenero = x.IdGenero,
                   IdMaterial = x.IdMaterial,
                   Stock = x.Stock,
                   StockMinimo = x.StockMinimo,
                   Costo = x.Costo,
                   Precio = x.Precio,
               }).ToList();

            return model;

        }

        //public List<ArticuloModel> ListaArticulos(int idCategoria)
        //{
        //    var model = _context.TblArticulo
        //        .Where(x=>x.TA_IdCategoria == idCategoria)
        //       .Select(x => new ArticuloModel
        //       {
        //           IdArticulo = x.IdArticulo,
        //           Codigo = x.Codigo,
        //           Nombre = x.Nombre,
        //           Stock = x.Stock,
        //           StockMinimo = x.StockMinimo,
        //           PrecioCompra = x.PrecioCompra,
        //           PrecioVenta = x.PrecioVenta,
        //           TA_IdCategoria = x.TA_IdCategoria,
        //           TA_IdTalla_Medida = x.TA_IdTalla_Medida,
        //           TA_IdEtapa = x.TA_IdEtapa,
        //           TA_IdGenero = x.TA_IdGenero,
        //           TA_IdMaterial = x.TA_IdMaterial,
        //       }).ToList();

        //    return model;

        //}



        public ArticuloModel Articulo(int idarticulo)
        {
            var model = _context.TblArticulo
                .Where(x => x.Id == idarticulo)
                .Select(x => new ArticuloModel
                {
                    Id = x.Id,
                    Codigo = x.Codigo,
                    IdCategoria = x.IdCategoria,
                    Nombre = x.Nombre,
                    IdTalla = x.IdTalla,
                    IdMedida = x.IdMedida,
                    IdEtapa = x.IdEtapa,
                    IdGenero = x.IdGenero,
                    IdMaterial = x.IdMaterial,
                    Stock = x.Stock,
                    StockMinimo = x.StockMinimo,
                    Costo = x.Costo,
                    Precio = x.Precio,


                }).FirstOrDefault();

            return model;
        }

        public ArticuloModel Articulo(string busqueda)
        {
            var model = _context.TblArticulo
                .Where(x => x.Codigo.Contains(busqueda) || x.Nombre.Contains(busqueda))
                .Select(x => new ArticuloModel
                {
                    Id = x.Id,
                    Codigo = x.Codigo,
                    IdCategoria = x.IdCategoria,
                    Nombre = x.Nombre,
                    IdTalla = x.IdTalla,
                    IdMedida = x.IdMedida,
                    IdEtapa = x.IdEtapa,
                    IdGenero = x.IdGenero,
                    IdMaterial = x.IdMaterial,
                    Stock = x.Stock,
                    StockMinimo = x.StockMinimo,
                    Costo = x.Costo,
                    Precio = x.Precio,

                }).FirstOrDefault();

            return model;
        }

        public MsgResult Crear(ArticuloModel model)
        {
            var res = new MsgResult();

            var entity = _context.TblArticulo.FirstOrDefault(x => x.Codigo == model.Codigo);

            if (entity != null)
            {
                res.IsSuccess = false;
                res.Message = $"Ya existe un articulo con el codigo especificada: {model.Codigo}";
                return res;
            }


            entity = new Articulo
            {
                Id = model.Id,
                Codigo = model.Codigo,
                IdCategoria = model.IdCategoria,
                Nombre = model.Nombre,
                IdTalla = model.IdTalla,
                IdMedida = model.IdMedida,
                IdEtapa = model.IdEtapa,
                IdGenero = model.IdGenero,
                IdMaterial = model.IdMaterial,
                Stock = model.Stock,
                StockMinimo = model.StockMinimo,
                Costo = model.Costo,
                Precio = model.Precio,



            };

            _context.TblArticulo.Add(entity);

            try
            {
                _context.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Articulo guardado correctamente";

                //El ID se retorna para que pueda usarse en la vista 
                res.Code = entity.Id;
                model.Id = entity.Id;
                res.Objeto = model;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar articulo";
                res.Error = ex;
            }

            return res;
        }

        public MsgResult Modificar(ArticuloModel model)
        {
            var res = new MsgResult();

            var entity = _context.TblArticulo.FirstOrDefault(x => x.Id == model.Id);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = $"No se encontro el articulo que desea modificar";
                return res;
            }

            entity.Id = model.Id;
            entity.Codigo = model.Codigo;
            entity.IdCategoria = model.IdCategoria;
            entity.Nombre = model.Nombre;
            entity.IdTalla = model.IdTalla;
            entity.IdMedida = model.IdMedida;
            entity.IdEtapa = model.IdEtapa;
            entity.IdGenero = model.IdGenero;
            entity.IdMaterial = model.IdMaterial;
            entity.Stock = model.Stock;
            entity.StockMinimo = model.StockMinimo;
            entity.Costo = model.Costo;
            entity.Precio = model.Precio;
          

            try
            {
                _context.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Articulo modificado correctamente";

            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al modificar articulo";
                res.Error = ex;
            }

            return res;
        }

        public MsgResult Eliminar(int idarticulo)
        {
            var res = new MsgResult();

            var entity = _context.TblArticulo
                .Include(x => x.DetalleVentas)
                .FirstOrDefault(x => x.Id == idarticulo);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "No se enconotró el articulo que intenta eliminar";
                res.Code = -1;
                return res;
            }

            if (entity.DetalleVentas.Count > 0)
            {
                res.IsSuccess = false;
                res.Message = "No se puede eliminar el articulo porque tiene facturas relacionadas.";
                res.Code = -2;
                return res;
            }


            _context.TblArticulo.Remove(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Articulo eliminada correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al eliminar el articulo";
                res.Error = ex;
            }

            return res;
        }
    }
}
