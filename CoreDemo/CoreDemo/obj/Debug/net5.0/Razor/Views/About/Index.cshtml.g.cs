#pragma checksum "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "410e5285e14c49d485a095a75d0806536e84012e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\About\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"410e5285e14c49d485a095a75d0806536e84012e", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410e5285e14c49d485a095a75d0806536e84012e4762", async() => {
                WriteLiteral(@"
	<!--/main-->
	<section class=""main-content-w3layouts-agileits"">
		<div class=""container"">
			<h3 class=""tittle"">Hakkımızda</h3>
			<div class=""row inner-sec"">
				<!--left-->
				<div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
					<div class=""blog-grid-top"">

						<div class=""blog_info_left_grid"">
						
							<iframe width=""773"" height=""435"" src=""https://www.youtube.com/embed/X9dhgBvcMo0"" title=""Bilsoft Yazılım Tanıtım Filmi"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" allowfullscreen></iframe>
						
						</div>
						<h3>
							Biz Kimiz
						</h3>
");
#nullable restore
#line 29 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\About\Index.cshtml"
                         foreach (var item in Model)
						{
							
						

#line default
#line hidden
#nullable disable
                WriteLiteral(@"						<p>
								2005 yılından beri bilişim sektöründe faaliyet gösteren firmamızın geliştirdiği Muhasebe programları, Türkiye genelinde 100.000'in üzerinde KOBİ tarafından kullanılmaktadır. Bilsoft Ön Muhasebe Programları, muhasebe bilgisi olmadan rahatlıkla kullanılabilecek şekilde kullanıcı dostu olarak geliştirilmiştir. Kullanımı kolay olmasının yanında, hafta sonu ve resmi tatiller de dahil olmak üzere kullanıcıların ihtiyaç duyduğunda 7/24 teknik servis hizmeti sunmaktayız.


								Bilsoft olarak, KOBİ'lerin ihtiyaçlarına daha kapsamlı çözümler sunmak amacıyla muhasebe programlarını sürekli olarak geliştirmekte ve güncellemekteyiz. KOBİ'lerin ihtiyaçları doğrultusunda Ön Muhasebe programlarına entegre şekilde çalışan hızlı satış programı, e-dönüşüm (e-fatura, e-arşiv fatura, e-irsaliye, e-müstahsil) programı, personel takip programı, pazar yeri entegrasyonu ve teknik servis programı geliştirerek kullanıcılarımıza sunduk. Bilsoft, müşterilerine e-dönüşüm paketi kapsamında e-faturaya geçiş ve e-arş");
                WriteLiteral(@"iv faturaya geçiş imkanı sunmaktadır.


								KOBİ'lerin finansal süreçlerini, gelir giderlerini daha etkin, daha kolay ve daha güvenli şekilde yönetmelerini sağlamak amacıyla durmadan çalışıyoruz. %100 yerli ve milli imkânlarla geliştirdiğimiz programlarımızla kullanıcılarımıza sadece firma içindeki bilgisayarlardan veya çevrimiçi olarak internetin olduğu her yerde bilgisayar, tablet ve cep telefonu üzerinden finansal verilerini yönetme ve gelir giderlerini takip etme imkânı sunuyoruz.


								Bilsoft, bugüne kadar elde ettiği yetenek ve tecrübeleri bugünün trendleri ile birleştirerek, kullanıcılarına yenilikçi çözümler sunmaya devam edecektir.


");
                WriteLiteral("\t\t\t\t\t\t</p>\r\n");
#nullable restore
#line 48 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\About\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t\t<!--//left-->\r\n\t\t\t\t<!--right-->\r\n\t\t\t\t<aside class=\"col-lg-4 agileits-w3ls-right-blog-con text-right\">\r\n\r\n\t\t\t\t\t<div class=\"right-blog-info text-left\">\r\n\t\t\t\t\t\t<div class=\"tech-btm\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "410e5285e14c49d485a095a75d0806536e84012e8272", async() => {
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
                WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t");
#nullable restore
#line 62 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\About\Index.cshtml"
                   Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t");
#nullable restore
#line 64 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\About\Index.cshtml"
                   Write(await Html.PartialAsync("~/Views/About/SocialMediaAbout.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\r\n\t\t\t\r\n\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t</aside>\r\n\t\t\t\t<!--//right-->\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
