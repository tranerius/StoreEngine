#pragma checksum "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d0e7061dd10bffe107df4dfdd8bb8018439766"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_EditCategory), @"mvc.1.0.view", @"/Views/AdminPanel/CategoriesAndProducts/EditCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/CategoriesAndProducts/EditCategory.cshtml", typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_EditCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d0e7061dd10bffe107df4dfdd8bb8018439766", @"/Views/AdminPanel/CategoriesAndProducts/EditCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/CategoriesAndProducts/_ViewImports.cshtml")]
    public class Views_AdminPanel_CategoriesAndProducts_EditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/categories_and_products/work_with_page.css";
    Context.Items["PageName"] = $"{localization.EditCategoryPageName} {Model.PageName}";
    UsualPage[] pages = Context.Items["UsualPages"] as UsualPage[];
    Template[] templates = Context.Items["Templates"] as Template[];
    bool isMainPage = Context.Items["isMainPage"] == null ? false : (bool)Context.Items["isMainPage"];

#line default
#line hidden
            BeginContext(543, 256, true);
            WriteLiteral(@"<script src=""/scripts/admin_panel/insert_tab.js""></script>
            <script src=""/scripts/admin_panel/checkbox_event_handler.js""></script>
            <form id=""edit-category"" class=""page-container"">
                <input type=""hidden"" name=""pageID""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 799, "\"", 843, 1);
#line 14 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 807, (int)AdminPanelPages.EditCategory, 807, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(844, 53, true);
            WriteLiteral(">\r\n                <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 897, "\"", 914, 1);
#line 15 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 905, Model.ID, 905, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(915, 56, true);
            WriteLiteral(">\r\n                <input id=\"save-button\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 971, "\"", 1013, 1);
#line 16 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 979, Html.Raw(localization.SaveButton), 979, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1014, 89, true);
            WriteLiteral(" />\r\n                <div class=\"blocks\">\r\n                    <div class=\"left-block\">\r\n");
            EndContext();
            BeginContext(1138, 43, true);
            WriteLiteral("                        <label for=\"Title\">");
            EndContext();
            BeginContext(1182, 36, false);
#line 20 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                      Write(Html.Raw(localization.CategoryTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 96, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"Title\" name=\"PageModel.Title\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1314, "\"", 1334, 1);
#line 21 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 1322, Model.Title, 1322, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1335, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1380, 46, true);
            WriteLiteral("                        <label for=\"PageName\">");
            EndContext();
            BeginContext(1427, 41, false);
#line 23 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                         Write(Html.Raw(localization.CategoryBreadcrumb));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 102, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"PageName\" name=\"PageModel.PageName\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1570, "\"", 1593, 1);
#line 24 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 1578, Model.PageName, 1578, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1594, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1645, 53, true);
            WriteLiteral("                        <label for=\"PageDescription\">");
            EndContext();
            BeginContext(1699, 38, false);
#line 26 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                                Write(Html.Raw(localization.PageDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 122, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageDescription\" name=\"PageModel.PageDescription\" maxlength=\"160\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1859, "\"", 1890, 1);
#line 27 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 1867, Model?.PageDescription, 1867, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1891, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(1937, 50, true);
            WriteLiteral("                        <label for=\"PageKeywords\">");
            EndContext();
            BeginContext(1988, 35, false);
#line 29 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                             Write(Html.Raw(localization.PageKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 100, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageKeywords\" name=\"PageModel.PageKeywords\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2123, "\"", 2150, 1);
#line 30 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 2131, Model.PageKeywords, 2131, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2151, 80, true);
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"right-block\">\r\n");
            EndContext();
            BeginContext(2269, 48, true);
            WriteLiteral("                        <label for=\"TemplateId\">");
            EndContext();
            BeginContext(2318, 31, false);
#line 34 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                           Write(Html.Raw(localization.Template));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 97, true);
            WriteLiteral("</label>\r\n                        <select id=\"TemplateId\" name=\"PageModel.TemplateId\" required>\r\n");
            EndContext();
