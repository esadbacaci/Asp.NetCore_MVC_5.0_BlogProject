#pragma checksum "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "884137f0dcfa0d9ca10ea1fde2dcb19783bf44e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"884137f0dcfa0d9ca10ea1fde2dcb19783bf44e3", @"/Areas/Admin/Views/Category/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kategori Listesi</h1>\r\n<br />\r\n<div class=\"table-responsive\">\r\n    <table class=\"table table-hover\">\r\n\r\n\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kategori Adı</th>\r\n        <th>Kategori Açıklama</th>\r\n\r\n        <th></th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 25 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 28 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 29 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryeDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 658, "\"", 712, 2);
            WriteAttributeValue("", 665, "/Admin/Category/CategoryDelete/", 665, 31, true);
#nullable restore
#line 33 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 696, item.CategoryID, 696, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"DeleteBtn\" onclick=\"return confirm(\'Eğer kategoriyi silerseniz bu kategoriye ait tüm bloglar silinecektir, bu işlemi onaylıyor musunuz ?\');\" class=\"btn btn-danger\">Sil</a></td>\r\n         \r\n\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 39 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 45 "D:\Web Projelerim\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index",new{page})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/Admin/Category/AddCategory\" class=\"btn btn-info\">Yeni Kategori Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591