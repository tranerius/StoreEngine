#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0025f77978ff58f0e5203f7e449046a9d40207e2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0025f77978ff58f0e5203f7e449046a9d40207e2", @"/Views/AdminPanel/Pages/EditPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Pages_EditPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/pages/workWithPage.css";
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
            BeginContext(483, 18, true);
            WriteLiteral("            <span>");
            EndContext();
            BeginContext(502, 27, false);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
             Write(localization.IncorrectInput);

#line default
#line hidden
            EndContext();
            BeginContext(529, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 14 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
}

#line default
#line hidden
            BeginContext(541, 92, true);
            WriteLiteral("            <form method=\"post\" class=\"pageContainer\">\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 633, "\"", 675, 1);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 641, Html.Raw(localization.SaveButton), 641, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(676, 97, true);
            WriteLiteral(" />\r\n                <div class=\"leftRightBlocks\">\r\n                    <div class=\"leftBlock\">\r\n");
            EndContext();
            BeginContext(808, 43, true);
            WriteLiteral("                        <label for=\"Title\">");
            EndContext();
            BeginContext(852, 28, false);
#line 20 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                      Write(Html.Raw(localization.Title));

#line default
#line hidden
            EndContext();
            BeginContext(880, 96, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"Title\" name=\"PageModel.Title\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 976, "\"", 996, 1);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 984, Model.Title, 984, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(997, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1042, 52, true);
            WriteLiteral("                        <label for=\"BreadcrumbName\">");
            EndContext();
            BeginContext(1095, 33, false);
#line 23 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                               Write(Html.Raw(localization.Breadcrumb));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 114, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"BreadcrumbName\" name=\"PageModel.BreadcrumbName\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1242, "\"", 1271, 1);
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 1250, Model.BreadcrumbName, 1250, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1272, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1323, 53, true);
            WriteLiteral("                        <label for=\"PageDescription\">");
            EndContext();
            BeginContext(1377, 38, false);
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                Write(Html.Raw(localization.PageDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 122, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageDescription\" name=\"PageModel.PageDescription\" maxlength=\"160\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1537, "\"", 1567, 1);
#line 27 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 1545, Model.PageDescription, 1545, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1568, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(1614, 50, true);
            WriteLiteral("                        <label for=\"PageKeywords\">");
            EndContext();
            BeginContext(1665, 35, false);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(localization.PageKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 100, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageKeywords\" name=\"PageModel.PageKeywords\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1800, "\"", 1827, 1);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 1808, Model.PageKeywords, 1808, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1828, 79, true);
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"rightBlock\">\r\n");
            EndContext();
