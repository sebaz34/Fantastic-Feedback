#pragma checksum "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae7d0f9136fba46a4fc5018402348f44237c0f95"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7d0f9136fba46a4fc5018402348f44237c0f95", @"/Views/Survey/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c5cb7ac3edafaca4227952dd74690bf35b84bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FFFrontEnd.Models.Survey>
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
            WriteLiteral("\r\n<h1>Overview</h1>\r\n\r\n<div>\r\n    <h4>Survey</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Title:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Model.SurveyTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Topic:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Model.SurveyTopic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Created by:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Model.SurveyCreatorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Date Created (UTC):\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Model.SurveyCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Comments:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Model.SurveyComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Image Link:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
       Write(Model.SurveyImage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 52 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
Write(Html.ActionLink("Edit Survey Details", "Edit", new { id = Model.SurveyID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae7d0f9136fba46a4fc5018402348f44237c0f956584", async() => {
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
            WriteLiteral("\r\n    <hr />\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 57 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
      
        Question newQuestion = new Question();
        newQuestion.SurveyID = (int)Model.SurveyID;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 61 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
Write(Html.ActionLink("Add New Question", "CreateAttachedQuestion", "Question", newQuestion));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <hr />
</div>
<div>
    <h4>Questions</h4>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Question
                </th>
                <th>
                    Survey Priority
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 78 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
             foreach (Question question in Model.Questions)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                 if (question.QuestionVisible)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                       Write(question.QuestionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 87 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                       Write(question.QuestionOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 90 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                              
                                Option newOption = new Option();
                                newOption.QuestionID = question.QuestionID;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
#nullable restore
#line 94 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                       Write(Html.ActionLink("New Response Option", "CreateAttachedOption", "Option", newOption));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 95 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", "Question", new { id = question.QuestionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 96 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", "Question", new { id = question.QuestionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>\r\n                            Response Options\r\n                        </th>\r\n");
#nullable restore
#line 103 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                         foreach (Option option in question.Options)
                        {
                            if (option.OptionVisible)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 107 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                               Write(Html.ActionLink($"{option.OptionText}", "Details", "Option", new { id = option.OptionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 108 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 111 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "A:\Github\Repositorys\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Survey\Details.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FFFrontEnd.Models.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
