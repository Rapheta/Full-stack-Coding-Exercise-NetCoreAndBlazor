#pragma checksum "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f834f658557db34031e7a3b0b40e584f719942db"
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
#line 1 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Bienvenido a esta nueva aplicación</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""alert alert-dark mt-3"" role=""alert"">
    Este es un pequeño ejercicio sobre la creación de un CRUD mediante la tecnología <b>.NET EntityFrameWork Core</b> y <b>Blazor</b>. Lo primero que se debe hacer es conectar un servicio .NET CORE a una base de datos. Mediante Blazor nos conectaremos a dicho servicio y crear así una Single Page Application.
</div>

");
            __builder.AddMarkupContent(2, @"<div class=""row"">
    <div class=""col-2"">

    </div>
    <div class=""col-2"">
        <img src=""../images/blazor.png"" asp-append-version=""true"" title=""Blazor"" style=""max-height: 200px; width: 100%; max-width:200px;"">
    </div>
    <div class=""col-1"">

    </div>
    <div class=""col-2"">
        <img src=""../images/netcore.png"" asp-append-version=""true"" title="".NET EntityFramework Core"" style=""max-height: 200px; width: 100%; max-width:200px;"">
    </div>
    <div class=""col-1"">

    </div>
    <div class=""col-2"">
        <img src=""../images/sql-server.png"" asp-append-version=""true"" title=""SQL Server"" style=""max-height: 200px; width: 100%; max-width:250px;"">
    </div>
    <div class=""col-2"">

    </div>
</div>

");
            __builder.AddMarkupContent(3, @"<div>
    <div class=""mt-2 mb-2"">Esta aplicación o proyecto Web simula la gestión de un centro de educación. Mediante la aplicación el usuario puede añadir alumnos al centro, profesores, asignaturas y finalmente gestionar las calificaciones de los alumnos.</div>

    <div class=""mt-2 mb-2"">Los pasos a seguir para implementar esta aplicación son:</div>

    <ul>
        <li>Creación de una base de datos</li>
        <li>Creación del servicio MVC .NET Core</li>
        <li>Creación de la aplicación Blazor</li>
    </ul>

    <div class=""mt-2 mb-2"">El diseño de nuestra base de datos sería el que se muestra en la imagen:</div>

    <div class=""row"">
        <div class=""col-3""></div>
        <div class=""col-6"">
            <img src=""../images/database.jpg"" asp-append-version=""true"" title=""Base de datos"" style=""width:100%;"">
        </div>
        <div class=""col-3""></div>
    </div>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
