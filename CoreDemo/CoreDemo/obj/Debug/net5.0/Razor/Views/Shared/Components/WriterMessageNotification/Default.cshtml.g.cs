#pragma checksum "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb553170b943e39935a788ccaa775d2be811856"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterMessageNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
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
#line 1 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb553170b943e39935a788ccaa775d2be811856", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterMessageNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"messageDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Mesajlar</h6>\r\n  <div class=\"dropdown-divider\"></div>\n");
#nullable restore
#line 7 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("          <a class=\"dropdown-item preview-item\">\r\n        <div class=\"preview-thumbnail\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 400, "\"", 434, 1);
#nullable restore
#line 12 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
WriteAttributeValue("", 406, item.SenderUser.WriterImage, 406, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" class=\"profile-pic\">\r\n        </div>\r\n        <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n            <h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\">");
#nullable restore
#line 15 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                                                    Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sana mesaj gönderdi</h6>\r\n            <p class=\"text-gray mb-0\"> ");
#nullable restore
#line 16 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                  Write(item.MessageDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </a>\r\n");
#nullable restore
#line 19 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n    <h6 class=\"p-3 mb-0 text-center\">3 view bag gelecek Yeni Mesaj</h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
