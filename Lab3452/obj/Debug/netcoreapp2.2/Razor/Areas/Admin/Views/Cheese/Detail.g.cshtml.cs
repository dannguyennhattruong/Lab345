#pragma checksum "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "140f5492f875824b09b1c34d7592c7faac5e18ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cheese_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Cheese/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Cheese/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Cheese_Detail))]
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
#line 1 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\_ViewImports.cshtml"
using Lab345;

#line default
#line hidden
#line 2 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\_ViewImports.cshtml"
using Lab345.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140f5492f875824b09b1c34d7592c7faac5e18ab", @"/Areas/Admin/Views/Cheese/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41af546e47c8f98337705e7fed2983ca17b4fc21", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cheese_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab345.Models.Cheese>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cheese", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(34, 13, false);
#line 2 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
Write(ViewBag.title);

#line default
#line hidden
            EndContext();
            BeginContext(47, 34, true);
            WriteLiteral("</h1>\r\n<h2>Cheese Details</h2> <p>");
            EndContext();
            BeginContext(81, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "140f5492f875824b09b1c34d7592c7faac5e18ab5038", async() => {
                BeginContext(169, 6, true);
                WriteLiteral("Return");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(179, 72, true);
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <tr>         <th>Name</th>         <td>");
            EndContext();
            BeginContext(252, 10, false);
#line 5 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(262, 70, true);
            WriteLiteral("</td>     </tr>\r\n    <tr>\r\n        <th>Descriptions</th>\r\n        <td>");
            EndContext();
            BeginContext(333, 18, false);
#line 8 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
       Write(Model.Descriptions);

#line default
#line hidden
            EndContext();
            BeginContext(351, 64, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>         <th>Country</th>         <td>");
            EndContext();
            BeginContext(416, 13, false);
#line 10 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
                                         Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(429, 50, true);
            WriteLiteral("</td>     </tr>\r\n    <tr>\r\n        <th>Year</th>\r\n");
            EndContext();
#line 13 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
         if (Model.Year == 0)
        {

#line default
#line hidden
            BeginContext(521, 25, true);
            WriteLiteral("            <td>N/a</td> ");
            EndContext();
#line 15 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
                         }
        else
        {

#line default
#line hidden
            BeginContext(574, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(591, 10, false);
#line 18 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
           Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(601, 5, true);
            WriteLiteral("</td>");
            EndContext();
#line 18 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
                                }

#line default
#line hidden
            BeginContext(609, 60, true);
            WriteLiteral("    </tr>\r\n    <tr>\r\n        <th>Quantity</th>\r\n        <td>");
            EndContext();
            BeginContext(670, 14, false);
#line 22 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
       Write(Model.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(684, 64, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Price</th>\r\n        <td>");
            EndContext();
            BeginContext(749, 11, false);
#line 26 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
       Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(760, 68, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Create On</th>\r\n        <td>");
            EndContext();
            BeginContext(829, 46, false);
#line 30 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
       Write(Model.CreateOn.ToString("dd-MM-yyyy hh:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(875, 79, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr></tr>\r\n    <tr>\r\n        <th>Image</th>\r\n        <td>");
            EndContext();
            BeginContext(954, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "140f5492f875824b09b1c34d7592c7faac5e18ab10677", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 964, "~/images/", 964, 9, true);
#line 35 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
AddHtmlAttributeValue("", 973, Model.Photo, 973, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 35 "C:\Users\ASUS\source\repos\Lab345\Lab345\Areas\Admin\Views\Cheese\Detail.cshtml"
AddHtmlAttributeValue("", 992, Model.Name, 992, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1007, 35, true);
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n\r\n\r\n\r\n</table> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab345.Models.Cheese> Html { get; private set; }
    }
}
#pragma warning restore 1591
