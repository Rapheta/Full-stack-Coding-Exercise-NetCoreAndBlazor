#pragma checksum "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b0b7cbcffa8210adf0869c4ebf9ea6c44b6b19c"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3><span class=\"oi oi-people\" aria-hidden=\"true\"></span>&nbsp;&nbsp;Alumnos</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row\">\r\n    <div class=\"col-12 text-right\">\r\n        <a class=\"btn btn-outline-success btn-sm mb-2\" href=\"alumnoForm\"><span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Nuevo</a>\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-sm table-hover");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 17 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
     if (oRespuesta != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.AddMarkupContent(6, @"<thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Apellidos</th>
                <th scope=""col"">Curso</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 29 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
             foreach (var oElement in oRespuesta)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "scope", "row");
            __builder.AddContent(14, 
#nullable restore
#line 32 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
                                     oElement.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
                         oElement.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
                         oElement.Apellidos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
                         oElement.Curso

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "text-right");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "text-primary");
            __builder.AddAttribute(32, "href", "/alumnoForm/" + (
#nullable restore
#line 38 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
                                                                       oElement.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "title", "Editar");
            __builder.AddMarkupContent(34, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "text-danger");
            __builder.AddAttribute(38, "href", "/eliminarAlumno/" + (
#nullable restore
#line 39 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
                                                                          oElement.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "title", "Eliminar");
            __builder.AddMarkupContent(40, "<span class=\"oi oi-x\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 43 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 45 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Alumnos.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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