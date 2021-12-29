using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;
using TiendaArtesaniasMarielos.Data.Models;

namespace TiendaArtesaniasMarielos.Data.Services
{
	public class VentaService
	{
		private readonly ArtesaniasDbContext _context;

		public VentaService(ArtesaniasDbContext context)
		{
			_context = context;
		}

		public VentaModel Factura(int idFactura)
		{
			var model = _context.TblVenta
				.Include(x => x.Cliente)
				.Include(x => x.DetalleVentas).ThenInclude(x => x.Articulo)
				.Where(x => x.Id == idFactura)
				.Select(x => new VentaModel
				{
					Id = x.Id,
					Numero = x.Numero,
					Fecha = x.Fecha,

					//Cliente
					IdCliente = x.IdCliente,
					NombreCliente = x.Cliente.Nombres + " " + x.Cliente.Apellidos,
					Direccion = x.Cliente.Direccion,
					Telefono = x.Cliente.Telefono,
					Correo = x.Cliente.Correo,

					//Items
					Items = x.DetalleVentas
					.Select(y => new ItemFacturaModel
					{
						Id = y.Id,
						IdVenta = y.IdVenta,

						//Productos                        
						IdArticulo = y.IdArticulo,
						Costo = y.Costo,
						Cantidad = y.Cantidad,
						Precio = y.Precio,
						Codigo = y.Articulo.Codigo,
						NombreArticulo = y.Articulo.Nombre,


					}).ToList()

				}).FirstOrDefault();

			return model;
		}

		public List<VentaModel> ListaFacturas(DateTime desde, DateTime hasta, int? idCliente = null)
		{
			var model = _context.TblVenta
				.Include(x => x.Cliente)
				.Include(x => x.DetalleVentas).ThenInclude(x => x.Articulo)
				.Where(x => x.Fecha >= desde && x.Fecha <= hasta
				&& (x.IdCliente == idCliente || idCliente == null))

				.Select(x => new VentaModel
				{
					Id = x.Id,
					Numero = x.Numero,
					Fecha = x.Fecha,

					//Cliente
					IdCliente = x.IdCliente,
					NombreCliente = x.Cliente.Nombres + " " + x.Cliente.Apellidos,
					Direccion = x.Cliente.Direccion,
					Telefono = x.Cliente.Telefono,
					Correo = x.Cliente.Correo,

					//Items
					Items = x.DetalleVentas
					.Select(y => new ItemFacturaModel
					{
						Id = y.Id,
						IdVenta = y.IdVenta,

						//Productos
						IdArticulo = y.IdArticulo,
						Costo = y.Costo,
						Cantidad = y.Cantidad,
						Precio = y.Precio,
						Codigo = y.Articulo.Codigo,
						NombreArticulo = y.Articulo.Nombre,

					}).ToList()

				}).ToList();

			return model;
		}

		public MsgResult Crear(VentaModel nuevaVenta)
		{
			var result = new MsgResult();

			var entity = _context.TblVenta
				.FirstOrDefault(x => x.Numero == nuevaVenta.Numero);
			//.Include(x => x.DetalleVentas)		para cargar los detalles junto a la venta, pero en este caso no es muy necesario  ->derek




			if (entity != null)
			{
				result.IsSuccess = false;
				result.Message = $"Ya existe una factura con el número {nuevaVenta.Numero}";
				return result;
			}

			entity = new Venta
			{
				Numero = nuevaVenta.Numero,
				Fecha = nuevaVenta.Fecha,
				IdCliente = nuevaVenta.IdCliente,
				DetalleVentas = nuevaVenta.Items
				.Select(x => new DetalleVenta
				{
					IdVenta = x.IdVenta,
					IdArticulo = x.IdArticulo,
					Costo = x.Costo,
					Cantidad = x.Cantidad,
					Precio = x.Precio,
				}).ToList(),
			};


			_context.TblVenta.Add(entity);

			try
            {
                NewMethod(result, entity);
            }
            catch (Exception ex)
			{
				result.IsSuccess = false;
				result.Message = "Error al crear la factura";
				result.Error = ex;
			}

			return result;
		}

        private void NewMethod(MsgResult result, Venta entity)
        {
            _context.SaveChanges();
            result.IsSuccess = true;
            result.Message = "Factura creada correctamente";
            result.Code = entity.Id;
        }

