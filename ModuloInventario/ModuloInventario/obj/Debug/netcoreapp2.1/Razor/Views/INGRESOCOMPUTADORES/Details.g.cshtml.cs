#pragma checksum "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc67858d962b66910e86c530bb6f6074d7cda1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_INGRESOCOMPUTADORES_Details), @"mvc.1.0.view", @"/Views/INGRESOCOMPUTADORES/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/INGRESOCOMPUTADORES/Details.cshtml", typeof(AspNetCore.Views_INGRESOCOMPUTADORES_Details))]
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
#line 1 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\_ViewImports.cshtml"
using ModuloInventario;

#line default
#line hidden
#line 2 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\_ViewImports.cshtml"
using ModuloInventario.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc67858d962b66910e86c530bb6f6074d7cda1a", @"/Views/INGRESOCOMPUTADORES/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f287a6a09c333a09cac0dfcadb99a72c109b8b66", @"/Views/_ViewImports.cshtml")]
    public class Views_INGRESOCOMPUTADORES_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModuloInventario.Models.INGRESOCOMPUTADORES>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 133, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>INGRESOCOMPUTADORES</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(231, 49, false);
#line 14 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(280, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(324, 45, false);
#line 17 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(369, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(413, 53, false);
#line 20 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CUADADDEUBICACION));

#line default
#line hidden
            EndContext();
            BeginContext(466, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(510, 49, false);
#line 23 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.CUADADDEUBICACION));

#line default
#line hidden
            EndContext();
            BeginContext(559, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(603, 50, false);
#line 26 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SECUENCIALITEM));

#line default
#line hidden
            EndContext();
            BeginContext(653, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(697, 46, false);
#line 29 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.SECUENCIALITEM));

#line default
#line hidden
            EndContext();
            BeginContext(743, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(787, 47, false);
#line 32 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DESCRIPCION));

#line default
#line hidden
            EndContext();
            BeginContext(834, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(878, 43, false);
#line 35 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.DESCRIPCION));

#line default
#line hidden
            EndContext();
            BeginContext(921, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(965, 46, false);
#line 38 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MEMORIARAM));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1055, 42, false);
#line 41 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.MEMORIARAM));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1141, 46, false);
#line 44 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PROCESADOR));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1231, 42, false);
#line 47 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.PROCESADOR));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1317, 45, false);
#line 50 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DISCODURO));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1406, 41, false);
#line 53 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.DISCODURO));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1491, 52, false);
#line 56 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SISTEMAOPERATIVO));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1587, 48, false);
#line 59 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.SISTEMAOPERATIVO));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1679, 46, false);
#line 62 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LICENCIADO));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1769, 42, false);
#line 65 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.LICENCIADO));

#line default
#line hidden
            EndContext();
            BeginContext(1811, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1855, 42, false);
#line 68 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OFFICE));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1941, 38, false);
#line 71 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.OFFICE));

#line default
#line hidden
            EndContext();
            BeginContext(1979, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2023, 41, false);
#line 74 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MARCA));

#line default
#line hidden
            EndContext();
            BeginContext(2064, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2108, 37, false);
#line 77 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.MARCA));

#line default
#line hidden
            EndContext();
            BeginContext(2145, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2189, 42, false);
#line 80 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MODELO));

#line default
#line hidden
            EndContext();
            BeginContext(2231, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2275, 38, false);
#line 83 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.MODELO));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2357, 41, false);
#line 86 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SERIE));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2442, 37, false);
#line 89 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.SERIE));

#line default
#line hidden
            EndContext();
            BeginContext(2479, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2523, 50, false);
#line 92 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PARTICULARIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(2573, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2617, 46, false);
#line 95 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.PARTICULARIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(2663, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2707, 42, false);
#line 98 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(2749, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2793, 38, false);
#line 101 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(2831, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2875, 47, false);
#line 104 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NODEFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(2922, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2966, 43, false);
#line 107 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.NODEFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(3009, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3053, 48, false);
#line 110 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VALORFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(3101, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3145, 44, false);
#line 113 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.VALORFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(3189, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3233, 52, false);
#line 116 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FECHAADQUISICION));

#line default
#line hidden
            EndContext();
            BeginContext(3285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3329, 48, false);
#line 119 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.FECHAADQUISICION));

#line default
#line hidden
            EndContext();
            BeginContext(3377, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3421, 49, false);
#line 122 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OBSERVACIONES));

#line default
#line hidden
            EndContext();
            BeginContext(3470, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3514, 45, false);
#line 125 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.OBSERVACIONES));

#line default
#line hidden
            EndContext();
            BeginContext(3559, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3606, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e61b8e3fd4b04b55b01eba9a3ce869de", async() => {
                BeginContext(3660, 4, true);
                WriteLiteral("Edit");
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
#line 130 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
                           WriteLiteral(Model.SECUENCIAL);

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
            BeginContext(3668, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3676, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82351470448a46ef918915991d6fc7f3", async() => {
                BeginContext(3698, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(3714, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModuloInventario.Models.INGRESOCOMPUTADORES> Html { get; private set; }
    }
}
#pragma warning restore 1591
