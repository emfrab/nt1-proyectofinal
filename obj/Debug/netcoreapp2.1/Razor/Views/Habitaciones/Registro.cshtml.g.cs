#pragma checksum "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2997d809ba06d61a81ca486fa43574d0325c20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Habitaciones_Registro), @"mvc.1.0.view", @"/Views/Habitaciones/Registro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Habitaciones/Registro.cshtml", typeof(AspNetCore.Views_Habitaciones_Registro))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\_ViewImports.cshtml"
using ProyectoHotelNT1;

#line default
#line hidden
#line 2 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\_ViewImports.cshtml"
using ProyectoHotelNT1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2997d809ba06d61a81ca486fa43574d0325c20", @"/Views/Habitaciones/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e477828d436828b27ace6a953b47ba0c270e305e", @"/Views/_ViewImports.cshtml")]
    public class Views_Habitaciones_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoHotelNT1.Models.Registro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
  
    ViewData["Title"] = "Huespedes";

#line default
#line hidden
            BeginContext(101, 609, true);
            WriteLiteral(@"
<h2>Registro de huespedes</h2>


<table class=""table"">
    <thead>
        <tr>
            <th>
                Nombre
            </th>
            <th>
                Apellido
            </th>
            <th>
                DNI
            </th>
            <th>
                Nro. habitacion
            </th>
            <th>
                Fecha ingreso
            </th>
            <th>
                Fecha salida
            </th>
            <th>
                Dias hospedado
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 38 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(759, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(820, 41, false);
#line 42 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(861, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(929, 43, false);
#line 45 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
               Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(972, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1040, 38, false);
#line 48 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1146, 48, false);
#line 51 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumHabitacion));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1262, 47, false);
#line 54 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1377, 46, false);
#line 57 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaEgreso));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1491, 48, false);
#line 60 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiasHospedado));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 46, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Registro.cshtml"
        }

#line default
#line hidden
            BeginContext(1596, 29, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>");
            EndContext();
            BeginContext(1625, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e66a2f27c2704d07afc5dcb82e9a7a29", async() => {
                BeginContext(1647, 6, true);
                WriteLiteral("Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1657, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoHotelNT1.Models.Registro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
