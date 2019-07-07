#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42023abb8fff35953ca0f2ffb152b4ec7533c0d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_CategoryProducts), @"mvc.1.0.view", @"/Views/AdminPanel/CategoriesAndProducts/CategoryProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/CategoriesAndProducts/CategoryProducts.cshtml", typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_CategoryProducts))]
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
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
using Treynessen.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42023abb8fff35953ca0f2ffb152b4ec7533c0d7", @"/Views/AdminPanel/CategoriesAndProducts/CategoryProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/CategoriesAndProducts/_ViewImports.cshtml")]
    public class Views_AdminPanel_CategoriesAndProducts_CategoryProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductPage>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Treynessen.TagHelpers.ImageTagHelper __Treynessen_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/products/categoryProducts.css";
    int categoryID = (int)Context.Items["itemID"];
    string categoryName = Context.Items["categoryName"] as string;
    User user = Context.Items["User"] as User;

#line default
#line hidden
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddProduct, user, Context))
{

#line default
#line hidden
            BeginContext(545, 50, true);
            WriteLiteral("<div class=\"addProductButton\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 595, "\"", 684, 5);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 602, Context.Request.Path, 602, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 623, "?pageID=", 623, 8, true);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 631, (int)AdminPanelPages.AddProduct, 631, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 665, "&itemID=", 665, 8, true);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 673, categoryID, 673, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(685, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(687, 70, false);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                                                                                                        Write(Html.Raw($"{localization.AddProductInCategory} <b>{categoryName}</b>"));

#line default
#line hidden
            EndContext();
            BeginContext(757, 26, true);
            WriteLiteral("</a>\r\n            </div>\r\n");
            EndContext();
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
}

#line default
#line hidden
            BeginContext(786, 98, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td></td>\r\n                    <td>");
            EndContext();
            BeginContext(885, 27, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                   Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(912, 65, true);
            WriteLiteral("</td>\r\n                    <td>URL</td>\r\n                    <td>");
            EndContext();
            BeginContext(978, 41, false);
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                   Write(Html.Raw(localization.ActionsWithProduct));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                 foreach (var p in Model)
                {

#line default
#line hidden
            BeginContext(1111, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1157, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ace2c4885a441fc9a139ff14086d946", async() => {
            }
            );
            __Treynessen_TagHelpers_ImageTagHelper = CreateTagHelper<global::Treynessen.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Treynessen_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                        WriteLiteral(Html.Raw($"{env.GetProductsImagesFolderSrc()}{p.PreviousPageID.ToString()}{p.ID.ToString()}/{p.Alias}.jpg"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Treynessen_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Treynessen_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxHeight = 150;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-height", __Treynessen_TagHelpers_ImageTagHelper.MaxHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxWidth = 150;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-width", __Treynessen_TagHelpers_ImageTagHelper.MaxWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.Quality = 50;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("quality", __Treynessen_TagHelpers_ImageTagHelper.Quality, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1333, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1365, 54, false);
#line 30 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                   Write(Html.Raw($"{p.PageName} <b>(ID{p.ID.ToString()})</b>"));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1451, 23, false);
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                   Write(Html.Raw(p.RequestPath));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 33 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditProduct, user, Context))
                {

#line default
#line hidden
            BeginContext(1623, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1730, "\"", 1773, 1);
#line 36 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 1738, (int)AdminPanelPages.EditProduct, 1738, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1774, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1841, "\"", 1854, 1);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 1849, p.ID, 1849, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1855, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1927, "\"", 1970, 1);
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 1935, Html.Raw(localization.EditProduct), 1935, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1971, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                }

#line default
#line hidden
            BeginContext(2028, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 41 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.ProductImages, user, Context))
                {

#line default
#line hidden
            BeginContext(2146, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2253, "\"", 2298, 1);
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2261, (int)AdminPanelPages.ProductImages, 2261, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2299, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2366, "\"", 2379, 1);
#line 45 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2374, p.ID, 2374, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2380, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2452, "\"", 2497, 1);
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2460, Html.Raw(localization.ProductImages), 2460, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2498, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 48 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                }

#line default
#line hidden
            BeginContext(2555, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 49 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteProduct, user, Context))
                {

#line default
#line hidden
            BeginContext(2673, 108, true);
            WriteLiteral("                        <form method=\"post\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2781, "\"", 2826, 1);
#line 52 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2789, (int)AdminPanelPages.DeleteProduct, 2789, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2827, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2894, "\"", 2907, 1);
#line 53 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2902, p.ID, 2902, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2908, 72, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"actionButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2980, "\"", 3025, 1);
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2988, Html.Raw(localization.DeleteProduct), 2988, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3026, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 56 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                }

#line default
#line hidden
            BeginContext(3083, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
    }

#line default
#line hidden
            BeginContext(3140, 20, true);
            WriteLiteral("            </table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProductsLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHostingEnvironment env { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductPage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
