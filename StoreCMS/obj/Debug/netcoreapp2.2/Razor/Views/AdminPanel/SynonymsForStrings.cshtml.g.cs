#pragma checksum "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b3c060f56599054b99168bba49b6600cdbbc35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_SynonymsForStrings), @"mvc.1.0.view", @"/Views/AdminPanel/SynonymsForStrings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPanel/SynonymsForStrings.cshtml", typeof(AspNetCore.Views_AdminPanel_SynonymsForStrings))]
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
#line 1 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Security;

#line default
#line hidden
#line 2 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Localization;

#line default
#line hidden
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.PagesManagement;

#line default
#line hidden
#line 4 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.AdminPanelTypes;

#line default
#line hidden
#line 5 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Context;

#line default
#line hidden
#line 6 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\_ViewImports.cshtml"
using Treynessen.Database.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b3c060f56599054b99168bba49b6600cdbbc35", @"/Views/AdminPanel/SynonymsForStrings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643dee66794a2698b58719ead6ad3b58418e7a0e", @"/Views/AdminPanel/_ViewImports.cshtml")]
    public class Views_AdminPanel_SynonymsForStrings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SynonymForString[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
  
    Layout = "CommonPage";
    User user = Context.Items["User"] as User;
    Context.Items["PageName"] = localization.PageName;
    Context.Items["PageStyle"] = "/styles/admin_panel/synonyms_for_strings.css";

#line default
#line hidden
            BeginContext(302, 92, true);
            WriteLiteral("<script>\r\n                        function errorMsg() {\r\n                            alert(\'");
            EndContext();
            BeginContext(395, 31, false);
#line 11 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                              Write(Html.Raw(localization.ErrorMsg));

#line default
#line hidden
            EndContext();
            BeginContext(426, 194, true);
            WriteLiteral("\');\r\n                        }\r\n                        function responseFromEditing(request) {\r\n                            if (request.status == 200) {\r\n                                alert(\'");
            EndContext();
            BeginContext(621, 45, false);
#line 15 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                  Write(Html.Raw(localization.SynonymForStringEdited));

#line default
#line hidden
            EndContext();
            BeginContext(666, 417, true);
            WriteLiteral(@"');
                                location.reload();
                            }
                            else if (request.status == 422) {
                                errorMsg();
                            }
                        }
                        function responseFromDeleting(request) {
                            if (request.status == 200) {
                                alert('");
            EndContext();
            BeginContext(1084, 46, false);
#line 24 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                  Write(Html.Raw(localization.SynonymForStringDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 190, true);
            WriteLiteral("\');\r\n                                location.reload();\r\n                            }\r\n                            else if (request.status == 404) {\r\n                                alert(\'");
            EndContext();
            BeginContext(1321, 47, false);
#line 28 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                  Write(Html.Raw(localization.SynonymForStringNotFound));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 94, true);
            WriteLiteral("\');\r\n                            }\r\n                        }\r\n                    </script>\r\n");
            EndContext();
#line 32 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
 if (SecurityFunctions.HasAccessTo(AdminPanelPages.AddSynonymForString, user, Context))
{

#line default
#line hidden
            BeginContext(1554, 132, true);
            WriteLiteral("                    <form id=\"add-synonym-for-string\" class=\"container\">\r\n                        <input type=\"hidden\" name=\"pageID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1686, "\"", 1737, 1);
#line 35 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 1694, (int)AdminPanelPages.AddSynonymForString, 1694, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1738, 97, true);
            WriteLiteral(">\r\n                        <div class=\"string\">\r\n                            <label for=\"string\">");
            EndContext();
            BeginContext(1836, 29, false);
#line 37 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                           Write(Html.Raw(localization.String));

#line default
#line hidden
            EndContext();
            BeginContext(1865, 235, true);
            WriteLiteral("</label>\r\n                            <input type=\"text\" id=\"string\" name=\"SynonymForStringModel.String\">\r\n                        </div>\r\n                        <div class=\"synonym\">\r\n                            <label for=\"synonym\">");
            EndContext();
            BeginContext(2101, 30, false);
#line 41 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                            Write(Html.Raw(localization.Synonym));

#line default
#line hidden
            EndContext();
            BeginContext(2131, 251, true);
            WriteLiteral("</label>\r\n                            <input type=\"text\" id=\"synonym\" name=\"SynonymForStringModel.Synonym\">\r\n                        </div>\r\n                        <div class=\"action\">\r\n                            <input type=\"submit\" id=\"add-button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2382, "\"", 2417, 1);
#line 45 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 2390, Html.Raw(localization.Add), 2390, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2418, 255, true);
            WriteLiteral(">\r\n                        </div>\r\n                    </form>\r\n                    <script>\r\n                        function responseFromAdding(request) {\r\n                            if (request.status == 201) {\r\n                                alert(\'");
            EndContext();
            BeginContext(2674, 44, false);
#line 51 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                  Write(Html.Raw(localization.SynonymForStringAdded));

#line default
#line hidden
            EndContext();
            BeginContext(2718, 467, true);
            WriteLiteral(@"');
                                location.reload();
                            }
                            else if (request.status == 422) {
                                errorMsg();
                            }
                        }
                        document.getElementById('add-button').addEventListener('click', createSendDataEventHandler('POST', 'add-synonym-for-string', responseFromAdding, errorMsg));
                    </script>
");
            EndContext();
#line 60 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
}

#line default
#line hidden
#line 61 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
 foreach (var pair in Model)
{

#line default
#line hidden
            BeginContext(3221, 25, true);
            WriteLiteral("                    <form");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3246, "\"", 3278, 2);
            WriteAttributeValue("", 3251, "synonym-for-string-", 3251, 19, true);
#line 63 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 3270, pair.ID, 3270, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3279, 65, true);
            WriteLiteral(" class=\"container\">\r\n                        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3344, "\"", 3364, 2);
            WriteAttributeValue("", 3349, "pageID-", 3349, 7, true);
#line 64 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 3356, pair.ID, 3356, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3365, 75, true);
            WriteLiteral(" name=\"pageID\">\r\n                        <input type=\"hidden\" name=\"itemID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3440, "\"", 3456, 1);
#line 65 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 3448, pair.ID, 3448, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3457, 83, true);
            WriteLiteral(">\r\n                        <div class=\"string\">\r\n                            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 3540, "\"", 3561, 2);
            WriteAttributeValue("", 3546, "string-", 3546, 7, true);
#line 67 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 3553, pair.ID, 3553, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3562, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3564, 29, false);
#line 67 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                    Write(Html.Raw(localization.String));

#line default
#line hidden
            EndContext();
            BeginContext(3593, 56, true);
            WriteLiteral("</label>\r\n                            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3649, "\"", 3669, 2);
            WriteAttributeValue("", 3654, "string-", 3654, 7, true);
#line 68 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 3661, pair.ID, 3661, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3670, 36, true);
            WriteLiteral(" name=\"SynonymForStringModel.String\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3706, "\"", 3727, 1);
#line 68 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 3714, pair?.String, 3714, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3728, 116, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"synonym\">\r\n                            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 3844, "\"", 3866, 2);
            WriteAttributeValue("", 3850, "synonym-", 3850, 8, true);
#line 71 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 3858, pair.ID, 3858, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3867, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3869, 30, false);
#line 71 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                     Write(Html.Raw(localization.Synonym));

#line default
#line hidden
            EndContext();
            BeginContext(3899, 56, true);
            WriteLiteral("</label>\r\n                            <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3955, "\"", 3976, 2);
            WriteAttributeValue("", 3960, "synonym-", 3960, 8, true);
#line 72 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 3968, pair.ID, 3968, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3977, 37, true);
            WriteLiteral(" name=\"SynonymForStringModel.Synonym\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4014, "\"", 4036, 1);
#line 72 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 4022, pair?.Synonym, 4022, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4037, 82, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"actions\">\r\n");
            EndContext();
#line 75 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
             if (SecurityFunctions.HasAccessTo(AdminPanelPages.EditSynonymForString, user, Context))
            {

#line default
#line hidden
            BeginContext(4236, 48, true);
            WriteLiteral("                            <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4284, "\"", 4309, 2);
            WriteAttributeValue("", 4289, "edit-button-", 4289, 12, true);
#line 77 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 4301, pair.ID, 4301, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4310, "\"", 4346, 1);
#line 77 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 4318, Html.Raw(localization.Edit), 4318, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4347, 88, true);
            WriteLiteral(">\r\n                            <script>\r\n                                let editButton_");
            EndContext();
            BeginContext(4437, 7, false);
#line 79 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                           Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4445, 40, true);
            WriteLiteral(" = document.getElementById(\'edit-button-");
            EndContext();
            BeginContext(4487, 7, false);
#line 79 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                                                             Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4495, 48, true);
            WriteLiteral("\');\r\n                                editButton_");
            EndContext();
            BeginContext(4545, 7, false);
#line 80 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                       Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4553, 67, true);
            WriteLiteral(".addEventListener(\'click\', () => { document.getElementById(\'pageID-");
            EndContext();
            BeginContext(4621, 7, false);
#line 80 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                                                                                   Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4628, 26, true);
            WriteLiteral("\').setAttribute(\'value\', \'");
            EndContext();
            BeginContext(4656, 41, false);
#line 80 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                                                                                                                      Write((int)AdminPanelPages.EditSynonymForString);

#line default
#line hidden
            EndContext();
            BeginContext(4698, 52, true);
            WriteLiteral("\'); });\r\n                                editButton_");
            EndContext();
            BeginContext(4752, 7, false);
#line 81 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                       Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4760, 82, true);
            WriteLiteral(".addEventListener(\'click\', createSendDataEventHandler(\'POST\', \'synonym-for-string-");
            EndContext();
            BeginContext(4844, 7, false);
#line 81 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                                                                                                   Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4852, 76, true);
            WriteLiteral("\', responseFromEditing, errorMsg));\r\n                            </script>\r\n");
            EndContext();
#line 83 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(4976, 48, true);
            WriteLiteral("                            <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5024, "\"", 5060, 1);
#line 86 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 5032, Html.Raw(localization.Edit), 5032, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5061, 12, true);
            WriteLiteral(" disabled>\r\n");
            EndContext();
#line 87 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
            }

#line default
#line hidden
            BeginContext(5088, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 88 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
             if (SecurityFunctions.HasAccessTo(AdminPanelPages.DeleteSynonymForString, user, Context))
            {

#line default
#line hidden
            BeginContext(5207, 36, true);
            WriteLiteral("                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5243, "\"", 5270, 2);
            WriteAttributeValue("", 5248, "delete-button-", 5248, 14, true);
#line 90 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 5262, pair.ID, 5262, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 5271, "\"", 5309, 1);
#line 90 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 5279, Html.Raw(localization.Delete), 5279, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5310, 90, true);
            WriteLiteral(">\r\n                            <script>\r\n                                let deleteButton_");
            EndContext();
            BeginContext(5402, 7, false);
#line 92 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                             Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(5410, 42, true);
            WriteLiteral(" = document.getElementById(\'delete-button-");
            EndContext();
            BeginContext(5454, 7, false);
#line 92 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                                                                 Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(5462, 50, true);
            WriteLiteral("\');\r\n                                deleteButton_");
            EndContext();
            BeginContext(5514, 7, false);
#line 93 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                         Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(5522, 67, true);
            WriteLiteral(".addEventListener(\'click\', () => { document.getElementById(\'pageID-");
            EndContext();
            BeginContext(5590, 7, false);
#line 93 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                                                                                     Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(5597, 26, true);
            WriteLiteral("\').setAttribute(\'value\', \'");
            EndContext();
            BeginContext(5625, 43, false);
#line 93 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                                                                                                                        Write((int)AdminPanelPages.DeleteSynonymForString);

#line default
#line hidden
            EndContext();
            BeginContext(5669, 54, true);
            WriteLiteral("\'); });\r\n                                deleteButton_");
            EndContext();
            BeginContext(5725, 7, false);
#line 94 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                         Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(5733, 84, true);
            WriteLiteral(".addEventListener(\'click\', createSendDataEventHandler(\'DELETE\', \'synonym-for-string-");
            EndContext();
            BeginContext(5819, 7, false);
#line 94 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
                                                                                                                                       Write(pair.ID);

#line default
#line hidden
            EndContext();
            BeginContext(5827, 77, true);
            WriteLiteral("\', responseFromDeleting, errorMsg));\r\n                            </script>\r\n");
            EndContext();
#line 96 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(5952, 48, true);
            WriteLiteral("                            <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6000, "\"", 6038, 1);
#line 99 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
WriteAttributeValue("", 6008, Html.Raw(localization.Delete), 6008, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6039, 12, true);
            WriteLiteral(" disabled>\r\n");
            EndContext();
#line 100 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
            }

#line default
#line hidden
            BeginContext(6066, 61, true);
            WriteLiteral("                        </div>\r\n                    </form>\r\n");
            EndContext();
#line 103 "C:\Users\79622\Desktop\Github\StoreCMS\StoreCMS\Views\AdminPanel\SynonymsForStrings.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISynonymsForStringsLocalization localization { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SynonymForString[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
