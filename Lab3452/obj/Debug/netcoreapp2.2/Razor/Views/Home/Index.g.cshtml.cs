#pragma checksum "C:\Users\ASUS\source\repos\Lab345\Lab345\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2efc6c94b0c6a7ee65ed0eb9b19cf2a19565b448"
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
#line 1 "C:\Users\ASUS\source\repos\Lab345\Lab345\Views\_ViewImports.cshtml"
using Lab345;

#line default
#line hidden
#line 2 "C:\Users\ASUS\source\repos\Lab345\Lab345\Views\_ViewImports.cshtml"
using Lab345.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2efc6c94b0c6a7ee65ed0eb9b19cf2a19565b448", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41af546e47c8f98337705e7fed2983ca17b4fc21", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab345.ViewModels.CheeseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(44, 199, true);
            WriteLiteral("\r\n  \r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Name</th>\r\n            <th>Country</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>     \r\n        \r\n");
            EndContext();
#line 17 "C:\Users\ASUS\source\repos\Lab345\Lab345\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.cheeses)
            {

#line default
#line hidden
            BeginContext(310, 42, true);
            WriteLiteral("                <tr>\r\n                <td>");
            EndContext();
            BeginContext(353, 13, false);
#line 20 "C:\Users\ASUS\source\repos\Lab345\Lab345\Views\Home\Index.cshtml"
               Write(item.CheeseId);

#line default
#line hidden
            EndContext();
            BeginContext(366, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(394, 9, false);
#line 21 "C:\Users\ASUS\source\repos\Lab345\Lab345\Views\Home\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(403, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(431, 12, false);
#line 22 "C:\Users\ASUS\source\repos\Lab345\Lab345\Views\Home\Index.cshtml"
               Write(item.Country);

#line default
#line hidden
            EndContext();
            BeginContext(443, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 24 "C:\Users\ASUS\source\repos\Lab345\Lab345\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(488, 34, true);
            WriteLiteral("        \r\n    </tbody>\r\n</table>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab345.ViewModels.CheeseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
