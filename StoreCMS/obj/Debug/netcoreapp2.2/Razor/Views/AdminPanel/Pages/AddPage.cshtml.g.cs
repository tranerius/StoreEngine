#pragma checksum "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f7a565839fb118184150748b651b845d09f0b0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Pages_AddPage), @"mvc.1.0.view", @"/Views/AdminPanel/Pages/AddPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Pages/AddPage.cshtml", typeof(AspNetCore.Views_AdminPanel_Pages_AddPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7a565839fb118184150748b651b845d09f0b0d", @"/Views/AdminPanel/Pages/AddPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Pages_AddPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/pages/work_with_page.css";
    Context.Items["PageName"] = localization.AddPage_PageName;
    User user = Context.Items["User"] as User;
    UsualPage[] pages = Context.Items["UsualPages"] as UsualPage[];
    Template[] templates = Context.Items["Templates"] as Template[];

#line default
#line hidden
            BeginContext(433, 251, true);
            WriteLiteral("<script src=\"/scripts/admin_panel/insert_tab.js\"></script>\r\n            <script src=\"/scripts/admin_panel/checkbox_event_handler.js\"></script>\r\n            <form id=\"add-page\" class=\"page-container\">\r\n                <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 684, "\"", 723, 1);
#line 14 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
WriteAttributeValue("", 692, (int)AdminPanelPages.AddPage, 692, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(724, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(760, 52, true);
            WriteLiteral("                <input id=\"add-button\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 812, "\"", 854, 1);
#line 16 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
WriteAttributeValue("", 820, Html.Raw(localization.SaveButton), 820, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(855, 89, true);
            WriteLiteral(" />\r\n                <div class=\"blocks\">\r\n                    <div class=\"left-block\">\r\n");
            EndContext();
            BeginContext(979, 43, true);
            WriteLiteral("                        <label for=\"Title\">");
            EndContext();
            BeginContext(1023, 28, false);
#line 20 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                      Write(Html.Raw(localization.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 101, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"Title\" name=\"PageModel.Title\" required />\r\n");
            EndContext();
            BeginContext(1192, 46, true);
            WriteLiteral("                        <label for=\"PageName\">");
            EndContext();
            BeginContext(1239, 33, false);
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                         Write(Html.Raw(localization.Breadcrumb));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 107, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"PageName\" name=\"PageModel.PageName\" required />\r\n");
            EndContext();
            BeginContext(1425, 53, true);
            WriteLiteral("                        <label for=\"PageDescription\">");
            EndContext();
            BeginContext(1479, 38, false);
#line 26 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                                Write(Html.Raw(localization.PageDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 125, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageDescription\" name=\"PageModel.PageDescription\" maxlength=\"160\">\r\n");
            EndContext();
            BeginContext(1685, 50, true);
            WriteLiteral("                        <label for=\"PageKeywords\">");
            EndContext();
            BeginContext(1736, 35, false);
#line 29 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                             Write(Html.Raw(localization.PageKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 180, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageKeywords\" name=\"PageModel.PageKeywords\" />\r\n                    </div>\r\n                    <div class=\"right-block\">\r\n");
            EndContext();
            BeginContext(1995, 48, true);
            WriteLiteral("                        <label for=\"TemplateId\">");
            EndContext();
            BeginContext(2044, 31, false);
#line 34 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                           Write(Html.Raw(localization.Template));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 133, true);
            WriteLiteral("</label>\r\n                        <select id=\"TemplateId\" name=\"PageModel.TemplateId\">\r\n                            <option selected>");
            EndContext();
            BeginContext(2209, 38, false);
#line 36 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                        Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2247, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 37 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                             foreach (var t in templates)
                            {

#line default
#line hidden
            BeginContext(2348, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2383, "\"", 2396, 1);
#line 39 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
WriteAttributeValue("", 2391, t.ID, 2391, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2397, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2399, 16, false);
#line 39 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                             Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2415, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 40 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                            }

#line default
#line hidden
            BeginContext(2457, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(2535, 50, true);
            WriteLiteral("                        <label for=\"PreviousPage\">");
            EndContext();
            BeginContext(2586, 35, false);
#line 43 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                             Write(Html.Raw(localization.PreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(2621, 139, true);
            WriteLiteral("</label>\r\n                        <select id=\"PreviousPage\" name=\"PageModel.PreviousPageID\">\r\n                            <option selected>");
            EndContext();
            BeginContext(2761, 42, false);
#line 45 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                        Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(2803, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 46 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                         foreach (var p in pages)
                        {

#line default
#line hidden
            BeginContext(2892, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2927, "\"", 2940, 1);
#line 48 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
WriteAttributeValue("", 2935, p.ID, 2935, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2941, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2943, 20, false);
#line 48 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                             Write(Html.Raw(p.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(2963, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 49 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                        }

#line default
#line hidden
            BeginContext(3001, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(3071, 43, true);
            WriteLiteral("                        <label for=\"Alias\">");
            EndContext();
            BeginContext(3115, 28, false);
#line 52 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                      Write(Html.Raw(localization.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(3143, 91, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"Alias\" name=\"PageModel.Alias\" />\r\n");
            EndContext();
#line 55 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                         if (!PagesManagementFunctions.HasMainPage(db))
                        {

#line default
#line hidden
            BeginContext(3377, 494, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""IsMainPage"" name=""PageModel.IsMainPage"" value=""false"" />
                            <script>
                                let isMainPageCheckbox = document.getElementById('IsMainPage');
                                isMainPageCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsMainPage"">");
            EndContext();
            BeginContext(3872, 33, false);
#line 63 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                               Write(Html.Raw(localization.IsMainPage));

#line default
#line hidden
            EndContext();
            BeginContext(3905, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
#line 65 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(4014, 495, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""Published"" name=""PageModel.Published"" value=""true"" checked />
                            <script>
                                let publishedCheckbox = document.getElementById('Published');
                                publishedCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""Published"">");
            EndContext();
            BeginContext(4510, 32, false);
#line 73 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                              Write(Html.Raw(localization.Published));

#line default
#line hidden
            EndContext();
            BeginContext(4542, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(4623, 483, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""IsIndex"" name=""PageModel.IsIndex"" value=""true"" checked />
                            <script>
                                let isIndexCheckbox = document.getElementById('IsIndex');
                                isIndexCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsIndex"">");
            EndContext();
            BeginContext(5107, 30, false);
#line 82 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                            Write(Html.Raw(localization.IsIndex));

#line default
#line hidden
            EndContext();
            BeginContext(5137, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(5219, 489, true);
            WriteLiteral(@"                        <div class=""checkbox-block"">
                            <input type=""checkbox"" id=""IsFollow"" name=""PageModel.IsFollow"" value=""true"" checked />
                            <script>
                                let isFollowCheckbox = document.getElementById('IsFollow');
                                isFollowCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsFollow"">");
            EndContext();
            BeginContext(5709, 31, false);
#line 91 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                             Write(Html.Raw(localization.IsFollow));

#line default
#line hidden
            EndContext();
            BeginContext(5740, 94, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(5863, 37, true);
            WriteLiteral("                <label for=\"Content\">");
            EndContext();
            BeginContext(5901, 30, false);
#line 96 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                Write(Html.Raw(localization.Content));

#line default
#line hidden
            EndContext();
            BeginContext(5931, 633, true);
            WriteLiteral(@"</label>
                <textarea id=""Content"" name=""PageModel.Content""></textarea>
            </form>
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
            BeginContext(6565, 37, false);
#line 107 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                              Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(6602, 170, true);
            WriteLiteral("\';\r\n                }\r\n                function responseHandler(request, formElement) {\r\n                    if (request.status == 201) {\r\n                        alert(\'");
            EndContext();
            BeginContext(6773, 32, false);
#line 111 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                          Write(Html.Raw(localization.PageAdded));

#line default
#line hidden
            EndContext();
            BeginContext(6805, 5, true);
            WriteLiteral("\');\r\n");
            EndContext();
#line 112 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                         if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditPage, user, Context))
                        {

#line default
#line hidden
            BeginContext(6939, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(6965, 58, true);
            WriteLiteral("location.replace(request.getResponseHeader(\'location\'));\r\n");
            EndContext();
#line 115 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(7107, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(7133, 64, true);
            WriteLiteral("location.replace(location.origin + location.pathname + \'?pageID=");
            EndContext();
            BeginContext(7199, 26, false);
#line 118 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                                                                                      Write((int)AdminPanelPages.Pages);

#line default
#line hidden
            EndContext();
            BeginContext(7226, 5, true);
            WriteLiteral("\');\r\n");
            EndContext();
#line 119 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\AddPage.cshtml"
                        }

#line default
#line hidden
            BeginContext(7258, 458, true);
            WriteLiteral(@"                    }
                    else if (request.status == 422) {
                        errorHandler(formElement);
                    }
                }
                document.getElementById('add-button').addEventListener('click', createSendDataEventHandler('POST', 'add-page', responseHandler, errorHandler));
                document.getElementById('Content').addEventListener('keydown', insertTabEventHandler);
            </script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CMSDatabase db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPagesLocalization localization { get; private set; }
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
