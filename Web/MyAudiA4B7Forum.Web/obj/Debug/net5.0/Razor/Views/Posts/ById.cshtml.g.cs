#pragma checksum "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1efd22cc4f568bd572f0622d8f0e99adad99f266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_ById), @"mvc.1.0.view", @"/Views/Posts/ById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efd22cc4f568bd572f0622d8f0e99adad99f266", @"/Views/Posts/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11dcba049d5ffe04b413e6b8036c412d63cf2eaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyAudiA4B7Forum.Web.ViewModels.Posts.PostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #ABEBC6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("votesForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddCommentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
   this.ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1efd22cc4f568bd572f0622d8f0e99adad99f2665956", async() => {
                WriteLiteral("\n");
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
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"

void DisplayComments(int? parentId)
{
    var comments = this.Model.Comments.Where(x => x.ParentId == parentId);
    if (!comments.Any())
    {
        return;
    }


#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
 foreach (var comment in comments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid mt-100"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card mb-4"">
                <div class=""card-header"">
                    <div class=""media flex-wrap w-100 align-items-center"">

                        <div class=""media-body ml-3"">
                            ");
#nullable restore
#line 24 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                       Write(comment.UserUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"text-muted small\">\n                                <time");
            BeginWriteAttribute("datetime", " datetime=\"", 792, "\"", 835, 1);
#nullable restore
#line 26 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
WriteAttributeValue("", 803, comment.CreatedOn.ToString("O"), 803, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></time>\n                            </div>\n                        </div>\n                        <div class=\"text-muted small ml-3\">\n");
#nullable restore
#line 30 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                             if (this.User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"px-4 pt-3\"> <button type=\"button\" class=\"btn btn-outline-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1152, "\"", 1193, 3);
            WriteAttributeValue("", 1162, "showAddCommentForm(", 1162, 19, true);
#nullable restore
#line 32 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
WriteAttributeValue("", 1181, comment.Id, 1181, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1192, ")", 1192, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-plus\"></i>&nbsp; Answer</button> </div>");
#nullable restore
#line 32 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                                                                                                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n                </div>\n                <div class=\"card-body\">\n                    <article>\n                        ");
#nullable restore
#line 38 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                   Write(Html.Raw(comment.SanitizedContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </article>\n");
#nullable restore
#line 40 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                       DisplayComments(comment.Id); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>");
#nullable restore
#line 45 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 47 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
 if (this.TempData["InfoMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-success\">\n    ");
#nullable restore
#line 50 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
Write(this.TempData["InfoMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
#nullable restore
#line 51 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 53 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<div class=""container-fluid mt-100"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card mb-4"">
                <div class=""card-header"">
                    <div class=""media flex-wrap w-100 align-items-center"">
                        
                        <div class=""media-body ml-3"">
                            ");
#nullable restore
#line 62 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                       Write(Model.UserUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"text-muted small\">\n                                <time");
            BeginWriteAttribute("datetime", " datetime=\"", 2240, "\"", 2281, 1);
#nullable restore
#line 64 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
WriteAttributeValue("", 2251, Model.CreatedOn.ToString("O"), 2251, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></time>\n                            </div>\n                        </div>\n                        <div class=\"text-muted small ml-3\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1efd22cc4f568bd572f0622d8f0e99adad99f26613718", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <div>\n                                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2565, "\"", 2600, 4);
            WriteAttributeValue("", 2575, "sendVote(", 2575, 9, true);
#nullable restore
#line 70 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
WriteAttributeValue("", 2584, Model.Id, 2584, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2593, ",", 2593, 1, true);
            WriteAttributeValue(" ", 2594, "true)", 2595, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                    <i class=\"fa fa-thumbs-up\"></i>\n                                </a>\n                            </div>\n                            <div id=\"votesCount\">");
#nullable restore
#line 74 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                                            Write(Model.VotesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                            <div>\n                                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2893, "\"", 2929, 4);
            WriteAttributeValue("", 2903, "sendVote(", 2903, 9, true);
#nullable restore
#line 76 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
WriteAttributeValue("", 2912, Model.Id, 2912, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2921, ",", 2921, 1, true);
            WriteAttributeValue(" ", 2922, "false)", 2923, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""fa fa-thumbs-down""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <article>
                        ");
#nullable restore
#line 85 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                   Write(Html.Raw(Model.SanitizedContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </article>\n\n");
#nullable restore
#line 88 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                     if (this.User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"px-4 pt-3\"> <button type=\"button\" class=\"btn btn-info float-right\" onclick=\"showAddCommentForm(0)\"><i class=\"fa fa-plus\"></i>&nbsp; Comment</button> </div>\n                        <div class=\"clearfix\"></div>");
#nullable restore
#line 91 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
                       DisplayComments(null); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<script src=""/lib/tinymce/tinymce.min.js"" type=""text/javascript""></script>
<script type=""text/javascript"">
    tinymce.init({
        selector: ""textarea"",
        plugins: [""image paste table link code media""]
    });
</script>
<div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1efd22cc4f568bd572f0622d8f0e99adad99f26618970", async() => {
                WriteLiteral("\n        <input type=\"hidden\" name=\"PostId\"");
                BeginWriteAttribute("value", " value=\"", 4142, "\"", 4164, 1);
#nullable restore
#line 108 "C:\Users\baicv\OneDrive\Desktop\MyAudiA4Forum\Web\MyAudiA4B7Forum.Web\Views\Posts\ById.cshtml"
WriteAttributeValue("", 4150, this.Model.Id, 4150, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <input type=""hidden"" name=""ParentId"" value=""0"" />
        <div>
            <label for=""Content""></label>
            <textarea name=""Content"" id=""Content"" class=""form-control""></textarea>
        </div>
        <div>
            <input type=""submit"" class=""btn btn-primary"" value=""Add comment"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function showAddCommentForm(parentId) {
            $(""#AddCommentForm input[name='ParentId']"").val(parentId);
            $(""#AddCommentForm"").show();
            $([document.documentElement, document.body]).animate({
                scrollTop: $(""#AddCommentForm"").offset().top
            }, 1000);
        }

        function sendVote(postId, isUpVote) {
            var token = $(""#votesForm input[name=__RequestVerificationToken]"").val();
            var json = { postId: postId, isUpVote: isUpVote };
            $.ajax({
                url: ""/api/votes"",
                type: ""POST"",
                data: JSON.stringify(json),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                headers: { 'X-CSRF-TOKEN': token },
                success: function (data) {
                    $(""#votesCount"").html(data.votesCount);
                }
            });
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyAudiA4B7Forum.Web.ViewModels.Posts.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
