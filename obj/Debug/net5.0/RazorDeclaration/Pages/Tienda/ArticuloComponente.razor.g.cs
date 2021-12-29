// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TiendaArtesaniasMarielos.Pages.Tienda
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Pages.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Sotsera.Blazor.Toaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/articulos")]
    public partial class ArticuloComponente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 210 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Tienda\ArticuloComponente.razor"
       

    public ArticuloModel Articulo { get; set; } = new ArticuloModel();

    public List<CategoriaModel> ListaCategorias { get; set; }

    //public int IdMedida { get; set; }
    public List<TallaModel> ListaTalla{ get; set; }
    public List<MedidaModel> ListaMedida { get; set; }
    public List<GeneroModel> ListaGeneros { get; set; }
    public List<EtapaModel> ListaEtapas { get; set; }
    public List<MaterialModel> ListaMateriales { get; set; }

    public List<ArticuloModel> ListaArticulos { get; set; } = new List<ArticuloModel>();

    protected override void OnInitialized()
    {
        ListaCategorias = categoriaService.ListaCategorias();
        ListaTalla = tallaService.ListaTalla();
        ListaMedida = medidaService.ListaMedidas();
        ListaGeneros = generoService.ListaGeneros();
        ListaEtapas = etapaService.ListaEtapas();
        ListaMateriales = materialService.ListaMateriales();

        CargarProductos();
    }

    protected void CargarProductos()
    {


        var result = articuloService.ListaArticulos();
        ListaArticulos = result;


    }



    protected void AgregarProducto()
    {
        var res = articuloService.Crear(Articulo);

        if (res.IsSuccess)
        {
            Articulo.Id = res.Code;

            //var prod = (ArticuloModel)res.Objeto;
            //var prod = res.Objeto as ProductoModel;

            ListaArticulos.Add(Articulo);

            Articulo = new ArticuloModel();
            toaster.Success(res.Message, "OK");

            //CargarProductos(); No recomendada

        }
        else
        {
            toaster.Error(res.Message, "Error");
        }
    }

    //protected void AlcambiarCategoriaSeleccionada(ChangeEventArgs e)
    //{
    //    Articulo.TA_IdCategoria = Convert.ToInt32(e.Value);

    //    CargarProductos(Articulo.TA_IdCategoria
    //        );


    //}


    protected async Task EliminarProducto(ArticuloModel producto)
    {
        var confirm = await swal.FireAsync(new SweetAlertOptions
        {
            Title = "¿Confirma que desea eliminar este articulo?",
            Text = "No podrá revertir esta operación",
            ShowConfirmButton = true,
            ShowCancelButton = true,
            ConfirmButtonText = "De acuerdo",
            CancelButtonText = "Cancelar"
        });

        if (!confirm.IsConfirmed)
        {
            return;
        }

        var res = articuloService.Eliminar(producto.Id);

        if (res.IsSuccess)
        {
            toaster.Success(res.Message, "OK");
            ListaArticulos.Remove(producto);
        }
        else
        {
            toaster.Error(res.Message, "Error");
        }
    }

    protected void GuardarProducto(ArticuloModel producto)
    {
        if (string.IsNullOrEmpty(producto.Codigo))
        {
            toaster.Error("Debe escribir el codigo del producto", "Error");
            return;
        }

        if (string.IsNullOrEmpty(producto.Nombre) || producto.Nombre.Length < 5)
        {
            toaster.Error("El nombre del articulo debe ser mayor a 5 caracteres", "Error");
            return;
        }

        if (string.IsNullOrEmpty(producto.Stock.ToString()))
        {
            toaster.Error("Debe escribir el nombre valor del stock", "Error");
            return;
        }

        if (string.IsNullOrEmpty(producto.Costo.ToString()))
        {
            toaster.Error("Debe escribir el costo del producto", "Error");
            return;
        }

        if (string.IsNullOrEmpty(producto.Precio.ToString()))
        {
            toaster.Error("Debe escribir el precio del producto", "Error");
            return;
        }


        var res = articuloService.Modificar(producto);

        if (res.IsSuccess)
        {
            toaster.Success(res.Message, "OK");
        }
        else
        {
            toaster.Error(res.Message, "Error");

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToaster toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArticuloService articuloService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EtapasService etapaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MaterialesService materialService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GeneroService generoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MedidaService medidaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TallaService tallaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CategoriasService categoriaService { get; set; }
    }
}
#pragma warning restore 1591
