#pragma checksum "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47287e5e486f518dd8c3b2a24a7fe1b2cb640684"
// <auto-generated/>
#pragma warning disable 1591
namespace TiendaArtesaniasMarielos.Pages.Modals
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ModalCategorias")]
    public partial class CategoriasModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorStrap.BSButton>(0);
            __builder.AddAttribute(1, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 3 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
                 Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
                                           onToggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Agregar Categoria");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<BlazorStrap.BSModal>(6);
            __builder.AddAttribute(7, "IsCentered", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSModalHeader>(9);
                __builder2.AddAttribute(10, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
                             onToggle

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, "Nueva Categoria");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSModalBody>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "container");
                    __builder3.OpenElement(18, "div");
                    __builder3.AddAttribute(19, "class", "row mb-3");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "input-group");
                    __builder3.OpenElement(24, "input");
                    __builder3.AddAttribute(25, "type", "text");
                    __builder3.AddAttribute(26, "class", "form-control");
                    __builder3.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
                                                                       Model.Nombre_Categoria

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Nombre_Categoria = __value, Model.Nombre_Categoria));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\r\n                        ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "input-group-append");
                    __builder3.OpenElement(32, "button");
                    __builder3.AddAttribute(33, "class", "btn btn-primary");
                    __builder3.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
                                                                      AgregarCategoria

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(35, "Agregar");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSModalFooter>(37);
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSButton>(39);
                    __builder3.AddAttribute(40, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 21 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
                         Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
                                                     onToggle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(43, "Cerrar");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(44, (__value) => {
#nullable restore
#line 4 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
               VerticallyCentered = (BlazorStrap.BSModal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.OpenComponent<Sotsera.Blazor.Toaster.ToastContainer>(46);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\CategoriasModal.razor"
       

    BSModal VerticallyCentered;

    void onToggle(/*MouseEventArgs e*/)
    {
        VerticallyCentered.Toggle();
        Model = new CategoriaModel();
    }

    public CategoriaModel Model { get; set; } = new CategoriaModel();

    public List<CategoriaModel> ListaCategorias { get; set; } = new List<CategoriaModel>();

    protected override void OnInitialized()
    {
        CargarCategorias();
        //otros metodos
    }

    protected void CargarCategorias()
    {
        var result = categoriaService.ListaCategorias();
        ListaCategorias = result;
    }

    protected void AgregarCategoria()
    {
        var result = categoriaService.Crear(Model);
        if (result.IsSuccess)
        {
            Model.Id = result.Code;
            Model.CantidadProductos = 0;

            ListaCategorias.Add(Model);

            Model = new CategoriaModel();
            toaster.Success(result.Message, "OK");
            onToggle();
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }

    }



    protected void ModificarCategoria(CategoriaModel categoria)
    {
        var result = categoriaService.Modificar(categoria);
        if (result.IsSuccess)
        {
            toaster.Success(result.Message, "OK");
        }
        else
        {
            toaster.Error(result.Message, "Error");
        }

    }

    protected async Task EliminarCategoria(int idCategoria)
    {
        var res = await swal.FireAsync(new SweetAlertOptions
        {
            Title = "??Confirma que desea eliminar esta categor??a?",
            Text = "Si la elimina, no podr?? recuperarla",
            ShowConfirmButton = true,
            ConfirmButtonText = "Si, eliminar",
            ShowCancelButton = true,
            CancelButtonText = "No, eliminar"
        });

        if (!res.IsConfirmed)
        {
            return;
        }

        var result = categoriaService.Eliminar(idCategoria);

        if (result.IsSuccess)
        {
            CargarCategorias();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CategoriasService categoriaService { get; set; }
    }
}
#pragma warning restore 1591
