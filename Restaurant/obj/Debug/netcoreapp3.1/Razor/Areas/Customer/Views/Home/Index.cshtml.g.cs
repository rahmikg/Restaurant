#pragma checksum "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10a51a5a6105dcf61755dc66bd23e40b8da376f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\_ViewImports.cshtml"
using Restaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\_ViewImports.cshtml"
using Restaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10a51a5a6105dcf61755dc66bd23e40b8da376f6", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26536fe9bedb6014b2c3fd2881202c7c46ad372a", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 9 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.Coupon.ToList().Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"border-white\">\r\n        <div class=\"carousel\" data-ride=\"carousel\" data-interval=\"2500\">\r\n");
#nullable restore
#line 13 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Coupon.ToList().Count(); i++)
            {
                if (i == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n");
#nullable restore
#line 18 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 774, "\"", 787, 1);
#nullable restore
#line 22 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 780, imgsrc, 780, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"70px\" class=\"d-block w-100\" />\r\n                    </div>\r\n");
#nullable restore
#line 24 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\r\n");
#nullable restore
#line 28 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1243, "\"", 1256, 1);
#nullable restore
#line 32 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1249, imgsrc, 1249, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\r\n                    </div>\r\n");
#nullable restore
#line 34 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
<br />


<div class=""backgroundWhiteBorder container"">

    <ul id=""menu-filters"" class=""menu-filter-list list-inline text-center"">

        <li class=""active btn btn-secondary ml-1 mr-1"" data-filter="".menu-restaurant"">
            Show All
        </li>

");
#nullable restore
#line 53 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
         foreach (var item in Model.Category)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 55 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
                                           Write(item.Name.Replace(" ", string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                ");
#nullable restore
#line 56 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 58 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n\r\n");
#nullable restore
#line 62 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var category in Model.Category)
    {
        IEnumerable<MenuItem> menuItems = Model.MenuItem.Where(u => u.Category.Name.Equals(category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\" id=\"menu-wrapper\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10a51a5a6105dcf61755dc66bd23e40b8da376f69269", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 66 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = menuItems;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 68 "C:\Users\rahmi\OneDrive\Desktop\Restaurant\Restaurant\Restaurant\Areas\Customer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script src=""https://code.jquery.com/jquery-3.3.1.js""
            integrity=""sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60=""
            crossorigin=""anonymous""></script>

    <script>
        var posts = $('.post');

        (function ($) {

            $(""#menu-filters li"").click(function () {
                $(""#menu-filters li"").removeClass('active btn btn-secondary');
                $(this).addClass('active btn btn-secondary');

                var selectedFilter = $(this).data(""filter"");

                $("".menu-restaurant"").fadeOut();

                setTimeout(function () {
                    $(selectedFilter).slideDown();
                }, 300);
            });



        })(jQuery);
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
