#pragma checksum "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e38fc2692ea3727af7de3307f520594fb652fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Course_Delete), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Course/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/Course/Delete.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_Course_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e38fc2692ea3727af7de3307f520594fb652fa", @"/Areas/AdminPanel/Views/Course/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6c057f01c383f6e67849fd8ad52c47bbed6be1", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Course_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:450px; height:250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(59, 100, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex justify-content-center\">\r\n            ");
            EndContext();
            BeginContext(159, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3899d50b54c41219948512445d28938", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 203, "~/img/course/", 203, 13, true);
#line 8 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
AddHtmlAttributeValue("", 216, Model.Course.Image, 216, 19, false);

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
            BeginContext(239, 123, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"text-center mt-3\">\r\n            <h5 class=\"mt-3\">Course Title</h5>\r\n            <p>");
            EndContext();
            BeginContext(363, 18, false);
#line 13 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.Course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(381, 76, true);
            WriteLiteral(" </p>\r\n            <h5 class=\"mt-3\">Course Description</h5>\r\n            <p>");
            EndContext();
            BeginContext(458, 24, false);
#line 15 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.Course.Description);

#line default
#line hidden
            EndContext();
            BeginContext(482, 77, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Course AboutCourse</h5>\r\n            <p>");
            EndContext();
            BeginContext(560, 31, false);
#line 17 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseContent.AboutCourse);

#line default
#line hidden
            EndContext();
            BeginContext(591, 76, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Course HowToApply</h5>\r\n            <p>");
            EndContext();
            BeginContext(668, 30, false);
#line 19 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseContent.HowToApply);

#line default
#line hidden
            EndContext();
            BeginContext(698, 79, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Course Certification</h5>\r\n            <p>");
            EndContext();
            BeginContext(778, 33, false);
#line 21 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseContent.Certification);

#line default
#line hidden
            EndContext();
            BeginContext(811, 72, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Course Starts</h5>\r\n            <p>");
            EndContext();
            BeginContext(884, 26, false);
#line 23 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseFeature.Starts);

#line default
#line hidden
            EndContext();
            BeginContext(910, 74, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Course Duration</h5>\r\n            <p>");
            EndContext();
            BeginContext(985, 28, false);
#line 25 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseFeature.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1013, 80, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Course Class Duration</h5>\r\n            <p>");
            EndContext();
            BeginContext(1094, 34, false);
#line 27 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseFeature.Class_Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 77, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Course Skill Level</h5>\r\n            <p>");
            EndContext();
            BeginContext(1206, 31, false);
#line 29 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseFeature.Skill_Level);

#line default
#line hidden
            EndContext();
            BeginContext(1237, 74, true);
            WriteLiteral("  </p>\r\n            <h5 class=\"mt-3\">Course Language</h5>\r\n            <p>");
            EndContext();
            BeginContext(1312, 28, false);
#line 31 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseFeature.Language);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 72, true);
            WriteLiteral("</p>\r\n            <h5 class=\"mt-3\">Course Students</h5>\r\n            <p>");
            EndContext();
            BeginContext(1413, 28, false);
#line 33 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseFeature.Students);

#line default
#line hidden
            EndContext();
            BeginContext(1441, 74, true);
            WriteLiteral("</p>\r\n            <h5 class=\"mt-3\">Course Assesments</h5>\r\n            <p>");
            EndContext();
            BeginContext(1516, 30, false);
#line 35 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseFeature.Assesments);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 74, true);
            WriteLiteral("</p>\r\n            <h5 class=\"mt-3\">Course Course Fee</h5>\r\n            <p>");
            EndContext();
            BeginContext(1621, 30, false);
#line 37 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Areas\AdminPanel\Views\Course\Delete.cshtml"
          Write(Model.CourseFeature.Course_Fee);

#line default
#line hidden
            EndContext();
            BeginContext(1651, 66, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"row mt-4\">\r\n            ");
            EndContext();
            BeginContext(1717, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a1028353b134efbbbde836ab16fc4c0", async() => {
                BeginContext(1795, 7, true);
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
            BeginContext(1806, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1820, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d705e09ccfaf466c98ed9ff2db75ce03", async() => {
                BeginContext(1866, 92, true);
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1965, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
