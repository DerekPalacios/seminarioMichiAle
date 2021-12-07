using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class GeneroService
    {
        private readonly ArtesaniasDbContext _context;

        public GeneroService(ArtesaniasDbContext context)
        {
            _context = context;
        }

        public List<GeneroModel> ListaGeneros()
        {
            var query = _context.CatGenero
            .Include(x => x.Articulos)
            .ToList();

            var lista = query.Select(x => new GeneroModel
            {
                Id = x.Id,
                Nombre_Genero = x.Nombre_Genero,
                CantidadProductos = x.Articulos.Count,
            }).ToList();

            return lista;

        }
        public GeneroModel Genero(int idgenero)
        {
            var query = _context.CatGenero
               .Include(x => x.Articulos)
                .Where(x => x.Id == idgenero)
                .ToList();

            var model = query.Select(x => new GeneroModel
            {
                Id = x.Id,
                Nombre_Genero = x.Nombre_Genero,
                CantidadProductos = x.Articulos.Count,

            }).FirstOrDefault();

            return model;
            ;
        }
    }

}