#pragma checksum "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8df13aa4ba06061c0a8a3633e4867489a3a949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Pages_Index), @"mvc.1.0.view", @"/Views/AdminPanel/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Pages/Index.cshtml", typeof(AspNetCore.Views_AdminPanel_Pages_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8df13aa4ba06061c0a8a3633e4867489a3a949", @"/Views/AdminPanel/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Pages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsualPage[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/pages/index.css";
    Context.Items["PageName"] = localization.Pages_PageName;
    User user = Context.Items["User"] as User;

#line default
#line hidden
            BeginContext(279, 144, true);
            WriteLiteral("<script>\r\n                function responseHandler(request) {\r\n                    if (request.status == 200) {\r\n                        alert(\'");
            EndContext();
            BeginContext(424, 34, false);
#line 12 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                          Write(Html.Raw(localization.PageDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(458, 158, true);
            WriteLiteral("\');\r\n                        location.reload();\r\n                    }\r\n                    else if (request.status == 404) {\r\n                        alert(\'");
            EndContext();
            BeginContext(617, 35, false);
#line 16 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                          Write(Html.Raw(localization.PageNotFound));

#line default
#line hidden
            EndContext();
            BeginContext(652, 70, true);
            WriteLiteral("\');\r\n                    }\r\n                }\r\n            </script>\r\n");
            EndContext();
#line 20 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddPage, user, Context))
{

#line default
#line hidden
            BeginContext(802, 61, true);
            WriteLiteral("            <div class=\"add-page-button\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 863, "\"", 930, 3);
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 870, Context.Request.Path, 870, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 891, "?pageID=", 891, 8, true);
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 899, (int)AdminPanelPages.AddPage, 899, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(931, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(933, 30, false);
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                                                                                  Write(Html.Raw(localization.AddPage));

#line default
#line hidden
            EndContext();
            BeginContext(963, 26, true);
            WriteLiteral("</a>\r\n            </div>\r\n");
            EndContext();
#line 25 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
}

#line default
#line hidden
            BeginContext(992, 100, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td>ID</td>\r\n                    <td>");
            EndContext();
            BeginContext(1093, 27, false);
#line 29 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 65, true);
            WriteLiteral("</td>\r\n                    <td>URL</td>\r\n                    <td>");
            EndContext();
            BeginContext(1186, 38, false);
#line 31 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(localization.ActionsWithPage));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 33 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(1292, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1339, 14, false);
#line 36 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(p.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1385, 20, false);
#line 37 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(p.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1437, 23, false);
#line 38 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(p.RequestPath));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 40 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditPage, user, Context))
                {

#line default
#line hidden
            BeginContext(1606, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1713, "\"", 1753, 1);
#line 43 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 1721, (int)AdminPanelPages.EditPage, 1721, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1754, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1821, "\"", 1834, 1);
#line 44 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 1829, p.ID, 1829, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1835, 73, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"action-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1908, "\"", 1948, 1);
#line 45 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 1916, Html.Raw(localization.EditPage), 1916, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1949, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 47 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2006, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 48 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeletePage, user, Context))
                {

#line default
#line hidden
            BeginContext(2121, 17, true);
            WriteLiteral("            <form");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2138, "\"", 2160, 2);
            WriteAttributeValue("", 2143, "delete-page-", 2143, 12, true);
#line 50 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2155, p.ID, 2155, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2161, 65, true);
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2226, "\"", 2268, 1);
#line 51 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2234, (int)AdminPanelPages.DeletePage, 2234, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2269, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2336, "\"", 2349, 1);
#line 52 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2344, p.ID, 2344, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2350, 37, true);
            WriteLiteral(">\r\n                            <input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2387, "\"", 2416, 2);
            WriteAttributeValue("", 2392, "delete-page-button-", 2392, 19, true);
#line 53 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2411, p.ID, 2411, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2417, 36, true);
            WriteLiteral(" type=\"submit\" class=\"action-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2453, "\"", 2495, 1);
#line 53 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2461, Html.Raw(localization.DeletePage), 2461, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2496, 144, true);
            WriteLiteral(" />\r\n                        </form>\r\n                        <script>\r\n                            document.getElementById(\'delete-page-button-");
            EndContext();
            BeginContext(2641, 4, false);
#line 56 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                                                                   Write(p.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2645, 79, true);
            WriteLiteral("\').addEventListener(\'click\', createSendDataEventHandler(\'DELETE\', \'delete-page-");
            EndContext();
            BeginContext(2725, 4, false);
#line 56 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                                                                                                                                                       Write(p.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2729, 58, true);
            WriteLiteral("\', responseHandler));\r\n                        </script>\r\n");
            EndContext();
#line 58 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2806, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 61 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2863, 20, true);
            WriteLiteral("            </table>");
            EndContext();
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsualPage[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
