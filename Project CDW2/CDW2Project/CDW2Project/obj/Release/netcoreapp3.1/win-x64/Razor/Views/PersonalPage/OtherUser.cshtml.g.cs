#pragma checksum "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4217887dae7415b4aece7f075ee2fe094e15e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonalPage_OtherUser), @"mvc.1.0.view", @"/Views/PersonalPage/OtherUser.cshtml")]
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
#line 1 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\_ViewImports.cshtml"
using CDW2Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\_ViewImports.cshtml"
using CDW2Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4217887dae7415b4aece7f075ee2fe094e15e8", @"/Views/PersonalPage/OtherUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14d9eac1b0908c07afe0ed72a7a27fb4196cad9c", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonalPage_OtherUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/PersonalPage/PersonalPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"reviewImageBox\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da4217887dae7415b4aece7f075ee2fe094e15e84557", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"avatar\">\r\n    <div class=\"dropdown\">\r\n        <button class=\"btn btn-primary btnChangeAvatar\" type=\"button\" id=\"dropdownMenuButton\" data-toggle=\"dropdown\">\r\n");
#nullable restore
#line 12 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
             if (string.IsNullOrEmpty(Model.Image))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img src=\"/img/emty_avatar.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 497, "\"", 503, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 15 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 575, "\"", 615, 4);
            WriteAttributeValue("", 581, "/User_Image/", 581, 12, true);
#nullable restore
#line 18 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
WriteAttributeValue("", 593, Model.Id, 593, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 602, "/", 602, 1, true);
#nullable restore
#line 18 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
WriteAttributeValue("", 603, Model.Image, 603, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 616, "\"", 622, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 19 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </button>
        <div class=""dropdown-menu scrollbar"" aria-labelledby=""dropdownMenuButton"" id=""style-1"">
            <span class=""dropdown-item it-avatar reviewImage"" style=""cursor:pointer""><i class=""far fa-eye""></i> View avatar</span>
        </div>
    </div>
    <h1>");
#nullable restore
#line 25 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div><!-- Avatar -->\r\n<!-- Language -->\r\n<div class=\"language\">\r\n    <div class=\"language__box\">\r\n");
#nullable restore
#line 30 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
         foreach (var item in Model.articleTypes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"language__box__item\"");
            BeginWriteAttribute("articleTypeId", " articleTypeId=\"", 1152, "\"", 1187, 1);
#nullable restore
#line 32 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
WriteAttributeValue("", 1168, item.ArticleTypeId, 1168, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div>\r\n                    ");
#nullable restore
#line 34 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
               Write(Html.Raw(item.image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h4>");
#nullable restore
#line 35 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 38 "D:\Trainning_asp.net\Chuyen de web 2\CDW2Project\CDW2Project\Views\PersonalPage\OtherUser.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""language__box__item active"" articleTypeId=""other"">
            <div>
                <i class=""devicon-slack-plain colored""></i>
                <h4>Other</h4>
            </div>
        </div>
    </div>
</div><!-- Language -->
<!-- Information -->
<div class=""info"">
    <!-- Information Left-->
    <div class=""info__left"">
        <div class=""info__left__box"">
        </div>
    </div><!-- Information Left-->
    <!-- Information Right-->
    <div class=""info__right"">
        <!-- Information Right Box-->
        <div class=""info__right__box scrollbar"" id=""style-1"">
            <div class=""scroll_box"">

            </div>
        </div><!-- Information Right Box-->
    </div><!-- Information Right-->
</div>
");
            DefineSection("PersonalPage", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4217887dae7415b4aece7f075ee2fe094e15e810808", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
