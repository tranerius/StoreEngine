#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d551771c101d86a1ca927e37148346564548acc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Templates_AddTemplate), @"mvc.1.0.view", @"/Views/AdminPanel/Templates/AddTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/Templates/AddTemplate.cshtml", typeof(AspNetCore.Views_AdminPanel_Templates_AddTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d551771c101d86a1ca927e37148346564548acc", @"/Views/AdminPanel/Templates/AddTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72ebc596467cb325db31555bef712b3fd90abe7", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_Templates_AddTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TemplateModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml"
  
    Layout = "CommonPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/templates/workWithTemplate.css";
    bool incorrect = Model == null ? false : true;

#line default
#line hidden
            BeginContext(242, 56, true);
            WriteLiteral("            <form method=\"post\" class=\"pageContainer\">\r\n");
            EndContext();
#line 9 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml"
             if (incorrect)
            {

#line default
#line hidden
            BeginContext(342, 22, true);
            WriteLiteral("                <span>");
            EndContext();
            BeginContext(365, 37, false);
#line 11 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml"
                 Write(Html.Raw(localization.IncorrectInput));

#line default
#line hidden
            EndContext();
            BeginContext(402, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 12 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml"
            }

#line default
#line hidden
            BeginContext(426, 79, true);
            WriteLiteral("                <div class=\"nameBlock\">\r\n                    <label for=\"Name\">");
            EndContext();
            BeginContext(506, 27, false);
#line 14 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml"
                                 Write(Html.Raw(localization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(533, 84, true);
            WriteLiteral("</label>\r\n                    <input type=\"text\" id=\"Name\" name=\"TemplateModel.Name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 617, "\"", 637, 1);
#line 15 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml"
WriteAttributeValue("", 625, Model?.Name, 625, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(638, 82, true);
            WriteLiteral(" required />\r\n                </div>\r\n                <label for=\"TemplateSource\">");
            EndContext();
            BeginContext(721, 35, false);
#line 17 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml"
                                       Write(Html.Raw(localization.TemplateCode));

#line default
#line hidden
            EndContext();
            BeginContext(756, 92, true);
            WriteLiteral("</label>\r\n                <textarea id=\"TemplateSource\" name=\"TemplateModel.TemplateSource\">");
            EndContext();
            BeginContext(849, 21, false);
#line 18 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml"
                                                                             Write(Model?.TemplateSource);

#line default
#line hidden
            EndContext();
            BeginContext(870, 49, true);
            WriteLiteral("</textarea>\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 919, "\"", 961, 1);
#line 19 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\Templates\AddTemplate.cshtml"
WriteAttributeValue("", 927, Html.Raw(localization.SaveButton), 927, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(962, 24, true);
            WriteLiteral(" />\r\n            </form>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITemplatesLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TemplateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