#line 36 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                             if (!Model.TemplateId.HasValue)
                            {

#line default
#line hidden
            BeginContext(2539, 49, true);
            WriteLiteral("                                <option selected>");
            EndContext();
            BeginContext(2589, 38, false);
#line 38 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                            Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2627, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 39 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2734, 40, true);
            WriteLiteral("                                <option>");
            EndContext();
            BeginContext(2775, 38, false);
#line 42 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                   Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2813, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 43 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                            }

#line default
#line hidden
            BeginContext(2855, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 44 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                             foreach (var t in templates)
                            {
                                if (Model.TemplateId.HasValue && t.ID == Model.TemplateId.Value)
                                {

#line default
#line hidden
            BeginContext(3078, 43, true);
            WriteLiteral("                                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3121, "\"", 3134, 1);
#line 48 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 3129, t.ID, 3129, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3135, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(3146, 16, false);
#line 48 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                                              Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3162, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 49 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3281, 43, true);
            WriteLiteral("                                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3324, "\"", 3337, 1);
#line 52 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 3332, t.ID, 3332, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3338, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3340, 16, false);
#line 52 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                                     Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3356, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 53 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(3433, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
#line 56 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                         if (!isMainPage)
                        {
                            

#line default
#line hidden
            BeginContext(3585, 54, true);
            WriteLiteral("                            <label for=\"PreviousPage\">");
            EndContext();
            BeginContext(3640, 35, false);
#line 59 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                                 Write(Html.Raw(localization.PreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(3675, 107, true);
            WriteLiteral("</label>\r\n                            <select id=\"PreviousPage\" name=\"PageModel.PreviousPageID\" required>\r\n");
            EndContext();
#line 61 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                 if (!Model.PreviousPageID.HasValue)
                                {

#line default
#line hidden
            BeginContext(3887, 53, true);
            WriteLiteral("                                    <option selected>");
            EndContext();
            BeginContext(3941, 42, false);
#line 63 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                                Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(3983, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 64 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4102, 44, true);
            WriteLiteral("                                    <option>");
            EndContext();
            BeginContext(4147, 42, false);
#line 67 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                       Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(4189, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 68 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                }

#line default
#line hidden
            BeginContext(4235, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 69 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                 foreach (var p in pages)
                                {
                                    if (Model.PreviousPageID == p.PreviousPageID && Model.Alias.Equals(p.Alias, StringComparison.Ordinal))
                                    {
                                        continue;
                                    }
                                    if (Model.PreviousPageID.HasValue && p.ID == Model.PreviousPageID.Value)
                                    {

#line default
#line hidden
            BeginContext(4747, 47, true);
            WriteLiteral("                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4794, "\"", 4807, 1);
#line 77 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 4802, p.ID, 4802, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4808, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(4819, 20, false);
#line 77 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                                                  Write(Html.Raw(p.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(4839, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 78 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4970, 47, true);
            WriteLiteral("                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5017, "\"", 5030, 1);
#line 81 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 5025, p.ID, 5025, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5031, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5033, 20, false);
#line 81 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                                         Write(Html.Raw(p.PageName));

#line default
#line hidden
            EndContext();
            BeginContext(5053, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 82 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(5138, 39, true);
            WriteLiteral("                            </select>\r\n");
            EndContext();
            BeginContext(5216, 47, true);
            WriteLiteral("                            <label for=\"Alias\">");
            EndContext();
            BeginContext(5264, 28, false);
#line 86 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                          Write(Html.Raw(localization.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(5292, 90, true);
            WriteLiteral("</label>\r\n                            <input type=\"text\" id=\"Alias\" name=\"PageModel.Alias\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5382, "\"", 5403, 1);
#line 87 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
WriteAttributeValue("", 5390, Model?.Alias, 5390, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5404, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 88 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(5479, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 91 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                             if (Model.Published)
                            {

#line default
#line hidden
            BeginContext(5615, 132, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 94 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5843, 115, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"false\" />\r\n");
            EndContext();
#line 98 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                            }

#line default
#line hidden
            BeginContext(5989, 323, true);
            WriteLiteral(@"                            <script>
                                let publishedCheckbox = document.getElementById('Published');
                                publishedCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""Published"">");
            EndContext();
            BeginContext(6313, 32, false);
#line 103 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                              Write(Html.Raw(localization.Published));

#line default
#line hidden
            EndContext();
            BeginContext(6345, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(6432, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 107 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                             if (Model.IsIndex)
                            {

#line default
#line hidden
            BeginContext(6566, 128, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"IsIndex\" name=\"PageModel.IsIndex\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 110 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(6790, 111, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"IsIndex\" name=\"PageModel.IsIndex\" value=\"false\" />\r\n");
            EndContext();
#line 114 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                            }

#line default
#line hidden
            BeginContext(6932, 315, true);
            WriteLiteral(@"                            <script>
                                let isIndexCheckbox = document.getElementById('IsIndex');
                                isIndexCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsIndex"">");
            EndContext();
            BeginContext(7248, 30, false);
#line 119 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                            Write(Html.Raw(localization.IsIndex));

#line default
#line hidden
            EndContext();
            BeginContext(7278, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(7360, 54, true);
            WriteLiteral("                        <div class=\"checkbox-block\">\r\n");
            EndContext();
#line 123 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                             if (Model.IsFollow)
                            {

#line default
#line hidden
            BeginContext(7495, 130, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"IsFollow\" name=\"PageModel.IsFollow\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 126 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(7721, 113, true);
            WriteLiteral("                                <input type=\"checkbox\" id=\"IsFollow\" name=\"PageModel.IsFollow\" value=\"false\" />\r\n");
            EndContext();
#line 130 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                            }

#line default
#line hidden
            BeginContext(7865, 319, true);
            WriteLiteral(@"                            <script>
                                let isFollowCheckbox = document.getElementById('IsFollow');
                                isFollowCheckbox.addEventListener('click', checkboxEventHandler);
                            </script>
                            <label for=""IsFollow"">");
            EndContext();
            BeginContext(8185, 31, false);
#line 135 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                             Write(Html.Raw(localization.IsFollow));

#line default
#line hidden
            EndContext();
            BeginContext(8216, 94, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(8339, 37, true);
            WriteLiteral("                <label for=\"Content\">");
            EndContext();
            BeginContext(8377, 30, false);
#line 140 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                Write(Html.Raw(localization.Content));

#line default
#line hidden
            EndContext();
            BeginContext(8407, 74, true);
            WriteLiteral("</label>\r\n                <textarea id=\"Content\" name=\"PageModel.Content\">");
            EndContext();
            BeginContext(8482, 14, false);
#line 141 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                                           Write(Model?.Content);

#line default
#line hidden
            EndContext();
            BeginContext(8496, 559, true);
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
            BeginContext(9056, 37, false);
#line 151 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                                              Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(9093, 170, true);
            WriteLiteral("\';\r\n                }\r\n                function responseHandler(request, formElement) {\r\n                    if (request.status == 200) {\r\n                        alert(\'");
            EndContext();
            BeginContext(9264, 37, false);
#line 155 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditCategory.cshtml"
                          Write(Html.Raw(localization.CategoryEdited));

#line default
#line hidden
            EndContext();
            BeginContext(9301, 513, true);
            WriteLiteral(@"');
                        location.reload();
                    }
                    else if (request.status == 422) {
                        errorHandler(formElement);
                    }
                }
                document.getElementById('save-button').addEventListener('click', createSendDataEventHandler('POST', 'edit-category', responseHandler, errorHandler));
                document.getElementById('Content').addEventListener('keydown', insertTabEventHandler);
            </script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICategoriesAndProductsLocalization localization { get; private set; }
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
