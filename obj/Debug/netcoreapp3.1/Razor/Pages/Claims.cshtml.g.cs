#pragma checksum "D:\R&D\ITfoxtec\Okta_SAML_Example\Pages\Claims.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b58d84dd71673fb6fc6a4149c35c70ece219a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Okta_SAML_Example.Pages.Pages_Claims), @"mvc.1.0.razor-page", @"/Pages/Claims.cshtml")]
namespace Okta_SAML_Example.Pages
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
#line 1 "D:\R&D\ITfoxtec\Okta_SAML_Example\Pages\_ViewImports.cshtml"
using Okta_SAML_Example;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b58d84dd71673fb6fc6a4149c35c70ece219a03", @"/Pages/Claims.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d15e85e3df87c132ca9fae88b19abe708c82662", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Claims : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\R&D\ITfoxtec\Okta_SAML_Example\Pages\Claims.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2>The users Claims (Iteration on User.Claims)</h2>\r\n        <p>\r\n");
#nullable restore
#line 11 "D:\R&D\ITfoxtec\Okta_SAML_Example\Pages\Claims.cshtml"
             foreach (var claim in User.Claims)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <strong>");
#nullable restore
#line 13 "D:\R&D\ITfoxtec\Okta_SAML_Example\Pages\Claims.cshtml"
                   Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <br /> <span style=\"padding-left: 10px\">Value: ");
#nullable restore
#line 13 "D:\R&D\ITfoxtec\Okta_SAML_Example\Pages\Claims.cshtml"
                                                                                       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n");
#nullable restore
#line 14 "D:\R&D\ITfoxtec\Okta_SAML_Example\Pages\Claims.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClaimsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClaimsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ClaimsModel>)PageContext?.ViewData;
        public ClaimsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
