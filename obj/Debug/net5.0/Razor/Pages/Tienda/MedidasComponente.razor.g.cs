#pragma checksum "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\Pages\Tienda\MedidasComponente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b582281a3599e043eefe0592609225f50d3c1a49"
// <auto-generated/>
#pragma warning disable 1591
namespace TiendaArtesaniasMarielos.Pages.Tienda
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using TiendaArtesaniasMarielos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Pages.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Sotsera.Blazor.Toaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\Pages\Tienda\MedidasComponente.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/medidas")]
    public partial class MedidasComponente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<TiendaArtesaniasMarielos.Pages.Modals.MedidasModal>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-bordered");
            __builder.AddMarkupContent(8, "<thead><tr><th>Tamaño</th>\r\n                        <th>Articulos</th>\r\n                        <th>Acciones</th></tr></thead>\r\n                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 30 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\Pages\Tienda\MedidasComponente.razor"
                     foreach (var cat in ListaMedidas)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\Pages\Tienda\MedidasComponente.razor"
                                                                               cat.Nombre_Medida

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cat.Nombre_Medida = __value, cat.Nombre_Medida));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 36 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\Pages\Tienda\MedidasComponente.razor"
__builder.AddContent(19, cat.CantidadArticulos);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-success");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\Pages\Tienda\MedidasComponente.razor"
                                                                          (()=>ModificarMedida(cat))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Guardar");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\Pages\Tienda\MedidasComponente.razor"
                                                                         (()=>EliminarMedida(cat.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\Pages\Tienda\MedidasComponente.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenComponent<Sotsera.Blazor.Toaster.ToastContainer>(32);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\Pages\Tienda\MedidasComponente.razor"
       
    public MedidaModel Model { get; set; } = new MedidaModel();

    public List<MedidaModel> ListaMedidas { get; set; } = new List<MedidaModel>();

    protected override void OnInitialized()
    {
        CargarMedida();
        //otros metodos
    }

    protected void CargarMedida()
    {
        var result = medidaService.ListaMedidas();
        ListaMedidas = result;
    }

    protected void AgregarMedida()
    {
        var result = medidaService.Crear(Model);
        if (result.IsSuccess)
        {
            Model.Id = result.Code;
            Model.CantidadArticulos = 0;



            ListaMedidas.Add(Model);

            Model = new MedidaModel();
            toaster.Success(result.Message, "OK");
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }

    }

    protected void ModificarMedida(MedidaModel etapa)
    {
        var result = medidaService.Modificar(etapa);
        if (result.IsSuccess)
        {
            toaster.Success(result.Message, "OK");
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }

    }

    protected async Task EliminarMedida(int idmedida)
    {
        var res = await swal.FireAsync(new SweetAlertOptions
        {
            Title = "¿Confirma que desea eliminar este dato?",
            Text = "Si la elimina, no podrá recuperarlo",
            ShowConfirmButton = true,
            ConfirmButtonText = "Si, eliminar",
            ShowCancelButton = true,
            CancelButtonText = "No, eliminar"
        });

        if (!res.IsConfirmed)
        {
            return;
        }

        var result = medidaService.Eliminar(idmedida);

        if (result.IsSuccess)
        {
            CargarMedida();
            toaster.Success(result.Message, "OK");
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToaster toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MedidaService medidaService { get; set; }
    }
}
#pragma warning restore 1591
