#pragma checksum "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\Dialogo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a1cbb8a48167d93efb63ea3c552ec1ea3f4b46c"
// <auto-generated/>
#pragma warning disable 1591
namespace Ejercicio1_2020_03.Shared
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
    public partial class Dialogo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .dialog-container {\r\n    position: absolute;\r\n    top: 0;\r\n    bottom: 0;\r\n    left: 0;\r\n    right: 0;\r\n    background-color: rgba(0,0,0,0.5);\r\n    z-index: 2000;\r\n    display: flex;\r\n    animation: dialog-container-entry 0.2s;\r\n}\r\n\r\n@keyframes dialog-container-entry {\r\n    0% {\r\n        opacity: 0;\r\n    }\r\n\r\n    100% {\r\n        opacity: 1;\r\n    }\r\n}\r\n\r\n\r\n.dialog {\r\n    background-color: white;\r\n    box-shadow: 0 0 12px rgba(0,0,0,0.6);\r\n    display: flex;\r\n    flex-direction: column;\r\n    z-index: 2000;\r\n    align-self: center;\r\n    margin: auto;\r\n    min-width: 550px;\r\n    width: 50%;\r\n    max-height: calc(100% - 3rem);\r\n    animation: dialog-entry 0.4s;\r\n    animation-timing-function: cubic-bezier(0.075, 0.820, 0.165, 1.000);\r\n}\r\n\r\n@keyframes dialog-entry {\r\n    0% {\r\n        transform: translateY(30px) scale(0.1);\r\n    }\r\n\r\n    100% {\r\n        transform: translateX(0px) scale(1.0);\r\n    }\r\n}\r\n\r\n.dialog-title {\r\n    background-color: #444;\r\n    color: #fff2cc;\r\n    padding: 1.3rem 2rem;\r\n}\r\n\r\n    .dialog-title h2 {\r\n        color: white;\r\n        font-size: 1.4rem;\r\n        margin: 0;\r\n        font-family: \'Bahnschrift\', Arial, Helvetica, sans-serif;\r\n        text-transform: uppercase;\r\n        line-height: 1.3rem;\r\n    }\r\n\r\n.dialog-body {\r\n    flex-grow: 1;\r\n    padding: 0.5rem 3rem 1rem 0;\r\n}\r\n\r\n    .dialog-body > div {\r\n        display: flex;\r\n        margin-top: 1rem;\r\n        align-items: center;\r\n    }\r\n\r\n    .dialog-body label {\r\n        text-align: right;\r\n        width: 200px;\r\n        margin: 0 1.5rem;\r\n    }\r\n\r\n.dialog-buttons {\r\n    height: 4rem;\r\n    background-color: #eee;\r\n    text-align: center;\r\n    padding: 0.8rem;\r\n}\r\n\r\n.dialog-buttons button,input {\r\n    margin: 0px 20px;\r\n}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "dialog-container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "dialog");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "dialog-title");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "h2");
            __builder.AddContent(11, 
#nullable restore
#line 99 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\Dialogo.razor"
                 Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "dialog-body");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddContent(17, 
#nullable restore
#line 102 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\Dialogo.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "dialog-buttons");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "btn btn-dark");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 105 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\Dialogo.razor"
                                                                 OnClose

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.AddContent(29, 
#nullable restore
#line 106 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\Dialogo.razor"
             Footer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\Dialogo.razor"
       

    [Parameter] public EventCallback OnClose { get; set; }

    [Parameter] public string Title { get; set; }
    [Parameter] public RenderFragment Body { get; set; }
    [Parameter] public RenderFragment Footer { get; set; }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591