// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Colegio.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\_Imports.razor"
using Colegio.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\_Imports.razor"
using Colegio.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
using Colegio.Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/alumnos")]
    public partial class Alumnos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
       
    public string Url = "/alumnos";

    public IEnumerable<Alumno> oRespuesta = new List<Alumno>();

    protected override async Task OnInitializedAsync()
    {
        oRespuesta = await Http.GetFromJsonAsync<IEnumerable<Alumno>>(Url);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
