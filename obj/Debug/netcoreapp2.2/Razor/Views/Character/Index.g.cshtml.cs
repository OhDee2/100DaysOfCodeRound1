#pragma checksum "C:\Users\james\Documents\Projects\KingdomOfRelationships\Views\Character\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff84b9260305988b002dc8586ce6c8f83367536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Character_Index), @"mvc.1.0.view", @"/Views/Character/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Character/Index.cshtml", typeof(AspNetCore.Views_Character_Index))]
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
#line 1 "C:\Users\james\Documents\Projects\KingdomOfRelationships\Views\_ViewImports.cshtml"
using KingdomOfRelationships;

#line default
#line hidden
#line 2 "C:\Users\james\Documents\Projects\KingdomOfRelationships\Views\_ViewImports.cshtml"
using KingdomOfRelationships.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff84b9260305988b002dc8586ce6c8f83367536", @"/Views/Character/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ffeaf31bf49593ae84e0a38b9a44d8f5bed4e58", @"/Views/_ViewImports.cshtml")]
    public class Views_Character_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CharacterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "C:\Users\james\Documents\Projects\KingdomOfRelationships\Views\Character\Index.cshtml"
      
        ViewBag.Title = "Character";

#line default
#line hidden
            BeginContext(73, 12, true);
            WriteLiteral("        <h1>");
            EndContext();
            BeginContext(86, 13, false);
#line 4 "C:\Users\james\Documents\Projects\KingdomOfRelationships\Views\Character\Index.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(99, 55, true);
            WriteLiteral("</h1>\r\n        <ul>\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(155, 20, false);
#line 7 "C:\Users\james\Documents\Projects\KingdomOfRelationships\Views\Character\Index.cshtml"
           Write(Model.Character.Name);

#line default
#line hidden
            EndContext();
            BeginContext(175, 36, true);
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n");
            EndContext();
            BeginContext(213, 43, true);
            WriteLiteral("        <h2>Related to</h2>\r\n        <ul>\r\n");
            EndContext();
#line 13 "C:\Users\james\Documents\Projects\KingdomOfRelationships\Views\Character\Index.cshtml"
             foreach(var relation in Model.RelatedCharacters)
            {

#line default
#line hidden
            BeginContext(334, 61, true);
            WriteLiteral("            <ul>\r\n                <li>\r\n                     ");
            EndContext();
            BeginContext(396, 13, false);
#line 17 "C:\Users\james\Documents\Projects\KingdomOfRelationships\Views\Character\Index.cshtml"
                Write(relation.Name);

#line default
#line hidden
            EndContext();
            BeginContext(409, 44, true);
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n");
            EndContext();
#line 20 "C:\Users\james\Documents\Projects\KingdomOfRelationships\Views\Character\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(468, 15, true);
            WriteLiteral("        </ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CharacterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
