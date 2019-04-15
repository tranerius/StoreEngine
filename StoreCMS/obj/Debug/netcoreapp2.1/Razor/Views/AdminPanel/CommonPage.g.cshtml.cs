#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6b07ca2849f033f4ac4efa339ba845fb20dcfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_CommonPage), @"mvc.1.0.view", @"/Views/AdminPanel/CommonPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/CommonPage.cshtml", typeof(AspNetCore.Views_AdminPanel_CommonPage))]
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
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Functions;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Localization;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.AdminPanelTypes;

#line default
#line hidden
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 5 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6b07ca2849f033f4ac4efa339ba845fb20dcfc", @"/Views/AdminPanel/CommonPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_CommonPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles/admin_panel/common.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles/admin_panel/admin_panel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
  
    User user = Context.Items["User"] as User;
    AdminPanelPages pageID;
    try
    {
        pageID = (AdminPanelPages)Convert.ToInt32(Context.Request.Query["pageID"]);
        pageID = DataCheck.HasAccessTo(pageID, user, Context) == false ? AdminPanelPages.MainPage : pageID;
    }
    catch
    {
        pageID = AdminPanelPages.MainPage;
    }

    Dictionary<AdminPanelPages, string> pages = new Dictionary<AdminPanelPages, string>();
    if (DataCheck.HasAccessTo(AdminPanelPages.MainPage, user, Context))
    {
        pages.Add(AdminPanelPages.MainPage, localization.MainPage);
    }
    if (DataCheck.HasAccessTo(AdminPanelPages.Pages, user, Context))
    {
        pages.Add(AdminPanelPages.Pages, localization.Pages);
    }
    if (DataCheck.HasAccessTo(AdminPanelPages.Pages, user, Context))
    {
        pages.Add(AdminPanelPages.Templates, localization.Templates);
    }
    if (DataCheck.HasAccessTo(AdminPanelPages.Settings, user, Context))
    {
        pages.Add(AdminPanelPages.Settings, localization.Settings);
    }

#line default
#line hidden
            BeginContext(1128, 25, true);
            WriteLiteral("<!doctype html>\r\n<html>\r\n");
            EndContext();
            BeginContext(1153, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8dc0e2a96f6435db9d9906ec055d2a4", async() => {
                BeginContext(1159, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(1173, 28, false);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
      Write(Html.Raw(localization.Title));

#line default
#line hidden
                EndContext();
                BeginContext(1201, 44, true);
                WriteLiteral("</title>\r\n    <meta charset=\"utf-8\" />\r\n    ");
                EndContext();
                BeginContext(1245, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb0ff08a0970445e936170e5d4213371", async() => {
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
                EndContext();
                BeginContext(1325, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1331, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "06f0859edb964f28b893922b3fdd3a76", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1416, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
     if (Context.Items["PageStyle"] != null)
    {

#line default
#line hidden
                BeginContext(1471, 46, true);
                WriteLiteral("        <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1517, "\"", 1561, 1);
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
WriteAttributeValue("", 1524, Html.Raw(Context.Items["PageStyle"]), 1524, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1562, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 43 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
    }

#line default
#line hidden
                BeginContext(1574, 57, true);
                WriteLiteral("    <meta name=\"viewport\" content=\"width=device-width\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1638, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1640, 605, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75315317d6343ae902c12d2a1f840f2", async() => {
                BeginContext(1646, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1653, 23, false);
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
Write(Context.Items["Routes"]);

#line default
#line hidden
                EndContext();
                BeginContext(1676, 69, true);
                WriteLiteral("\r\n    <div class=\"commonContainer\">\r\n        <ul class=\"menuBlock\">\r\n");
                EndContext();
#line 50 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
             foreach (var p in pages)
            {
                if (pageID == p.Key)
                {

#line default
#line hidden
                BeginContext(1856, 44, true);
                WriteLiteral("                    <li class=\"withPadding\">");
                EndContext();
                BeginContext(1901, 17, false);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                                       Write(Html.Raw(p.Value));

#line default
#line hidden
                EndContext();
                BeginContext(1918, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 55 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1985, 26, true);
                WriteLiteral("                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2011, "\"", 2060, 3);
#line 58 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
WriteAttributeValue("", 2018, Context.Request.Path, 2018, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 2039, "?pageID=", 2039, 8, true);
#line 58 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
WriteAttributeValue("", 2047, (int)p.Key, 2047, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2061, 21, true);
                WriteLiteral(" class=\"withPadding\">");
                EndContext();
                BeginContext(2083, 17, false);
#line 58 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                                                                                            Write(Html.Raw(p.Value));

#line default
#line hidden
                EndContext();
                BeginContext(2100, 11, true);
                WriteLiteral("</a></li>\r\n");
                EndContext();
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(2145, 46, true);
                WriteLiteral("        </ul>\r\n        <content>\r\n            ");
                EndContext();
                BeginContext(2192, 12, false);
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2204, 34, true);
                WriteLiteral("\r\n        </content>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2245, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAdminPanelPageLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
