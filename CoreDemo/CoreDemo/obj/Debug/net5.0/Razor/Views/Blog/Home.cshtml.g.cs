#pragma checksum "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45f471502721d9312512dfd2f0d677c27f8b0deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Home), @"mvc.1.0.view", @"/Views/Blog/Home.cshtml")]
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
#line 1 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f471502721d9312512dfd2f0d677c27f8b0deb", @"/Views/Blog/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.PagedList<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""banner"">
		<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
			<ol class=""carousel-indicators"">
				<li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
				<li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
				<li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
				<li data-target=""#carouselExampleIndicators"" data-slide-to=""3""></li>
			</ol>
			<div class=""carousel-inner"" role=""listbox"">
				<div class=""carousel-item active"">
					<div class=""carousel-caption"">
						<h3>Create the lifestyle
							<span>you desire</span>
						</h3>
						<div class=""read"">
							<a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
						</div>
					</div>
				</div>
				<div class=""carousel-item item2"">
					<div class=""carousel-caption"">
						<h3>Engaging Purposeful
							<span>and Creative</span>
						</h3>
						<div class=""read"">
							<a href=""single.html"" class=""b");
            WriteLiteral(@"tn btn-primary read-m"">Read More</a>
						</div>
					</div>
				</div>
				<div class=""carousel-item item3"">
					<div class=""carousel-caption"">
						<h3>Create the lifestyle
							<span>you desire</span>
						</h3>
						<div class=""read"">
							<a href=""#"" class=""btn btn-primary read-m"">Read More</a>
						</div>
					</div>
				</div>
				<div class=""carousel-item item4"">
					<div class=""carousel-caption"">
						<h3>Engaging Purposeful
							<span>and Creative</span>
						</h3>
						<div class=""read"">
							<a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
						</div>
					</div>
				</div>
			</div>
			<a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
				<span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
				<span class=""sr-only"">Previous</span>
			</a>
			<a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
				<span class=""carousel-");
            WriteLiteral(@"control-next-icon"" aria-hidden=""true""></span>
				<span class=""sr-only"">Next</span>
			</a>
		</div>
	</div>

<section class=""main-content-w3layouts-agileits"">
	<div class=""container"">
		
		<div class=""row inner-sec"">
			<!--left-->
			<div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">


");
#nullable restore
#line 78 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
                 foreach (var item in Model.OrderByDescending(m => m.BlogID))
				{
		

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<article class=\"blog-grid-top\">\r\n\t\t\t\t\t<div class=\"b-grid-top\">\r\n\t\t\t\t\t\t<div class=\"blog_info_left_grid\">\r\n\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2790, "\"", 2827, 2);
            WriteAttributeValue("", 2797, "/Blog/BlogReadAll/", 2797, 18, true);
#nullable restore
#line 84 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
WriteAttributeValue("", 2815, item.BlogID, 2815, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 2844, "\"", 2865, 1);
#nullable restore
#line 85 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
WriteAttributeValue("", 2850, item.BlogImage, 2850, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 2884, "\"", 2890, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"blog-info-middle\">\r\n\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 92 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
                                                                            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t<li class=\"mx-2\">\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 97 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
                                   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t<li>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<h3>\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3461, "\"", 3498, 2);
            WriteAttributeValue("", 3468, "/Blog/BlogReadAll/", 3468, 18, true);
#nullable restore
#line 111 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
WriteAttributeValue("", 3486, item.BlogID, 3486, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 111 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
                                                                Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n\t\t\t\t\t</h3>\r\n");
            WriteLiteral("\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3690, "\"", 3727, 2);
            WriteAttributeValue("", 3697, "/Blog/BlogReadAll/", 3697, 18, true);
#nullable restore
#line 114 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
WriteAttributeValue("", 3715, item.BlogID, 3715, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n\t\t\t\t</article>\r\n");
#nullable restore
#line 116 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<br />
<br />
				<style>

					.pagination-container .page-item > a.page-link {
						color: #fff;
						background-color: #f58320;
						border-color: #f58320;
						border: 1px solid #fff;
					}

						.pagination-container .page-item > a.page-link:hover {
							background-color: darkorange ;
							border-color: darkorange;
						}

					.pagination-container .page-item.active > span.page-link {
						color: #fff;
						background-color: darkorange;
						border-color: darkorange;
						border: 1px solid #fff;
					}
				</style>
<div class=""pagination-container"">
	<ul class=""pagination justify-content-center"">
");
#nullable restore
#line 145 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
         if (Model.PageNumber != 1)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4552, "\"", 4615, 1);
#nullable restore
#line 147 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
WriteAttributeValue("", 4559, Url.Action("Home", new { page = Model.PageNumber - 1 }), 4559, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Önceki</a></li>\r\n");
#nullable restore
#line 148 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 150 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
         for (int i = 1; i <= Model.PageCount; i++)
		{
			if (Model.PageNumber == i)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<li class=\"page-item active\"><span class=\"page-link\">");
#nullable restore
#line 154 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 155 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4870, "\"", 4914, 1);
#nullable restore
#line 158 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
WriteAttributeValue("", 4877, Url.Action("Home", new { page = i }), 4877, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 158 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 159 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
			}
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 162 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
         if (Model.PageNumber != Model.PageCount)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5037, "\"", 5100, 1);
#nullable restore
#line 164 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
WriteAttributeValue("", 5044, Url.Action("Home", new { page = Model.PageNumber + 1 }), 5044, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sonraki</a></li>\r\n");
#nullable restore
#line 165 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n</div>\r\n\r\n\t\t\t</div>\r\n\t\t\t<!--//left-->\r\n\t\t\t<!--right-->\r\n\t\t\t<aside class=\"col-lg-4 agileits-w3ls-right-blog-con text-left\">\r\n\t\t\t\t<div class=\"right-blog-info text-left\">\r\n\t\t\t\t\t\r\n\t\t\t\t\t");
#nullable restore
#line 175 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
               Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 177 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
               Write(await Component.InvokeAsync("WriterLastBlog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 179 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
               Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 181 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\Home.cshtml"
               Write(await Html.PartialAsync("Partial1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\r\n\r\n\t\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t</aside>\r\n\t\t\t<!--//right-->\r\n\t\t</div>\r\n\r\n\t</div>\r\n\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.PagedList<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
