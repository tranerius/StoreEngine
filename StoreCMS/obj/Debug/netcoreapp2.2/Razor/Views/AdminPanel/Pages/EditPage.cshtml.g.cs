#pragma checksum "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d80dda721547c82fdb9538cdc8aa8603f99ac86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Pages_EditPage), @"mvc.1.0.view", @"/Views/AdminPanel/Pages/EditPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Pages/EditPage.cshtml", typeof(AspNetCore.Views_AdminPanel_Pages_EditPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d80dda721547c82fdb9538cdc8aa8603f99ac86", @"/Views/AdminPanel/Pages/EditPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Pages_EditPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/pages/work_with_page.css";
    Context.Items["PageName"] = $"{localization.EditPage_PageName} {Model.PageName}";
    UsualPage[] pages = Context.Items["UsualPages"] as UsualPage[];
    Template[] templates = Context.Items["Templates"] as Template[];
    bool isMainPage = Context.Items["isMainPage"] == null ? false : (bool)Context.Items["isMainPage"];

#line default
#line hidden
            BeginContext(506, 252, true);
            WriteLiteral("<script src=\"/scripts/admin_panel/insert_tab.js\"></script>\r\n            <script src=\"/scripts/admin_panel/checkbox_event_handler.js\"></script>\r\n            <form id=\"edit-page\" class=\"page-container\">\r\n                <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 758, "\"", 798, 1);
#line 14 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 766, (int)AdminPanelPages.EditPage, 766, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(799, 53, true);
            WriteLiteral(">\r\n                <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 852, "\"", 869, 1);
#line 15 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 860, Model.ID, 860, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(870, 56, true);
            WriteLiteral(">\r\n                <input id=\"save-button\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 926, "\"", 968, 1);
#line 16 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 934, Html.Raw(localization.SaveButton), 934, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(969, 89, true);
            WriteLiteral(" />\r\n                <div class=\"blocks\">\r\n                    <div class=\"left-block\">\r\n");
            EndContext();
            BeginContext(1093, 43, true);
            WriteLiteral("                        <label for=\"Title\">");
            EndContext();
            BeginContext(1137, 28, false);
#line 20 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                      Write(Html.Raw(localization.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 96, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"Title\" name=\"PageModel.Title\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1261, "\"", 1281, 1);
#line 21 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 1269, Model.Title, 1269, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1282, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1327, 46, true);
            WriteLiteral("                        <label for=\"PageName\">");
            EndContext();
            BeginContext(1374, 33, false);
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                         Write(Html.Raw(localization.Breadcrumb));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 102, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"PageName\" name=\"PageModel.PageName\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1509, "\"", 1532, 1);
#line 24 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 1517, Model.PageName, 1517, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1533, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1584, 53, true);
            WriteLiteral("                        <label for=\"PageDescription\">");
            EndContext();
            BeginContext(1638, 38, false);
#line 26 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                Write(Html.Raw(localization.PageDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 122, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageDescription\" name=\"PageModel.PageDescription\" maxlength=\"160\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1798, "\"", 1828, 1);
#line 27 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 1806, Model.PageDescription, 1806, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1829, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(1875, 50, true);
            WriteLiteral("                        <label for=\"PageKeywords\">");
            EndContext();
            BeginContext(1926, 35, false);
#line 29 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(localization.PageKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 100, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageKeywords\" name=\"PageModel.PageKeywords\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2061, "\"", 2088, 1);
#line 30 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 2069, Model.PageKeywords, 2069, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2089, 80, true);
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"right-block\">\r\n");
            EndContext();
            BeginContext(2207, 48, true);
            WriteLiteral("                        <label for=\"TemplateId\">");
            EndContext();
            BeginContext(2256, 31, false);
#line 34 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                           Write(Html.Raw(localization.Template));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 97, true);
            WriteLiteral("</label>\r\n                        <select id=\"TemplateId\" name=\"PageModel.TemplateId\" required>\r\n");
            EndContext();
