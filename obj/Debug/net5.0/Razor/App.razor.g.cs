#pragma checksum "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97986a6d7acc4d7b610aad3f90abede50a7ba531"
// <auto-generated/>
#pragma warning disable 1591
namespace TiendaArtesaniasMarielos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Pages.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Sotsera.Blazor.Toaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "PreferExactMatches", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(8);
                __builder2.AddAttribute(9, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "D:\Usuarios\Alejandro Moraga\Escritorio\AA\AA\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<TiendaArtesaniasMarielos.Shared.PathNotFound>(11);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
