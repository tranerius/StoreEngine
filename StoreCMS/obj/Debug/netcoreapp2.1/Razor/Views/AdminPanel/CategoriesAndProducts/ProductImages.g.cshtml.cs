#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeccde8bfc10da8e4256fc861f888569715e9503"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_ProductImages), @"mvc.1.0.view", @"/Views/AdminPanel/CategoriesAndProducts/ProductImages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/CategoriesAndProducts/ProductImages.cshtml", typeof(AspNetCore.Views_AdminPanel_CategoriesAndProducts_ProductImages))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeccde8bfc10da8e4256fc861f888569715e9503", @"/Views/AdminPanel/CategoriesAndProducts/ProductImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd484aca00b6366db4c9613599bf6cd4bf9f84d6", @"/Views/AdminPanel/CategoriesAndProducts/_ViewImports.cshtml")]
    public class Views_AdminPanel_CategoriesAndProducts_ProductImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
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
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/categories_and_products/product_images.css";
    ProductPage product = Context.Items["ProductPage"] as ProductPage;
    Context.Items["PageName"] = $"{localization.ProductImagesPageName} {product?.PageName}";
    User user = Context.Items["User"] as User;

#line default
#line hidden
            BeginContext(423, 130, true);
            WriteLiteral("<script src=\"/scripts/admin_panel/send_data.js\"></script>\r\n            <script src=\"/scripts/admin_panel/send_file.js\"></script>\r\n");
            EndContext();
