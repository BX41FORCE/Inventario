#pragma checksum "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSVARIOS\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a1aba6b6e16e5a40eac8412879b118f26f3293b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BAJADEEQUIPOSVARIOS_Create), @"mvc.1.0.view", @"/Views/BAJADEEQUIPOSVARIOS/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BAJADEEQUIPOSVARIOS/Create.cshtml", typeof(AspNetCore.Views_BAJADEEQUIPOSVARIOS_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a1aba6b6e16e5a40eac8412879b118f26f3293b", @"/Views/BAJADEEQUIPOSVARIOS/Create.cshtml")]
    public class Views_BAJADEEQUIPOSVARIOS_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModuloInventario.DBContext.BAJADEEQUIPOSVARIOS>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSVARIOS\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/ASIGNACIONCOMPUTADORES/Index.cshtml";

#line default
#line hidden
            BeginContext(160, 1360, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>BAJADEEQUIPOSVARIOS</h4>
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
                <label asp-for=""SECUANCIALINGRESOVARIOS"" class=""control-label""></label>
                <input asp-for=""SECUANCIALINGRESOVARIOS"" class=""form-control"" />
                <s");
            WriteLiteral(@"pan asp-validation-for=""SECUANCIALINGRESOVARIOS"" class=""text-danger""></span>
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
                BeginContext(1538, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\BAJADEEQUIPOSVARIOS\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModuloInventario.DBContext.BAJADEEQUIPOSVARIOS> Html { get; private set; }
    }
}
#pragma warning restore 1591
