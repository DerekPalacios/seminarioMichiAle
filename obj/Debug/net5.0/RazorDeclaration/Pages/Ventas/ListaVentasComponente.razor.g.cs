// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TiendaArtesaniasMarielos.Pages.Ventas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/facturas")]
    public partial class ListaVentasComponente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
       

    public DateTime Desde { get; set; } = DateTime.Now.AddDays(-365);
    public DateTime Hasta { get; set; } = DateTime.Now;

    public int? IdCliente { get; set; }

    public List<VentaModel> ListaFacturas { get; set; } = new List<VentaModel>();
    public List<ClienteModel> ListaClientes { get; set; }

    protected override void OnInitialized()
    {
        ListaClientes = clientesService.ListaClientes();
        CargarFacturas();
    }

    protected void CargarFacturas()
    {
        var hasta = Hasta.AddHours(23).AddMinutes(59).AddSeconds(59);
        ListaFacturas = facturaService.ListaFacturas(Desde, hasta, IdCliente);
    }

    protected async Task EliminarFactura(VentaModel model)
    {
        var confirm = await swal.FireAsync(new SweetAlertOptions
        {
            Title = "¿Confirma que desea eliminar esta factura?",
            Text = "Si la elimina, no podrá recuperarla",
            ShowConfirmButton = true,
            ConfirmButtonText = "Si, eliminar",
            ShowCancelButton = true,
            CancelButtonText = "No, no la elimine"
        });

        if (!confirm.IsConfirmed)
        {
            return;
        }

        var res = facturaService.Eliminar(model.IdVenta);
        if (res.IsSuccess)
        {
            toaster.Success(res.Message, "OK");
            ListaFacturas.Remove(model);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService clientesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VentasService facturaService { get; set; }
    }
}
#pragma warning restore 1591