#pragma checksum "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08bd79a0e02260f3cb9f5927aaae8a413afb3a3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterAboutOnDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
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
#line 1 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08bd79a0e02260f3cb9f5927aaae8a413afb3a3e", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterAboutOnDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"
<div class=""row author-section"">
  <div class=""col-12 grid-margin stretch-card"">
    <div class=""card"">
      <div class=""card-body"">
        <h4 class=""card-title"">Yazar Hakkında</h4>
        <div class=""d-flex mt-5 align-items-center"">
          <div class=""author-img-wrapper"">
");
            WriteLiteral("          </div>\n          <div class=\"author-info ml-4\">\n            <h5 class=\"author-name\">");
#nullable restore
#line 41 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                               Write(Model.FirstOrDefault()?.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <p class=\"author-email\">");
#nullable restore
#line 42 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                               Write(Model.FirstOrDefault()?.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p class=\"author-about\">");
#nullable restore
#line 43 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                               Write(Model.FirstOrDefault()?.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <div class=""author-socials"">
              <a href=""#"" class=""social-link""><i class=""mdi mdi-facebook""></i></a>
              <a href=""#"" class=""social-link""><i class=""mdi mdi-twitter""></i></a>
              <a href=""#"" class=""social-link""><i class=""mdi mdi-instagram""></i></a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>

<style>

    .author-section {
        margin-top: 40px;
    }

    .author-img-wrapper {
        width: 100px;
        height: 100px;
        overflow: hidden;
        border-radius: 50%;
    }

        .author-img-wrapper img {
            width: 100%;
            height: auto;
        }

    .author-info .author-name {
        font-size: 24px;
        font-weight: 600;
        margin-bottom: 10px;
    }

    .author-info .author-email {
        font-size: 18px;
        color: #6c757d;
        margin-bottom: 10px;
    }

    .author-info .author-about {
        font-size: 16px;
        margin-bottom: 20px;
    }

    .author-so");
            WriteLiteral(@"cials .social-link {
        display: inline-block;
        font-size: 24px;
        color: #6c757d;
        margin-right: 10px;
        transition: all 0.3s ease-in-out;
    }

        .author-socials .social-link:hover {
            color: #007bff;
        }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
