#pragma checksum "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Alerta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ac1080eca461c10c7ce8a112bef6366a66a8cab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Habitaciones_Alerta), @"mvc.1.0.view", @"/Views/Habitaciones/Alerta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Habitaciones/Alerta.cshtml", typeof(AspNetCore.Views_Habitaciones_Alerta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac1080eca461c10c7ce8a112bef6366a66a8cab", @"/Views/Habitaciones/Alerta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e477828d436828b27ace6a953b47ba0c270e305e", @"/Views/_ViewImports.cshtml")]
    public class Views_Habitaciones_Alerta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Alerta.cshtml"
 if (ViewBag.miCodigoScript != null)
{

#line default
#line hidden
            BeginContext(41, 22, true);
            WriteLiteral("    <script>\r\n        ");
            EndContext();
            BeginContext(64, 32, false);
#line 4 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Alerta.cshtml"
   Write(Html.Raw(ViewBag.miCodigoScript));

#line default
#line hidden
            EndContext();
            BeginContext(96, 49, true);
            WriteLiteral("\r\n        window.history.back();\r\n    </script>\r\n");
            EndContext();
#line 7 "C:\Users\ema_a\Source\Repos\proyecto-final-NT1\Views\Habitaciones\Alerta.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591