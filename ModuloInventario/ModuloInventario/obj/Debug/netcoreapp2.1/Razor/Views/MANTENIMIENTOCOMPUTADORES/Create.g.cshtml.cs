#pragma checksum "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a37730daa0066ac0538e4720a2e7386106d3c18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MANTENIMIENTOCOMPUTADORES_Create), @"mvc.1.0.view", @"/Views/MANTENIMIENTOCOMPUTADORES/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MANTENIMIENTOCOMPUTADORES/Create.cshtml", typeof(AspNetCore.Views_MANTENIMIENTOCOMPUTADORES_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a37730daa0066ac0538e4720a2e7386106d3c18", @"/Views/MANTENIMIENTOCOMPUTADORES/Create.cshtml")]
    public class Views_MANTENIMIENTOCOMPUTADORES_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModuloInventario.DBContext.MANTENIMIENTOCOMPUTADORES>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/ASIGNACIONCOMPUTADORES/Index.cshtml";

#line default
#line hidden
            BeginContext(166, 1384, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>MANTENIMIENTOCOMPUTADORES</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""TIPO"" class=""control-label""></label>
                <input asp-for=""TIPO"" class=""form-control"" />
                <span asp-validation-for=""TIPO"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SECUANCIALPERSONA"" class=""control-label""></label>
                <input asp-for=""SECUANCIALPERSONA"" class=""form-control"" />
                <span asp-validation-for=""SECUANCIALPERSONA"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SECUANCIALINGRESOCOMPUTADORES"" class=""control-label""></label>
                <input asp-for=""SECUANCIALINGRESOCOMPUTADORES"" class=""form-control"" />
");
            WriteLiteral(@"                <span asp-validation-for=""SECUANCIALINGRESOCOMPUTADORES"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1568, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\MANTENIMIENTOCOMPUTADORES\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModuloInventario.DBContext.MANTENIMIENTOCOMPUTADORES> Html { get; private set; }
    }
}
#pragma warning restore 1591
