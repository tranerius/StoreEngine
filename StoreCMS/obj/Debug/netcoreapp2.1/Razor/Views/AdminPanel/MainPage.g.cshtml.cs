#pragma checksum "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44145171a72e4eb3b093461593db8343e967a4c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_MainPage), @"mvc.1.0.view", @"/Views/AdminPanel/MainPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/MainPage.cshtml", typeof(AspNetCore.Views_AdminPanel_MainPage))]
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
using Trane.Functions;

#line default
#line hidden
#line 2 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Trane.OtherTypes;

#line default
#line hidden
#line 3 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Trane.Database.Context;

#line default
#line hidden
#line 4 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Trane.Database.Entities;

#line default
#line hidden
#line 5 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Trane.DependencyInjection;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44145171a72e4eb3b093461593db8343e967a4c0", @"/Views/AdminPanel/MainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9049d201b75fa75abda620bf76a94272daa30415", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\MainPage.cshtml"
  
    User user = Context.Items["User"] as User;
    Layout = "AdminPanelPage";
    Context.Items["PageStyle"] = "/styles/admin_panel/main_page.css";
    AccessLevelConfiguration configuration = Context.Items["AccessLevelConfiguration"] as AccessLevelConfiguration;

#line default
#line hidden
            BeginContext(275, 31, true);
            WriteLiteral("Main Page<br />\r\nПользователь: ");
            EndContext();
            BeginContext(307, 36, false);
#line 8 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\MainPage.cshtml"
         Write(user.UserType.AccessLevel.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(343, 26, true);
            WriteLiteral("<br />\r\nГлавная страница: ");
            EndContext();
            BeginContext(370, 26, false);
#line 9 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\MainPage.cshtml"
             Write(configuration.ShowMainPage);

#line default
#line hidden
            EndContext();
            BeginContext(396, 18, true);
            WriteLiteral("<br />\r\nСтраницы: ");
            EndContext();
            BeginContext(415, 23, false);
#line 10 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\MainPage.cshtml"
     Write(configuration.ShowPages);

#line default
#line hidden
            EndContext();
            BeginContext(438, 27, true);
            WriteLiteral("<br />\r\nДобавить страницу: ");
            EndContext();
            BeginContext(466, 21, false);
#line 11 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\MainPage.cshtml"
              Write(configuration.AddPage);

#line default
#line hidden
            EndContext();
            BeginContext(487, 19, true);
            WriteLiteral("<br />\r\nНастройки: ");
            EndContext();
            BeginContext(507, 30, false);
#line 12 "D:\Users\trane\Desktop\github\StoreCMS\StoreCMS\Views\AdminPanel\MainPage.cshtml"
      Write(configuration.AccessToSettings);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
