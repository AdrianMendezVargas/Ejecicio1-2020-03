#pragma checksum "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\FieldsEstudiante.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "834717e7b8b2ab019237c79e387e3c8c65186db0"
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
    public partial class FieldsEstudiante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-field");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label>Nombres: </label>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
            __builder.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\FieldsEstudiante.razor"
                                Estudiante.Nombres

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Estudiante.Nombres = __value, Estudiante.Nombres))));
            __builder.AddAttribute(9, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Estudiante.Nombres));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "<br>\r\n        ");
            __Blazor.Ejercicio1_2020_03.Shared.FieldsEstudiante.TypeInference.CreateValidationMessage_0(__builder, 11, 12, 
#nullable restore
#line 5 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\FieldsEstudiante.razor"
                                ()=>Estudiante.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-field");
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.AddMarkupContent(19, "<label>Semestre: </label>\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddMarkupContent(21, "\r\n        ");
            __Blazor.Ejercicio1_2020_03.Shared.FieldsEstudiante.TypeInference.CreateInputNumber_1(__builder, 22, 23, 
#nullable restore
#line 12 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\FieldsEstudiante.razor"
                                  Estudiante.Semestre

#line default
#line hidden
#nullable disable
            , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Estudiante.Semestre = __value, Estudiante.Semestre)), 25, () => Estudiante.Semestre);
            __builder.AddMarkupContent(26, "<br>\r\n        ");
            __Blazor.Ejercicio1_2020_03.Shared.FieldsEstudiante.TypeInference.CreateValidationMessage_2(__builder, 27, 28, 
#nullable restore
#line 13 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\FieldsEstudiante.razor"
                                ()=>Estudiante.Semestre

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-field");
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.AddMarkupContent(35, "<label>Nacionalidad: </label>\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
            __builder.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\FieldsEstudiante.razor"
                                Estudiante.Nacionalidad

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Estudiante.Nacionalidad = __value, Estudiante.Nacionalidad))));
            __builder.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Estudiante.Nacionalidad));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "<br>\r\n        ");
            __Blazor.Ejercicio1_2020_03.Shared.FieldsEstudiante.TypeInference.CreateValidationMessage_3(__builder, 43, 44, 
#nullable restore
#line 20 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\FieldsEstudiante.razor"
                                ()=>Estudiante.Nacionalidad

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Hp\source\Aplicada2\Ejercicio1-2020-03\Shared\FieldsEstudiante.razor"
       
    [Parameter] public Estudiante Estudiante { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Ejercicio1_2020_03.Shared.FieldsEstudiante
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
