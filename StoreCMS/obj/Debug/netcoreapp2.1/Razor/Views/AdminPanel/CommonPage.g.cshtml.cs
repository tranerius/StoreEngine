#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb6a823159278389785ac864e59fe2bd9c084382"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6a823159278389785ac864e59fe2bd9c084382", @"/Views/AdminPanel/CommonPage.cshtml")]
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
    if (DataCheck.HasAccessTo(AdminPanelPages.Categories, user, Context))
    {
        pages.Add(AdminPanelPages.Categories, localization.CategoriesAndProducts);
    }
    if (DataCheck.HasAccessTo(AdminPanelPages.Templates, user, Context))
    {
        pages.Add(AdminPanelPages.Templates, localization.Templates);
    }
    if (DataCheck.HasAccessTo(AdminPanelPages.Chunks, user, Context))
    {
        pages.Add(AdminPanelPages.Chunks, localization.TemplateChunks);
    }
    if(DataCheck.HasAccessTo(AdminPanelPages.Files, user, Context))
    {
        pages.Add(AdminPanelPages.Files, localization.Files);
    }
    if (DataCheck.HasAccessTo(AdminPanelPages.Settings, user, Context))
    {
        pages.Add(AdminPanelPages.Settings, localization.Settings);
    }

#line default
#line hidden
            BeginContext(1609, 25, true);
            WriteLiteral("<!doctype html>\r\n<html>\r\n");
            EndContext();
            BeginContext(1634, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b314995e442b4c549cc43b111e50ba12", async() => {
                BeginContext(1640, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(1654, 28, false);
#line 48 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
      Write(Html.Raw(localization.Title));

#line default
#line hidden
                EndContext();
                BeginContext(1682, 44, true);
                WriteLiteral("</title>\r\n    <meta charset=\"utf-8\" />\r\n    ");
                EndContext();
                BeginContext(1726, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "346cadfb568b4e16afda373df0f157b6", async() => {
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
                BeginContext(1806, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1812, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6398b88d332545189a61fe8ff3d142c1", async() => {
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
                BeginContext(1897, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
     if (Context.Items["PageStyle"] != null)
    {

#line default
#line hidden
                BeginContext(1952, 46, true);
                WriteLiteral("        <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1998, "\"", 2042, 1);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
WriteAttributeValue("", 2005, Html.Raw(Context.Items["PageStyle"]), 2005, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2043, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 55 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
    }

#line default
#line hidden
                BeginContext(2055, 57, true);
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
            BeginContext(2119, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2121, 563, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88593d8976ab43cf90789b0606a49541", async() => {
                BeginContext(2127, 69, true);
                WriteLiteral("\r\n    <div class=\"commonContainer\">\r\n        <ul class=\"menuBlock\">\r\n");
                EndContext();
#line 61 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
             foreach (var p in pages)
            {
                if (pageID == p.Key)
                {

#line default
#line hidden
                BeginContext(2307, 44, true);
                WriteLiteral("                    <li class=\"withPadding\">");
                EndContext();
                BeginContext(2352, 17, false);
#line 65 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                                       Write(Html.Raw(p.Value));

#line default
#line hidden
                EndContext();
                BeginContext(2369, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 66 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(2436, 26, true);
                WriteLiteral("                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2462, "\"", 2511, 3);
#line 69 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
WriteAttributeValue("", 2469, Context.Request.Path, 2469, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 2490, "?pageID=", 2490, 8, true);
#line 69 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
WriteAttributeValue("", 2498, (int)p.Key, 2498, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2512, 21, true);
                WriteLiteral(" class=\"withPadding\">");
                EndContext();
                BeginContext(2534, 17, false);
#line 69 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                                                                                            Write(Html.Raw(p.Value));

#line default
#line hidden
                EndContext();
                BeginContext(2551, 11, true);
                WriteLiteral("</a></li>\r\n");
                EndContext();
#line 70 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(2596, 34, true);
                WriteLiteral("        </ul>\r\n        <content>\r\n");
                EndContext();
                BeginContext(2631, 12, false);
#line 74 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2643, 34, true);
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
            BeginContext(2684, 9, true);
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
