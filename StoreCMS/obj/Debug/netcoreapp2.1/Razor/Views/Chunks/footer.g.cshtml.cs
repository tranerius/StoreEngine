#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c102f4d98a71280bf4558ebe028f16aa49e014ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chunks_footer), @"mvc.1.0.view", @"/Views/Chunks/footer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chunks/footer.cshtml", typeof(AspNetCore.Views_Chunks_footer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c102f4d98a71280bf4558ebe028f16aa49e014ad", @"/Views/Chunks/footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a171fe621900d30ce349d435054eba87062936fb", @"/Views/Chunks/_ViewImports.cshtml")]
    public class Views_Chunks_footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 252, true);
            WriteLiteral("<div class=\"footer-block\">\n\t<p>Информация, содержащаяся на данном сайте, имеет справочный характер и не является публичной офертой</p>\n\t<p>InstrumentShop39.RU сайт-витрина магазина «Инструмент». Электроинструмент в Калининграде по самым низким ценам © ");
            EndContext();
            BeginContext(266, 17, false);
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\Chunks\footer.cshtml"
                                                                                                                    Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(284, 11, true);
            WriteLiteral("</p>\n</div>");
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
