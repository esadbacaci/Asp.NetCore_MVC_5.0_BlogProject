#pragma checksum "D:\Web Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32980cd8e4209217696578a3a1a38df505627800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterLastBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterLastBlog/Default.cshtml")]
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
#line 1 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32980cd8e4209217696578a3a1a38df505627800", @"/Views/Shared/Components/WriterLastBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterLastBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t\r\n<div class=\"tech-btm\">\r\n\t<h4>Diğer Bloglar</h4>\r\n\r\n\t<div class=\"row row-cols-1 row-cols-md-2 g-4\">\r\n");
#nullable restore
#line 12 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
 foreach (var item in Model.OrderBy(x => Guid.NewGuid()).Take(2))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col\">\r\n\t\t\t\t<div class=\"card h-100\">\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 360, "\"", 397, 2);
            WriteAttributeValue("", 367, "/Blog/BlogReadAll/", 367, 18, true);
#nullable restore
#line 16 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 385, item.BlogID, 385, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 411, "\"", 432, 1);
#nullable restore
#line 17 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 417, item.BlogImage, 417, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 454, "\"", 460, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t</a>\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 545, "\"", 582, 2);
            WriteAttributeValue("", 552, "/Blog/BlogReadAll/", 552, 18, true);
#nullable restore
#line 21 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 570, item.BlogID, 570, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                                                                Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t<div class=\"sub-meta mb-3\">\r\n\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t<i class=\"far fa-clock\"></i> ");
#nullable restore
#line 25 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                                                         Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 31 "D:\Web Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
