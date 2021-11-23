using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
    public class VentasService
    {
        private readonly ArtesaniasDbContext _context;

        public VentasService(ArtesaniasDbContext context)
        {
            _context = context;
        }

		public VentaModel Factura(int idFactura)
		{
			var model = _context.TblVenta
				.Include(x => x.Cliente)
				.Include(x => x.DetalleVentas).ThenInclude(x => x.Articulo)
				.Where(x => x.IdVenta == idFactura)
				.Select(x => new VentaModel
				{
					IdVenta = x.IdVenta,
					NumVenta = x.NumVenta,

					//Cliente
					TV_IdCliente = x.TV_IdCliente,
					NombreCliente = x.Cliente.Nombres + " " + x.Cliente.Apellidos,
					FechaVenta = x.FechaVenta,
					

					//Items
					Items = x.DetalleVentas
					.Select(y => new ItemFacturaModel
					{
						IdDetalleVenta = y.IdDetalleVenta,
						TDV_IdVenta = y.TDV_IdVenta,


						//Productos
						Codigo = y.Articulo.Codigo,
						TDV_IdArticulo = y.TDV_IdArticulo,
						NombreArticulo = y.Articulo.Nombre,
						PrecioCompra = y.Costo,
						Cantidad = y.Cantidad,
						PrecioUnidad = y.PrecioUnidad,

					}).ToList()

				}).FirstOrDefault();

			return model;
		}

		public List<VentaModel> ListaFacturas(DateTime desde, DateTime hasta, int? idCliente = null)
        {
			var model = _context.TblVenta
				.Include(x => x.Cliente)
				.Include(x => x.DetalleVentas).ThenInclude(x => x.Articulo)
				.Where(x => x.FechaVenta >= desde && x.FechaVenta <= hasta 
				&& (x.TV_IdCliente == idCliente || idCliente ==null))

				.Select(x => new VentaModel
				{
					IdVenta = x.IdVenta,
					NumVenta = x.NumVenta,

					//Cliente
					TV_IdCliente = x.TV_IdCliente,
					NombreCliente = x.Cliente.Nombres + " " + x.Cliente.Apellidos,
					FechaVenta = x.FechaVenta,


					//Items
					Items = x.DetalleVentas
					.Select(y => new ItemFacturaModel
					{
						IdDetalleVenta = y.IdDetalleVenta,
						TDV_IdVenta = y.TDV_IdVenta,


						//Productos
						Codigo = y.Articulo.Codigo,
						TDV_IdArticulo = y.TDV_IdArticulo,
						NombreArticulo = y.Articulo.Nombre,
						PrecioCompra = y.Costo,
						Cantidad = y.Cantidad,
						PrecioUnidad = y.PrecioUnidad,

					}).ToList()

				}).ToList();

			return model;
		}

		public MsgResult Crear(VentaModel model)
		{
			var result = new MsgResult();

			var entity = _context.TblVenta
				.Include(x => x.DetalleVentas)
				.FirstOrDefault(x => x.NumVenta == model.NumVenta);

			if (entity != null)
			{
				result.IsSuccess = false;
				result.Message = $"Ya existe una factura con el número {model.NumVenta}";
				return result;
			}

			entity = new Venta
			{
				
				NumVenta = model.NumVenta,
				TV_IdCliente = model.TV_IdCliente,
				FechaVenta = model.FechaVenta,
				DetalleVentas = model.Items
				.Select(x => new DetalleVenta
				{
					TDV_IdVenta = x.TDV_IdVenta,
					TDV_IdArticulo = x.TDV_IdArticulo,
					Costo = x.PrecioCompra,
					Cantidad = x.Cantidad,
					PrecioUnidad = x.PrecioUnidad,
				}).ToList(),
			};

			_context.TblVenta.Add(entity);

			try
			{
				_context.SaveChanges();
				result.IsSuccess = true;
				result.Message = "Factura creada correctamente";
				result.Code = entity.IdVenta;
			}
			catch (Exception ex)
			{
				result.IsSuccess = false;
				result.Message = "Error al crear la factura";
				result.Error = ex;
			}

			return result;
		}

		public MsgResult Modificar(VentaModel model)
		{
			var result = new MsgResult();

			var entity = _context.TblVenta
				.Include(x=>x.DetalleVentas)
				.FirstOrDefault(x => x.IdVenta == model.IdVenta);

			if (entity == null)
			{
				result.IsSuccess = false;
				result.Message = $"La factura que intenta modificar no existe";
				return result;
			}

			entity.NumVenta = model.NumVenta;
			entity.TV_IdCliente = model.TV_IdCliente;
			entity.FechaVenta = model.FechaVenta;

            var itemsFactura = entity.DetalleVentas.ToList();

            foreach (var itemModel in model.Items)
            {
                var itemFactura = itemsFactura.FirstOrDefault(x => x.IdDetalleVenta == itemModel.IdDetalleVenta);
                if (itemFactura != null)
                {
                    itemFactura.Cantidad = itemModel.Cantidad;
                    itemFactura.PrecioUnidad = itemModel.PrecioUnidad;
                }
            }


            try
			{
				_context.SaveChanges();
				result.IsSuccess = true;
				result.Message = "Factura guardada correctamente";
				result.Code = entity.IdVenta;
			}
			catch (Exception ex)
			{
				result.IsSuccess = false;
				result.Message = "Error al guardar la factura";
				result.Error = ex;
			}

			return result;
		}
		public MsgResult Eliminar(int idFactura)
		{
			var result = new MsgResult();

			var entity = _context.TblVenta.FirstOrDefault(x => x.IdVenta == idFactura);

			if (entity == null)
			{
				result.IsSuccess = false;
				result.Message = $"La factura que intenta eliminar no existe";
				return result;
			}

			_context.TblVenta.Remove(entity);

			try
			{
				_context.SaveChanges();
				result.IsSuccess = true;
				result.Message = "Factura eliminada correctamente";
				result.Code = entity.IdVenta;
			}
			catch (Exception ex)
			{
				result.IsSuccess = false;
				result.Message = "Error al eliminar la factura";
				result.Error = ex;
			}

			return result;
		}

		//Elementos de la factura
		public MsgResult AgregarProducto(ItemFacturaModel model)
		{
			var result = new MsgResult();

			var entity = _context.TblVenta
				.Include(x => x.DetalleVentas)
				.FirstOrDefault(x => x.IdVenta == model.TDV_IdArticulo);

			if (entity == null)
			{
				result.IsSuccess = false;
				result.Message = "No existe la factura a la cual desea agregar el producto";
				return result;
			}


			var item = new DetalleVenta
			{

				TDV_IdVenta = model.TDV_IdVenta,
				TDV_IdArticulo = model.TDV_IdArticulo,
				Costo = model.PrecioCompra,
				Cantidad = model.Cantidad,
				PrecioUnidad = model.PrecioUnidad,
			};

			entity.DetalleVentas.Add(item);

			try
			{
				_context.SaveChanges();
				result.IsSuccess = true;
				result.Message = "Elemento agregado correctamente";
				result.Code = item.IdDetalleVenta;
			}
			catch (Exception ex)
			{
				result.IsSuccess = false;
				result.Message = "Error al agregar el producto a la factura.";
				result.Error = ex;
			}


			return result;

		}

		public MsgResult EliminarProducto(ItemFacturaModel model)
		{
			var result = new MsgResult();

			var entity = _context.TblDetalleVenta.FirstOrDefault(x => x.IdDetalleVenta == model.IdDetalleVenta);

			if (entity == null)
			{
				result.IsSuccess = false;
				result.Message = "No existe el producto que desea eliminar";
				return result;
			}

			_context.TblDetalleVenta.Remove(entity);

			try
			{
				_context.SaveChanges();
				result.IsSuccess = true;
				result.Message = "Elemento eliminado correctamente";
			}
			catch (Exception ex)
			{
				result.IsSuccess = false;
				result.Message = "Error al eliminar el producto a la factura.";
				result.Error = ex;
			}


			return result;

		}

	}
}
