#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b965ddb34f7b5826c5482e1a525975db7ed039d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Templates_ChunksPage), @"mvc.1.0.view", @"/Views/AdminPanel/Templates/ChunksPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Templates/ChunksPage.cshtml", typeof(AspNetCore.Views_AdminPanel_Templates_ChunksPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b965ddb34f7b5826c5482e1a525975db7ed039d", @"/Views/AdminPanel/Templates/ChunksPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Templates_ChunksPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TemplateChunk[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/templates/index.css";
    User user = Context.Items["User"] as User;

#line default
#line hidden
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
 if (DataCheck.HasAccessTo(AdminPanelPages.AddTemplateChunk, user, Context))
{

#line default
#line hidden
            BeginContext(310, 45, true);
            WriteLiteral("            <div class=\"addTemplateButton\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 355, "\"", 431, 3);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 362, Context.Request.Path, 362, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 383, "?pageID=", 383, 8, true);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 391, (int)AdminPanelPages.AddTemplateChunk, 391, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(432, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(434, 39, false);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                                                                                                                      Write(Html.Raw(localization.AddTemplateChunk));

#line default
#line hidden
            EndContext();
            BeginContext(473, 12, true);
            WriteLiteral("</a></div>\r\n");
            EndContext();
#line 11 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
}

#line default
#line hidden
            BeginContext(488, 100, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td>ID</td>\r\n                    <td>");
            EndContext();
            BeginContext(589, 40, false);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                   Write(Html.Raw(localization.TemplateChunkName));

#line default
#line hidden
            EndContext();
            BeginContext(629, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(661, 30, false);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                   Write(Html.Raw(localization.Actions));

#line default
#line hidden
            EndContext();
            BeginContext(691, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
             foreach (var t in Model)
            {

#line default
#line hidden
            BeginContext(775, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(822, 14, false);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                   Write(Html.Raw(t.ID));

#line default
#line hidden
            EndContext();
            BeginContext(836, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(868, 16, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                   Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(884, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                     if (DataCheck.HasAccessTo(AdminPanelPages.EditTemplateChunk, user, Context))
                    {

#line default
#line hidden
            BeginContext(1039, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1146, "\"", 1195, 1);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1154, (int)AdminPanelPages.EditTemplateChunk, 1154, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1196, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1263, "\"", 1276, 1);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1271, t.ID, 1271, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1277, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1349, "\"", 1398, 1);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1357, Html.Raw(localization.EditTemplateChunk), 1357, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1399, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(1460, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                     if (DataCheck.HasAccessTo(AdminPanelPages.DeleteTemplateChunk, user, Context))
                    {

#line default
#line hidden
            BeginContext(1584, 108, true);
            WriteLiteral("                        <form method=\"post\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1692, "\"", 1743, 1);
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1700, (int)AdminPanelPages.DeleteTemplateChunk, 1700, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1744, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1811, "\"", 1824, 1);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1819, t.ID, 1819, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1825, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1897, "\"", 1948, 1);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1905, Html.Raw(localization.DeleteTemplateChunk), 1905, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1949, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(2010, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
            }

#line default
#line hidden
            BeginContext(2075, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TemplateChunk[]> Html { get; private set; }
    }
}
#pragma warning restore 1591