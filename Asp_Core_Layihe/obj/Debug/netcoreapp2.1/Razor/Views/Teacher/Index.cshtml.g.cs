#pragma checksum "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0811e750f4e1270ebe143925a33c8779bac101a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0811e750f4e1270ebe143925a33c8779bac101a", @"/Views/Teacher/Index.cshtml")]
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
            BeginContext(29, 584, true);
            WriteLiteral(@"<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>our teachers</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""teacher-area pt-150 pb-105"">
    <div class=""container"">
        <div class=""row"">
");
            EndContext();
#line 20 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
             foreach (Teacher teach in Model)
            {

#line default
#line hidden
            BeginContext(675, 201, true);
            WriteLiteral("                <div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-teacher mb-45\">\r\n                        <div class=\"single-teacher-img\">\r\n                            ");
            EndContext();
            BeginContext(876, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "077a1ed7f9c54813b837b8fbf70fc7c3", async() => {
                BeginContext(950, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68495ac7262644199a86ec91517f45c4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 960, "~/img/teacher/", 960, 14, true);
#line 25 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
AddHtmlAttributeValue("", 974, teach.Image, 974, 12, false);

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
            BeginContext(1006, 140, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"single-teacher-content text-center\">\r\n                            <h2>");
            EndContext();
            BeginContext(1146, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15bc9ac48bcb4c2f91047d032602f367", async() => {
                BeginContext(1220, 14, false);
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
            BeginContext(1238, 39, true);
            WriteLiteral("</h2>\r\n                            <h4>");
            EndContext();
            BeginContext(1278, 14, false);
#line 29 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
                           Write(teach.Position);

#line default
#line hidden
            EndContext();
            BeginContext(1292, 79, true);
            WriteLiteral("</h4>\r\n                            <ul>\r\n                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1371, "\"", 1408, 1);
#line 31 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1378, teach.TeacherContact.Facebook, 1378, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1409, 84, true);
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1493, "\"", 1529, 1);
#line 32 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1500, teach.TeacherContact.Twitter, 1500, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1530, 83, true);
            WriteLiteral("><i class=\"zmdi zmdi-twitter\"></i></a></li>\r\n                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1613, "\"", 1650, 1);
#line 33 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1620, teach.TeacherContact.Linkedin, 1620, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1651, 165, true);
            WriteLiteral("><i class=\"zmdi zmdi-linkedin\"></i></a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 38 "C:\Users\Abulfat\Desktop\Asp.Net Core Layihe\Asp_Core_Layihe\Asp_Core_Layihe\Views\Teacher\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1831, 46, true);
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
