#pragma checksum "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bf6eaf4f42124d85494ad8ab2fb8f2fe8c0df90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_INGRESOVARIOS_Details), @"mvc.1.0.view", @"/Views/INGRESOVARIOS/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/INGRESOVARIOS/Details.cshtml", typeof(AspNetCore.Views_INGRESOVARIOS_Details))]
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
#line 1 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\_ViewImports.cshtml"
using ModuloInventario;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\_ViewImports.cshtml"
using ModuloInventario.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf6eaf4f42124d85494ad8ab2fb8f2fe8c0df90", @"/Views/INGRESOVARIOS/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f287a6a09c333a09cac0dfcadb99a72c109b8b66", @"/Views/_ViewImports.cshtml")]
    public class Views_INGRESOVARIOS_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModuloInventario.Models.INGRESOVARIOS>
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 127, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>INGRESOVARIOS</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(219, 49, false);
#line 14 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(312, 45, false);
#line 17 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(357, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(401, 53, false);
#line 20 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CUADADDEUBICACION));

#line default
#line hidden
            EndContext();
            BeginContext(454, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(498, 49, false);
#line 23 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.CUADADDEUBICACION));

#line default
#line hidden
            EndContext();
            BeginContext(547, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(591, 40, false);
#line 26 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ITEM));

#line default
#line hidden
            EndContext();
            BeginContext(631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(675, 36, false);
#line 29 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.ITEM));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 47, false);
#line 32 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DESCRIPCION));

#line default
#line hidden
            EndContext();
            BeginContext(802, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(846, 43, false);
#line 35 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.DESCRIPCION));

#line default
#line hidden
            EndContext();
            BeginContext(889, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(933, 41, false);
#line 38 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MARCA));

#line default
#line hidden
            EndContext();
            BeginContext(974, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1018, 37, false);
#line 41 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.MARCA));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1099, 42, false);
#line 44 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MODELO));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1185, 38, false);
#line 47 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.MODELO));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1267, 41, false);
#line 50 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SERIE));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1352, 37, false);
#line 53 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.SERIE));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1433, 50, false);
#line 56 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PARTICULARIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1527, 46, false);
#line 59 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.PARTICULARIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(1573, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1617, 42, false);
#line 62 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1703, 38, false);
#line 65 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1785, 47, false);
#line 68 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NODEFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1876, 43, false);
#line 71 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.NODEFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1963, 48, false);
#line 74 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VALORFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2055, 44, false);
#line 77 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.VALORFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2143, 52, false);
#line 80 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FECHAADQUISICION));

#line default
#line hidden
            EndContext();
            BeginContext(2195, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2239, 48, false);
#line 83 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.FECHAADQUISICION));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2331, 49, false);
#line 86 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OBSERVACIONES));

#line default
#line hidden
            EndContext();
            BeginContext(2380, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2424, 45, false);
#line 89 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.OBSERVACIONES));

#line default
#line hidden
            EndContext();
            BeginContext(2469, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2516, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dff246d4ec84d1b8ec887d757acb206", async() => {
                BeginContext(2570, 4, true);
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
#line 94 "C:\Users\Usuario\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOVARIOS\Details.cshtml"
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
            BeginContext(2578, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2586, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "461256554c3c4ae19f9dd6cc0383615b", async() => {
                BeginContext(2608, 12, true);
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
            BeginContext(2624, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModuloInventario.Models.INGRESOVARIOS> Html { get; private set; }
    }
}
#pragma warning restore 1591
