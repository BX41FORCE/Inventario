#pragma checksum "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5998484366e24c31a4bd0bb535b93d11acde6c74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_INGRESOCOMPUTADORES_Index), @"mvc.1.0.view", @"/Views/INGRESOCOMPUTADORES/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/INGRESOCOMPUTADORES/Index.cshtml", typeof(AspNetCore.Views_INGRESOCOMPUTADORES_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5998484366e24c31a4bd0bb535b93d11acde6c74", @"/Views/INGRESOCOMPUTADORES/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f287a6a09c333a09cac0dfcadb99a72c109b8b66", @"/Views/_ViewImports.cshtml")]
    public class Views_INGRESOCOMPUTADORES_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ModuloInventario.Models.INGRESOCOMPUTADORES>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(108, 47, true);
            WriteLiteral("\r\n<h2>Ingreso de Computadores</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(155, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82a984f59aa849088f085ee5f6f961ad", async() => {
                BeginContext(178, 8, true);
                WriteLiteral("Ingresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(190, 170, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-responsive\" border=\"1\">\r\n    <thead  style=\"background-color:#3072AC; color:#ffffff;\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(361, 49, false);
#line 16 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(410, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(466, 53, false);
#line 19 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CUADADDEUBICACION));

#line default
#line hidden
            EndContext();
            BeginContext(519, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(575, 40, false);
#line 22 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ITEM));

#line default
#line hidden
            EndContext();
            BeginContext(615, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(671, 47, false);
#line 25 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DESCRIPCION));

#line default
#line hidden
            EndContext();
            BeginContext(718, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(774, 46, false);
#line 28 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MEMORIARAM));

#line default
#line hidden
            EndContext();
            BeginContext(820, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(876, 46, false);
#line 31 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PROCESADOR));

#line default
#line hidden
            EndContext();
            BeginContext(922, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(978, 45, false);
#line 34 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DISCODURO));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1079, 52, false);
#line 37 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SISTEMAOPERATIVO));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1187, 46, false);
#line 40 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LICENCIADO));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1289, 42, false);
#line 43 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OFFICE));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1387, 41, false);
#line 46 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MARCA));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1484, 42, false);
#line 49 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MODELO));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1582, 41, false);
#line 52 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SERIE));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1679, 50, false);
#line 55 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PARTICULARIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1785, 42, false);
#line 58 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(1827, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1883, 47, false);
#line 61 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NODEFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1986, 48, false);
#line 64 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VALORFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(2034, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2090, 52, false);
#line 67 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FECHAADQUISICION));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2198, 49, false);
#line 70 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OBSERVACIONES));

#line default
#line hidden
            EndContext();
            BeginContext(2247, 120, true);
            WriteLiteral("\r\n            </th>\r\n            <th>..............Opciones............</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 76 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2399, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2448, 48, false);
#line 79 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CODIGOINTERNO));

#line default
#line hidden
            EndContext();
            BeginContext(2496, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2552, 52, false);
#line 82 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CUADADDEUBICACION));

#line default
#line hidden
            EndContext();
            BeginContext(2604, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2660, 39, false);
#line 85 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ITEM));

#line default
#line hidden
            EndContext();
            BeginContext(2699, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2755, 46, false);
#line 88 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DESCRIPCION));

#line default
#line hidden
            EndContext();
            BeginContext(2801, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2857, 45, false);
#line 91 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MEMORIARAM));

#line default
#line hidden
            EndContext();
            BeginContext(2902, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2958, 45, false);
#line 94 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PROCESADOR));

#line default
#line hidden
            EndContext();
            BeginContext(3003, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3059, 44, false);
#line 97 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DISCODURO));

#line default
#line hidden
            EndContext();
            BeginContext(3103, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3159, 51, false);
#line 100 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SISTEMAOPERATIVO));

#line default
#line hidden
            EndContext();
            BeginContext(3210, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3266, 45, false);
#line 103 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LICENCIADO));

#line default
#line hidden
            EndContext();
            BeginContext(3311, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3367, 41, false);
#line 106 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OFFICE));

#line default
#line hidden
            EndContext();
            BeginContext(3408, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3464, 40, false);
#line 109 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MARCA));

#line default
#line hidden
            EndContext();
            BeginContext(3504, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3560, 41, false);
#line 112 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MODELO));

#line default
#line hidden
            EndContext();
            BeginContext(3601, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3657, 40, false);
#line 115 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SERIE));

#line default
#line hidden
            EndContext();
            BeginContext(3697, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3753, 49, false);
#line 118 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PARTICULARIDAD));

#line default
#line hidden
            EndContext();
            BeginContext(3802, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3858, 41, false);
#line 121 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ESTADO));

#line default
#line hidden
            EndContext();
            BeginContext(3899, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3955, 46, false);
#line 124 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NODEFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(4001, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4057, 47, false);
#line 127 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VALORFACTURA));

#line default
#line hidden
            EndContext();
            BeginContext(4104, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4160, 51, false);
#line 130 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FECHAADQUISICION));

#line default
#line hidden
            EndContext();
            BeginContext(4211, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4267, 48, false);
#line 133 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OBSERVACIONES));

#line default
#line hidden
            EndContext();
            BeginContext(4315, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4370, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129932178bb74b27bcfd73c8f7bafdbd", async() => {
                BeginContext(4423, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 136 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
                                       WriteLiteral(item.SECUENCIAL);

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
            BeginContext(4433, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4453, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa498a281e5f4429a0f65c284a587336", async() => {
                BeginContext(4509, 7, true);
                WriteLiteral("Detalle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 137 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
                                          WriteLiteral(item.SECUENCIAL);

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
            BeginContext(4520, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4540, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e8b9f3ab1142cbbb1f776e1c8179eb", async() => {
                BeginContext(4595, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 138 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
                                         WriteLiteral(item.SECUENCIAL);

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
            BeginContext(4607, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 141 "C:\Users\bryan\OneDrive\Escritorio\Inventario\ModuloInventario\ModuloInventario\Views\INGRESOCOMPUTADORES\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4646, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ModuloInventario.Models.INGRESOCOMPUTADORES>> Html { get; private set; }
    }
}
#pragma warning restore 1591
