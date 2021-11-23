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
                   IdArticulo = x.IdArticulo,
                   Codigo = x.Codigo,
                   Nombre = x.Nombre,
                   Stock = x.Stock,
                   StockMinimo = x.StockMinimo,
                   PrecioCompra = x.PrecioCompra,
                   PrecioVenta = x.PrecioVenta,
                   TA_IdCategoria = x.TA_IdCategoria,
                   TA_IdTalla_Medida = x.TA_IdTalla_Medida,
                   TA_IdEtapa = x.TA_IdEtapa,
                   TA_IdGenero = x.TA_IdGenero,
                   TA_IdMaterial = x.TA_IdMaterial,
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
                .Where(x => x.IdArticulo == idarticulo)
                .Select(x => new ArticuloModel
                {
                    IdArticulo = x.IdArticulo,
                    Codigo = x.Codigo,
                    Nombre = x.Nombre,
                    Stock = x.Stock,
                    StockMinimo = x.StockMinimo,
                    PrecioCompra = x.PrecioCompra,
                    PrecioVenta = x.PrecioVenta,
                    TA_IdCategoria = x.TA_IdCategoria,
                    TA_IdTalla_Medida = x.TA_IdTalla_Medida,
                    TA_IdEtapa = x.TA_IdEtapa,
                    TA_IdGenero = x.TA_IdGenero,
                    TA_IdMaterial = x.TA_IdMaterial,


                }).FirstOrDefault();

            return model;
        }

        public ArticuloModel Articulo(string busqueda)
        {
            var model = _context.TblArticulo
                .Where(x => x.Codigo.Contains(busqueda) || x.Nombre.Contains(busqueda))
                .Select(x => new ArticuloModel
                {
                    IdArticulo = x.IdArticulo,
                    Codigo = x.Codigo,
                    Nombre = x.Nombre,
                    Stock = x.Stock,
                    StockMinimo = x.StockMinimo,
                    PrecioCompra = x.PrecioCompra,
                    PrecioVenta = x.PrecioVenta,
                    TA_IdCategoria = x.TA_IdCategoria,
                    TA_IdTalla_Medida = x.TA_IdTalla_Medida,
                    TA_IdEtapa = x.TA_IdEtapa,
                    TA_IdGenero = x.TA_IdGenero,
                    TA_IdMaterial = x.TA_IdMaterial,

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
                Codigo = model.Codigo,
                Nombre = model.Nombre,
                Stock = model.Stock,
                StockMinimo = model.StockMinimo,
                PrecioCompra = model.PrecioCompra,
                PrecioVenta = model.PrecioVenta,
                TA_IdCategoria = model.TA_IdCategoria,
                TA_IdTalla_Medida = model.TA_IdTalla_Medida,
                TA_IdEtapa = model.TA_IdEtapa,
                TA_IdGenero = model.TA_IdGenero,
                TA_IdMaterial = model.TA_IdMaterial,
               
           
               
            };

            _context.TblArticulo.Add(entity);

            try
            {
                _context.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Articulo guardado correctamente";

                //El ID se retorna para que pueda usarse en la vista 
                res.Code = entity.IdArticulo;
                model.IdArticulo = entity.IdArticulo;
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

            var entity = _context.TblArticulo.FirstOrDefault(x => x.IdArticulo == model.IdArticulo);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = $"No se encontro el articulo que desea modificar";
                return res;
            }


            entity.Codigo = model.Codigo;
            entity.Nombre = model.Nombre;
            entity.Stock = model.Stock;
            entity.StockMinimo = model.StockMinimo;
            entity.PrecioCompra = model.PrecioCompra;
            entity.PrecioVenta = model.PrecioVenta;
            entity.TA_IdCategoria = model.TA_IdCategoria;
            entity.TA_IdTalla_Medida = model.TA_IdTalla_Medida;
            entity.TA_IdEtapa = model.TA_IdEtapa;
            entity.TA_IdGenero = model.TA_IdGenero;
            entity.TA_IdMaterial = model.TA_IdMaterial;
          

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
                .FirstOrDefault(x => x.IdArticulo == idarticulo);

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