#line 34 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.PageType == PageType.Category)
                        {

#line default
#line hidden
            BeginContext(2044, 50, true);
            WriteLiteral("                        <label for=\"CategoryName\">");
            EndContext();
            BeginContext(2095, 35, false);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(localization.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 110, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"CategoryName\" name=\"PageModel.CategoryName\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2240, "\"", 2267, 1);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 2248, Model.CategoryName, 2248, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2268, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(2338, 48, true);
            WriteLiteral("                        <label for=\"TemplateId\">");
            EndContext();
            BeginContext(2387, 31, false);
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                           Write(Html.Raw(localization.Template));

#line default
#line hidden
            EndContext();
            BeginContext(2418, 97, true);
            WriteLiteral("</label>\r\n                        <select id=\"TemplateId\" name=\"PageModel.TemplateId\" required>\r\n");
            EndContext();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (!Model.TemplateId.HasValue)
                        {

#line default
#line hidden
            BeginContext(2600, 45, true);
            WriteLiteral("                            <option selected>");
            EndContext();
            BeginContext(2646, 38, false);
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                        Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2684, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 45 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2779, 36, true);
            WriteLiteral("                            <option>");
            EndContext();
            BeginContext(2816, 38, false);
#line 48 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                               Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2854, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 49 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }

#line default
#line hidden
            BeginContext(2892, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 50 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         foreach (var t in templates)
                        {
                            if (Model.TemplateId.HasValue && t.ID == Model.TemplateId.Value)
                            {

#line default
#line hidden
            BeginContext(3099, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3134, "\"", 3147, 1);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 3142, t.ID, 3142, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3148, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(3159, 16, false);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                      Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3175, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 55 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3282, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3317, "\"", 3330, 1);
#line 58 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 3325, t.ID, 3325, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3331, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3333, 16, false);
#line 58 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3349, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(3418, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(3492, 46, true);
            WriteLiteral("                        <label for=\"PageType\">");
            EndContext();
            BeginContext(3539, 31, false);
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                         Write(Html.Raw(localization.PageType));

#line default
#line hidden
            EndContext();
            BeginContext(3570, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 64 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.PageType == PageType.Usual)
                        {

#line default
#line hidden
            BeginContext(3671, 56, true);
            WriteLiteral("                        <input type=\"text\" id=\"PageType\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3727, "\"", 3764, 1);
#line 66 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 3735, Html.Raw(localization.Usual), 3735, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3765, 14, true);
            WriteLiteral(" disabled />\r\n");
            EndContext();
#line 67 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        else if (Model.PageType == PageType.Category)
                        {

#line default
#line hidden
            BeginContext(3904, 56, true);
            WriteLiteral("                        <input type=\"text\" id=\"PageType\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3960, "\"", 4000, 1);
#line 70 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 3968, Html.Raw(localization.Category), 3968, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4001, 14, true);
            WriteLiteral(" disabled />\r\n");
            EndContext();
#line 71 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(4085, 50, true);
            WriteLiteral("                        <label for=\"PreviousPage\">");
            EndContext();
            BeginContext(4136, 35, false);
#line 73 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(localization.PreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(4171, 103, true);
            WriteLiteral("</label>\r\n                        <select id=\"PreviousPage\" name=\"PageModel.PreviousPageID\" required>\r\n");
            EndContext();
#line 75 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (!Model.PreviousPageID.HasValue)
                        {

#line default
#line hidden
            BeginContext(4363, 45, true);
            WriteLiteral("                            <option selected>");
            EndContext();
            BeginContext(4409, 42, false);
#line 77 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                        Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(4451, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 78 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4546, 36, true);
            WriteLiteral("                            <option>");
            EndContext();
            BeginContext(4583, 42, false);
#line 81 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                               Write(Html.Raw(localization.WithoutPreviousPage));

#line default
#line hidden
            EndContext();
            BeginContext(4625, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 82 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }

#line default
#line hidden
            BeginContext(4663, 24, true);
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
            BeginContext(5085, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5120, "\"", 5133, 1);
#line 91 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 5128, p.ID, 5128, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5134, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(5145, 16, false);
#line 91 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                      Write(Html.Raw(p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(5161, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 92 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5268, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5303, "\"", 5316, 1);
#line 95 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 5311, p.ID, 5311, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5317, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5319, 16, false);
#line 95 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                             Write(Html.Raw(p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(5335, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 96 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(5404, 11, true);
            WriteLiteral("</select>\r\n");
            EndContext();
            BeginContext(5450, 43, true);
            WriteLiteral("                        <label for=\"Alias\">");
            EndContext();
            BeginContext(5494, 28, false);
#line 100 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                      Write(Html.Raw(localization.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(5522, 86, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"Alias\" name=\"PageModel.Alias\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5608, "\"", 5629, 1);
#line 101 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
WriteAttributeValue("", 5616, Model?.Alias, 5616, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5630, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 103 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.IsMainPage)
                        {

#line default
#line hidden
            BeginContext(5753, 235, true);
            WriteLiteral("                        <div class=\"checkboxBlock\">\r\n                            <input type=\"checkbox\" id=\"IsMainPage\" name=\"PageModel.IsMainPage\" value=\"true\" checked=\"checked\" />\r\n                            <label for=\"IsMainPage\">");
            EndContext();
            BeginContext(5989, 33, false);
#line 107 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                               Write(Html.Raw(localization.IsMainPage));

#line default
#line hidden
            EndContext();
            BeginContext(6022, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
#line 109 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        

#line default
#line hidden
            BeginContext(6134, 53, true);
            WriteLiteral("                        <div class=\"checkboxBlock\">\r\n");
            EndContext();
#line 112 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.Published)
                        {

#line default
#line hidden
            BeginContext(6261, 128, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 115 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(6473, 110, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"true\" />\r\n");
            EndContext();
#line 119 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }

#line default
#line hidden
            BeginContext(6610, 51, true);
            WriteLiteral("                            <label for=\"Published\">");
            EndContext();
            BeginContext(6662, 32, false);
#line 120 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                              Write(Html.Raw(localization.Published));

#line default
#line hidden
            EndContext();
            BeginContext(6694, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(6781, 53, true);
            WriteLiteral("                        <div class=\"checkboxBlock\">\r\n");
            EndContext();
#line 124 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                         if (Model.IsRobotIndex)
                        {

#line default
#line hidden
            BeginContext(6911, 134, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsRobotIndex\" name=\"PageModel.IsRobotIndex\" value=\"true\" checked=\"checked\" />\r\n");
            EndContext();
#line 127 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(7129, 116, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsRobotIndex\" name=\"PageModel.IsRobotIndex\" value=\"true\" />\r\n");
            EndContext();
#line 131 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                        }

#line default
#line hidden
            BeginContext(7272, 54, true);
            WriteLiteral("                            <label for=\"IsRobotIndex\">");
            EndContext();
            BeginContext(7327, 35, false);
#line 132 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                 Write(Html.Raw(localization.IsRobotIndex));

#line default
#line hidden
            EndContext();
            BeginContext(7362, 94, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(7485, 37, true);
            WriteLiteral("                <label for=\"Content\">");
            EndContext();
            BeginContext(7523, 30, false);
#line 137 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                Write(Html.Raw(localization.Content));

#line default
#line hidden
            EndContext();
            BeginContext(7553, 74, true);
            WriteLiteral("</label>\r\n                <textarea id=\"Content\" name=\"PageModel.Content\">");
            EndContext();
            BeginContext(7628, 14, false);
#line 138 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Pages\EditPage.cshtml"
                                                           Write(Model?.Content);

#line default
#line hidden
            EndContext();
            BeginContext(7642, 32, true);
            WriteLiteral("</textarea>\r\n            </form>");
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
