#pragma checksum "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b59deea3a55a4bcfbf40b53ad8360e7552ea8a24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SOLICITUD_Details), @"mvc.1.0.view", @"/Views/SOLICITUD/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SOLICITUD/Details.cshtml", typeof(AspNetCore.Views_SOLICITUD_Details))]
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
#line 1 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\_ViewImports.cshtml"
using ModuloInventario;

#line default
#line hidden
#line 2 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\_ViewImports.cshtml"
using ModuloInventario.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b59deea3a55a4bcfbf40b53ad8360e7552ea8a24", @"/Views/SOLICITUD/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f287a6a09c333a09cac0dfcadb99a72c109b8b66", @"/Views/_ViewImports.cshtml")]
    public class Views_SOLICITUD_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModuloInventario.Models.SOLICITUD>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>SOLICITUD</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(211, 53, false);
#line 14 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SECUENCIALPERSONA));

#line default
#line hidden
            EndContext();
            BeginContext(264, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(308, 49, false);
#line 17 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayFor(model => model.SECUENCIALPERSONA));

#line default
#line hidden
            EndContext();
            BeginContext(357, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(401, 42, false);
#line 20 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TIEMPO));

#line default
#line hidden
            EndContext();
            BeginContext(443, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(487, 38, false);
#line 23 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayFor(model => model.TIEMPO));

#line default
#line hidden
            EndContext();
            BeginContext(525, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(569, 40, false);
#line 26 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(609, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(653, 36, false);
#line 29 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayFor(model => model.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(689, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(733, 48, false);
#line 32 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TIEMPOINICIO));

#line default
#line hidden
            EndContext();
            BeginContext(781, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(825, 44, false);
#line 35 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayFor(model => model.TIEMPOINICIO));

#line default
#line hidden
            EndContext();
            BeginContext(869, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(913, 45, false);
#line 38 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TIEMPOFIN));

#line default
#line hidden
            EndContext();
            BeginContext(958, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1002, 41, false);
#line 41 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayFor(model => model.TIEMPOFIN));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1087, 43, false);
#line 44 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DETALLE));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1174, 39, false);
#line 47 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayFor(model => model.DETALLE));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1257, 42, false);
#line 50 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1343, 38, false);
#line 53 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
       Write(Html.DisplayFor(model => model.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1428, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "170f9904b1e14061a39a47087825573a", async() => {
                BeginContext(1482, 4, true);
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
#line 58 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\SOLICITUD\Details.cshtml"
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
            BeginContext(1490, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1498, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e252c1e61f342f1a12f0aee77ad58b6", async() => {
                BeginContext(1520, 12, true);
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
            BeginContext(1536, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModuloInventario.Models.SOLICITUD> Html { get; private set; }
    }
}
#pragma warning restore 1591
