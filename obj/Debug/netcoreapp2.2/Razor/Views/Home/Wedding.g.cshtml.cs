#pragma checksum "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79d78df14011758cb25b30ab4b3487a37c7fbc0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Wedding), @"mvc.1.0.view", @"/Views/Home/Wedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Wedding.cshtml", typeof(AspNetCore.Views_Home_Wedding))]
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
#line 1 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79d78df14011758cb25b30ab4b3487a37c7fbc0e", @"/Views/Home/Wedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Wedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml"
  
    ViewData["Title"] = "Read/Update/Delete a Wedding";

#line default
#line hidden
            BeginContext(61, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(77, 66, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-10 text-left\">\n        <h1>");
            EndContext();
            BeginContext(144, 15, false);
#line 9 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml"
       Write(Model.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(159, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(165, 15, false);
#line 9 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml"
                            Write(Model.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(180, 19, true);
            WriteLiteral("\'s Wedding </h1>\n\t\t");
            EndContext();
            BeginContext(199, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79d78df14011758cb25b30ab4b3487a37c7fbc0e5838", async() => {
                BeginContext(289, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(302, 7, true);
            WriteLiteral("\n\t\t|\n\t\t");
            EndContext();
            BeginContext(309, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79d78df14011758cb25b30ab4b3487a37c7fbc0e7681", async() => {
                BeginContext(396, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(406, 90, true);
            WriteLiteral("\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-10 offset-1\">\n        <h3>Date: ");
            EndContext();
            BeginContext(497, 35, false);
#line 18 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml"
             Write(Model.Date.ToString("MMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(532, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(537, 31, false);
#line 18 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml"
                                                     Write(Model.Date.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(568, 174, true);
            WriteLiteral("</h3>\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-10 offset-1\">\n        <h3>Guests: </h3>\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-10 offset-1\">\n");
            EndContext();
#line 30 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml"
         foreach (var guest in Model.Guests)
        {

#line default
#line hidden
            BeginContext(797, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(813, 20, false);
#line 32 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml"
          Write(guest.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(833, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(835, 19, false);
#line 32 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml"
                                Write(guest.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(854, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 33 "/Users/patrickhebert/Desktop/Developer/c#_stack/Assignments/WeddingPlanner/Views/Home/Wedding.cshtml"
        }

#line default
#line hidden
            BeginContext(869, 18, true);
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
