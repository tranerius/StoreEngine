#pragma checksum "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\LoginForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96ebf652ab877258d48d850acf1e791e20ddac11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_LoginForm), @"mvc.1.0.view", @"/Views/AdminPanel/LoginForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/LoginForm.cshtml", typeof(AspNetCore.Views_AdminPanel_LoginForm))]
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
#line 1 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Security;

#line default
#line hidden
#line 2 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Localization;

#line default
#line hidden
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.PagesManagement;

#line default
#line hidden
#line 4 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.AdminPanelTypes;

#line default
#line hidden
#line 5 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 6 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ebf652ab877258d48d850acf1e791e20ddac11", @"/Views/AdminPanel/LoginForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_LoginForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(45, 25, true);
            WriteLiteral("<!doctype html>\r\n<html>\r\n");
            EndContext();
            BeginContext(70, 269, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96ebf652ab877258d48d850acf1e791e20ddac114092", async() => {
                BeginContext(76, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(90, 28, false);
#line 5 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\LoginForm.cshtml"
      Write(Html.Raw(localization.Title));

#line default
#line hidden
                EndContext();
                BeginContext(118, 214, true);
                WriteLiteral("</title>\r\n    <meta charset=\"utf-8\" />\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/styles/admin_panel/common.css\" />\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/styles/admin_panel/login_form.css\" />\r\n");
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
            BeginContext(339, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(341, 1651, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96ebf652ab877258d48d850acf1e791e20ddac115879", async() => {
                BeginContext(347, 97, true);
                WriteLiteral("\r\n    <form id=\"login-form\" class=\"login-form-block\">\r\n        <input type=\"hidden\" name=\"pageID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 444, "\"", 485, 1);
#line 12 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\LoginForm.cshtml"
WriteAttributeValue("", 452, (int)AdminPanelPages.LoginForm, 452, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(486, 30, true);
                WriteLiteral(">\r\n        <label for=\"Login\">");
                EndContext();
                BeginContext(517, 31, false);
#line 13 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\LoginForm.cshtml"
                      Write(Html.Raw(localization.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(548, 79, true);
                WriteLiteral("</label>\r\n        <input type=\"text\" id=\"Login\" name=\"Login\" autocomplete=\"off\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 627, "\"", 648, 1);
#line 14 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\LoginForm.cshtml"
WriteAttributeValue("", 635, Model?.Login, 635, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(649, 42, true);
                WriteLiteral(" required>\r\n        <label for=\"Password\">");
                EndContext();
                BeginContext(692, 31, false);
#line 15 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\LoginForm.cshtml"
                         Write(Html.Raw(localization.Password));

#line default
#line hidden
                EndContext();
                BeginContext(723, 70, true);
                WriteLiteral("</label>\r\n        <input type=\"password\" id=\"Password\" name=\"Password\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 793, "\"", 817, 1);
#line 16 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\LoginForm.cshtml"
WriteAttributeValue("", 801, Model?.Password, 801, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(818, 59, true);
                WriteLiteral(" required>\r\n        <input type=\"submit\" id=\"submit-button\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 877, "\"", 914, 1);
#line 17 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\LoginForm.cshtml"
WriteAttributeValue("", 885, Html.Raw(localization.Enter), 885, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(915, 534, true);
                WriteLiteral(@" />
    </form>
    <script src=""/scripts/admin_panel/send_data.js""></script>
    <script>
        function errorHandler(formElement) {
            let errorMsgElement = document.getElementById('error-msg');
            if (errorMsgElement === null) {
                errorMsgElement = document.createElement('span');
                errorMsgElement.setAttribute('id', 'error-msg');
                formElement.insertBefore(errorMsgElement, formElement.firstChild);
            }
            errorMsgElement.textContent = '");
                EndContext();
                BeginContext(1450, 37, false);
#line 28 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\LoginForm.cshtml"
                                      Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
                EndContext();
                BeginContext(1487, 498, true);
                WriteLiteral(@"';
        }
        function responseHandler(request, formElement) {
            if (request.status == 200) {
                location.reload();
            }
            else if (request.status == 401) {
                errorHandler(formElement);
            }
        }
        let submitButton = document.getElementById('submit-button');
        submitButton.addEventListener('click', createSendDataEventHandler('POST', 'login-form', responseHandler, errorHandler));
    </script>
");
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
            BeginContext(1992, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILoginFormLocalization localization { get; private set; }
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
