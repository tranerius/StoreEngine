#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "857f44fd22e0f4ab6969e5ac23a68110a369a506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chunks_product_page_content), @"mvc.1.0.view", @"/Views/Chunks/product_page_content.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chunks/product_page_content.cshtml", typeof(AspNetCore.Views_Chunks_product_page_content))]
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
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.Functions;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.Controllers;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.PagesManagement;

#line default
#line hidden
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.ImagesManagement;

#line default
#line hidden
#line 5 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857f44fd22e0f4ab6969e5ac23a68110a369a506", @"/Views/Chunks/product_page_content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a171fe621900d30ce349d435054eba87062936fb", @"/Views/Chunks/_ViewImports.cshtml")]
    public class Views_Chunks_product_page_content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page>
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
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
   Dictionary<int, int> counters = new Dictionary<int, int>(); 

#line default
#line hidden
            BeginContext(76, 58, true);
            WriteLiteral("<div class=\"content-block\">\n\t<div class=\"navigation-menu\">");
            EndContext();
            BeginContext(136, 72, false);
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                             Write(Model != null ? Html.Raw(Model.BreadcrumbsHtml) : Html.Raw(string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(209, 3, true);
            WriteLiteral(" → ");
            EndContext();
            BeginContext(214, 65, false);
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                                                                           Write(Model != null ? Html.Raw(Model.PageName) : Html.Raw(string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(280, 125, true);
            WriteLiteral("</div>\n\t<div class=\"container\">\n\t\t<div class=\"gallery\">\n\t\t\t<a class=\"selected-image-block\" data-lightbox=\"image\" data-title=\"");
            EndContext();
            BeginContext(407, 65, false);
#line 6 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                                          Write(Model != null ? Html.Raw(Model.PageName) : Html.Raw(string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(473, 62, true);
            WriteLiteral("\"><img id=\"selected-image\"></a>\n\t\t\t<div id=\"image-container\">\n");
            EndContext();
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                   var env = Context.RequestServices.GetService(typeof(Microsoft.AspNetCore.Hosting.IHostingEnvironment)) as Microsoft.AspNetCore.Hosting.IHostingEnvironment; foreach (var imgUrl in ImagesManagementFunctions.GetProductImagesUrl(Model as ProductPage, env, 0)) { 

#line default
#line hidden
            BeginContext(806, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 810, "\"", 908, 2);
            WriteAttributeValue("", 815, "image-", 815, 6, true);
            WriteAttributeValue("", 821, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                                                                                                                                                                                                                                                                             if(!counters.ContainsKey(1)) { counters.Add(1, 0); } 

#line default
#line hidden
                BeginContext(885, 13, false);
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                                                                                                                                                                                                                                                                                                                                    Write(++counters[1]);

#line default
#line hidden
                EndContext();
                                                                                                                                                                                                                                                                                                                                                                                                                
                PopWriter();
            }
            ), 821, 87, false);
            EndWriteAttribute();
            BeginContext(909, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(910, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31aef31d85fb47cea83a9b91a9787cce", async() => {
            }
            );
            __Treynessen_TagHelpers_ImageTagHelper = CreateTagHelper<global::Treynessen.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Treynessen_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                    WriteLiteral(imgUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Treynessen_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Treynessen_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxWidth = 350;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-width", __Treynessen_TagHelpers_ImageTagHelper.MaxWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
__Treynessen_TagHelpers_ImageTagHelper.MaxHeight = 270;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("max-height", __Treynessen_TagHelpers_ImageTagHelper.MaxHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
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
            BeginContext(987, 6, true);
            WriteLiteral("</div>");
            EndContext();
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              } 

#line default
#line hidden
            BeginContext(1005, 79, true);
            WriteLiteral("\t\t\t</div>\n\t\t</div>\n\t\t<div class=\"info-container\">\n\t\t\t<div class=\"product-name\">");
            EndContext();
            BeginContext(1086, 65, false);
#line 12 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                  Write(Model != null ? Html.Raw(Model.PageName) : Html.Raw(string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 47, true);
            WriteLiteral("</div>\n\t\t\t<div class=\"price\"><span>Цена:</span>");
            EndContext();
            BeginContext(1201, 336, false);
#line 13 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                                             Write(Model is ProductPage && (Model as ProductPage).OldPrice != 0 ? Html.Raw("<span>" + OtherFunctions.PriceFormatting((Model as ProductPage).Price) + "</span><span>" + OtherFunctions.PriceFormatting((Model as ProductPage).OldPrice) + "</span>") : Html.Raw("<span>" + OtherFunctions.PriceFormatting((Model as ProductPage).Price) + "</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 455, true);
            WriteLiteral(@"</div>
			<div class=""offer"">Если найдете цену ниже, мы предложим более выгодные условия!</div>
			<div class=""info"">Приходите! У нас огромный ассортимент инструмента, есть другие модели!</div>
			<div class=""info"">Звоните со вторника по воскресенье с 11:00 до 17:00</div>
			<div class=""info"">по телефону <a href=""tel:89082905999"">8 9082 905-999</a></div>
		</div>
	</div>
	<div class=""description"">
		<div class=""tab"">Описание</div>
		<div class=""text"">");
            EndContext();
            BeginContext(1995, 64, false);
#line 22 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\product_page_content.cshtml"
                      Write(Model != null ? Html.Raw(Model.Content) : Html.Raw(string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(2060, 22, true);
            WriteLiteral("</div>\n\t</div>\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
