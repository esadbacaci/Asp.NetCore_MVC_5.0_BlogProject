#pragma checksum "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c42c7a2df654070df5a6d3eb1e9ba67e83022a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogReadAll), @"mvc.1.0.view", @"/Views/Blog/BlogReadAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c42c7a2df654070df5a6d3eb1e9ba67e83022a0", @"/Views/Blog/BlogReadAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogReadAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/images/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--\r\n\tAuthor: W3layouts\r\n\tAuthor URL: http://w3layouts.com\r\n\tLicense: Creative Commons Attribution 3.0 Unported\r\n\tLicense URL: http://creativecommons.org/licenses/by/3.0/\r\n-->\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c42c7a2df654070df5a6d3eb1e9ba67e83022a05246", async() => {
                WriteLiteral("\r\n\r\n\t<!--//banner-->\r\n\t<section class=\"banner-bottom\">\r\n\t\t<!--/blog-->\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<!--left-->\r\n\t\t\t\t<div class=\"col-lg-8 left-blog-info-w3layouts-agileits text-left\">\r\n");
#nullable restore
#line 27 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                 foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<div class=\"blog-grid-top\">\r\n\t\t\t\t\t\t\t<div class=\"b-grid-top\">\r\n\t\t\t\t\t\t\t\t<div class=\"blog_info_left_grid\">\r\n\r\n\t\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 748, "\"", 769, 1);
#nullable restore
#line 33 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
WriteAttributeValue("", 754, item.BlogImage, 754, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 788, "\"", 794, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"width:100%\"><!--burada tildayı görmemesi için substring kulllandık-->\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"blog-info-middle\">\r\n\t\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 40 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                                                                Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
											</a>
										</li>
										<li class=""mx-2"">
										
										<li>
											<a href=""#"">
												<i class=""far fa-profile""></i>
											</a>
										</li>

									</ul>
								</div>
							</div>

							<h3>
								<a href=""#"">");
#nullable restore
#line 56 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                       Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n\t\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 59 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                           Write(Html.Raw(@item.BlogContent));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 63 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
					}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t<!--//left-->\r\n\t\t\t\t<!--right-->\r\n\t\t\t\t<aside class=\"col-lg-4 agileits-w3ls-right-blog-con text-right\">\r\n\t\t\t\t\t<div class=\"right-blog-info text-left\">\r\n\t\t\t\t\t\t<div class=\"tech-btm\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c42c7a2df654070df5a6d3eb1e9ba67e83022a08898", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<h4>Bültene Abone Ol</h4>\r\n\t\t\t\t\t\t");
#nullable restore
#line 82 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t");
#nullable restore
#line 84 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t");
#nullable restore
#line 86 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Html.PartialAsync("Partial1"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t<br />\r\n\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t");
#nullable restore
#line 90 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Component.InvokeAsync("WriterLastBlog"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



						<div class=""single-gd my-5 tech-btm"">
						BOŞ ALAN BLOGREADALL İÇİNDE
						</div>
						<div class=""single-gd tech-btm"">
							<h4>Yazı Gelebilir</h4>
							<div class=""blog-grids"">
								<div class=""blog-grid-left"">
								
										");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c42c7a2df654070df5a6d3eb1e9ba67e83022a011671", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
								
								</div>
								<div class=""blog-grid-right"">

								
								</div>
								<div class=""clearfix""> </div>
							</div>
						</div>
					</div>

				</aside>
				<!--//right-->
			</div>
		</div>
	</section>



	

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
