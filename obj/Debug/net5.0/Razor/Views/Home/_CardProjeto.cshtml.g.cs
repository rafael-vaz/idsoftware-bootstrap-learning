#pragma checksum "/home/rafael/Downloads/Projetos/IdSoftware/Views/Home/_CardProjeto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f88dc09e4922accbbf3ca7c848d09d0cef97af0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__CardProjeto), @"mvc.1.0.view", @"/Views/Home/_CardProjeto.cshtml")]
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
#line 1 "/home/rafael/Downloads/Projetos/IdSoftware/Views/_ViewImports.cshtml"
using IdSoftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rafael/Downloads/Projetos/IdSoftware/Views/_ViewImports.cshtml"
using IdSoftware.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88dc09e4922accbbf3ca7c848d09d0cef97af0d", @"/Views/Home/_CardProjeto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d87ec58aed00bcc1afb22fe2a82f86a64786bbdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__CardProjeto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("  <div class=\"card\">\n      <div class=\"card-img\">\n          <img");
            BeginWriteAttribute("src", " src=", 75, "", 80, 0);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 4 "/home/rafael/Downloads/Projetos/IdSoftware/Views/Home/_CardProjeto.cshtml"
                Write("/imagens/projeto" + @Model + ".png");

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"img-fluid\">\n      </div>\n      \n      <div class=\"card-body\">\n      <h4 class=\"card-title\">Projeto ");
#nullable restore
#line 8 "/home/rafael/Downloads/Projetos/IdSoftware/Views/Home/_CardProjeto.cshtml"
                                Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" da ID</h4>\n          <p class=\"card-text\">\n              In hac habitasse platea dictumst. Suspendisse mattis mattis semper.\n          </p>\n      </div>\n      <div class=\"card-footer\">\n          <a");
            BeginWriteAttribute("href", " href=\"", 431, "\"", 438, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\">Saiba Mais</a>\n      </div>\n  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
