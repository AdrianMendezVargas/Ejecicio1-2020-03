#pragma checksum "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\GenericForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1652b618063befed0177b30937abfd2696f6c851"
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
    public partial class GenericForm<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddMultipleAttributes(1, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 2 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\GenericForm.razor"
                       Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\GenericForm.razor"
                                          Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\GenericForm.razor"
                                                                OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddContent(6, 
#nullable restore
#line 3 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\GenericForm.razor"
     Fields

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\GenericForm.razor"
       
    [Parameter] public RenderFragment Fields { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public T Model { get; set; }
    [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, Object> Attributes { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
