#pragma checksum "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4778dbe05eff2e88b078f867414006d3424c2010"
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
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "filter");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "class", "custom-select");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                             indexSelect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => indexSelect = __value, indexSelect));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", "0");
            __builder.AddContent(20, "Filtrar por");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value", "1");
            __builder.AddContent(24, "Id");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "2");
            __builder.AddContent(28, "Nombre");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "3");
            __builder.AddContent(32, "Semestre");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "4");
            __builder.AddContent(36, "Nacionalidad");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", 
#nullable restore
#line 14 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                       (indexSelect == 1 || indexSelect == 3 ) ? "number" : "text"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                                                                            criterioDeBusqueda

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => criterioDeBusqueda = __value, criterioDeBusqueda));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-outline-primary");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                                          FiltarEstudiantes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
 if (Estudiantes == null || EstudiantesFiltrados == null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.AddMarkupContent(52, "<div class=\"loading-message\">\r\n        <span>Cargando...</span>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
} else { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.OpenElement(54, "table");
            __builder.AddAttribute(55, "class", "table table-hover");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.AddMarkupContent(57, @"<thead class=""thead-light"">
            <tr>
                <th>Id</th>
                <th>Nombres</th>
                <th>Semestre</th>
                <th>Nacionalidad</th>
                <th></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(58, "tbody");
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 36 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
             foreach (var estudiante in EstudiantesFiltrados) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                ");
            __builder.OpenElement(61, "tr");
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 38 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                         estudiante.EstudianteId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 39 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                         estudiante.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 40 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                         estudiante.Semestre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 41 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                         estudiante.Nacionalidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "td");
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "class", "btn btn-warning");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                                                  ()=>ModificarEstudiante(estudiante)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(79, "Mas");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 44 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 47 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 49 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
 if (MostraDialogoEditor) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "    ");
            __builder.OpenComponent<Ejercicio1_2020_03.Shared.DialogoEditorEstudiantes>(87);
            __builder.AddAttribute(88, "estudiante", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Ejercicio1_2020_03.Models.Estudiante>(
#nullable restore
#line 50 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                          estudianteEnModificacion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 51 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                       OcultarDialogo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(90, "EsNuevoEstudiante", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
                                                 esNuevo

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 53 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Pages\RegistroEstudiantes.razor"
       

    bool MostraDialogoEditor = false;
    bool esNuevo = false;

    int indexSelect = 0; //indice actual del select
    string criterioDeBusqueda;

    Estudiante estudianteEnModificacion = new Estudiante();

    public List<Estudiante> Estudiantes { get; set; }
    public List<Estudiante> EstudiantesFiltrados { get; set; }

    protected async override Task OnInitializedAsync() {
        Estudiantes = await EstudiantesBLL.GetEstudiantes();
        EstudiantesFiltrados = Estudiantes;
    }

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

    async Task OcultarDialogo() {
        MostraDialogoEditor = false;
        Estudiantes = await EstudiantesBLL.GetEstudiantes();
        QuitarFiltros();
    }

    void QuitarFiltros() {
        indexSelect = 0;
        criterioDeBusqueda = "";
        FiltarEstudiantes();
    }

    void FiltarEstudiantes() {

        if (indexSelect == 0) {//Todos

            EstudiantesFiltrados = Estudiantes.Where(e => true).ToList();

        } else if (indexSelect == 1) {//Id

            if (int.TryParse(criterioDeBusqueda , out int Id)) {

                EstudiantesFiltrados = Estudiantes.Where(e => e.EstudianteId == Id).ToList();
            }

        } else if (indexSelect == 2) {//Nombre

            EstudiantesFiltrados = Estudiantes.Where(e => e.Nombres.ToLower().Contains(criterioDeBusqueda.ToLower())).ToList();

        } else if (indexSelect == 3) {//Semestre

            if (int.TryParse(criterioDeBusqueda , out int semestre)) {

                EstudiantesFiltrados = Estudiantes.Where(e => e.Semestre == semestre).ToList();
            }

        } else if (indexSelect == 4) {//Nacionalidad

            EstudiantesFiltrados = Estudiantes.Where(e => e.Nacionalidad == criterioDeBusqueda).ToList();

        }

    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