        public MsgResult Modificar(VentaModel model, List<ItemFacturaModel> itemFacturaModelsAnterior)
		{
			var result = new MsgResult();
			try { 
				
				var entity = _context.TblVenta
						.Include(x => x.DetalleVentas)
						.FirstOrDefault(x => x.Id == model.Id);

					model.Items.ForEach(itemNuevo =>
					{
						var itemAntiguo = itemFacturaModelsAnterior.FirstOrDefault(item => item.Codigo == itemNuevo.Codigo);
					//modificacion de los stock de los ARTICULOS en base a ls items actuales de factura y los anteriores de la modificacion
						
						if (itemAntiguo != null)
						{
							int stockActual = _context.TblArticulo.First(art => art.Codigo == itemNuevo.Codigo).Stock;
							_context.TblArticulo.First(art => art.Codigo == itemNuevo.Codigo).Stock = stockActual + (itemNuevo.Cantidad - itemAntiguo.Cantidad) *-1;

						}
						else
						{
							int stockActual = _context.TblArticulo.First(art => art.Codigo == itemNuevo.Codigo).Stock;
							_context.TblArticulo.First(art => art.Codigo == itemNuevo.Codigo).Stock = stockActual - itemNuevo.Cantidad ;
						}
					});


					if (entity == null)
					{
						result.IsSuccess = false;
						result.Message = $"La factura que intenta modificar no existe";
						return result;
					}

					entity.Numero = model.Numero;
					entity.Fecha = model.Fecha;
					entity.IdCliente = model.IdCliente;

					var itemsFactura = entity.DetalleVentas.ToList();

					foreach (var itemModel in model.Items)
					{
						var itemFactura = itemsFactura.FirstOrDefault(x => x.Id == itemModel.Id);
						if (itemFactura != null)
						{
							itemFactura.Cantidad = itemModel.Cantidad;
							itemFactura.Precio = itemModel.Precio;
						}
						else
						{
						var item = new DetalleVenta
						{
							IdVenta = itemModel.IdVenta,
							IdArticulo = itemModel.IdArticulo,
							Costo = itemModel.Costo,
							Cantidad = itemModel.Cantidad,
							Precio = itemModel.Precio,
						};
						entity.DetalleVentas.Add(item);
						//AgregarProducto(itemModel);

						}
					}
			
						_context.SaveChanges();
						result.IsSuccess = true;
						result.Message = "Factura guardada correctamente";
						result.Code = entity.Id;
			}
			catch (Exception ex)
			{
				result.IsSuccess = false;
				result.Message = "Error al guardar la factura";
				result.Error = ex;
			}

			return result;
		}

		//eliminacion de factura
		public MsgResult Eliminar(int idFactura)
		{
			var result = new MsgResult();

			var entity = _context.TblVenta.FirstOrDefault(x => x.Id == idFactura);

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
				result.Code = entity.Id;
			}
			catch (Exception ex)
			{
				result.IsSuccess = false;
				result.Message = "Error al eliminar la factura";
				result.Error = ex;
			}

			return result;
		}

		//Elementos de la factura, devuelve booleano si ingresa el elemento correctamente
		public bool AgregarProducto(ItemFacturaModel model)
		{
			//var result = new MsgResult();

			var entity = _context.TblVenta
				.FirstOrDefault(x => x.Id == model.IdVenta);

				//.Include(x => x.DetalleVentas)		->no veo necesario incluir la lista de detalles, cuando lo que se hara es agregar un nuevo detalle

			//	para mi, simpre habra una venta donde se tenga que guardar		->derek

			//if (entity == null)
			//{
			//	result.IsSuccess = false;
			//	result.Message = "No existe la factura a la cual desea agregar el producto";
			//	return result;
			//}


			var item = new DetalleVenta
			{
				IdVenta = model.IdVenta,
				IdArticulo= model.IdArticulo,
				Costo = model.Costo,
				Cantidad = model.Cantidad,
				Precio = model.Precio,
			};

            try
            {
				entity.DetalleVentas.Add(item);
				return true;

            }
            catch (Exception)
            {
				return false;
            }
			

			//try
			//{
			//	_context.SaveChanges();
			//	result.IsSuccess = true;
			//	result.Message = "Elemento agregado correctamente";
			//	result.Code = item.Id;
			//}
			//catch (Exception ex)
			//{
			//	result.IsSuccess = false;
			//	result.Message = "Error al agregar el producto a la factura.";
			//	result.Error = ex;
			//}

		}

		public MsgResult EliminarProducto(ItemFacturaModel model)
		{
			var result = new MsgResult();

			var entity = _context.TblDetalleVenta
				.FirstOrDefault(x => x.Id == model.Id);

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
