using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;
using TiendaArtesaniasMarielos.Data.Extensions;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class UsuariosService
    {
        private readonly ArtesaniasDbContext _context;
        public UsuariosService(ArtesaniasDbContext context)
        {
            _context = context;
        }
        public MsgResult Registrar(Usuario usuario)
        {
            var res = new MsgResult();


            var newUser = _context.TblUsuario.FirstOrDefault(x => x.Nombre_Usuario == usuario.Nombre_Usuario);

            if (newUser != null)
            {
                res.IsSuccess = false;
                res.Message = "Ya existe un usuario con este nombre";
                return res;
            }


            //var claveEncriptada = usuario.Clave.Encriptar();

            ////var confirclaveEncriptada = usuario.ConfirmarClave.Encriptar();

            newUser = new Usuario
            {
                TU_IdRol = usuario.TU_IdRol,
                Nombre_Apellido = usuario.Nombre_Apellido,
                Nombre_Usuario = usuario.Nombre_Usuario,
                Clave = usuario.Clave,
                ConfirmarClave = usuario.ConfirmarClave
            };

            _context.TblUsuario.Add(newUser);

            try
            {
                _context.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Usuario registrado correctamente";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Error al registrar el usuario";
                res.Error = ex;
            }

            return res;
        }
        public MsgResult ValidarNombreUsuario(string nombre_usuario)
        {
            var res = new MsgResult();

            var existeUsuario = _context.TblUsuario.FirstOrDefault(x => x.Nombre_Usuario == nombre_usuario);

            if (existeUsuario == null)
            {
                res.IsSuccess = false;
            }
            else
            {
                res.IsSuccess = true;
            }

            return res;
        }

        public MsgResult Login(LoginUsuarioModel model)

        { 
            var result = new MsgResult();

            var user = _context.TblUsuario.FirstOrDefault(x => x.Nombre_Usuario == model.Usuario);

            if(user==null)
            {
                result.IsSuccess = false;
                result.Message = "Usuario no existe";

                return result;
            }

            //var passwordHashed = model.Clave.Encriptar();

            if (user.Clave != model.Password)
            {
                result.IsSuccess = false;
                result.Message = "Contraseña no válida";
                return result;
            }

            result.IsSuccess = true;
            result.Message = "Acceso Concedido";
            return result;
        }

}

}
