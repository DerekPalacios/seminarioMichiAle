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
        public DbSet<Talla> CatTalla { get; set; }
        public DbSet<Etapa> CatEtapa { get; set; }
        public DbSet<Medida> CatMedida { get; set; }
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
            categorias.HasKey(x => x.Id);
            categorias.Property(x => x.Id).ValueGeneratedOnAdd();
            categorias.HasMany(x => x.Articulos)
                     .WithOne(x => x.Categoria)
                     .HasForeignKey(x => x.IdCategoria);

            //Talla o Medida
            var tallaMedidas = modelBuilder.Entity<Talla>();
            tallaMedidas.HasKey(x => x.Id);
            tallaMedidas.Property(x => x.Id).ValueGeneratedOnAdd();

            tallaMedidas.HasMany(x => x.Articulos)
                .WithOne(x => x.Talla)
                .HasForeignKey(x => x.IdTalla);

            //Etapas
            var etapas = modelBuilder.Entity<Etapa>();
            etapas.HasKey(x => x.Id);
            etapas.Property(x => x.Id).ValueGeneratedOnAdd();

            etapas.HasMany(x => x.Articulos)
                .WithOne(x => x.Etapa)
                .HasForeignKey(x => x.IdEtapa);


            //Medida
            var medida = modelBuilder.Entity<Medida>();
            medida.HasKey(x => x.Id);
            medida.Property(x => x.Id).ValueGeneratedOnAdd();

            medida.HasMany(x => x.Articulos)
                .WithOne(x => x.Medida)
                .HasForeignKey(x => x.IdMedida);

            //Genero
            var generos = modelBuilder.Entity<Genero>();
            generos.HasKey(x => x.Id);
            generos.Property(x => x.Id).ValueGeneratedOnAdd();

            generos.HasMany(x => x.Articulos)
                .WithOne(x => x.Genero)
                .HasForeignKey(x => x.IdGenero);

            //materiales
            var materiales = modelBuilder.Entity<Material>();
            materiales.HasKey(x => x.Id);
            materiales.Property(x => x.Id).ValueGeneratedOnAdd();
            materiales.HasMany(x => x.Articulos)
                     .WithOne(x => x.Material)
                     .HasForeignKey(x => x.IdMaterial);

            //Clientes
            var clientes = modelBuilder.Entity<Cliente>();
            clientes.HasKey(x => x.Id);
            clientes.Property(x => x.Id).ValueGeneratedOnAdd();
            clientes.HasMany(x => x.Ventas)
                     .WithOne(x => x.Cliente)
                     .HasForeignKey(x => x.IdCliente);

            //Roles
            var roles = modelBuilder.Entity<Rol>();
            roles.HasKey(x => x.IdRol);
            roles.Property(x => x.IdRol).ValueGeneratedOnAdd();
            roles.HasMany(x => x.Usuarios)
                     .WithOne(x => x.Rol)
                     .HasForeignKey(x => x.IdRol);


            //Articulos
            var articulos = modelBuilder.Entity<Articulo>();
            articulos.HasKey(x => x.Id);
            articulos.Property(x => x.Id).ValueGeneratedOnAdd();
            articulos.HasMany(x => x.DetalleVentas)
                     .WithOne(x => x.Articulo)
                     .HasForeignKey(x => x.IdArticulo);


            //Ventas
            var ventas = modelBuilder.Entity<Venta>();
            ventas.HasKey(x => x.Id);
            ventas.Property(x => x.Id).ValueGeneratedOnAdd();
            ventas.HasMany(x => x.DetalleVentas)
                     .WithOne(x => x.Venta)
                     .HasForeignKey(x => x.IdVenta);

            //Detalle Ventas
            var detalles = modelBuilder.Entity<DetalleVenta>();
            detalles.HasKey(x => x.Id);
            detalles.Property(x => x.Id).ValueGeneratedOnAdd();


            //Usuarios
            var usuarios = modelBuilder.Entity<Usuario>();
            usuarios.HasKey(x => x.Id);
            usuarios.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
