#pragma checksum "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c8a84b3317d7f56cd9ab6b333eb78354428e0e4"
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
#line 4 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profesorForm")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/profesorForm/{Id:int}")]
    public partial class ProfesorForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><span class=\"oi oi-clipboard\" aria-hidden=\"true\"></span>&nbsp;&nbsp;Formulario del Profesor</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor"
                  oProfesor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "container-fluid mt-3");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.AddMarkupContent(11, "<label class=\"col-sm-3\">Nombre</label>\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-sm-9");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control form-control-sm");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor"
                                                                              oProfesor.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProfesor.Nombre = __value, oProfesor.Nombre))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProfesor.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.AddMarkupContent(26, "<label class=\"col-sm-3\">Apellidos</label>\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-sm-9");
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control form-control-sm");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor"
                                                                              oProfesor.Apellidos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProfesor.Apellidos = __value, oProfesor.Apellidos))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProfesor.Apellidos));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.AddMarkupContent(41, "<label class=\"col-sm-3\">Area</label>\r\n            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-sm-9");
                __builder2.AddMarkupContent(44, "\r\n                ");
                __Blazor.Colegio.Blazor.Pages.ProfesorForm.TypeInference.CreateInputNumber_0(__builder2, 45, 46, "form-control form-control-sm", 47, 
#nullable restore
#line 29 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor"
                                                                                oProfesor.Area

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProfesor.Area = __value, oProfesor.Area)), 49, () => oProfesor.Area);
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group row mb-1 mt-2");
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-sm-12");
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "button");
                __builder2.AddAttribute(60, "class", "btn btn-success btn-sm");
                __builder2.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor"
                                                                 Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(62, "Guardar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\TRABAJO\PRUEBAS Y EJERCICIOS\Colegio - Ejercicio FullStack\Colegio.Blazor\Pages\ProfesorForm.razor"
       
    [Parameter]
    public int Id { get; set; }

    Profesor oProfesor = new Profesor();
    object oRespuesta = new object();
    Profesor oRespuestaProfesor = new Profesor();
    public string Url = "/Profesores";

    private async Task Save()
    {
        if (Id != 0)
        {
            var response = await Http.PutAsJsonAsync<Profesor>(Url, oProfesor);
            oRespuesta = response.Content.ReadFromJsonAsync<object>().Result;
        }
        else
        {
            var response = await Http.PostAsJsonAsync<Profesor>(Url, oProfesor);
            oRespuesta = response.Content.ReadFromJsonAsync<object>().Result;
        }

        Navigationmanager.NavigateTo("/profesores");
    }

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            oRespuestaProfesor = await Http.GetFromJsonAsync<Profesor>(Url + "/" + Id);
            oProfesor = oRespuestaProfesor;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigationmanager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Colegio.Blazor.Pages.ProfesorForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
