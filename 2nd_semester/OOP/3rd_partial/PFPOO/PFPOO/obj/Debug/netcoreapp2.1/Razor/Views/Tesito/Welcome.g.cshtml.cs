#pragma checksum "C:\Users\pdiaz\Desktop\PFPOO\PFPOO\Views\Tesito\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20faa4bfe499772511f6727d6fe0c68be2c00f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tesito_Welcome), @"mvc.1.0.view", @"/Views/Tesito/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tesito/Welcome.cshtml", typeof(AspNetCore.Views_Tesito_Welcome))]
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
#line 1 "C:\Users\pdiaz\Desktop\PFPOO\PFPOO\Views\_ViewImports.cshtml"
using PFPOO;

#line default
#line hidden
#line 2 "C:\Users\pdiaz\Desktop\PFPOO\PFPOO\Views\_ViewImports.cshtml"
using PFPOO.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20faa4bfe499772511f6727d6fe0c68be2c00f84", @"/Views/Tesito/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f7b1b7fb06aaa191eb3c190f4f9398084b32a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tesito_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\pdiaz\Desktop\PFPOO\PFPOO\Views\Tesito\Welcome.cshtml"
  
    ViewData["Title"] = "Bienvenidos";

#line default
#line hidden
            BeginContext(47, 65, true);
            WriteLiteral("\r\n<h2>Tesitos varios</h2>\r\n\r\n<p>Por ahora no hay nada</p>\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\pdiaz\Desktop\PFPOO\PFPOO\Views\Tesito\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(177, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(190, 19, false);
#line 11 "C:\Users\pdiaz\Desktop\PFPOO\PFPOO\Views\Tesito\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(209, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "C:\Users\pdiaz\Desktop\PFPOO\PFPOO\Views\Tesito\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(223, 5, true);
            WriteLiteral("</ul>");
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
