#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d87690f8e3bc731f5415cd0156cfcccf8582da2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d87690f8e3bc731f5415cd0156cfcccf8582da2", @"/Views/AdminPanel/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Pages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsualPage[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/pages/index.css";
    Context.Items["PageName"] = localization.Pages_PageName;
    User user = Context.Items["User"] as User;

#line default
#line hidden
            BeginContext(279, 215, true);
            WriteLiteral("<script src=\"/scripts/admin_panel/send_data.js\"></script>\r\n            <script>\r\n                function responseHandler(request) {\r\n                    if (request.status == 200) {\r\n                        alert(\'");
            EndContext();
            BeginContext(495, 34, false);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                          Write(Html.Raw(localization.PageDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(529, 158, true);
            WriteLiteral("\');\r\n                        location.reload();\r\n                    }\r\n                    else if (request.status == 404) {\r\n                        alert(\'");
            EndContext();
            BeginContext(688, 35, false);
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                          Write(Html.Raw(localization.PageNotFound));

#line default
#line hidden
            EndContext();
            BeginContext(723, 70, true);
            WriteLiteral("\');\r\n                    }\r\n                }\r\n            </script>\r\n");
            EndContext();
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddPage, user, Context))
{

#line default
#line hidden
            BeginContext(873, 61, true);
            WriteLiteral("            <div class=\"add-page-button\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 934, "\"", 1001, 3);
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 941, Context.Request.Path, 941, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 962, "?pageID=", 962, 8, true);
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 970, (int)AdminPanelPages.AddPage, 970, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1002, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1004, 30, false);
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                                                                                  Write(Html.Raw(localization.AddPage));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 26, true);
            WriteLiteral("</a>\r\n            </div>\r\n");
            EndContext();
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1063, 100, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td>ID</td>\r\n                    <td>");
            EndContext();
            BeginContext(1164, 27, false);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 65, true);
            WriteLiteral("</td>\r\n                    <td>URL</td>\r\n                    <td>");
            EndContext();
            BeginContext(1257, 38, false);
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(localization.ActionsWithPage));

#line default
#line hidden
            EndContext();
            BeginContext(1295, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(1363, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1410, 14, false);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(p.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1456, 20, false);
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(p.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1508, 23, false);
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                   Write(Html.Raw(p.RequestPath));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 41 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditPage, user, Context))
                {

#line default
#line hidden
            BeginContext(1677, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1784, "\"", 1824, 1);
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 1792, (int)AdminPanelPages.EditPage, 1792, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1825, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1892, "\"", 1905, 1);
#line 45 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 1900, p.ID, 1900, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1906, 73, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"action-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1979, "\"", 2019, 1);
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 1987, Html.Raw(localization.EditPage), 1987, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2020, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 48 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2077, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 49 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeletePage, user, Context))
                {

#line default
#line hidden
            BeginContext(2192, 17, true);
            WriteLiteral("            <form");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2209, "\"", 2231, 2);
            WriteAttributeValue("", 2214, "delete-page-", 2214, 12, true);
#line 51 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2226, p.ID, 2226, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2232, 65, true);
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2297, "\"", 2339, 1);
#line 52 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2305, (int)AdminPanelPages.DeletePage, 2305, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2340, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2407, "\"", 2420, 1);
#line 53 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2415, p.ID, 2415, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2421, 37, true);
            WriteLiteral(">\r\n                            <input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2458, "\"", 2487, 2);
            WriteAttributeValue("", 2463, "delete-page-button-", 2463, 19, true);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2482, p.ID, 2482, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2488, 36, true);
            WriteLiteral(" type=\"submit\" class=\"action-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2524, "\"", 2566, 1);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
WriteAttributeValue("", 2532, Html.Raw(localization.DeletePage), 2532, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2567, 144, true);
            WriteLiteral(" />\r\n                        </form>\r\n                        <script>\r\n                            document.getElementById(\'delete-page-button-");
            EndContext();
            BeginContext(2712, 4, false);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                                                                   Write(p.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2716, 79, true);
            WriteLiteral("\').addEventListener(\'click\', createSendDataEventHandler(\'DELETE\', \'delete-page-");
            EndContext();
            BeginContext(2796, 4, false);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                                                                                                                                                       Write(p.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2800, 58, true);
            WriteLiteral("\', responseHandler));\r\n                        </script>\r\n");
            EndContext();
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2877, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 62 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2934, 20, true);
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
