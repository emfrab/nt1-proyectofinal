#pragma checksum "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Liberar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd81890c97e3735c997cd8db1a22c03dd7bc8d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Habitaciones_Liberar), @"mvc.1.0.view", @"/Views/Habitaciones/Liberar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Habitaciones/Liberar.cshtml", typeof(AspNetCore.Views_Habitaciones_Liberar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd81890c97e3735c997cd8db1a22c03dd7bc8d78", @"/Views/Habitaciones/Liberar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e477828d436828b27ace6a953b47ba0c270e305e", @"/Views/_ViewImports.cshtml")]
    public class Views_Habitaciones_Liberar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoHotelNT1.Models.Habitaciones>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Liberar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Liberar.cshtml"
  
    ViewData["Title"] = "Liberar";

#line default
#line hidden
            BeginContext(90, 123, true);
            WriteLiteral("\r\n<h2>Liberar habitacion</h2>\r\n\r\n<h3>Esta seguro que quiere liberar la habitacion?</h3>\r\n<div>\r\n    <h4>Habitacion <b>Nro. ");
            EndContext();
            BeginContext(214, 45, false);
#line 11 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Liberar.cshtml"
                      Write(Html.DisplayFor(model => model.NumHabitacion));

#line default
#line hidden
            EndContext();
            BeginContext(259, 140, true);
            WriteLiteral("</b> </h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Nro. habitacion\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(400, 45, false);
#line 18 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Liberar.cshtml"
       Write(Html.DisplayFor(model => model.NumHabitacion));

#line default
#line hidden
            EndContext();
            BeginContext(445, 98, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Esta ocupada\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(544, 43, false);
#line 24 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Liberar.cshtml"
       Write(Html.DisplayFor(model => model.EstaOcupada));

#line default
#line hidden
            EndContext();
            BeginContext(587, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Precio por dia\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(688, 44, false);
#line 30 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Liberar.cshtml"
       Write(Html.DisplayFor(model => model.PrecioPorDia));

#line default
#line hidden
            EndContext();
            BeginContext(732, 102, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Capacidad maxima\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(835, 44, false);
#line 36 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Liberar.cshtml"
       Write(Html.DisplayFor(model => model.CapacidadMax));

#line default
#line hidden
            EndContext();
            BeginContext(879, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(913, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8011ffacb544da4b1f4134770fcc783", async() => {
                BeginContext(940, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(950, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72a4a4be3a734e389ff19e7e68f1a2e1", async() => {
                    BeginContext(972, 6, true);
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
                BeginContext(982, 12, true);
                WriteLiteral(" |\r\n        ");
                EndContext();
                BeginContext(994, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f02bb15635a40f4b73a5ced51d45a36", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 42 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Liberar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1030, 79, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Liberar\" class=\"btn btn-default\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1116, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoHotelNT1.Models.Habitaciones> Html { get; private set; }
    }
}
#pragma warning restore 1591
