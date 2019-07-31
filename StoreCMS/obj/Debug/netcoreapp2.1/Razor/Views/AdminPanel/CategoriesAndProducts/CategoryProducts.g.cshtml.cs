#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41dfe90bc2d8ed7a8648ec3bedeb5a501440ff2e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41dfe90bc2d8ed7a8648ec3bedeb5a501440ff2e", @"/Views/AdminPanel/CategoriesAndProducts/CategoryProducts.cshtml")]
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
    Context.Items["PageStyle"] = "/styles/admin_panel/categories_and_products/category_products.css";
    int categoryID = (int)Context.Items["itemID"];
    string categoryName = Context.Items["categoryName"] as string;
    Context.Items["PageName"] = $"{localization.CategoryProductsPageName} {categoryName}";
    User user = Context.Items["User"] as User;

#line default
#line hidden
            BeginContext(583, 215, true);
            WriteLiteral("<script src=\"/scripts/admin_panel/send_data.js\"></script>\r\n            <script>\r\n                function responseHandler(request) {\r\n                    if (request.status == 200) {\r\n                        alert(\'");
            EndContext();
            BeginContext(799, 37, false);
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                          Write(Html.Raw(localization.ProductDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(836, 158, true);
            WriteLiteral("\');\r\n                        location.reload();\r\n                    }\r\n                    else if (request.status == 404) {\r\n                        alert(\'");
            EndContext();
            BeginContext(995, 38, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                          Write(Html.Raw(localization.ProductNotFound));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 70, true);
            WriteLiteral("\');\r\n                    }\r\n                }\r\n            </script>\r\n");
            EndContext();
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddProduct, user, Context))
{

#line default
#line hidden
            BeginContext(1186, 64, true);
            WriteLiteral("            <div class=\"add-product-button\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1250, "\"", 1339, 5);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 1257, Context.Request.Path, 1257, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1278, "?pageID=", 1278, 8, true);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 1286, (int)AdminPanelPages.AddProduct, 1286, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 1320, "&itemID=", 1320, 8, true);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 1328, categoryID, 1328, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1340, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1342, 70, false);
#line 29 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                                                                                                        Write(Html.Raw($"{localization.AddProductInCategory} <b>{categoryName}</b>"));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 26, true);
            WriteLiteral("</a>\r\n            </div>\r\n");
            EndContext();
#line 31 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
}

#line default
#line hidden
            BeginContext(1441, 98, true);
            WriteLiteral("            <table>\r\n                <tr>\r\n                    <td></td>\r\n                    <td>");
            EndContext();
            BeginContext(1540, 27, false);
#line 35 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                   Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 65, true);
            WriteLiteral("</td>\r\n                    <td>URL</td>\r\n                    <td>");
            EndContext();
            BeginContext(1633, 30, false);
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                   Write(Html.Raw(localization.Actions));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 39 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                 foreach (var p in Model)
                {

#line default
#line hidden
            BeginContext(1755, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1801, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b96b2026ab4b1c8974dd517f785ae8", async() => {
            }
            );
            __Treynessen_TagHelpers_ImageTagHelper = CreateTagHelper<global::Treynessen.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Treynessen_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                        WriteLiteral(Html.Raw($"{env.GetProductsImagesFolderSrc()}{p.PreviousPageID.ToString()}{p.ID.ToString()}/{p.Alias}.jpg"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Treynessen_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Treynessen_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxHeight = 150;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-height", __Treynessen_TagHelpers_ImageTagHelper.MaxHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxWidth = 150;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-width", __Treynessen_TagHelpers_ImageTagHelper.MaxWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
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
            BeginContext(1977, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2009, 54, false);
#line 43 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                   Write(Html.Raw($"{p.PageName} <b>(ID{p.ID.ToString()})</b>"));

#line default
#line hidden
            EndContext();
            BeginContext(2063, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2095, 23, false);
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                   Write(Html.Raw(p.RequestPath));

#line default
#line hidden
            EndContext();
            BeginContext(2118, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditProduct, user, Context))
                {

#line default
#line hidden
            BeginContext(2267, 107, true);
            WriteLiteral("                        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2374, "\"", 2417, 1);
#line 49 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2382, (int)AdminPanelPages.EditProduct, 2382, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2418, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2485, "\"", 2498, 1);
#line 50 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2493, p.ID, 2493, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2499, 73, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"action-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2572, "\"", 2615, 1);
#line 51 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2580, Html.Raw(localization.EditProduct), 2580, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2616, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 53 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                }

#line default
#line hidden
            BeginContext(2673, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 54 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.ProductImages, user, Context))
                {

#line default
#line hidden
            BeginContext(2791, 91, true);
            WriteLiteral("        <form method=\"get\">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2882, "\"", 2927, 1);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 2890, (int)AdminPanelPages.ProductImages, 2890, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2928, 67, true);
            WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2995, "\"", 3008, 1);
#line 58 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 3003, p.ID, 3003, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3009, 73, true);
            WriteLiteral(">\r\n                            <input type=\"submit\" class=\"action-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3082, "\"", 3127, 1);
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 3090, Html.Raw(localization.ProductImages), 3090, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3128, 38, true);
            WriteLiteral(" />\r\n                        </form>\r\n");
            EndContext();
#line 61 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                }

#line default
#line hidden
            BeginContext(3185, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 62 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteProduct, user, Context))
                {

#line default
#line hidden
            BeginContext(3303, 17, true);
            WriteLiteral("            <form");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3320, "\"", 3345, 2);
            WriteAttributeValue("", 3325, "delete-product-", 3325, 15, true);
#line 64 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 3340, p.ID, 3340, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3346, 65, true);
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3411, "\"", 3456, 1);
#line 65 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 3419, (int)AdminPanelPages.DeleteProduct, 3419, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3457, 65, true);
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3522, "\"", 3535, 1);
#line 66 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 3530, p.ID, 3530, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3536, 37, true);
            WriteLiteral(">\r\n                            <input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3573, "\"", 3605, 2);
            WriteAttributeValue("", 3578, "delete-product-button-", 3578, 22, true);
#line 67 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 3600, p.ID, 3600, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3606, 36, true);
            WriteLiteral(" type=\"submit\" class=\"action-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3642, "\"", 3687, 1);
#line 67 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
WriteAttributeValue("", 3650, Html.Raw(localization.DeleteProduct), 3650, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3688, 147, true);
            WriteLiteral(" />\r\n                        </form>\r\n                        <script>\r\n                            document.getElementById(\'delete-product-button-");
            EndContext();
            BeginContext(3836, 4, false);
#line 70 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                                                                      Write(p.ID);

#line default
#line hidden
            EndContext();
            BeginContext(3840, 82, true);
            WriteLiteral("\').addEventListener(\'click\', createSendDataEventHandler(\'DELETE\', \'delete-product-");
            EndContext();
            BeginContext(3923, 4, false);
#line 70 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                                                                                                                                                             Write(p.ID);

#line default
#line hidden
            EndContext();
            BeginContext(3927, 58, true);
            WriteLiteral("\', responseHandler));\r\n                        </script>\r\n");
            EndContext();
#line 72 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
                }

#line default
#line hidden
            BeginContext(4004, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 75 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\CategoryProducts.cshtml"
    }

#line default
#line hidden
            BeginContext(4061, 20, true);
            WriteLiteral("            </table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICategoriesAndProductsLocalization localization { get; private set; }
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
