#pragma checksum "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888bfb4e33a9baae95d1c05c2afc7f0962c8ff42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_Delete), @"mvc.1.0.view", @"/Views/Survey/Delete.cshtml")]
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
#nullable restore
#line 1 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\_ViewImports.cshtml"
using FFFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\_ViewImports.cshtml"
using FFFrontEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888bfb4e33a9baae95d1c05c2afc7f0962c8ff42", @"/Views/Survey/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c5cb7ac3edafaca4227952dd74690bf35b84bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API_FantasticFeedback.Models.Survey>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Survey</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurveyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurveyTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyTopic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurveyTopic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyCreatorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurveyCreatorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurveyCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurveyComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurveyImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyVisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurveyVisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888bfb4e33a9baae95d1c05c2afc7f0962c8ff4210100", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888bfb4e33a9baae95d1c05c2afc7f0962c8ff4210448", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API_FantasticFeedback.Models.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
