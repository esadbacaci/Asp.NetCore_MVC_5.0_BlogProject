#pragma checksum "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f984aaed112fac67446639005ebd97f657b8736"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f984aaed112fac67446639005ebd97f657b8736", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f984aaed112fac67446639005ebd97f657b87363817", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t<div class=\"container\">\r\n\t\t<h3 class=\"tittle\">Yazar Kayıt Sayfası</h3>\r\n\t\t<div class=\"inner-sec\">\r\n\t\t\t<div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 14 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register",FormMethod.Post))
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t<label for=\"validationCustom01\">Ad Soyad</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 19 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.WriterName,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 20 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterName,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t<label for=\"validationCustom02\">Mail Adresi</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 26 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.WriterMail,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 27 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterMail,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t<div class=\"form-group col-md-6\">\r\n\t\t\t\t\t\t\t<label for=\"exampleInputPassword1 mb-2\">Şifre</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 35 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.WriterPassword,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 36 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterPassword,"",new{@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n");
            WriteLiteral(@"			</div>
					<button style=""background:#00488e !important ""id=""btn1"" type=""submit"" class=""btn btn-primary submit mb-4"">Kayıt Ol</button>
					<p>
						<input type=""checkbox""> 
						<a href=""#"" id=""btn2"">Tüm Şartları Okudum, Kabul Ediyorum</a>
					</p>
");
#nullable restore
#line 53 "C:\Users\bcces\Desktop\x\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
			</div>
		</div>
	</div>
	<br />
	
	<script>
		$('#btn1').click(function(){
			swal(""Başarılı"", ""Kaydınız Başarıyla Oluşturulmuştur"", ""success"");
		});
	</script>

	<script>
		$('#btn2').click(function () {
			swal("" Site Kabul Şartları "","" Şartlar "");
		});
	</script>

</section>
");
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
