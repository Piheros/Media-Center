#pragma checksum "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b645336f7a0b73c51af7d9a6c24a8c95957e36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tag_Index), @"mvc.1.0.view", @"/Views/Tag/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tag/Index.cshtml", typeof(AspNetCore.Views_Tag_Index))]
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
#line 1 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\_ViewImports.cshtml"
using MediaCenter;

#line default
#line hidden
#line 2 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\_ViewImports.cshtml"
using MediaCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b645336f7a0b73c51af7d9a6c24a8c95957e36", @"/Views/Tag/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe01eb615ee21b71032b6971cabe530061c7dff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Tag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediaCenter.Models.Tag>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Image", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
  
    int imageid = ViewBag.imageid;
    Image imagemini = ViewBag.imagemini;
    ViewData["Title"] = "Index Tag";

#line default
#line hidden
            BeginContext(169, 139, true);
            WriteLiteral("\r\n<h2>Details Tag Image</h2>\r\n<p>Details Tag of Image in database.</p>\r\n<hr />\r\n\r\n<div style=\"text-align:center\">\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 308, "", 348, 1);
#line 14 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
WriteAttributeValue("", 315, Model.GetEnumerator().MoveNext(), 315, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(348, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 15 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
     if (imagemini.Data != null)
    {
        var base64 = Convert.ToBase64String(imagemini.Data);
        var imgSrc = String.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
            BeginContext(530, 31, true);
            WriteLiteral("        <div>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 561, "\"", 574, 1);
#line 20 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
WriteAttributeValue("", 567, imgSrc, 567, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(575, 35, true);
            WriteLiteral(" width=\"400px\" />\r\n        </div>\r\n");
            EndContext();
#line 22 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(634, 69, true);
            WriteLiteral("        <br /><span style=\'color:red\'>File not found !</span><br />\r\n");
            EndContext();
#line 26 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(710, 23, true);
            WriteLiteral("    <br />\r\n    <div>\r\n");
            EndContext();
#line 29 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#line 31 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
             if (imageid == item.ImageId)
            {

#line default
#line hidden
            BeginContext(840, 47, true);
            WriteLiteral("                <button class=\"btn alert-info\">");
            EndContext();
            BeginContext(888, 38, false);
#line 33 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(926, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 34 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
            }

#line default
#line hidden
#line 34 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(963, 294, true);
            WriteLiteral(@"    </div>
    <hr />
    <div style=""text-align:left"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Name Tag</th>
                    <th>Supress Tag</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 47 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#line 49 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
                     if (imageid == item.ImageId)
                    {

#line default
#line hidden
            BeginContext(1396, 93, true);
            WriteLiteral("                        <tr>\r\n                            <td><button class=\"btn alert-info\">");
            EndContext();
            BeginContext(1490, 38, false);
#line 52 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 82, true);
            WriteLiteral("</button></td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1610, 314, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f8885470d7c458ab971ddfbef42729f", async() => {
                BeginContext(1681, 159, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" class=\"btn btn-danger\" value=\"Suppress\" />\r\n                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1840, "", 1880, 1);
#line 56 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
WriteAttributeValue("", 1847, Model.GetEnumerator().MoveNext(), 1847, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1880, 37, true);
                WriteLiteral(" />\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1924, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
                    }

#line default
#line hidden
#line 60 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2034, 115, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div style=\"text-align:right\">\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(2149, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0ee01841f7b4a53a78756f8672e6fd2", async() => {
                BeginContext(2220, 10, true);
                WriteLiteral("Create Tag");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
                                     WriteLiteral(imageid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2234, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2248, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dae2c701b32d49519ddca2aeb82fe7b7", async() => {
                BeginContext(2342, 6, true);
                WriteLiteral("Return");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\Pierre\Desktop\MediaCenter\WebApplication1\Views\Tag\Index.cshtml"
                                                             WriteLiteral(imageid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2352, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MediaCenter.Models.Tag>> Html { get; private set; }
    }
}
#pragma warning restore 1591