#pragma checksum "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95a0109c1bdd11f401c5fa1230a8e7b9220f9081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registroes_Delete), @"mvc.1.0.view", @"/Views/Registroes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registroes/Delete.cshtml", typeof(AspNetCore.Views_Registroes_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a0109c1bdd11f401c5fa1230a8e7b9220f9081", @"/Views/Registroes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e477828d436828b27ace6a953b47ba0c270e305e", @"/Views/_ViewImports.cshtml")]
    public class Views_Registroes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoHotelNT1.Models.Registro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml"
  
    ViewData["Title"] = "Eliminar";

#line default
#line hidden
            BeginContext(87, 200, true);
            WriteLiteral("\r\n<h2>Eliminar</h2>\r\n\r\n<h3>Seguro que desea eliminar este registro?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Nombre\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(288, 38, false);
#line 17 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(326, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Apellido\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(421, 40, false);
#line 23 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(461, 89, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            DNI\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(551, 35, false);
#line 29 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(586, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Nro. habitacion\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(688, 45, false);
#line 35 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumHabitacion));

#line default
#line hidden
            EndContext();
            BeginContext(733, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Fecha ingreso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(833, 44, false);
#line 41 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(877, 98, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Fecha egreso\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(976, 43, false);
#line 47 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaEgreso));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Dias hospedado\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1120, 45, false);
#line 53 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiasHospedado));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 47, true);
            WriteLiteral("\r\n        </dd>\r\n       \r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1212, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88fbcd192c44709b5ed2cbe5ad46013", async() => {
                BeginContext(1238, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1248, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c79dbc6f587b46a4b419525b5e77f7cf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Registroes\Delete.cshtml"
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
                BeginContext(1284, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1294, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1f9f253bf7c4806b1d9b23cc0b0aa81", async() => {
                    BeginContext(1316, 40, true);
                    WriteLiteral("<i class=\"fas fa-arrow-left\"></i> Volver");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1360, 84, true);
                WriteLiteral(" |\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-default\" />\r\n\r\n    ");
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
            BeginContext(1451, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoHotelNT1.Models.Registro> Html { get; private set; }
    }
}
#pragma warning restore 1591
