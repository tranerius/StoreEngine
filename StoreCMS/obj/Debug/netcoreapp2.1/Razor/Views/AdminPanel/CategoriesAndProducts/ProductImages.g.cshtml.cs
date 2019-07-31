#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c93f22930865b04293aaa595c0ca93b22c416c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c93f22930865b04293aaa595c0ca93b22c416c", @"/Views/AdminPanel/CategoriesAndProducts/ProductImages.cshtml")]
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
            BeginContext(641, 109, true);
            WriteLiteral("            <form id=\"upload-image\" class=\"upload-image\">\r\n                <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 750, "\"", 797, 1);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 758, (int)AdminPanelPages.AddProductImage, 758, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(798, 53, true);
            WriteLiteral(">\r\n                <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 851, "\"", 871, 1);
#line 16 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 859, product?.ID, 859, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(872, 104, true);
            WriteLiteral(">\r\n                <div class=\"input-file-button\">\r\n                    <label for=\"upload-file-button\">");
            EndContext();
            BeginContext(977, 34, false);
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                               Write(Html.Raw(localization.UploadImage));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 256, true);
            WriteLiteral(@"</label>
                    <input type=""file"" id=""upload-file-button"" name=""uploadedFile"" accept="".jpg, .jpeg"" /> 
                </div>
            </form>
            <script>
                function errorHandler() {
                    alert('");
            EndContext();
            BeginContext(1268, 50, false);
#line 24 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                      Write(Html.Raw(localization.UnsuccessfullyImageUploaded));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 158, true);
            WriteLiteral("\');\r\n                }\r\n                function responseHandler(request) {\r\n                    if (request.status == 200) {\r\n                        alert(\'");
            EndContext();
            BeginContext(1477, 36, false);
#line 28 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                          Write(Html.Raw(localization.ImageUploaded));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 439, true);
            WriteLiteral(@"');
                        location.reload();
                    }
                    else if (request.status == 415) {
                        errorHandler();
                    }
                    
                }
                document.getElementById('upload-file-button').addEventListener('change', createSendFileEventHandler('upload-image', responseHandler, errorHandler, '.jpeg', '.jpg')); 
            </script>
");
            EndContext();
#line 38 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
}

#line default
#line hidden
            BeginContext(1955, 39, true);
            WriteLiteral("            <div class=\"images-list\">\r\n");
            EndContext();
#line 40 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
      
        int imageID = 0;
    

#line default
#line hidden
            BeginContext(2035, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 43 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
     if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteProductImage, user, Context))
    {

#line default
#line hidden
            BeginContext(2134, 100, true);
            WriteLiteral("            <script>\r\n                    function errorHandler() {\r\n                        alert(\'");
            EndContext();
            BeginContext(2235, 36, false);
#line 47 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                          Write(Html.Raw(localization.ImageNotFound));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 174, true);
            WriteLiteral("\');\r\n                    }\r\n                    function responseHandler(request) {\r\n                        if (request.status == 200) {\r\n                            alert(\'");
            EndContext();
            BeginContext(2446, 35, false);
#line 51 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                              Write(Html.Raw(localization.ImageDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2481, 261, true);
            WriteLiteral(@"');
                            location.reload();
                        }
                        else if (request.status == 404) {
                            errorHandler();
                        }
                    }
                </script>
");
            EndContext();
#line 59 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
    }

#line default
#line hidden
            BeginContext(2749, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 60 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
     foreach (var m in Model)
    {

#line default
#line hidden
            BeginContext(2787, 64, true);
            WriteLiteral("            <div class=\"image-block\">\r\n                    <div>");
            EndContext();
            BeginContext(2851, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76f63ebc75654c72bf8d9f4d10ac8bec", async() => {
            }
            );
            __Treynessen_TagHelpers_ImageTagHelper = CreateTagHelper<global::Treynessen.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Treynessen_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                         WriteLiteral(m);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Treynessen_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Treynessen_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxWidth = 290;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-width", __Treynessen_TagHelpers_ImageTagHelper.MaxWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxHeight = 175;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-height", __Treynessen_TagHelpers_ImageTagHelper.MaxHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 63 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
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
            BeginContext(2921, 35, true);
            WriteLiteral("</div>\r\n                    <label>");
            EndContext();
            BeginContext(2957, 35, false);
#line 64 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                      Write(m.Substring(m.LastIndexOf('/') + 1));

#line default
#line hidden
            EndContext();
            BeginContext(2992, 35, true);
            WriteLiteral("</label>\r\n                    <form");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3027, "\"", 3059, 2);
            WriteAttributeValue("", 3032, "delete-image-", 3032, 13, true);
#line 65 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 3045, imageID + 1, 3045, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3060, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 66 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteProductImage, user, Context))
                {

#line default
#line hidden
            BeginContext(3186, 58, true);
            WriteLiteral("                        <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3244, "\"", 3294, 1);
#line 68 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 3252, (int)AdminPanelPages.DeleteProductImage, 3252, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3295, 61, true);
            WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3356, "\"", 3376, 1);
#line 69 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 3364, product?.ID, 3364, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3377, 62, true);
            WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"imageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3439, "\"", 3455, 1);
#line 70 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 3447, imageID, 3447, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3456, 33, true);
            WriteLiteral(">\r\n                        <input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3489, "\"", 3528, 2);
            WriteAttributeValue("", 3494, "delete-image-button-", 3494, 20, true);
#line 71 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 3514, imageID + 1, 3514, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3529, 14, true);
            WriteLiteral(" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3543, "\"", 3593, 1);
#line 71 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 3551, Html.Raw(localization.DeleteProductImage), 3551, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3594, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 72 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3659, 44, true);
            WriteLiteral("                        <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3703, "\"", 3753, 1);
#line 75 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
WriteAttributeValue("", 3711, Html.Raw(localization.DeleteProductImage), 3711, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3754, 14, true);
            WriteLiteral(" disabled />\r\n");
            EndContext();
#line 76 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                }

#line default
#line hidden
            BeginContext(3787, 29, true);
            WriteLiteral("                    </form>\r\n");
            EndContext();
#line 78 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                 if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteProductImage, user, Context))
                {

#line default
#line hidden
            BeginContext(3939, 99, true);
            WriteLiteral("                    <script>\r\n                        document.getElementById(\'delete-image-button-");
            EndContext();
            BeginContext(4040, 11, false);
#line 81 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                                                 Write(imageID + 1);

#line default
#line hidden
            EndContext();
            BeginContext(4052, 80, true);
            WriteLiteral("\').addEventListener(\'click\', createSendDataEventHandler(\'DELETE\', \'delete-image-");
            EndContext();
            BeginContext(4134, 11, false);
#line 81 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                                                                                                                                                               Write(imageID + 1);

#line default
#line hidden
            EndContext();
            BeginContext(4146, 68, true);
            WriteLiteral("\', responseHandler, errorHandler));\r\n                    </script>\r\n");
            EndContext();
#line 83 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
                }

#line default
#line hidden
            BeginContext(4233, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 85 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\CategoriesAndProducts\ProductImages.cshtml"
        imageID++;
    }

#line default
#line hidden
            BeginContext(4284, 14, true);
            WriteLiteral("        </div>");
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
