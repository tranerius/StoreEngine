#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "342a3cba199e6ca3c40a4986eb8d9e8cc93c4101"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_EditProduct), @"mvc.1.0.view", @"/Views/AdminPanel/CategoriesAndProducts/EditProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/CategoriesAndProducts/EditProduct.cshtml", typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_EditProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"342a3cba199e6ca3c40a4986eb8d9e8cc93c4101", @"/Views/AdminPanel/CategoriesAndProducts/EditProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/CategoriesAndProducts/_ViewImports.cshtml")]
    public class Views_AdminPanel_CategoriesAndProducts_EditProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/products/workWithProduct.css";
    var templates = db.Templates.ToList();
    bool incorrect = Context.Items["IsIncorrect"] == null ? false : (bool)Context.Items["IsIncorrect"];

#line default
#line hidden
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
 if (incorrect)
{

#line default
#line hidden
            BeginContext(376, 6, true);
            WriteLiteral("<span>");
            EndContext();
            BeginContext(383, 37, false);
#line 12 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
 Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(420, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
}

#line default
#line hidden
            BeginContext(432, 44, true);
            WriteLiteral("<form method=\"post\" class=\"pageContainer\">\r\n");
            EndContext();
            BeginContext(509, 36, true);
            WriteLiteral("                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 545, "\"", 587, 1);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 553, Html.Raw(localization.SaveButton), 553, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(588, 97, true);
            WriteLiteral(" />\r\n                <div class=\"leftRightBlocks\">\r\n                    <div class=\"leftBlock\">\r\n");
            EndContext();
            BeginContext(720, 43, true);
            WriteLiteral("                        <label for=\"Title\">");
            EndContext();
            BeginContext(764, 28, false);
#line 20 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                      Write(Html.Raw(localization.Title));

#line default
#line hidden
            EndContext();
            BeginContext(792, 96, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"Title\" name=\"PageModel.Title\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 888, "\"", 909, 1);
#line 21 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 896, Model?.Title, 896, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(910, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(955, 46, true);
            WriteLiteral("                        <label for=\"PageName\">");
            EndContext();
            BeginContext(1002, 33, false);
#line 23 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                         Write(Html.Raw(localization.Breadcrumb));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 102, true);
            WriteLiteral("*</label>\r\n                        <input type=\"text\" id=\"PageName\" name=\"PageModel.PageName\" required");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1137, "\"", 1161, 1);
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 1145, Model?.PageName, 1145, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1162, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(1202, 136, true);
            WriteLiteral("                        <div class=\"priceBlock\">\r\n                            <div>\r\n                                <label for=\"Price\">");
            EndContext();
            BeginContext(1339, 28, false);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                              Write(Html.Raw(localization.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 104, true);
            WriteLiteral("</label>\r\n                                <input type=\"number\" id=\"Price\" name=\"PageModel.Price\" min=\"0\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1471, "\"", 1492, 1);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 1479, Model?.Price, 1479, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1493, 130, true);
            WriteLiteral(" />\r\n                            </div>\r\n                            <div>\r\n                                <label for=\"OldPrice\">");
            EndContext();
            BeginContext(1624, 31, false);
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                 Write(Html.Raw(localization.OldPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 110, true);
            WriteLiteral("</label>\r\n                                <input type=\"number\" id=\"OldPrice\" name=\"PageModel.OldPrice\" min=\"0\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1765, "\"", 1789, 1);
#line 33 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 1773, Model?.OldPrice, 1773, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1790, 73, true);
            WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(1910, 54, true);
            WriteLiteral("                        <label for=\"ShortDescription\">");
            EndContext();
            BeginContext(1965, 39, false);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                 Write(Html.Raw(localization.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 134, true);
            WriteLiteral("</label>\r\n                        <textarea class=\"shortDescription\" rows=\"3\" id=\"ShortDescription\" name=\"PageModel.ShortDescription\">");
            EndContext();
            BeginContext(2139, 23, false);
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                                                                                       Write(Model?.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(2162, 87, true);
            WriteLiteral("</textarea>\r\n                    </div>\r\n                    <div class=\"rightBlock\">\r\n");
            EndContext();
            BeginContext(2293, 48, true);
            WriteLiteral("                        <label for=\"TemplateId\">");
            EndContext();
            BeginContext(2342, 31, false);
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                           Write(Html.Raw(localization.Template));

#line default
#line hidden
            EndContext();
            BeginContext(2373, 142, true);
            WriteLiteral("</label>\r\n                        <select id=\"TemplateId\" name=\"PageModel.TemplateId\" required>\r\n                            <option selected>");
            EndContext();
            BeginContext(2516, 38, false);
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                        Write(Html.Raw(localization.WithoutTemplate));

#line default
#line hidden
            EndContext();
            BeginContext(2554, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 45 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                             foreach (var t in templates)
                            {

#line default
#line hidden
            BeginContext(2655, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2690, "\"", 2703, 1);
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 2698, t.ID, 2698, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2704, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2706, 16, false);
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                             Write(Html.Raw(t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2722, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 48 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                            }

#line default
#line hidden
            BeginContext(2764, 35, true);
            WriteLiteral("                        </select>\r\n");
            EndContext();
            BeginContext(2834, 43, true);
            WriteLiteral("                        <label for=\"Alias\">");
            EndContext();
            BeginContext(2878, 28, false);
#line 51 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                      Write(Html.Raw(localization.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(2906, 86, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"Alias\" name=\"PageModel.Alias\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2992, "\"", 3013, 1);
#line 52 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 3000, Model?.Alias, 3000, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3014, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(3065, 53, true);
            WriteLiteral("                        <label for=\"PageDescription\">");
            EndContext();
            BeginContext(3119, 38, false);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                Write(Html.Raw(localization.PageDescription));

#line default
#line hidden
            EndContext();
            BeginContext(3157, 122, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageDescription\" name=\"PageModel.PageDescription\" maxlength=\"160\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3279, "\"", 3310, 1);
#line 55 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 3287, Model?.PageDescription, 3287, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3311, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(3357, 50, true);
            WriteLiteral("                        <label for=\"PageKeywords\">");
            EndContext();
            BeginContext(3408, 35, false);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                             Write(Html.Raw(localization.PageKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(3443, 100, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"PageKeywords\" name=\"PageModel.PageKeywords\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3543, "\"", 3571, 1);
#line 58 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
WriteAttributeValue("", 3551, Model?.PageKeywords, 3551, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3572, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(3617, 53, true);
            WriteLiteral("                        <div class=\"checkboxBlock\">\r\n");
            EndContext();
#line 61 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                         if (Model == null || Model.Published)
                        {

#line default
#line hidden
            BeginContext(3761, 118, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"true\" checked />\r\n");
            EndContext();
#line 64 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3963, 110, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"Published\" name=\"PageModel.Published\" value=\"true\" />\r\n");
            EndContext();
#line 68 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }

#line default
#line hidden
            BeginContext(4100, 51, true);
            WriteLiteral("                            <label for=\"Published\">");
            EndContext();
            BeginContext(4152, 32, false);
#line 69 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                              Write(Html.Raw(localization.Published));

#line default
#line hidden
            EndContext();
            BeginContext(4184, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(4265, 53, true);
            WriteLiteral("                        <div class=\"checkboxBlock\">\r\n");
            EndContext();
#line 73 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                         if (Model == null || Model.IsIndex)
                        {

#line default
#line hidden
            BeginContext(4407, 114, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsIndex\" name=\"PageModel.IsIndex\" value=\"true\" checked />\r\n");
            EndContext();
#line 76 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4605, 106, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsIndex\" name=\"PageModel.IsIndex\" value=\"true\" />\r\n");
            EndContext();
#line 80 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }

#line default
#line hidden
            BeginContext(4738, 49, true);
            WriteLiteral("                            <label for=\"IsIndex\">");
            EndContext();
            BeginContext(4788, 30, false);
#line 81 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                            Write(Html.Raw(localization.IsIndex));

#line default
#line hidden
            EndContext();
            BeginContext(4818, 42, true);
            WriteLiteral("</label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(4900, 53, true);
            WriteLiteral("                        <div class=\"checkboxBlock\">\r\n");
            EndContext();
#line 85 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                         if (Model == null || Model.IsFollow)
                        {

#line default
#line hidden
            BeginContext(5043, 116, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsFollow\" name=\"PageModel.IsFollow\" value=\"true\" checked />\r\n");
            EndContext();
#line 88 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(5243, 108, true);
            WriteLiteral("                            <input type=\"checkbox\" id=\"IsFollow\" name=\"PageModel.IsFollow\" value=\"true\" />\r\n");
            EndContext();
#line 92 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                        }

#line default
#line hidden
            BeginContext(5378, 50, true);
            WriteLiteral("                            <label for=\"IsFollow\">");
            EndContext();
            BeginContext(5429, 31, false);
#line 93 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                             Write(Html.Raw(localization.IsFollow));

#line default
#line hidden
            EndContext();
            BeginContext(5460, 94, true);
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(5583, 37, true);
            WriteLiteral("                <label for=\"Content\">");
            EndContext();
            BeginContext(5621, 30, false);
#line 98 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                Write(Html.Raw(localization.Content));

#line default
#line hidden
            EndContext();
            BeginContext(5651, 74, true);
            WriteLiteral("</label>\r\n                <textarea id=\"Content\" name=\"PageModel.Content\">");
            EndContext();
            BeginContext(5726, 14, false);
#line 99 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\EditProduct.cshtml"
                                                           Write(Model?.Content);

#line default
#line hidden
            EndContext();
            BeginContext(5740, 32, true);
            WriteLiteral("</textarea>\r\n            </form>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CMSDatabase db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProductsLocalization localization { get; private set; }
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