#line 12 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddProductImage, user, Context))
{

#line default
#line hidden
            BeginContext(641, 142, true);
            WriteLiteral("            <form class=\"upload-image\">\r\n                <div class=\"input-file-button\">\r\n                    <label for=\"upload-file-button\">");
            EndContext();
            BeginContext(784, 34, false);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                               Write(Html.Raw(localization.UploadImage));

#line default
#line hidden
            EndContext();
            BeginContext(818, 267, true);
            WriteLiteral(@"</label>
                    <input type=""file"" id=""upload-file-button"" name=""uploadedFile"" accept="".jpg, .jpeg"" />
                </div>
            </form>
            <script>
                function successfulRequestHandler() {
                    alert('");
            EndContext();
            BeginContext(1086, 36, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                      Write(Html.Raw(localization.ImageUploaded));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 141, true);
            WriteLiteral("\');\r\n                    location.reload();\r\n                }\r\n                function errorRequestHandler() {\r\n                    alert(\'");
            EndContext();
            BeginContext(1264, 50, false);
#line 26 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                      Write(Html.Raw(localization.UnsuccessfullyImageUploaded));

#line default
#line hidden
            EndContext();
            BeginContext(1314, 68, true);
            WriteLiteral("\');\r\n                }\r\n                let searchString = \'?pageID=");
            EndContext();
            BeginContext(1384, 36, false);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                        Write((int)AdminPanelPages.AddProductImage);

#line default
#line hidden
            EndContext();
            BeginContext(1421, 8, true);
            WriteLiteral("&itemID=");
            EndContext();
            BeginContext(1430, 11, false);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                                                                      Write(product?.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1441, 281, true);
            WriteLiteral(@"';
                let uploadFileButton = document.getElementById('upload-file-button');
                uploadFileButton.addEventListener('change', createSendFileEventHandler(searchString, successfulRequestHandler, errorRequestHandler,'.jpeg', '.jpg'));
            </script>
");
            EndContext();
#line 32 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
}

#line default
#line hidden
            BeginContext(1725, 39, true);
            WriteLiteral("            <div class=\"images-list\">\r\n");
            EndContext();
#line 34 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
      
        int imageID = 0;
    

#line default
#line hidden
            BeginContext(1805, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 37 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
     foreach (var m in Model)
    {

#line default
#line hidden
            BeginContext(1843, 68, true);
            WriteLiteral("                <div class=\"image-block\">\r\n                    <div>");
            EndContext();
            BeginContext(1911, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd7a97be52ac4a518781f53358c6e081", async() => {
            }
            );
            __Treynessen_TagHelpers_ImageTagHelper = CreateTagHelper<global::Treynessen.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Treynessen_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                         WriteLiteral(m);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Treynessen_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Treynessen_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxWidth = 290;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-width", __Treynessen_TagHelpers_ImageTagHelper.MaxWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxHeight = 175;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-height", __Treynessen_TagHelpers_ImageTagHelper.MaxHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.Quality = 80;

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
            BeginContext(1981, 35, true);
            WriteLiteral("</div>\r\n                    <label>");
            EndContext();
            BeginContext(2017, 35, false);
#line 41 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                      Write(m.Substring(m.LastIndexOf('/') + 1));

#line default
#line hidden
            EndContext();
            BeginContext(2052, 35, true);
            WriteLiteral("</label>\r\n                    <form");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2087, "\"", 2124, 2);
            WriteAttributeValue("", 2092, "delete-image-form-", 2092, 18, true);
#line 42 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 2110, imageID + 1, 2110, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2125, 62, true);
            WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"imageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2187, "\"", 2203, 1);
#line 43 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 2195, imageID, 2195, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2204, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 44 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteProductImage, user, Context))
                {

#line default
#line hidden
            BeginContext(2330, 30, true);
            WriteLiteral("                        <input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2360, "\"", 2399, 2);
            WriteAttributeValue("", 2365, "delete-image-button-", 2365, 20, true);
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 2385, imageID + 1, 2385, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2400, 14, true);
            WriteLiteral(" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2414, "\"", 2464, 1);
#line 46 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 2422, Html.Raw(localization.DeleteProductImage), 2422, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2465, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2530, 44, true);
            WriteLiteral("                        <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2574, "\"", 2624, 1);
#line 50 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 2582, Html.Raw(localization.DeleteProductImage), 2582, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2625, 14, true);
            WriteLiteral(" disabled />\r\n");
            EndContext();
#line 51 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                }

#line default
#line hidden
            BeginContext(2658, 29, true);
            WriteLiteral("                    </form>\r\n");
            EndContext();
#line 53 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteProductImage, user, Context))
                {

#line default
#line hidden
            BeginContext(2810, 76, true);
            WriteLiteral("                    <script>\r\n                        let deleteImageButton_");
            EndContext();
            BeginContext(2888, 11, false);
#line 56 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                          Write(imageID + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2900, 48, true);
            WriteLiteral(" = document.getElementById(\'delete-image-button-");
            EndContext();
            BeginContext(2950, 11, false);
#line 56 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                                                                                        Write(imageID + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2962, 47, true);
            WriteLiteral("\');\r\n                        deleteImageButton_");
            EndContext();
            BeginContext(3011, 11, false);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                      Write(imageID + 1);

#line default
#line hidden
            EndContext();
            BeginContext(3023, 73, true);
            WriteLiteral(".addEventListener(\'click\', createSendDataEventHandler(\'DELETE\', \'?pageID=");
            EndContext();
            BeginContext(3098, 39, false);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                                                                                                             Write((int)AdminPanelPages.DeleteProductImage);

#line default
#line hidden
            EndContext();
            BeginContext(3138, 8, true);
            WriteLiteral("&itemID=");
            EndContext();
            BeginContext(3147, 11, false);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                                                                                                                                                              Write(product?.ID);

#line default
#line hidden
            EndContext();
            BeginContext(3158, 22, true);
            WriteLiteral("\', \'delete-image-form-");
            EndContext();
            BeginContext(3182, 11, false);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                                                                                                                                                                                                 Write(imageID + 1);

#line default
#line hidden
            EndContext();
            BeginContext(3194, 18, true);
            WriteLiteral("\', () => { alert(\'");
            EndContext();
            BeginContext(3213, 35, false);
#line 57 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                                                                                                                                                                                                                                Write(Html.Raw(localization.ImageDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(3248, 60, true);
            WriteLiteral("\'); location.reload(); }));\r\n                    </script>\r\n");
            EndContext();
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                }

#line default
#line hidden
            BeginContext(3327, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 61 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
        imageID++;
    }

#line default
#line hidden
            BeginContext(3378, 18, true);
            WriteLiteral("            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
