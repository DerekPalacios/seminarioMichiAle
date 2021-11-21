using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class RolesService
    {
        private readonly ArtesaniasDbContext _context;

        public RolesService(ArtesaniasDbContext context)
        {
            _context = context;
        }

        public List<Rol> ListaRoles()
        {
            var lista = _context.TblRol.ToList();

            return lista;
        }
    }
}
