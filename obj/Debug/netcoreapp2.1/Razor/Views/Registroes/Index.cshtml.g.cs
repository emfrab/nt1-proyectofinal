#pragma checksum "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "839b4a96973fcfd693b8f39e937ebff91b713cf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registroes_Index), @"mvc.1.0.view", @"/Views/Registroes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registroes/Index.cshtml", typeof(AspNetCore.Views_Registroes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839b4a96973fcfd693b8f39e937ebff91b713cf2", @"/Views/Registroes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e477828d436828b27ace6a953b47ba0c270e305e", @"/Views/_ViewImports.cshtml")]
    public class Views_Registroes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoHotelNT1.Models.Registro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
  
    ViewData["Title"] = "Registro";

#line default
#line hidden
            BeginContext(100, 180, true);
            WriteLiteral("\r\n<h2 class=\"titulo\">Registro de huespedes</h2>\r\n\r\n<div class=\"informacion\">\r\n    <div class=\"itemInfo\">\r\n        <h4> <i class=\"fas fa-arrow-right\"></i> Total huespedes alojados: ");
            EndContext();
            BeginContext(281, 15, false);
#line 11 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
                                                                     Write(ViewBag.totales);

#line default
#line hidden
            EndContext();
            BeginContext(296, 724, true);
            WriteLiteral(@" </h4>
    </div>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>
                <strong>Nro. habitacion</strong>
            </th>
            <th>
                <strong>Nombre</strong>
            </th>
            <th>
                <strong>Apellido</strong>
            </th>
            <th>
                <strong> DNI</strong>
            </th>
            <th>
                <strong>Fecha ingreso</strong>
            </th>
            <th>
                <strong> Fecha salida</strong>
            </th>
            <th>
                <strong>Dias hospedado</strong>
            </th>

            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 44 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1069, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1130, 48, false);
#line 48 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumHabitacion));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1246, 41, false);
#line 51 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1355, 43, false);
#line 54 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1466, 38, false);
#line 57 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1572, 47, false);
#line 60 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1687, 46, false);
#line 63 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaEgreso));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1801, 48, false);
#line 66 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiasHospedado));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 74, true);
            WriteLiteral(" Dias\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1923, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f54788cd67dc48c883f4298a0749057f", async() => {
                BeginContext(1970, 41, true);
                WriteLiteral("<i class=\"far fa-trash-alt\"></i> Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2015, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 73 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2070, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
