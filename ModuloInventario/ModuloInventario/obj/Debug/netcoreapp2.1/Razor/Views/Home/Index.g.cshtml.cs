#pragma checksum "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756aac00673438230190ecbf24f8a899961d27dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756aac00673438230190ecbf24f8a899961d27dc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f287a6a09c333a09cac0dfcadb99a72c109b8b66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Usuario\Desktop\SifizsoftInventario\ModuloInventario\ModuloInventario\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 5225, true);
            WriteLiteral(@"
<p></p>


<div class=""container"">
    <div class=""row bg"">
        <div class=""col-sm-6"">
            <div class=""card border-light"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-2"">
                            <i class=""fas fa-desktop fa-3x"" style=""color:#3072AC;""></i>
                        </div>
                        <div class=""col"">
                            <h3 class=""card-title"" style=""color:#3072AC;"">Administracion de Equipos</h3>
                        </div>
                    </div>
                    <p></p>
                    <a href=""ingresoDeEquipos.html"" class=""btn btn-primary btn-md btn-block"">Ingresar</a>
                </div>
            </div>
        </div>
        <div class=""col-sm-6"">
            <div class=""card border-light"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-2"">
                      ");
            WriteLiteral(@"      <i class=""fas fa-users fa-3x"" style=""color:#3072AC;""></i>
                        </div>
                        <div class=""col"">
                            <h3 class=""card-title"" style=""color:#3072AC;""> Asignación de Equipo</h3>
                        </div>
                    </div>
                    <p></p>
                    <a href=""asignacionDeEquipos.html"" class=""btn btn-primary btn-md btn-block"">Asignar</a>
                </div>
            </div>
        </div>
    </div>
    <p></p>
    <div class=""row"">
        <div class=""col-sm-6"">
            <div class=""card border-light"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-2"">
                            <i class=""fas fa-times-circle fa-3x"" style=""color:#3072AC;""></i>
                        </div>
                        <div class=""col"">
                            <h3 class=""card-title"" style=""color:#3072AC;""> Baja de Equipos</h3>
     ");
            WriteLiteral(@"                   </div>
                    </div>
                    <p></p>
                    <a href=""bajaEquipo.html"" class=""btn btn-primary btn-md btn-block"">Dar de Baja</a>
                </div>
            </div>
        </div>
        <div class=""col-sm-6"">
            <div class=""card border-light"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-2"">
                            <i class=""fas fa-toolbox fa-3x"" style=""color:#3072AC;""></i>
                        </div>
                        <div class=""col"">
                            <h3 class=""card-title"" style=""color:#3072AC;""> Mantenimiento</h3>
                        </div>
                    </div>
                    <p></p>
                    <a href=""mantenimiento.html"" class=""btn btn-primary btn-md btn-block"">Ingresar</a>
                </div>
            </div>
        </div>
    </div>
    <p></p>
    <div class=""row"">
        <di");
            WriteLiteral(@"v class=""col-sm-6"">
            <div class=""card border-light"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-2"">
                            <i class=""fas fa-chart-pie fa-3x"" style=""color:#3072AC;""></i>
                        </div>
                        <div class=""col"">
                            <h3 class=""card-title"" style=""color:#3072AC;""> Disponibilidad</h3>
                        </div>
                    </div>
                    <p></p>
                    <a href=""disponibilidad.html"" class=""btn btn-primary btn-md btn-block"">Consultar</a>
                </div>
            </div>
        </div>
        <div class=""col-sm-6"">
            <div class=""card border-light"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-2"">
                            <i class=""fas fa-building fa-3x"" style=""color:#3072AC;""></i>
                  ");
            WriteLiteral(@"      </div>
                        <div class=""col"">
                            <h3 class=""card-title"" style=""color:#3072AC;""> Áreas</h3>
                        </div>
                    </div>
                    <p></p>
                    <a href=""area.html"" class=""btn btn-primary btn-md btn-block"">Revisar</a>
                </div>
            </div>
        </div>
        <p></p>
        <div class=""col-sm-6"">
            <div class=""card border-light"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-2"">
                            <i class=""fas fa-table fa-3x"" style=""color:#3072AC;""></i>
                        </div>
                        <div class=""col"">
                            <h3 class=""card-title"" style=""color:#3072AC;""> Catálogo</h3>
                        </div>
                    </div>
                    <p></p>
                    <a href=""catalogo.html"" class=""btn btn-primary btn-md ");
            WriteLiteral("btn-block\">Ingresar</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
