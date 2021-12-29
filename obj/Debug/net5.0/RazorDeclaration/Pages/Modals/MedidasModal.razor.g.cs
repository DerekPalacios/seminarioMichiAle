// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ModalMedidas")]
    public partial class MedidasModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\derek\OneDrive\Documentos\Seminario Aletas Michi 2021\AA\AA\AA\Pages\Modals\MedidasModal.razor"
       

    BSModal VerticallyCentered;

    void onToggle(/*MouseEventArgs e*/)
    {
        VerticallyCentered.Toggle();
        Model = new MedidaModel();
    }

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
