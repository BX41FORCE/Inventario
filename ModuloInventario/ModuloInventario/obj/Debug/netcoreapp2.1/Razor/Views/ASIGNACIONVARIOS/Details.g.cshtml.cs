#pragma checksum "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da9c206083fee23a70bb4eee2bf2a74738ad589e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ASIGNACIONVARIOS_Details), @"mvc.1.0.view", @"/Views/ASIGNACIONVARIOS/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ASIGNACIONVARIOS/Details.cshtml", typeof(AspNetCore.Views_ASIGNACIONVARIOS_Details))]
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
#line 1 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\_ViewImports.cshtml"
using ModuloInventario;

#line default
#line hidden
#line 2 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\_ViewImports.cshtml"
using ModuloInventario.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9c206083fee23a70bb4eee2bf2a74738ad589e", @"/Views/ASIGNACIONVARIOS/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f287a6a09c333a09cac0dfcadb99a72c109b8b66", @"/Views/_ViewImports.cshtml")]
    public class Views_ASIGNACIONVARIOS_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModuloInventario.Models.ASIGNACIONVARIOS>
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(94, 199, true);
            WriteLiteral("\r\n<h2 class=\"text-center\" style=\"background-color:#3072AC; color:#ffffff;\">Detalle</h2>\r\n\r\n<div>\r\n    <h4>ASIGNACIONVARIOS</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(294, 47, false);
#line 14 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RESPONSABLE));

#line default
#line hidden
            EndContext();
            BeginContext(341, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(385, 43, false);
#line 17 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.RESPONSABLE));

#line default
#line hidden
            EndContext();
            BeginContext(428, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(472, 49, false);
#line 20 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(521, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(565, 45, false);
#line 23 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(610, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(654, 48, false);
#line 26 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TIEMPOINICIO));

#line default
#line hidden
            EndContext();
            BeginContext(702, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(746, 44, false);
#line 29 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.TIEMPOINICIO));

#line default
#line hidden
            EndContext();
            BeginContext(790, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(834, 45, false);
#line 32 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TIEMPOFIN));

#line default
#line hidden
            EndContext();
            BeginContext(879, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(923, 41, false);
#line 35 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.TIEMPOFIN));

#line default
#line hidden
            EndContext();
            BeginContext(964, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1011, 64, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e0fbf891964493bac1ec904764b08c", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29debcd5ec814fce9aadf1fee1ce6061", async() => {
>>>>>>> e7c5613bfb83ad7b48c48ac6dae04883bc6b1014
                BeginContext(1065, 6, true);
                WriteLiteral("Editar");
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
#line 40 "C:\Users\Administrador\Desktop\Inventario\ModuloInventario\ModuloInventario\Views\ASIGNACIONVARIOS\Details.cshtml"
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
            BeginContext(1075, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1083, 32, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f7e06bdeb34b63b7a83beb77fe950f", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75ae7e9225b04aa19b8b5556a277e34c", async() => {
>>>>>>> e7c5613bfb83ad7b48c48ac6dae04883bc6b1014
                BeginContext(1105, 6, true);
                WriteLiteral("Volver");
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
            BeginContext(1115, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModuloInventario.Models.ASIGNACIONVARIOS> Html { get; private set; }
    }
}
#pragma warning restore 1591
