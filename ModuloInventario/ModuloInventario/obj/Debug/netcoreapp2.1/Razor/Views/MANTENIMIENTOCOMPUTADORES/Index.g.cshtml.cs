#pragma checksum "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a82ef68004d4e2d46041c935ced7e08a5b6c7c36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MANTENIMIENTOCOMPUTADORES_Index), @"mvc.1.0.view", @"/Views/MANTENIMIENTOCOMPUTADORES/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MANTENIMIENTOCOMPUTADORES/Index.cshtml", typeof(AspNetCore.Views_MANTENIMIENTOCOMPUTADORES_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a82ef68004d4e2d46041c935ced7e08a5b6c7c36", @"/Views/MANTENIMIENTOCOMPUTADORES/Index.cshtml")]
    public class Views_MANTENIMIENTOCOMPUTADORES_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ModuloInventario.DBContext.MANTENIMIENTOCOMPUTADORES>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/ASIGNACIONCOMPUTADORES/Index.cshtml";

#line default
#line hidden
            BeginContext(178, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(337, 40, false);
#line 17 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(377, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(433, 53, false);
#line 20 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SECUANCIALPERSONA));

#line default
#line hidden
            EndContext();
            BeginContext(486, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(542, 65, false);
#line 23 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SECUANCIALINGRESOCOMPUTADORES));

#line default
#line hidden
            EndContext();
            BeginContext(607, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(725, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(774, 39, false);
#line 32 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(813, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(869, 52, false);
#line 35 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SECUANCIALPERSONA));

#line default
#line hidden
            EndContext();
            BeginContext(921, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(977, 64, false);
#line 38 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SECUANCIALINGRESOCOMPUTADORES));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1116, "\"", 1147, 1);
#line 41 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
WriteAttributeValue("", 1131, item.SECUENCIAL, 1131, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1148, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1200, "\"", 1231, 1);
#line 42 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
WriteAttributeValue("", 1215, item.SECUENCIAL, 1215, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1232, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1286, "\"", 1317, 1);
#line 43 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
WriteAttributeValue("", 1301, item.SECUENCIAL, 1301, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1318, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1368, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ModuloInventario.DBContext.MANTENIMIENTOCOMPUTADORES>> Html { get; private set; }
    }
}
#pragma warning restore 1591
