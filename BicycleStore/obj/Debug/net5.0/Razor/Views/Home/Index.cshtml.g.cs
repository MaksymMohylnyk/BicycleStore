#pragma checksum "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f446808fc4ffdecedd4cb4620f14255ee577b80c"
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
#line 1 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\_ViewImports.cshtml"
using BicycleStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\_ViewImports.cshtml"
using BicycleStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f446808fc4ffdecedd4cb4620f14255ee577b80c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9f18bd330e5d586f72127509e0b78990b1e134", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BicycleStore.Models.Bicycle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f446808fc4ffdecedd4cb4620f14255ee577b80c4027", async() => {
                WriteLiteral("\r\n    <title>Bicycle store</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f446808fc4ffdecedd4cb4620f14255ee577b80c5029", async() => {
                WriteLiteral(@"
    <div class=""modal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>");
#nullable restore
#line 22 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
                  Write(ViewBag.IndexMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"">Ok</button>
                </div>
            </div>
        </div>
    </div>

    <div class=""flex flex-row justify-content-center"">
");
#nullable restore
#line 32 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
         foreach(var prop in ViewBag.Props)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f446808fc4ffdecedd4cb4620f14255ee577b80c6591", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
                                                                      Write(prop);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1068, "~/Home/Index?prop=", 1068, 18, true);
#nullable restore
#line 34 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1086, prop, 1086, 5, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>

    <h1>Our offers:</h1>
    <table class=""table table-bordered border-primary table-dark mt-3"">
        <thead>
            <tr>
                <th>Title</th>
                <th>Picture</th>
                <th>Weight</th>
                <th>Material</th>
                <th>Color</th>
                <th>Wheel Diameter</th>
                <th>Additional Info</th>
                <th>Price</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 53 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
             foreach (var bicycle in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
               Write(bicycle.BicycleTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1776, "\"", 1803, 1);
#nullable restore
#line 58 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 1782, bicycle.BicycleImage, 1782, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 128px; height: 64px;\"/>\r\n                </td>\r\n                <td>");
#nullable restore
#line 60 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
               Write(bicycle.BicycleWeight);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 61 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
               Write(bicycle.BicycleMaterial);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 62 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
               Write(bicycle.BicycleColor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 63 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
               Write(bicycle.BicycleWheelDiameter);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 64 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
               Write(bicycle.BicycleAdditionalInfo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 65 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
               Write(bicycle.BicyclePrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f446808fc4ffdecedd4cb4620f14255ee577b80c11945", async() => {
                    WriteLiteral("Buy");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2205, "~/Home/Buy/", 2205, 11, true);
#nullable restore
#line 66 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2216, bicycle.BicycleId, 2216, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 68 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
                     using (Html.BeginForm("AddToCart", "Cart"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2405, "\"", 2431, 1);
#nullable restore
#line 70 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 2413, bicycle.BicycleId, 2413, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"BicycleId\" />\r\n");
#nullable restore
#line 71 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
                   Write(Html.Hidden("returnUrl", Context.Request.Path));

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"submit\" value=\"Add to Cart\" class=\"btn btn-success\" />\r\n");
#nullable restore
#line 73 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Makson\source\repos\BicycleStore\BicycleStore\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BicycleStore.Models.Bicycle>> Html { get; private set; }
    }
}
#pragma warning restore 1591