#pragma checksum "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSCOMPUTADORES\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19606f7b4193e13da3996f7df85f16108bd2638a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BAJADEEQUIPOSCOMPUTADORES_Details), @"mvc.1.0.view", @"/Views/BAJADEEQUIPOSCOMPUTADORES/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BAJADEEQUIPOSCOMPUTADORES/Details.cshtml", typeof(AspNetCore.Views_BAJADEEQUIPOSCOMPUTADORES_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19606f7b4193e13da3996f7df85f16108bd2638a", @"/Views/BAJADEEQUIPOSCOMPUTADORES/Details.cshtml")]
    public class Views_BAJADEEQUIPOSCOMPUTADORES_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModuloInventario.DBContext.BAJADEEQUIPOSCOMPUTADORES>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSCOMPUTADORES\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/ASIGNACIONCOMPUTADORES/Index.cshtml";

#line default
#line hidden
            BeginContext(167, 139, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>BAJADEEQUIPOSCOMPUTADORES</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(307, 40, false);
#line 15 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(347, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(391, 36, false);
#line 18 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(427, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(471, 53, false);
#line 21 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SECUANCIALPERSONA));

#line default
#line hidden
            EndContext();
            BeginContext(524, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(568, 49, false);
#line 24 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.SECUANCIALPERSONA));

#line default
#line hidden
            EndContext();
            BeginContext(617, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(661, 65, false);
#line 27 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SECUANCIALINGRESOCOMPUTADORES));

#line default
#line hidden
            EndContext();
            BeginContext(726, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(770, 61, false);
#line 30 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.SECUANCIALINGRESOCOMPUTADORES));

#line default
#line hidden
            EndContext();
            BeginContext(831, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 898, "\"", 930, 1);
#line 35 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSCOMPUTADORES\Details.cshtml"
WriteAttributeValue("", 913, Model.SECUENCIAL, 913, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(931, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModuloInventario.DBContext.BAJADEEQUIPOSCOMPUTADORES> Html { get; private set; }
    }
}
#pragma warning restore 1591
