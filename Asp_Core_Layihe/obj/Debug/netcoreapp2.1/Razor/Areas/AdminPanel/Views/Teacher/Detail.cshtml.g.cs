#pragma checksum "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18c130b587044dcc048cb5bd757d35ccc79c2dc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Teacher_Detail), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Teacher/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/Teacher/Detail.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_Teacher_Detail))]
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
#line 1 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Asp_Core_Layihe.Models;

#line default
#line hidden
#line 2 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Asp_Core_Layihe.Helpers;

#line default
#line hidden
#line 3 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Asp_Core_Layihe.Areas.AdminPanel.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18c130b587044dcc048cb5bd757d35ccc79c2dc5", @"/Areas/AdminPanel/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6c057f01c383f6e67849fd8ad52c47bbed6be1", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeacherVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:450px; height:250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(60, 100, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex justify-content-center\">\r\n            ");
            EndContext();
            BeginContext(160, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edca5a8f3aec43b4a40f407b8402be44", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 204, "~/img/teacher/", 204, 14, true);
#line 8 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 218, Model.Teacher.Image, 218, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(242, 127, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"text-center mt-3\">\r\n            <h5 class=\"mt-3\">Teacher FullName</h5>\r\n            <p>");
            EndContext();
            BeginContext(370, 22, false);
#line 13 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.Teacher.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(392, 74, true);
            WriteLiteral(" </p>\r\n            <h5 class=\"mt-3\">Teacher Position</h5>\r\n            <p>");
            EndContext();
            BeginContext(467, 22, false);
#line 15 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.Teacher.Position);

#line default
#line hidden
            EndContext();
            BeginContext(489, 72, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher About</h5>\r\n            <p>");
            EndContext();
            BeginContext(562, 19, false);
#line 17 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.Teacher.About);

#line default
#line hidden
            EndContext();
            BeginContext(581, 73, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher DEGREE</h5>\r\n            <p>");
            EndContext();
            BeginContext(655, 20, false);
#line 19 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.Teacher.DEGREE);

#line default
#line hidden
            EndContext();
            BeginContext(675, 77, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher EXPERIENCE</h5>\r\n            <p>");
            EndContext();
            BeginContext(753, 24, false);
#line 21 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.Teacher.EXPERIENCE);

#line default
#line hidden
            EndContext();
            BeginContext(777, 74, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher.HOBBIES</h5>\r\n            <p>");
            EndContext();
            BeginContext(852, 21, false);
#line 23 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.Teacher.HOBBIES);

#line default
#line hidden
            EndContext();
            BeginContext(873, 74, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher.FACULTY</h5>\r\n            <p>");
            EndContext();
            BeginContext(948, 21, false);
#line 25 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.Teacher.FACULTY);

#line default
#line hidden
            EndContext();
            BeginContext(969, 75, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher Language</h5>\r\n            <p>");
            EndContext();
            BeginContext(1045, 28, false);
#line 27 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.SkillsTeacher.Language);

#line default
#line hidden
            EndContext();
            BeginContext(1073, 78, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher Team Leader</h5>\r\n            <p>");
            EndContext();
            BeginContext(1152, 31, false);
#line 29 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.SkillsTeacher.Team_Leader);

#line default
#line hidden
            EndContext();
            BeginContext(1183, 76, true);
            WriteLiteral("</p>\r\n            <h5 class=\"mt-3\">Teacher Development</h5>\r\n            <p>");
            EndContext();
            BeginContext(1260, 31, false);
#line 31 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.SkillsTeacher.Development);

#line default
#line hidden
            EndContext();
            BeginContext(1291, 71, true);
            WriteLiteral("</p>\r\n            <h5 class=\"mt-3\">Teacher Design</h5>\r\n            <p>");
            EndContext();
            BeginContext(1363, 26, false);
#line 33 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.SkillsTeacher.Design);

#line default
#line hidden
            EndContext();
            BeginContext(1389, 75, true);
            WriteLiteral("</p>\r\n            <h5 class=\"mt-3\">Teacher Innovation</h5>\r\n            <p>");
            EndContext();
            BeginContext(1465, 30, false);
#line 35 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.SkillsTeacher.Innovation);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 78, true);
            WriteLiteral("</p>\r\n            <h5 class=\"mt-3\">Teacher Communication</h5>\r\n            <p>");
            EndContext();
            BeginContext(1574, 33, false);
#line 37 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.SkillsTeacher.Communication);

#line default
#line hidden
            EndContext();
            BeginContext(1607, 70, true);
            WriteLiteral("</p>\r\n            <h5 class=\"mt-3\">Teacher Email</h5>\r\n            <p>");
            EndContext();
            BeginContext(1678, 26, false);
#line 39 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.TeacherContact.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1704, 72, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher Phone</h5>\r\n            <p>");
            EndContext();
            BeginContext(1777, 26, false);
#line 41 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.TeacherContact.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 72, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher SKYPE</h5>\r\n            <p>");
            EndContext();
            BeginContext(1876, 26, false);
#line 43 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.TeacherContact.SKYPE);

#line default
#line hidden
            EndContext();
            BeginContext(1902, 75, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher Facebook</h5>\r\n            <p>");
            EndContext();
            BeginContext(1978, 29, false);
#line 45 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.TeacherContact.Facebook);

#line default
#line hidden
            EndContext();
            BeginContext(2007, 74, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher Twitter</h5>\r\n            <p>");
            EndContext();
            BeginContext(2082, 28, false);
#line 47 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.TeacherContact.Twitter);

#line default
#line hidden
            EndContext();
            BeginContext(2110, 76, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Teacher Linkedin </h5>\r\n            <p>");
            EndContext();
            BeginContext(2187, 29, false);
#line 49 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Teacher\Detail.cshtml"
          Write(Model.TeacherContact.Linkedin);

#line default
#line hidden
            EndContext();
            BeginContext(2216, 68, true);
            WriteLiteral("  </p>\r\n        </div>\r\n        <div class=\"row mt-4\">\r\n            ");
            EndContext();
            BeginContext(2284, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d8c05b17b294f44ac6585d7e8553b1a", async() => {
                BeginContext(2363, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2374, 32, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeacherVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
