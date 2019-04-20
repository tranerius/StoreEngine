#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc9476abbdd9f7fa3dd882e92a773603dedb35f0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc9476abbdd9f7fa3dd882e92a773603dedb35f0", @"/Views/AdminPanel/Templates/TemplatesPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Templates_TemplatesPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Template[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/templates/index.css";
    User user = Context.Items["User"] as User;

#line default
#line hidden
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
 if (DataCheck.HasAccessTo(AdminPanelPages.AddTemplate, user, Context))
{

#line default
#line hidden
            BeginContext(300, 45, true);
            WriteLiteral("            <div class=\"addTemplateButton\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 345, "\"", 416, 3);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 352, Context.Request.Path, 352, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 373, "?pageID=", 373, 8, true);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 381, (int)AdminPanelPages.AddTemplate, 381, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(417, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(419, 34, false);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                                                                                                                 Write(Html.Raw(localization.AddTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(453, 12, true);
            WriteLiteral("</a></div>\r\n");
            EndContext();
#line 11 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
}

#line default
#line hidden
            BeginContext(468, 100, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td>ID</td>\r\n                    <td>");
            EndContext();
            BeginContext(569, 35, false);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                   Write(Html.Raw(localization.TemplateName));

#line default
#line hidden
            EndContext();
            BeginContext(604, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(636, 30, false);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                   Write(Html.Raw(localization.Actions));

#line default
#line hidden
            EndContext();
            BeginContext(666, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
             foreach (var t in Model)
            {

#line default
#line hidden
            BeginContext(750, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(797, 14, false);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                   Write(Html.Raw(t.ID));

#line default
#line hidden
            EndContext();
            BeginContext(811, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(843, 16, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                   Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(859, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                     if (DataCheck.HasAccessTo(AdminPanelPages.EditTemplate, user, Context))
                    {

#line default
#line hidden
            BeginContext(1009, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1116, "\"", 1160, 1);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 1124, (int)AdminPanelPages.EditTemplate, 1124, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1161, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1228, "\"", 1241, 1);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 1236, t.ID, 1236, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1242, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1314, "\"", 1358, 1);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 1322, Html.Raw(localization.EditTemplate), 1322, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1359, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(1420, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                     if (DataCheck.HasAccessTo(AdminPanelPages.DeleteTemplate, user, Context))
                    {

#line default
#line hidden
            BeginContext(1539, 108, true);
            WriteLiteral("                        <form method=\"post\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1647, "\"", 1693, 1);
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 1655, (int)AdminPanelPages.DeleteTemplate, 1655, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1694, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1761, "\"", 1774, 1);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 1769, t.ID, 1769, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1775, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1847, "\"", 1893, 1);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
WriteAttributeValue("", 1855, Html.Raw(localization.DeleteTemplate), 1855, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1894, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(1955, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\TemplatesPage.cshtml"
            }

#line default
#line hidden
            BeginContext(2020, 20, true);
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
