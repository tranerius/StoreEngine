#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf26d264edaa0490d608f7211fae027532f6d272"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf26d264edaa0490d608f7211fae027532f6d272", @"/Views/AdminPanel/Pages/EditPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Pages_EditPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/pages/edit_page.css";
    var pages = db.UsualPages.Select(p => new { p.ID, Name = $"{p.Title}(ID{p.ID})", p.PreviousPageID, p.Alias });
    var templates = db.Templates.ToList();
    bool incorrect = Context.Items["IsIncorrect"] == null ? false : (bool)Context.Items["IsIncorrect"];

#line default
#line hidden
#line 11 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
 if (incorrect)
{

#line default
#line hidden
            BeginContext(480, 6, true);
            WriteLiteral("<span>");
            EndContext();
            BeginContext(487, 27, false);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
 Write(localization.IncorrectInput);

#line default
#line hidden
            EndContext();
            BeginContext(514, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 14 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
}

#line default
#line hidden
            BeginContext(526, 58, true);
            WriteLiteral("<form method=\"post\">\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 584, "\"", 626, 1);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 592, Html.Raw(localization.SaveButton), 592, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(627, 103, true);
            WriteLiteral(" />\r\n                <div class=\"workWithPageContainer\">\r\n                    <div class=\"leftBlock\">\r\n");
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("                        <label for=\"Title\">");
            EndContext();
            BeginContext(809, 28, false);
#line 20 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                      Write(Html.Raw(localization.Title));

#line default
#line hidden
            EndContext();
            BeginContext(837, 96, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"Title\" name=\"PageModel.Title\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 933, "\"", 953, 1);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 941, Model.Title, 941, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(954, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(999, 52, true);
            WriteLiteral("                        <label for=\"BreadcrumbName\">");
            EndContext();
            BeginContext(1052, 33, false);
#line 23 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                               Write(Html.Raw(localization.Breadcrumb));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 114, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"BreadcrumbName\" name=\"PageModel.BreadcrumbName\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1199, "\"", 1228, 1);
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 1207, Model.BreadcrumbName, 1207, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1229, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1280, 53, true);
            WriteLiteral("                        <label for=\"PageDescription\">");
            EndContext();
            BeginContext(1334, 38, false);
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                Write(Html.Raw(localization.PageDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 122, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageDescription\" name=\"PageModel.PageDescription\" maxlength=\"160\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1494, "\"", 1524, 1);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 1502, Model.PageDescription, 1502, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1525, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(1571, 50, true);
            WriteLiteral("                        <label for=\"PageKeywords\">");
            EndContext();
            BeginContext(1622, 35, false);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(localization.PageKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 100, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageKeywords\" name=\"PageModel.PageKeywords\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1757, "\"", 1784, 1);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 1765, Model.PageKeywords, 1765, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1785, 79, true);
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"rightBlock\">\r\n");
            EndContext();
