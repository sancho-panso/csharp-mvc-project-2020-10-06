#pragma checksum "C:\Users\moksleivis\source\repos\2020-10-06-MVC\2020-10-06-MVC\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "089fb58e953d3e7caa0c9d60b75e0fe8fc3a48a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\moksleivis\source\repos\2020-10-06-MVC\2020-10-06-MVC\Views\_ViewImports.cshtml"
using _2020_10_06_MVC;

#line default
#line hidden
#line 2 "C:\Users\moksleivis\source\repos\2020-10-06-MVC\2020-10-06-MVC\Views\_ViewImports.cshtml"
using _2020_10_06_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089fb58e953d3e7caa0c9d60b75e0fe8fc3a48a9", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40cc5e237c48af86d43ddf968e7e52eeb9f27da7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 49, true);
            WriteLiteral("\r\n<h1>About me page</h1>\r\n<ul class=\"test\">Test\r\n");
            EndContext();
#line 8 "C:\Users\moksleivis\source\repos\2020-10-06-MVC\2020-10-06-MVC\Views\Home\About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(143, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(156, 9, false);
#line 10 "C:\Users\moksleivis\source\repos\2020-10-06-MVC\2020-10-06-MVC\Views\Home\About.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(165, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(167, 12, false);
#line 10 "C:\Users\moksleivis\source\repos\2020-10-06-MVC\2020-10-06-MVC\Views\Home\About.cshtml"
                  Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(179, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\Users\moksleivis\source\repos\2020-10-06-MVC\2020-10-06-MVC\Views\Home\About.cshtml"

    }

#line default
#line hidden
            BeginContext(195, 5, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
