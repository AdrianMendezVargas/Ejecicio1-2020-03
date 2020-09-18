#pragma checksum "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98cbc885d11ce2fa08aecdbfa195b0c2d8b93706"
// <auto-generated/>
#pragma warning disable 1591
namespace Ejercicio1_2020_03.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Ejercicio1_2020_03;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Ejercicio1_2020_03.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Ejercicio1_2020_03.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Ejercicio1_2020_03.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/estudiantes")]
    public partial class RegistroEstudiantes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main-header-list");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h2>Lista de estudiante</h2>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "type", "button");
            __builder.AddAttribute(6, "class", "btn btn-success");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                                            AgregarEstudiante

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "+ Agregar");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-hover");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<thead class=\"thead-light\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nombres</th>\r\n            <th>Semestre</th>\r\n            <th>Nacionalidad</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 20 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
         foreach (var estudiante in Estudiantes) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "            ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 22 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                     estudiante.EstudianteId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 23 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                     estudiante.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 24 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                     estudiante.Semestre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 25 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                     estudiante.Nacionalidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-warning");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                                              ()=>ModificarEstudiante(estudiante)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Mas");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 29 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n");
#nullable restore
#line 33 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
 if (MostraDialogoEditor) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "    ");
            __builder.OpenComponent<Ejercicio1_2020_03.Shared.EditorEstudiantes>(43);
            __builder.AddAttribute(44, "estudiante", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Ejercicio1_2020_03.Models.Estudiante>(
#nullable restore
#line 34 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                   estudianteEnModificacion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 35 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                OcultarDialogo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(46, "EsNuevoEstudiante", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                          esNuevo

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 37 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
       

    bool MostraDialogoEditor = false;
    bool esNuevo = false;


    Estudiante estudianteEnModificacion = new Estudiante();

    public List<Estudiante> Estudiantes { get; set; }

    void ModificarEstudiante(Estudiante estudiante) {
        estudianteEnModificacion = estudiante;
        esNuevo = false;
        MostraDialogoEditor = true;
    }

    void AgregarEstudiante() {
        estudianteEnModificacion = new Estudiante();
        esNuevo = true;
        MostraDialogoEditor = true;
    }

    void OcultarDialogo() {
        MostraDialogoEditor = false;
        Estudiantes = EstudiantesBLL.GetEstudiantes();
    }

    protected override void OnInitialized() {
        Estudiantes = EstudiantesBLL.GetEstudiantes();
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
