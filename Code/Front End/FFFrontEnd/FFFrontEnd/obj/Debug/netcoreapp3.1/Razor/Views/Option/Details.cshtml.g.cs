#pragma checksum "D:\GitHub\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Option\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c54e290ecc71bdfbfa84e4f6fd3a04b3a50bcdec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Option_Details), @"mvc.1.0.view", @"/Views/Option/Details.cshtml")]
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
#line 1 "D:\GitHub\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\_ViewImports.cshtml"
using FFFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\_ViewImports.cshtml"
using FFFrontEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54e290ecc71bdfbfa84e4f6fd3a04b3a50bcdec", @"/Views/Option/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c5cb7ac3edafaca4227952dd74690bf35b84bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Option_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FFFrontEnd.Models.Option>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitHub\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Option\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Option</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            Option Text:\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\GitHub\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Option\Details.cshtml"
       Write(Html.DisplayFor(model => model.OptionText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Option Priority:\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\GitHub\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Option\Details.cshtml"
       Write(Html.DisplayFor(model => model.OptionOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 28 "D:\GitHub\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Option\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.OptionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 29 "D:\GitHub\Fantastic-Feedback\Code\Front End\FFFrontEnd\FFFrontEnd\Views\Option\Details.cshtml"
Write(Html.ActionLink("Delete", "Delete", "Option", new { id = Model.OptionID}));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FFFrontEnd.Models.Option> Html { get; private set; }
    }
}
#pragma warning restore 1591
