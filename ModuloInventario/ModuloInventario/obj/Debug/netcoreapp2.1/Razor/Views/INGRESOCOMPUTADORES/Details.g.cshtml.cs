#pragma checksum "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42600ae36890927279541beb0b7059324760c972"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42600ae36890927279541beb0b7059324760c972", @"/Views/INGRESOCOMPUTADORES/Details.cshtml")]
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
            BeginContext(97, 137, true);
            WriteLiteral("\r\n<h2>Detalle</h2>\r\n\r\n<div>\r\n    <h4>Ingreso de Computadores</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(235, 49, false);
#line 14 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(284, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(328, 45, false);
#line 17 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(417, 53, false);
#line 20 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CUADADDEUBICACION));

#line default
#line hidden
            EndContext();
            BeginContext(470, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(514, 49, false);
#line 23 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.CUADADDEUBICACION));

#line default
#line hidden
            EndContext();
            BeginContext(563, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(607, 50, false);
#line 26 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SECUENCIALITEM));

#line default
#line hidden
            EndContext();
            BeginContext(657, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(701, 46, false);
#line 29 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.SECUENCIALITEM));

#line default
#line hidden
            EndContext();
            BeginContext(747, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(791, 47, false);
#line 32 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DESCRIPCION));

#line default
#line hidden
            EndContext();
            BeginContext(838, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(882, 43, false);
#line 35 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.DESCRIPCION));

#line default
#line hidden
            EndContext();
            BeginContext(925, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(969, 46, false);
#line 38 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MEMORIARAM));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1059, 42, false);
#line 41 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.MEMORIARAM));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1145, 46, false);
#line 44 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PROCESADOR));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1235, 42, false);
#line 47 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.PROCESADOR));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1321, 45, false);
#line 50 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DISCODURO));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1410, 41, false);
#line 53 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.DISCODURO));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1495, 52, false);
#line 56 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SISTEMAOPERATIVO));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1591, 48, false);
#line 59 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.SISTEMAOPERATIVO));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1683, 46, false);
#line 62 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LICENCIADO));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1773, 42, false);
#line 65 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.LICENCIADO));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1859, 42, false);
#line 68 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OFFICE));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1945, 38, false);
#line 71 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.OFFICE));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2027, 41, false);
#line 74 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MARCA));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2112, 37, false);
#line 77 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.MARCA));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2193, 42, false);
#line 80 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MODELO));

#line default
#line hidden
            EndContext();
            BeginContext(2235, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2279, 38, false);
#line 83 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.MODELO));

#line default
#line hidden
            EndContext();
            BeginContext(2317, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2361, 41, false);
#line 86 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SERIE));

#line default
#line hidden
            EndContext();
            BeginContext(2402, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2446, 37, false);
#line 89 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.SERIE));

#line default
#line hidden
            EndContext();
            BeginContext(2483, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2527, 50, false);
#line 92 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PARTICULARIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(2577, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2621, 46, false);
#line 95 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.PARTICULARIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(2667, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2711, 42, false);
#line 98 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(2753, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2797, 38, false);
#line 101 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(2835, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2879, 47, false);
#line 104 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NODEFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(2926, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2970, 43, false);
#line 107 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.NODEFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(3013, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3057, 48, false);
#line 110 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VALORFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(3105, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3149, 44, false);
#line 113 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.VALORFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(3193, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3237, 52, false);
#line 116 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FECHAADQUISICION));

#line default
#line hidden
            EndContext();
            BeginContext(3289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3333, 48, false);
#line 119 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.FECHAADQUISICION));

#line default
#line hidden
            EndContext();
            BeginContext(3381, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3425, 49, false);
#line 122 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OBSERVACIONES));

#line default
#line hidden
            EndContext();
            BeginContext(3474, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3518, 45, false);
#line 125 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Details.cshtml"
       Write(Html.DisplayFor(model => model.OBSERVACIONES));

#line default
#line hidden
            EndContext();
            BeginContext(3563, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3610, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f992964ac17a4b829dc97026f9b87cd8", async() => {
                BeginContext(3664, 4, true);
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
            BeginContext(3672, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3680, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac27eaf313b24dde98eaf5b376159557", async() => {
                BeginContext(3702, 12, true);
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
            BeginContext(3718, 10, true);
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