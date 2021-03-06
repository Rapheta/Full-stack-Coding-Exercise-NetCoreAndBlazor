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
#line 4 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\EvaluacionForm.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\EvaluacionForm.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\EvaluacionForm.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/evaluacionForm")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/evaluacionForm/{Id:int}")]
    public partial class EvaluacionForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\EvaluacionForm.razor"
       
    [Parameter]
    public int Id { get; set; }

    Evaluacion oEvaluacion = new Evaluacion();
    object oRespuesta = new object();
    Evaluacion oRespuestaEvaluacion = new Evaluacion();
    public string Url = "/Evaluacion/GetEvaluacion";


    public IEnumerable<Alumno> oAlumnos = new List<Alumno>();
    public string UrlAlumnos = "/Alumnos";

    public IEnumerable<Asignatura> oAsignaturas = new List<Asignatura>();
    public string UrlAsignaturas = "/Asignaturas";

    private void Cancel() => Navigationmanager.NavigateTo("/evaluaciones");

    private async Task Save()
    {
        Url = "/Evaluacion";
        if (Id != 0)
        {
            var response = await Http.PutAsJsonAsync<Evaluacion>(Url, oEvaluacion);
            oRespuesta = response.Content.ReadFromJsonAsync<object>().Result;
        }
        else
        {
            var response = await Http.PostAsJsonAsync<Evaluacion>(Url, oEvaluacion);
            oRespuesta = response.Content.ReadFromJsonAsync<object>().Result;
        }

        Navigationmanager.NavigateTo("/evaluaciones");
    }

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            oRespuestaEvaluacion = await Http.GetFromJsonAsync<Evaluacion>(Url + "/" + Id);
            oEvaluacion = oRespuestaEvaluacion;
        }
        else
        {
            oAlumnos = await Http.GetFromJsonAsync<IEnumerable<Alumno>>(UrlAlumnos);
            oAsignaturas = await Http.GetFromJsonAsync<IEnumerable<Asignatura>>(UrlAsignaturas);
        }
    }

    private void AsignarAlumno(int alumnoId)
    {
        oEvaluacion.AlumnoId = alumnoId;
    }

    private void AsignarAsignatura(int asignaturaId)
    {
        oEvaluacion.AsignaturaId = asignaturaId;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigationmanager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
