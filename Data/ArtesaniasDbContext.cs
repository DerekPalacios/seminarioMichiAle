using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;

namespace TiendaArtesaniasMarielos.Data
{
    public class ArtesaniasDbContext: DbContext
    {
        public ArtesaniasDbContext(DbContextOptions<ArtesaniasDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> CatCategoria { get; set; }
        public DbSet<Talla_Medida> CatTalla_Medida { get; set; }
        public DbSet<Etapa> CatEtapa { get; set; }
        public DbSet<Genero> CatGenero { get; set; }
        public DbSet<Material> CatMaterial { get; set; }
        public DbSet<Cliente> CatCliente{ get; set; }
        public DbSet<DetalleVenta> TblDetalleVenta { get; set; }
        public DbSet<Venta> TblVenta { get; set; }
        public DbSet<Articulo> TblArticulo { get; set; }
        public DbSet<Rol> TblRol { get; set; }
        public DbSet<Usuario> TblUsuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Categorias
            var categorias = modelBuilder.Entity<Categoria>();
            categorias.HasKey(x => x.IdCategoria);
            categorias.Property(x => x.IdCategoria).ValueGeneratedOnAdd();
            categorias.HasMany(x => x.Articulos)
                     .WithOne(x => x.Categoria)
                     .HasForeignKey(x => x.TA_IdCategoria);

            //Talla o Medida
            var tallaMedidas = modelBuilder.Entity<Talla_Medida>();
            tallaMedidas.HasKey(x => x.IdTalla_Medida);
            tallaMedidas.Property(x => x.IdTalla_Medida).ValueGeneratedOnAdd();

            tallaMedidas.HasMany(x => x.Articulos)
                .WithOne(x => x.Talla_Medida)
                .HasForeignKey(x => x.TA_IdTalla_Medida);

            //Etapas
            var etapas = modelBuilder.Entity<Etapa>();
            etapas.HasKey(x => x.IdEtapa);
            etapas.Property(x => x.IdEtapa).ValueGeneratedOnAdd();

            etapas.HasMany(x => x.Articulos)
                .WithOne(x => x.Etapa)
                .HasForeignKey(x => x.TA_IdEtapa);


            //Genero
            var generos = modelBuilder.Entity<Genero>();
            generos.HasKey(x => x.IdGenero);
            generos.Property(x => x.IdGenero).ValueGeneratedOnAdd();

            generos.HasMany(x => x.Articulos)
                .WithOne(x => x.Genero)
                .HasForeignKey(x => x.TA_IdGenero);

            //materiales
            var materiales = modelBuilder.Entity<Material>();
            materiales.HasKey(x => x.IdMaterial);
            materiales.Property(x => x.IdMaterial).ValueGeneratedOnAdd();
            materiales.HasMany(x => x.Articulos)
                     .WithOne(x => x.Material)
                     .HasForeignKey(x => x.TA_IdMaterial);

            //Clientes
            var clientes = modelBuilder.Entity<Cliente>();
            clientes.HasKey(x => x.IdCliente);
            clientes.Property(x => x.IdCliente).ValueGeneratedOnAdd();
            clientes.HasMany(x => x.Ventas)
                     .WithOne(x => x.Cliente)
                     .HasForeignKey(x => x.TV_IdCliente);

            //Roles
            var roles = modelBuilder.Entity<Rol>();
            roles.HasKey(x => x.IdRol);
            roles.Property(x => x.IdRol).ValueGeneratedOnAdd();
            roles.HasMany(x => x.Usuarios)
                     .WithOne(x => x.Rol)
                     .HasForeignKey(x => x.TU_IdRol);


            //Articulos
            var articulos = modelBuilder.Entity<Articulo>();
            articulos.HasKey(x => x.IdArticulo);
            articulos.Property(x => x.IdArticulo).ValueGeneratedOnAdd();
            articulos.HasMany(x => x.DetalleVentas)
                     .WithOne(x => x.Articulo)
                     .HasForeignKey(x => x.TDV_IdArticulo);


            //Ventas
            var ventas = modelBuilder.Entity<Venta>();
            ventas.HasKey(x => x.IdVenta);
            ventas.Property(x => x.IdVenta).ValueGeneratedOnAdd();
            ventas.HasMany(x => x.DetalleVentas)
                     .WithOne(x => x.Venta)
                     .HasForeignKey(x => x.TDV_IdVenta);

            //Detalle Ventas
            var detalles = modelBuilder.Entity<DetalleVenta>();
            detalles.HasKey(x => x.IdDetalleVenta);
            detalles.Property(x => x.IdDetalleVenta).ValueGeneratedOnAdd();


            //Usuarios
            var usuarios = modelBuilder.Entity<Usuario>();
            usuarios.HasKey(x => x.IdUsuario);
            usuarios.Property(x => x.IdUsuario).ValueGeneratedOnAdd();
        }
    }
}
