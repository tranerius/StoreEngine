#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3032ad6eeb1bec72dfa2df8a20605c250ed03c69"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3032ad6eeb1bec72dfa2df8a20605c250ed03c69", @"/Views/AdminPanel/Templates/ChunksPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Templates_ChunksPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chunk[]>
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
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddChunk, user, Context))
{

#line default
#line hidden
            BeginContext(302, 45, true);
            WriteLiteral("            <div class=\"addTemplateButton\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 347, "\"", 415, 3);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 354, Context.Request.Path, 354, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 375, "?pageID=", 375, 8, true);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 383, (int)AdminPanelPages.AddChunk, 383, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(416, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(418, 31, false);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                                                                                                              Write(Html.Raw(localization.AddChunk));

#line default
#line hidden
            EndContext();
            BeginContext(449, 12, true);
            WriteLiteral("</a></div>\r\n");
            EndContext();
#line 11 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
}

#line default
#line hidden
            BeginContext(464, 100, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td>ID</td>\r\n                    <td>");
            EndContext();
            BeginContext(565, 32, false);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                   Write(Html.Raw(localization.ChunkName));

#line default
#line hidden
            EndContext();
            BeginContext(597, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(629, 30, false);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                   Write(Html.Raw(localization.Actions));

#line default
#line hidden
            EndContext();
            BeginContext(659, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
             foreach (var t in Model)
            {

#line default
#line hidden
            BeginContext(743, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(790, 14, false);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                   Write(Html.Raw(t.ID));

#line default
#line hidden
            EndContext();
            BeginContext(804, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(836, 16, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                   Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(852, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                     if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditChunk, user, Context))
                    {

#line default
#line hidden
            BeginContext(1007, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1114, "\"", 1155, 1);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1122, (int)AdminPanelPages.EditChunk, 1122, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1156, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1223, "\"", 1236, 1);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1231, t.ID, 1231, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1237, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1309, "\"", 1350, 1);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1317, Html.Raw(localization.EditChunk), 1317, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1351, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(1412, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                     if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteChunk, user, Context))
                    {

#line default
#line hidden
            BeginContext(1536, 108, true);
            WriteLiteral("                        <form method=\"post\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1644, "\"", 1687, 1);
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1652, (int)AdminPanelPages.DeleteChunk, 1652, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1688, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1755, "\"", 1768, 1);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1763, t.ID, 1763, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1769, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1841, "\"", 1884, 1);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
WriteAttributeValue("", 1849, Html.Raw(localization.DeleteChunk), 1849, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1885, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(1946, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\ChunksPage.cshtml"
            }

#line default
#line hidden
            BeginContext(2011, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chunk[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
