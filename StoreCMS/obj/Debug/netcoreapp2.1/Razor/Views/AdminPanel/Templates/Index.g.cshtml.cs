#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d09c7c6b560b011f47bd5c4290fd496ecc3638ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Templates_Index), @"mvc.1.0.view", @"/Views/AdminPanel/Templates/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Templates/Index.cshtml", typeof(AspNetCore.Views_AdminPanel_Templates_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09c7c6b560b011f47bd5c4290fd496ecc3638ab", @"/Views/AdminPanel/Templates/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Templates_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Template>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/templates/index.css";
    User user = Context.Items["User"] as User;

#line default
#line hidden
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
 if (DataCheck.HasAccessTo(AdminPanelPages.AddTemplate, user, Context))
{

#line default
#line hidden
            BeginContext(304, 37, true);
            WriteLiteral("    <div class=\"addTemplateButton\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 341, "\"", 412, 3);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
WriteAttributeValue("", 348, Context.Request.Path, 348, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 369, "?pageID=", 369, 8, true);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
WriteAttributeValue("", 377, (int)AdminPanelPages.AddTemplate, 377, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(413, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(415, 34, false);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
                                                                                                         Write(Html.Raw(localization.AddTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(449, 12, true);
            WriteLiteral("</a></div>\r\n");
            EndContext();
#line 11 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
}

#line default
#line hidden
            BeginContext(464, 74, true);
            WriteLiteral("<table class=\"templatesList\">\r\n    <tr>\r\n        <td>ID</td>\r\n        <td>");
            EndContext();
            BeginContext(539, 27, false);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
       Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(566, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(586, 30, false);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
       Write(Html.Raw(localization.Actions));

#line default
#line hidden
            EndContext();
            BeginContext(616, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
     foreach (var t in Model)
    {

#line default
#line hidden
            BeginContext(672, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(703, 14, false);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
           Write(Html.Raw(t.ID));

#line default
#line hidden
            EndContext();
            BeginContext(717, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(741, 16, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
           Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(757, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
                 if (DataCheck.HasAccessTo(AdminPanelPages.EditTemplate, user, Context))
                {

#line default
#line hidden
            BeginContext(891, 99, true);
            WriteLiteral("                    <form method=\"get\">\r\n                        <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 990, "\"", 1034, 1);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
WriteAttributeValue("", 998, (int)AdminPanelPages.EditTemplate, 998, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1035, 63, true);
            WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1098, "\"", 1111, 1);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
WriteAttributeValue("", 1106, t.ID, 1106, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1112, 68, true);
            WriteLiteral(">\r\n                        <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1180, "\"", 1224, 1);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
WriteAttributeValue("", 1188, Html.Raw(localization.EditTemplate), 1188, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1225, 34, true);
            WriteLiteral(" />\r\n                    </form>\r\n");
            EndContext();
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1278, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
                 if (DataCheck.HasAccessTo(AdminPanelPages.DeleteTemplate, user, Context))
                {

#line default
#line hidden
            BeginContext(1389, 100, true);
            WriteLiteral("                    <form method=\"post\">\r\n                        <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1489, "\"", 1535, 1);
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
WriteAttributeValue("", 1497, (int)AdminPanelPages.DeleteTemplate, 1497, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1536, 63, true);
            WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1599, "\"", 1612, 1);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
WriteAttributeValue("", 1607, t.ID, 1607, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1613, 68, true);
            WriteLiteral(">\r\n                        <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1681, "\"", 1727, 1);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
WriteAttributeValue("", 1689, Html.Raw(localization.DeleteTemplate), 1689, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1728, 34, true);
            WriteLiteral(" />\r\n                    </form>\r\n");
            EndContext();
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1781, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1822, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Template>> Html { get; private set; }
    }
}
#pragma warning restore 1591
