#pragma checksum "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66652a80b6d755b75cdba84cba9537312d2115d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Index), @"mvc.1.0.view", @"/Views/Teacher/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Index.cshtml", typeof(AspNetCore.Views_Teacher_Index))]
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
#line 1 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\_ViewImports.cshtml"
using Asp_Core_Layihe.Models;

#line default
#line hidden
#line 2 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\_ViewImports.cshtml"
using Asp_Core_Layihe.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\_ViewImports.cshtml"
using Asp_Core_Layihe.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66652a80b6d755b75cdba84cba9537312d2115d", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c33eb03b1c85eaf19dcd5cef151c4d426387943", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Teacher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(517, 100, true);
            WriteLiteral("\r\n<div class=\"teacher-area pt-150 pb-105\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 20 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
             foreach (Teacher teach in Model)
            {

#line default
#line hidden
            BeginContext(679, 201, true);
            WriteLiteral("                <div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-teacher mb-45\">\r\n                        <div class=\"single-teacher-img\">\r\n                            ");
            EndContext();
            BeginContext(880, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4862a2df47a340af8a0122f914c38e84", async() => {
                BeginContext(954, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d611f5f5ebc4da9bcf60566f693fd3d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 964, "~/img/teacher/", 964, 14, true);
#line 25 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
AddHtmlAttributeValue("", 978, teach.Image, 978, 12, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
                                                                               WriteLiteral(teach.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1010, 140, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"single-teacher-content text-center\">\r\n                            <h2>");
            EndContext();
            BeginContext(1150, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "304cb1bd83194a238b0b152ec72f0e7a", async() => {
                BeginContext(1224, 14, false);
#line 28 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
                                                                                                    Write(teach.FullName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
                                                                                  WriteLiteral(teach.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1242, 39, true);
            WriteLiteral("</h2>\r\n                            <h4>");
            EndContext();
            BeginContext(1282, 14, false);
#line 29 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
                           Write(teach.Position);

#line default
#line hidden
            EndContext();
            BeginContext(1296, 79, true);
            WriteLiteral("</h4>\r\n                            <ul>\r\n                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1375, "\"", 1412, 1);
#line 31 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1382, teach.TeacherContact.Facebook, 1382, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1413, 84, true);
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1497, "\"", 1533, 1);
#line 32 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1504, teach.TeacherContact.Twitter, 1504, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1534, 83, true);
            WriteLiteral("><i class=\"zmdi zmdi-twitter\"></i></a></li>\r\n                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1617, "\"", 1654, 1);
#line 33 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1624, teach.TeacherContact.Linkedin, 1624, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1655, 165, true);
            WriteLiteral("><i class=\"zmdi zmdi-linkedin\"></i></a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 38 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1835, 46, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
