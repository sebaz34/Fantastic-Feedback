#pragma checksum "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b15ff38f78daf32cb6a5a279b3fd7a5e8a1b62ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_Details), @"mvc.1.0.view", @"/Views/Survey/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b15ff38f78daf32cb6a5a279b3fd7a5e8a1b62ae", @"/Views/Survey/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c5cb7ac3edafaca4227952dd74690bf35b84bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API_FantasticFeedback.Models.Survey>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Survey</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyTopic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyTopic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyCreatorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyCreatorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveyVisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveyVisible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 64 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b15ff38f78daf32cb6a5a279b3fd7a5e8a1b62ae9808", async() => {
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
