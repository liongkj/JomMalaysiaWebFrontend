#pragma checksum "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\Listing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecbbe5796b50c40e2480da1c4db87aea933c3e2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Listing_Index), @"mvc.1.0.view", @"/Views/Listing/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Listing/Index.cshtml", typeof(AspNetCore.Views_Listing_Index))]
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
#line 1 "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\_ViewImports.cshtml"
using JomMalaysia.Presentation;

#line default
#line hidden
#line 2 "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\_ViewImports.cshtml"
using JomMalaysia.Presentation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecbbe5796b50c40e2480da1c4db87aea933c3e2d", @"/Views/Listing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a1dd094eb31a2c880adc4a5bd80467fd5d0db7", @"/Views/_ViewImports.cshtml")]
    public class Views_Listing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JomMalaysia.Presentation.Models.ListingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\Listing\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutModal.cshtml";

#line default
#line hidden
            BeginContext(163, 504, true);
            WriteLiteral(@"<div class=""col-md-12 col-sm-12 no-padding"" style=""overflow-x:auto !important"" ;"">
    <table class=""table table-hover"">
        <thead class=""table-primary"">
            <tr>
                <th scope=""col""></th>
                <th scope=""col"">Listing Name</th>
                <th scope=""col"">Merchant</th>
                <th scope=""col"">Type</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\Listing\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(724, 48, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
            EndContext();
            BeginContext(1168, 51, true);
            WriteLiteral("                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(1220, 16, false);
#line 29 "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\Listing\Index.cshtml"
                   Write(item.ListingName);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1268, 25, false);
#line 30 "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\Listing\Index.cshtml"
                   Write(item.Merchant.companyName);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1325, 21, false);
#line 31 "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\Listing\Index.cshtml"
                   Write(item.ListingType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1346, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1378, 16, false);
#line 32 "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\Listing\Index.cshtml"
                   Write(item.Status.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 70, true);
            WriteLiteral("</td>\r\n                    <td>check box</td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\khaij\source\repos\liongkj\jommalaysiaportal\JomMalaysia.Presentation\Views\Listing\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1479, 46, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JomMalaysia.Presentation.Models.ListingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
