#pragma checksum "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92095ce1a54247c06318d45ee90dde921bb6ad07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Category), @"mvc.1.0.view", @"/Views/Categories/Category.cshtml")]
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
#line 1 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\_ViewImports.cshtml"
using MyAudiA4B7Forum.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\_ViewImports.cshtml"
using MyAudiA4B7Forum.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92095ce1a54247c06318d45ee90dde921bb6ad07", @"/Views/Categories/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11dcba049d5ffe04b413e6b8036c412d63cf2eaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyAudiA4B7Forum.Web.ViewModels.Categories.CategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #000"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "forumCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
   this.ViewData["Title"] = Model.Title; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92095ce1a54247c06318d45ee90dde921bb6ad075174", async() => {
                WriteLiteral("\n  \n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<h1 class=\"display-3\">");
#nullable restore
#line 7 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<div class=\"alert alert-info\">\n    ");
#nullable restore
#line 9 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
#nullable restore
#line 12 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
 foreach (var post in Model.ForumPosts)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"media-body\">\n    <h4 class=\"media-heading\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92095ce1a54247c06318d45ee90dde921bb6ad077116", async() => {
#nullable restore
#line 15 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
                                                                                             Write(post.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
                                                                            WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\n    <ul class=\"list-inline list-unstyled text-right\">\n        <li class=\"list-inline-item\">\n            <i class=\"fas fa-user-edit\"></i> ");
#nullable restore
#line 18 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
                                        Write(post.UserUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </li>\n        <li class=\"list-inline-item\">\n            <i class=\"fas fa-calendar-alt\"></i> ");
#nullable restore
#line 21 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
                                           Write(post.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </li>\n        <li class=\"list-inline-item\">\n            <i class=\"fas fa-comment-dots\"></i> ");
#nullable restore
#line 24 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
                                           Write(post.CommentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments\n        </li>\n    </ul>\n</div>");
#nullable restore
#line 27 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<nav>\n    <ul class=\"pagination justify-content-center\">\n");
#nullable restore
#line 31 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
         if (this.Model.CurrentPage == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item disabled\">\n    <a class=\"page-link\" href=\"#\">Previous</a>\n</li>\n");
#nullable restore
#line 36 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
 }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92095ce1a54247c06318d45ee90dde921bb6ad0711970", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
           WriteLiteral(this.Model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
            WriteLiteral(this.Model.CurrentPage - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</li>");
#nullable restore
#line 44 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 46 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
         for (int i = 1; i <= this.Model.PagesCount; i++)
        {
            var active = i == this.Model.CurrentPage ? "active" : string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("<li");
            BeginWriteAttribute("class", " class=\"", 1453, "\"", 1478, 2);
            WriteAttributeValue("", 1461, "page-item", 1461, 9, true);
#nullable restore
#line 49 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
WriteAttributeValue(" ", 1470, active, 1471, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92095ce1a54247c06318d45ee90dde921bb6ad0715989", async() => {
#nullable restore
#line 53 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
                      Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
           WriteLiteral(this.Model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
           WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</li>");
#nullable restore
#line 54 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 56 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
         if (this.Model.CurrentPage == this.Model.PagesCount)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item disabled\">\n    <a class=\"page-link\" href=\"#\">Next</a>\n</li>\n");
#nullable restore
#line 61 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
 }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92095ce1a54247c06318d45ee90dde921bb6ad0719984", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
           WriteLiteral(this.Model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
            WriteLiteral(this.Model.CurrentPage + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</li>");
#nullable restore
#line 69 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Categories\Category.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n</nav>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyAudiA4B7Forum.Web.ViewModels.Categories.CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
