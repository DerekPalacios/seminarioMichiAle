#pragma checksum "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc583eb1919a1b36189e0915ffdc8ab569dc001a"
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
#line 1 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Sotsera.Blazor.Toaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tallaMedida")]
    public partial class TallaMedidaComponente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row mb-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "input-group");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
                                                               Model.Descripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Descripcion = __value, Model.Descripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "input-group-append");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
                                                              AgregarTallaMedida

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Agregar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table table-bordered");
            __builder.AddMarkupContent(27, "<thead><tr><th>Talla o Medida</th>\r\n                        <th>Articulos</th>\r\n                        <th>Acciones</th></tr></thead>\r\n                ");
            __builder.OpenElement(28, "tbody");
#nullable restore
#line 28 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
                     foreach (var cat in ListaTallaMedida)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
                                                                               cat.Descripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cat.Descripcion = __value, cat.Descripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 34 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
                                 cat.CantidadArticulos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.OpenElement(40, "td");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-success");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
                                                                          (()=>ModificarTallaMedida(cat))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Guardar");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-danger");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
                                                                         (()=>EliminarTallaMedida(cat.IdTalla_Medida))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.OpenComponent<Sotsera.Blazor.Toaster.ToastContainer>(51);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Tienda\TallaMedidaComponente.razor"
       
    public TallaMedidaModel Model { get; set; } = new TallaMedidaModel();

    public List<TallaMedidaModel> ListaTallaMedida { get; set; } = new List<TallaMedidaModel>();

    protected override void OnInitialized()
    {
        CargarTallaMedida();
        //otros metodos
    }

    protected void CargarTallaMedida()
    {
        var result = tallaMedidaService.ListaTallaMedida();
        ListaTallaMedida = result;
    }

    protected void AgregarTallaMedida()
    {
        var result = tallaMedidaService.Crear(Model);
        if (result.IsSuccess)
        {
            Model.IdTalla_Medida = result.Code;
            Model.CantidadArticulos = 0;



            ListaTallaMedida.Add(Model);

            Model = new TallaMedidaModel();
            toaster.Success(result.Message, "OK");
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }

    }

    protected void ModificarTallaMedida(TallaMedidaModel tallaMedida)
    {
        var result = tallaMedidaService.Modificar(tallaMedida);
        if (result.IsSuccess)
        {
            toaster.Success(result.Message, "OK");
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }

    }

    protected async Task EliminarTallaMedida(int idtallaMedida)
    {
        var res = await swal.FireAsync(new SweetAlertOptions
        {
            Title = "¿Confirma que desea eliminar este dato?",
            Text = "Si la elimina, no podrá recuperarlo",
            ShowConfirmButton = true,
            ConfirmButtonText = "Si, eliminar",
            ShowCancelButton = true,
            CancelButtonText = "No, no lo elimine"
        });

        if (!res.IsConfirmed)
        {
            return;
        }

        var result = tallaMedidaService.Eliminar(idtallaMedida);

        if (result.IsSuccess)
        {
            CargarTallaMedida();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TallaMedidaService tallaMedidaService { get; set; }
    }
}
#pragma warning restore 1591
