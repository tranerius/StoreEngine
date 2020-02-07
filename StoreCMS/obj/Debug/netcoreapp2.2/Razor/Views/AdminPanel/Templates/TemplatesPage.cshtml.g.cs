#pragma checksum "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8be7a91a120b7b8e41d287e4658be30998ce5fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Templates_TemplatesPage), @"mvc.1.0.view", @"/Views/AdminPanel/Templates/TemplatesPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Templates/TemplatesPage.cshtml", typeof(AspNetCore.Views_AdminPanel_Templates_TemplatesPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8be7a91a120b7b8e41d287e4658be30998ce5fd", @"/Views/AdminPanel/Templates/TemplatesPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Templates_TemplatesPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Template[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/templates/index.css";
    Context.Items["PageName"] = localization.TemplatesPageName;
    User user = Context.Items["User"] as User;

#line default
#line hidden
            BeginContext(289, 144, true);
            WriteLiteral("<script>\r\n                function responseHandler(request) {\r\n                    if (request.status == 200) {\r\n                        alert(\'");
            EndContext();
            BeginContext(434, 38, false);
#line 12 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                          Write(Html.Raw(localization.TemplateDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(472, 158, true);
            WriteLiteral("\');\r\n                        location.reload();\r\n                    }\r\n                    else if (request.status == 404) {\r\n                        alert(\'");
            EndContext();
            BeginContext(631, 39, false);
#line 16 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                          Write(Html.Raw(localization.TemplateNotFound));

#line default
#line hidden
            EndContext();
            BeginContext(670, 70, true);
            WriteLiteral("\');\r\n                    }\r\n                }\r\n            </script>\r\n");
            EndContext();
#line 20 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddTemplate, user, Context))
{

#line default
#line hidden
            BeginContext(824, 47, true);
            WriteLiteral("            <div class=\"add-template-button\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 871, "\"", 942, 3);
#line 22 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 878, Context.Request.Path, 878, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 899, "?pageID=", 899, 8, true);
#line 22 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 907, (int)AdminPanelPages.AddTemplate, 907, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(943, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(945, 34, false);
#line 22 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                                                                                                                   Write(Html.Raw(localization.AddTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(979, 12, true);
            WriteLiteral("</a></div>\r\n");
            EndContext();
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
}

#line default
#line hidden
            BeginContext(994, 100, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td>ID</td>\r\n                    <td>");
            EndContext();
            BeginContext(1095, 35, false);
#line 27 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                   Write(Html.Raw(localization.TemplateName));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1162, 30, false);
#line 28 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                   Write(Html.Raw(localization.Actions));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 30 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
             foreach (var t in Model)
            {

#line default
#line hidden
            BeginContext(1276, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1323, 14, false);
#line 33 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                   Write(Html.Raw(t.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1369, 16, false);
#line 34 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                   Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 36 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                     if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditTemplate, user, Context))
                    {

#line default
#line hidden
            BeginContext(1543, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1650, "\"", 1694, 1);
#line 39 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 1658, (int)AdminPanelPages.EditTemplate, 1658, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1695, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1762, "\"", 1775, 1);
#line 40 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 1770, t.ID, 1770, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1776, 73, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"action-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1849, "\"", 1893, 1);
#line 41 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 1857, Html.Raw(localization.EditTemplate), 1857, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1894, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 43 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(1955, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 44 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                     if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteTemplate, user, Context))
                    {

#line default
#line hidden
            BeginContext(2082, 13, true);
            WriteLiteral("        <form");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2095, "\"", 2121, 2);
            WriteAttributeValue("", 2100, "delete-template-", 2100, 16, true);
#line 46 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 2116, t.ID, 2116, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2122, 65, true);
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2187, "\"", 2233, 1);
#line 47 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 2195, (int)AdminPanelPages.DeleteTemplate, 2195, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2234, 65, true);
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2299, "\"", 2312, 1);
#line 48 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 2307, t.ID, 2307, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2313, 37, true);
            WriteLiteral(">\r\n                            <input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2350, "\"", 2374, 2);
            WriteAttributeValue("", 2355, "delete-button-", 2355, 14, true);
#line 49 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 2369, t.ID, 2369, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2375, 36, true);
            WriteLiteral(" type=\"submit\" class=\"action-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2411, "\"", 2457, 1);
#line 49 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 2419, Html.Raw(localization.DeleteTemplate), 2419, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2458, 139, true);
            WriteLiteral(" />\r\n                        </form>\r\n                        <script>\r\n                            document.getElementById(\'delete-button-");
            EndContext();
            BeginContext(2598, 4, false);
#line 52 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                                                              Write(t.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2602, 83, true);
            WriteLiteral("\').addEventListener(\'click\', createSendDataEventHandler(\'DELETE\', \'delete-template-");
            EndContext();
            BeginContext(2686, 4, false);
#line 52 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                                                                                                                                                      Write(t.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2690, 59, true);
            WriteLiteral("\', responseHandler ));\r\n                        </script>\r\n");
            EndContext();
#line 54 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(2772, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 57 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
            }

#line default
#line hidden
            BeginContext(2837, 20, true);
            WriteLiteral("            </table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITemplatesLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Template[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