#line 34 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.PageType == PageType.Category)
                        {

#line default
#line hidden
            BeginContext(2001, 50, true);
            WriteLiteral("                        <label for=\"CategoryName\">");
            EndContext();
            BeginContext(2052, 35, false);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(localization.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 110, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"CategoryName\" name=\"PageModel.CategoryName\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2197, "\"", 2224, 1);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 2205, Model.CategoryName, 2205, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2225, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(2295, 48, true);
            WriteLiteral("                        <label for=\"TemplateId\">");
            EndContext();
            BeginContext(2344, 31, false);
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                           Write(Html.Raw(localization.Template));

#line default
#line hidden
            EndContext();
            BeginContext(2375, 97, true);
            WriteLiteral("</label>\r\n                        <select id=\"TemplateId\" name=\"PageModel.TemplateId\" required>\r\n");
            EndContext();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                             if (!Model.TemplateId.HasValue)
                            {

#line default
#line hidden
            BeginContext(2565, 49, true);
            WriteLiteral("                                <option selected>");
            EndContext();
            BeginContext(2615, 38, false);
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                            Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2653, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 45 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2760, 40, true);
            WriteLiteral("                                <option>");
            EndContext();
            BeginContext(2801, 38, false);
#line 48 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                   Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2839, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 49 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }

#line default
#line hidden
            BeginContext(2881, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 50 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                             foreach (var t in templates)
                            {
                                if (Model.TemplateId.HasValue && t.ID == Model.TemplateId.Value)
                                {

#line default
#line hidden
            BeginContext(3104, 39, true);
            WriteLiteral("                                <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3143, "\"", 3156, 1);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 3151, t.ID, 3151, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3157, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(3168, 16, false);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                          Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3184, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 55 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3303, 39, true);
            WriteLiteral("                                <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3342, "\"", 3355, 1);
#line 58 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 3350, t.ID, 3350, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3356, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3358, 16, false);
#line 58 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                 Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3374, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(3451, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(3525, 46, true);
            WriteLiteral("                        <label for=\"PageType\">");
            EndContext();
            BeginContext(3572, 31, false);
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                         Write(Html.Raw(localization.PageType));

#line default
#line hidden
            EndContext();
            BeginContext(3603, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 64 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.PageType == PageType.Usual)
                        {

#line default
#line hidden
            BeginContext(3704, 56, true);
            WriteLiteral("                        <input type=\"text\" id=\"PageType\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3760, "\"", 3797, 1);
#line 66 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 3768, Html.Raw(localization.Usual), 3768, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3798, 14, true);
            WriteLiteral(" disabled />\r\n");
            EndContext();
#line 67 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        else if (Model.PageType == PageType.Category)
                        {

#line default
#line hidden
            BeginContext(3937, 56, true);
            WriteLiteral("                        <input type=\"text\" id=\"PageType\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3993, "\"", 4033, 1);
#line 70 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 4001, Html.Raw(localization.Category), 4001, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4034, 14, true);
            WriteLiteral(" disabled />\r\n");
            EndContext();
#line 71 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(4118, 50, true);
            WriteLiteral("                        <label for=\"PreviousPage\">");
            EndContext();
            BeginContext(4169, 35, false);
#line 73 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(localization.PreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(4204, 103, true);
            WriteLiteral("</label>\r\n                        <select id=\"PreviousPage\" name=\"PageModel.PreviousPageID\" required>\r\n");
            EndContext();
#line 75 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (!Model.PreviousPageID.HasValue)
                        {

#line default
#line hidden
            BeginContext(4396, 45, true);
            WriteLiteral("                            <option selected>");
            EndContext();
            BeginContext(4442, 42, false);
#line 77 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                        Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(4484, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 78 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4579, 36, true);
            WriteLiteral("                            <option>");
            EndContext();
            BeginContext(4616, 42, false);
#line 81 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                               Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(4658, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 82 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }

#line default
#line hidden
            BeginContext(4696, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 83 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         foreach (var p in pages)
                        {
                            if (Model.PreviousPageID == p.PreviousPageID && Model.Alias.Equals(p.Alias))
                            {
                                continue;
                            }
                            if (Model.PreviousPageID.HasValue && p.ID == Model.PreviousPageID.Value)
                            {

#line default
#line hidden
            BeginContext(5118, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5153, "\"", 5166, 1);
#line 91 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 5161, p.ID, 5161, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5167, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(5178, 16, false);
#line 91 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                      Write(Html.Raw(p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(5194, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 92 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5301, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5336, "\"", 5349, 1);
#line 95 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 5344, p.ID, 5344, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5350, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5352, 16, false);
#line 95 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(5368, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 96 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(5437, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(5507, 43, true);
            WriteLiteral("                        <label for=\"Alias\">");
            EndContext();
            BeginContext(5551, 28, false);
#line 100 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                      Write(Html.Raw(localization.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(5579, 86, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"Alias\" name=\"PageModel.Alias\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5665, "\"", 5686, 1);
#line 101 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 5673, Model?.Alias, 5673, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5687, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 103 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.IsMainPage)
                        {

#line default
#line hidden
            BeginContext(5810, 235, true);
            WriteLiteral("                        <div class=\"checkboxBlock\">\r\n                            <input type=\"checkbox\" id=\"IsMainPage\" name=\"PageModel.IsMainPage\" value=\"true\" checked=\"checked\" />\r\n                            <label for=\"IsMainPage\">");
            EndContext();
            BeginContext(6046, 33, false);
#line 107 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                               Write(Html.Raw(localization.IsMainPage));

#line default
#line hidden
            EndContext();
            BeginContext(6079, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
#line 109 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(6191, 53, true);
            WriteLiteral("                        <div class=\"checkboxBlock\">\r\n");
            EndContext();
#line 112 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.Published)
                        {

#line default
#line hidden
            BeginContext(6318, 128, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 115 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(6530, 110, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"true\" />\r\n");
            EndContext();
#line 119 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }

#line default
#line hidden
            BeginContext(6667, 51, true);
            WriteLiteral("                            <label for=\"Published\">");
            EndContext();
            BeginContext(6719, 32, false);
#line 120 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                              Write(Html.Raw(localization.Published));

#line default
#line hidden
            EndContext();
            BeginContext(6751, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(6838, 53, true);
            WriteLiteral("                        <div class=\"checkboxBlock\">\r\n");
            EndContext();
#line 124 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.IsRobotIndex)
                        {

#line default
#line hidden
            BeginContext(6968, 134, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsRobotIndex\" name=\"PageModel.IsRobotIndex\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 127 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(7186, 116, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsRobotIndex\" name=\"PageModel.IsRobotIndex\" value=\"true\" />\r\n");
            EndContext();
#line 131 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }

#line default
#line hidden
            BeginContext(7329, 54, true);
            WriteLiteral("                            <label for=\"IsRobotIndex\">");
            EndContext();
            BeginContext(7384, 35, false);
#line 132 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                 Write(Html.Raw(localization.IsRobotIndex));

#line default
#line hidden
            EndContext();
            BeginContext(7419, 113, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
