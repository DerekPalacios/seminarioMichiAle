using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class ClienteService
    {
        private readonly ArtesaniasDbContext _context;

        public ClienteService(ArtesaniasDbContext context)
        {
            _context = context;
        }

        public List<ClienteModel> ListaClientes()
        {
            var model = _context.CatCliente
               .Select(x => new ClienteModel
               {
                   IdCliente = x.IdCliente,
                   Nombres = x.Nombres,
                   Apellidos = x.Apellidos,
                   Identificacion = x.Identificacion,
                   Direccion = x.Direccion,
                   Telefono = x.Telefono,
                   Correo = x.Correo,

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



        public ClienteModel Cliente(int idcliente)
        {
            var model = _context.CatCliente
                .Where(x => x.IdCliente == idcliente)
                .Select(x => new ClienteModel
                {
                  
                    IdCliente = x.IdCliente,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Identificacion = x.Identificacion,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    Correo = x.Correo,


                }).FirstOrDefault();

            return model;
        }

        //public ArticuloModel Articulo(string busqueda)
        //{
        //    var model = _context.TblArticulo
        //        .Where(x => x.Codigo.Contains(busqueda) || x.Nombre.Contains(busqueda))
        //        .Select(x => new ArticuloModel
        //        {
        //            IdArticulo = x.IdArticulo,
        //            Codigo = x.Codigo,
        //            Nombre = x.Nombre,
        //            Stock = x.Stock,
        //            StockMinimo = x.StockMinimo,
        //            PrecioCompra = x.PrecioCompra,
        //            PrecioVenta = x.PrecioVenta,
        //            TA_IdCategoria = x.TA_IdCategoria,
        //            TA_IdTalla_Medida = x.TA_IdTalla_Medida,
        //            TA_IdEtapa = x.TA_IdEtapa,
        //            TA_IdGenero = x.TA_IdGenero,
        //            TA_IdMaterial = x.TA_IdMaterial,

        //        }).FirstOrDefault();

        //    return model;
        //}

        public MsgResult Crear(ClienteModel model)
        {
            var res = new MsgResult();

            var entity = _context.CatCliente.FirstOrDefault(x => x.Identificacion == model.Identificacion);

            if (entity != null)
            {
                res.IsSuccess = false;
                res.Message = $"Ya existe un cliente con esa identificacion especificada: {model.Identificacion}";
                return res;
            }


            entity = new Cliente
            {
                IdCliente = model.IdCliente,
                Nombres = model.Nombres,
                Apellidos = model.Apellidos,
                Identificacion = model.Identificacion,
                Direccion = model.Direccion,
                Telefono = model.Telefono,
                Correo = model.Correo,



            };

            _context.CatCliente.Add(entity);

            try
            {
                _context.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Cliente guardado correctamente";

                //El ID se retorna para que pueda usarse en la vista 
                res.Code = entity.IdCliente;
                model.IdCliente = entity.IdCliente;
                res.Objeto = model;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar cliente";
                res.Error = ex;
            }

            return res;
        }

        public MsgResult Modificar(ClienteModel model)
        {
            var res = new MsgResult();

            var entity = _context.CatCliente.FirstOrDefault(x => x.IdCliente == model.IdCliente);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = $"Cliente no encontrado";
                return res;
            }

            entity.Nombres = model.Nombres;
            entity.Apellidos = model.Apellidos;
            entity.Identificacion = model.Identificacion;
            entity.Direccion = model.Direccion;
            entity.Telefono = model.Telefono;
            entity.Correo = model.Correo;


            try
            {
                _context.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Cliente modificado correctamente";

            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al modificar cliente";
                res.Error = ex;
            }

            return res;
        }

        public MsgResult Eliminar(int idcliente)
        {
            var res = new MsgResult();

            var entity = _context.CatCliente
                .Include(x => x.Ventas)
                .FirstOrDefault(x => x.IdCliente == idcliente);

            if (entity == null)
            {
                res.IsSuccess = false;
                res.Message = "No se encontró el cliente que intenta eliminar";
                res.Code = -1;
                return res;
            }

            if (entity.Ventas.Count > 0)
            {
                res.IsSuccess = false;
                res.Message = "No se puede eliminar el cliente porque tiene facturas relacionadas.";
                res.Code = -2;
                return res;
            }


            _context.CatCliente.Remove(entity);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al eliminar cliente";
                res.Error = ex;
            }

            return res;
        }
    }
}