#line 36 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                             if (!Model.TemplateId.HasValue)
                            {

#line default
#line hidden
            BeginContext(2477, 49, true);
            WriteLiteral("                                <option selected>");
            EndContext();
            BeginContext(2527, 38, false);
#line 38 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                            Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2565, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 39 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2672, 40, true);
            WriteLiteral("                                <option>");
            EndContext();
            BeginContext(2713, 38, false);
#line 42 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                   Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2751, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 43 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }

#line default
#line hidden
            BeginContext(2793, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 44 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                             foreach (var t in templates)
                            {
                                if (Model.TemplateId.HasValue && t.ID == Model.TemplateId.Value)
                                {

#line default
#line hidden
            BeginContext(3016, 43, true);
            WriteLiteral("                                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3059, "\"", 3072, 1);
#line 48 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 3067, t.ID, 3067, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3073, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(3084, 16, false);
#line 48 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                              Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3100, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 49 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3219, 43, true);
            WriteLiteral("                                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3262, "\"", 3275, 1);
#line 52 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 3270, t.ID, 3270, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3276, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3278, 16, false);
#line 52 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                     Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3294, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 53 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(3371, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
#line 56 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (!isMainPage)
                        {
                            

#line default
#line hidden
            BeginContext(3523, 54, true);
            WriteLiteral("                            <label for=\"PreviousPage\">");
            EndContext();
            BeginContext(3578, 35, false);
#line 59 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                 Write(Html.Raw(localization.PreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(3613, 107, true);
            WriteLiteral("</label>\r\n                            <select id=\"PreviousPage\" name=\"PageModel.PreviousPageID\" required>\r\n");
            EndContext();
#line 61 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                 if (!Model.PreviousPageID.HasValue)
                                {

#line default
#line hidden
            BeginContext(3825, 53, true);
            WriteLiteral("                                    <option selected>");
            EndContext();
            BeginContext(3879, 42, false);
#line 63 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(3921, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 64 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4040, 44, true);
            WriteLiteral("                                    <option>");
            EndContext();
            BeginContext(4085, 42, false);
#line 67 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                       Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(4127, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 68 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                }

#line default
#line hidden
            BeginContext(4173, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 69 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                 foreach (var p in pages)
                                {
                                    if (Model.PreviousPageID.HasValue && p.ID == Model.PreviousPageID.Value)
                                    {

#line default
#line hidden
            BeginContext(4416, 47, true);
            WriteLiteral("                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4463, "\"", 4476, 1);
#line 73 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 4471, p.ID, 4471, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4477, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(4488, 20, false);
#line 73 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                                  Write(Html.Raw(p.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(4508, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 74 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4639, 47, true);
            WriteLiteral("                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4686, "\"", 4699, 1);
#line 77 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 4694, p.ID, 4694, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4700, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4702, 20, false);
#line 77 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                         Write(Html.Raw(p.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(4722, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 78 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(4807, 39, true);
            WriteLiteral("                            </select>\r\n");
            EndContext();
            BeginContext(4885, 47, true);
            WriteLiteral("                            <label for=\"Alias\">");
            EndContext();
            BeginContext(4933, 28, false);
#line 82 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                          Write(Html.Raw(localization.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(4961, 90, true);
            WriteLiteral("</label>\r\n                            <input type=\"text\" id=\"Alias\" name=\"PageModel.Alias\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5051, "\"", 5072, 1);
#line 83 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 5059, Model?.Alias, 5059, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5073, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 84 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(5148, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 87 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                             if (Model.Published)
                            {

#line default
#line hidden
            BeginContext(5284, 132, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 90 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5512, 115, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"false\" />\r\n");
            EndContext();
#line 94 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }

#line default
#line hidden
            BeginContext(5658, 323, true);
            WriteLiteral(@"                            <script>
                                let publishedCheckbox = document.getElementById('Published');
                                publishedCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""Published"">");
            EndContext();
            BeginContext(5982, 32, false);
#line 99 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                              Write(Html.Raw(localization.Published));

#line default
#line hidden
            EndContext();
            BeginContext(6014, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(6101, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 103 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                             if (Model.IsIndex)
                            {

#line default
#line hidden
            BeginContext(6235, 128, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"IsIndex\" name=\"PageModel.IsIndex\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 106 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(6459, 111, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"IsIndex\" name=\"PageModel.IsIndex\" value=\"false\" />\r\n");
            EndContext();
#line 110 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }

#line default
#line hidden
            BeginContext(6601, 315, true);
            WriteLiteral(@"                            <script>
                                let isIndexCheckbox = document.getElementById('IsIndex');
                                isIndexCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsIndex"">");
            EndContext();
            BeginContext(6917, 30, false);
#line 115 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                            Write(Html.Raw(localization.IsIndex));

#line default
#line hidden
            EndContext();
            BeginContext(6947, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(7029, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 119 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                             if (Model.IsFollow)
                            {

#line default
#line hidden
            BeginContext(7164, 130, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"IsFollow\" name=\"PageModel.IsFollow\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 122 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(7390, 113, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"IsFollow\" name=\"PageModel.IsFollow\" value=\"false\" />\r\n");
            EndContext();
#line 126 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }

#line default
#line hidden
            BeginContext(7534, 319, true);
            WriteLiteral(@"                            <script>
                                let isFollowCheckbox = document.getElementById('IsFollow');
                                isFollowCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsFollow"">");
            EndContext();
            BeginContext(7854, 31, false);
#line 131 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(localization.IsFollow));

#line default
#line hidden
            EndContext();
            BeginContext(7885, 94, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(8008, 37, true);
            WriteLiteral("                <label for=\"Content\">");
            EndContext();
            BeginContext(8046, 30, false);
#line 136 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                Write(Html.Raw(localization.Content));

#line default
#line hidden
            EndContext();
            BeginContext(8076, 74, true);
            WriteLiteral("</label>\r\n                <textarea id=\"Content\" name=\"PageModel.Content\">");
            EndContext();
            BeginContext(8151, 14, false);
#line 137 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                           Write(Model?.Content);

#line default
#line hidden
            EndContext();
            BeginContext(8165, 559, true);
            WriteLiteral(@"</textarea>
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
            BeginContext(8725, 37, false);
#line 147 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                              Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(8762, 170, true);
            WriteLiteral("\';\r\n                }\r\n                function responseHandler(request, formElement) {\r\n                    if (request.status == 200) {\r\n                        alert(\'");
            EndContext();
            BeginContext(8933, 33, false);
#line 151 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                          Write(Html.Raw(localization.PageEdited));

#line default
#line hidden
            EndContext();
            BeginContext(8966, 509, true);
            WriteLiteral(@"');
                        location.reload();
                    }
                    else if (request.status == 422) {
                        errorHandler(formElement);
                    }
                }
                document.getElementById('save-button').addEventListener('click', createSendDataEventHandler('POST', 'edit-page', responseHandler, errorHandler));
                document.getElementById('Content').addEventListener('keydown', insertTabEventHandler);
            </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
