#pragma checksum "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be82a233102eab29208fc9be0b2695c23fabb78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be82a233102eab29208fc9be0b2695c23fabb78", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Informacion de Escuela";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Escuela:</h1>\r\n<h2>Nombre: ");
#nullable restore
#line 9 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>Tipo de Escuela: ");
#nullable restore
#line 10 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<address>\r\n    <p>Direcci??n: ");
#nullable restore
#line 12 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\Escuela\Index.cshtml"
             Write(Model.Direcci??n);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Pa??s:");
#nullable restore
#line 13 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\Escuela\Index.cshtml"
       Write(Model.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
#nullable restore
#line 14 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\Escuela\Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</address>\r\n<p><strong>A??o de Fundacion: ");
#nullable restore
#line 16 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\Escuela\Index.cshtml"
                        Write(Model.A??oDeCreaci??n);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> </p>\r\n\r\n<p><i>");
#nullable restore
#line 18 "C:\Users\david.montano\Documents\Desarrollo\Asp-MVC\Project\Views\Escuela\Index.cshtml"
 Write(ViewBag.CosaDinamica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
