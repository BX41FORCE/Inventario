#pragma checksum "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\ITEMs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4346b07e93c55f39bce1f7ba04844b4f16e21ccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ITEMs_Details), @"mvc.1.0.view", @"/Views/ITEMs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ITEMs/Details.cshtml", typeof(AspNetCore.Views_ITEMs_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4346b07e93c55f39bce1f7ba04844b4f16e21ccd", @"/Views/ITEMs/Details.cshtml")]
    public class Views_ITEMs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModuloInventario.DBContext.ITEM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\ITEMs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/ASIGNACIONCOMPUTADORES/Index.cshtml";

#line default
#line hidden
            BeginContext(146, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>ITEM</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(265, 42, false);
#line 15 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\ITEMs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CODIGO));

#line default
#line hidden
            EndContext();
            BeginContext(307, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(351, 38, false);
#line 18 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\ITEMs\Details.cshtml"
       Write(Html.DisplayFor(model => model.CODIGO));

#line default
#line hidden
            EndContext();
            BeginContext(389, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(433, 44, false);
#line 21 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\ITEMs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TIPOITEM));

#line default
#line hidden
            EndContext();
            BeginContext(477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(521, 40, false);
#line 24 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\ITEMs\Details.cshtml"
       Write(Html.DisplayFor(model => model.TIPOITEM));

#line default
#line hidden
            EndContext();
            BeginContext(561, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(605, 49, false);
#line 27 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\ITEMs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CATEGORIAITEM));

#line default
#line hidden
            EndContext();
            BeginContext(654, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(698, 45, false);
#line 30 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\ITEMs\Details.cshtml"
       Write(Html.DisplayFor(model => model.CATEGORIAITEM));

#line default
#line hidden
            EndContext();
            BeginContext(743, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 810, "\"", 842, 1);
#line 35 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\ITEMs\Details.cshtml"
WriteAttributeValue("", 825, Model.SECUENCIAL, 825, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(843, 65, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModuloInventario.DBContext.ITEM> Html { get; private set; }
    }
}
#pragma warning restore 1591
