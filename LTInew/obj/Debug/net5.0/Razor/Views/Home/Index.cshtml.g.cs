#pragma checksum "E:\lti web app\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba42e609b9aa02c08ad5d63f08b684df98b7a380"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\lti web app\Views\_ViewImports.cshtml"
using LTIWEBAPPDEMO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\lti web app\Views\_ViewImports.cshtml"
using LTIWEBAPPDEMO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba42e609b9aa02c08ad5d63f08b684df98b7a380", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa93b9771d30f569cd3e0200930db9baf566e64", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LTIWEBAPPDEMO.Models.Vehicle>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\lti web app\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row bg-title"">
    <div class=""col-lg-3 col-md-4 col-sm-4 col-xs-12"">
        <h4 class=""page-title"">Vehicals</h4>
    </div>
    <div class=""col-lg-9 col-sm-8 col-md-8 col-xs-12"">
        <button class=""right-side-toggle waves-effect waves-light btn-info btn-circle pull-right m-l-20""><i class=""ti-settings text-white""></i></button>
        <ol class=""breadcrumb"">
            <li><a href=""#"">Dashboard</a></li>
            <li class=""active"">Dashboard</li>
        </ol>
    </div>
    <!-- /.col-lg-12 -->
</div>
<div class=""row"">
    <div class=""col-md-6"">
        <div class=""white-box"">
            <h3 class=""box-title m-b-0"">Create all type Vehicals</h3>
");
            WriteLiteral("        </div>\n    </div>\n    <div class=\"col-md-6\">\n        <div class=\"white-box\">\n");
            WriteLiteral("            <p class=\"box-title m-b-0 btn btn-success\">");
#nullable restore
#line 56 "E:\lti web app\Views\Home\Index.cshtml"
                                                  Write(Html.ActionLink("List of Vehicles", "Bind", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n        </div>\n        <!--<div class=\"white-box\">-->\n");
            WriteLiteral("            <!--<button type=\"button\" class=\"btn btn-danger\">Kubernates Testing Application</button>\n        </div>-->\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LTIWEBAPPDEMO.Models.Vehicle>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591