#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e12a64e46464a750c355c3bf523b728863740c3"
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
using Treynessen.Security;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Localization;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.PagesManagement;

#line default
#line hidden
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.AdminPanelTypes;

#line default
#line hidden
#line 5 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e12a64e46464a750c355c3bf523b728863740c3", @"/Views/AdminPanel/CommonPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_CommonPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
  
    User user = Context.Items["User"] as User;
    AdminPanelPages pageID = (AdminPanelPages)Context.Items["pageID"];
    string pageName = Context.Items["PageName"] as string;

    Dictionary<AdminPanelPages, string> pages = new Dictionary<AdminPanelPages, string>();
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.MainPage, user, Context))
    {
        pages.Add(AdminPanelPages.MainPage, localization.MainPage);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.Pages, user, Context))
    {
        pages.Add(AdminPanelPages.Pages, localization.Pages);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.Categories, user, Context))
    {
        pages.Add(AdminPanelPages.Categories, localization.CategoriesAndProducts);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.Redirections, user, Context))
    {
        pages.Add(AdminPanelPages.Redirections, localization.Redirections);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.Templates, user, Context))
    {
        pages.Add(AdminPanelPages.Templates, localization.Templates);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.Chunks, user, Context))
    {
        pages.Add(AdminPanelPages.Chunks, localization.Chunks);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.FileManager, user, Context))
    {
        pages.Add(AdminPanelPages.FileManager, localization.FileManager);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.UserTypes, user, Context))
    {
        pages.Add(AdminPanelPages.UserTypes, localization.UserTypes);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.SynonymsForStrings, user, Context))
    {
        pages.Add(AdminPanelPages.SynonymsForStrings, localization.SynonymsForStrings);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.UserProfile, user, Context))
    {
        pages.Add(AdminPanelPages.UserProfile, localization.UserProfile);
    }
    if (SecurityFunctions.HasAccessTo(AdminPanelPages.Settings, user, Context))
    {
        pages.Add(AdminPanelPages.Settings, localization.Settings);
    }

#line default
#line hidden
            BeginContext(2203, 25, true);
            WriteLiteral("<!doctype html>\r\n<html>\r\n");
            EndContext();
            BeginContext(2228, 540, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb14f79c1c7c4da7823d2996c4d82d44", async() => {
                BeginContext(2234, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(2248, 60, false);
#line 56 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
      Write(Html.Raw(pageName == null ? string.Empty : $"{pageName} - "));

#line default
#line hidden
                EndContext();
                BeginContext(2309, 28, false);
#line 56 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                                                                   Write(Html.Raw(localization.Title));

#line default
#line hidden
                EndContext();
                BeginContext(2337, 215, true);
                WriteLiteral("</title>\r\n    <meta charset=\"utf-8\" />\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/styles/admin_panel/common.css\" />\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/styles/admin_panel/admin_panel.css\" />\r\n");
                EndContext();
#line 60 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
     if (Context.Items["PageStyle"] != null)
    {

#line default
#line hidden
                BeginContext(2605, 42, true);
                WriteLiteral("    <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2647, "\"", 2691, 1);
#line 62 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
WriteAttributeValue("", 2654, Html.Raw(Context.Items["PageStyle"]), 2654, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2692, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
    }

#line default
#line hidden
                BeginContext(2704, 57, true);
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
            BeginContext(2768, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2770, 559, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36406b0c282040b683007175d636b55e", async() => {
                BeginContext(2776, 69, true);
                WriteLiteral("\r\n    <div class=\"commonContainer\">\r\n        <ul class=\"menuBlock\">\r\n");
                EndContext();
#line 69 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
             foreach (var p in pages)
            {
                if (pageID == p.Key)
                {

#line default
#line hidden
                BeginContext(2956, 36, true);
                WriteLiteral("            <li class=\"withPadding\">");
                EndContext();
                BeginContext(2993, 17, false);
#line 73 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                               Write(Html.Raw(p.Value));

#line default
#line hidden
                EndContext();
                BeginContext(3010, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 74 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(3077, 18, true);
                WriteLiteral("            <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3095, "\"", 3144, 3);
#line 77 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
WriteAttributeValue("", 3102, Context.Request.Path, 3102, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 3123, "?pageID=", 3123, 8, true);
#line 77 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
WriteAttributeValue("", 3131, (int)p.Key, 3131, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3145, 21, true);
                WriteLiteral(" class=\"withPadding\">");
                EndContext();
                BeginContext(3167, 17, false);
#line 77 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                                                                                    Write(Html.Raw(p.Value));

#line default
#line hidden
                EndContext();
                BeginContext(3184, 11, true);
                WriteLiteral("</a></li>\r\n");
                EndContext();
#line 78 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(3229, 46, true);
                WriteLiteral("        </ul>\r\n        <content>\r\n            ");
                EndContext();
                BeginContext(3276, 12, false);
#line 82 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CommonPage.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3288, 34, true);
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
            BeginContext(3329, 9, true);
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
