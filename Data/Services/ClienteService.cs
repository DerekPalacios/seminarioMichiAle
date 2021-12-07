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

        public ClienteModel Cliente(int idCliente)
        {
            var model = _context.CatCliente
                 .Where(x => x.Id == idCliente)
                 .Select(x => new ClienteModel
                 {
                     Id = x.Id,
                     Nombres = x.Nombres,
                     Apellidos = x.Apellidos,
                     Identificacion = x.Identificacion,
                     Direccion = x.Direccion,
                     Telefono = x.Telefono,
                     Correo = x.Correo,
                 }).FirstOrDefault();

            return model;

        }

        public List<ClienteModel> ListaClientes()
        {
            var model = _context.CatCliente
                .Select(x => new ClienteModel
                {
                    Id = x.Id,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Identificacion = x.Identificacion,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    Correo = x.Correo,
                }).ToList();

            return model;
        }

        public MsgResult Crear(ClienteModel model)
        {
            var result = new MsgResult();

            var entity = _context.CatCliente.FirstOrDefault(x => x.Identificacion == model.Identificacion);

            if (entity != null)
            {
                result.IsSuccess = false;
                result.Message = $"Ya existe un cliente creado con la identifación {model.Identificacion}";
                return result;
            }

            entity = new Cliente
            {
                Nombres = model.Nombres,
                Apellidos = model.Apellidos,
                Identificacion = model.Identificacion,
                Direccion = model.Direccion,
                Telefono = model.Telefono,
                Correo = model.Correo
            };

            _context.CatCliente.Add(entity);

            try
            {
                _context.SaveChanges();

                result.IsSuccess = true;
                result.Message = "Cliente registrado correctamente";
                result.Code = entity.Id;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = "Error al crear el cliente";
                result.Error = ex;
            }

            return result;

        }

        public MsgResult Modificar(ClienteModel model)
        {
            var result = new MsgResult();

            var entity = _context.CatCliente.FirstOrDefault(x => x.Id == model.Id);

            if (entity == null)
            {
                result.IsSuccess = false;
                result.Message = $"Cliente no encontrado";
                return result;
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

                result.IsSuccess = true;
                result.Message = "Cliente modificado correctamente";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = "Error al modificar el cliente";
                result.Error = ex;
            }

            return result;

        }

        public MsgResult Eliminar(int idCliente)
        {
            var result = new MsgResult();

            var entity = _context.CatCliente.FirstOrDefault(x => x.Id == idCliente);

            if (entity == null)
            {
                result.IsSuccess = false;
                result.Message = $"Cliente no encontrado";
                return result;
            }

            //TODO: Validar relaciones

            _context.CatCliente.Remove(entity);

            try
            {
                _context.SaveChanges();

                result.IsSuccess = true;
                result.Message = "Cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = "Error al eliminar el cliente";
                result.Error = ex;
            }

            return result;
        }
    }
}
