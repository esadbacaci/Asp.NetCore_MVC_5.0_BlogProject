#pragma checksum "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a786f3af70b3d8220c4dfd5e7ae0552ec0f9866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_AddWriter), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/AddWriter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a786f3af70b3d8220c4dfd5e7ae0552ec0f9866", @"/Areas/Admin/Views/Writer/AddWriter.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Writer_AddWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
  
    ViewData["Title"] = "AddWriter";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Yazar Oluştur</h1>\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 12 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
 using (Html.BeginForm("AddWriter", "Writer", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.Label("Yazar Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.TextBoxFor(x=>x.WriterName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.ValidationMessageFor(x=>x.WriterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />  \r\n");
#nullable restore
#line 21 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.Label("Yazar Hakkında"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.TextBoxFor(x=>x.WriterAbout,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.ValidationMessageFor(x=>x.WriterAbout));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n");
#nullable restore
#line 28 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.Label("Yazar Mail"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.TextAreaFor(x=>x.WriterMail,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.ValidationMessageFor(x=>x.WriterMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br /> \r\n");
#nullable restore
#line 34 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.Label("Yazar Şifresi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.PasswordFor(x=>x.WriterPassword,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
Write(Html.ValidationMessageFor(x=>x.WriterPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n");
            WriteLiteral("        <button class=\"btn btn-info\">Yazar Ekle</button>\r\n");
#nullable restore
#line 42 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\AddWriter.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
