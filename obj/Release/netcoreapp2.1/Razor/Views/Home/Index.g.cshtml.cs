#pragma checksum "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0dbb156e5ce501eafd518e177cb3c79f28552d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\izmir\source\repos\blog\blog\Views\_ViewImports.cshtml"
using blog;

#line default
#line hidden
#line 2 "C:\Users\izmir\source\repos\blog\blog\Views\_ViewImports.cshtml"
using blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0dbb156e5ce501eafd518e177cb3c79f28552d4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb75ca75589086f3cd7b7a5e09e52e9d3c84d752", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<blog.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 727, true);
            WriteLiteral(@"
<header class=""masthead"">
    <div class=""container"" id=""page-top"">
        <div class=""intro-text"">
            <div class=""intro-lead-in"">Welcome To Our Blog!</div>
            <div class=""intro-heading text-uppercase"">It's Nice To Meet You</div>
            <a class=""btn btn-primary btn-xl text-uppercase js-scroll-trigger"" href=""#posts"">Recent Posts</a>
        </div>
    </div>
</header>

<section class=""page-section center-block  align-content-center "" id=""posts"">
    <div class=""container center-block"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <h2 class=""section-heading text-uppercase"">New Posts</h2>

            </div>
        </div>
       
");
            EndContext();
#line 26 "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml"
         foreach (var post in Model.Post)
        {

#line default
#line hidden
            BeginContext(875, 201, true);
            WriteLiteral("            <div class=\"col-md-7 container-fluid\">\r\n                <div class=\"card align-items-center \">\r\n                    <div class=\"card-body \">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1077, 40, false);
#line 31 "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => post.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 52, true);
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(1170, 52, false);
#line 32 "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => post.Short_description));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 57, true);
            WriteLiteral("</p>\r\n\r\n                        <b> Category:</b><br />\r\n");
            EndContext();
#line 35 "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml"
                             for (int i = 0; i < post.Categories.Count; i++)
                            {

#line default
#line hidden
            BeginContext(1388, 53, true);
            WriteLiteral("                                <p class=\"card-text\">");
            EndContext();
            BeginContext(1442, 48, false);
#line 37 "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml"
                                                Write(Html.DisplayFor(modelItem => post.Categories[i]));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 38 "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1527, 71, true);
            WriteLiteral("                                             \r\n                        ");
            EndContext();
            BeginContext(1598, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77372faf1c7460a82efe3c0d1d4994b", async() => {
                BeginContext(1697, 9, true);
                WriteLiteral("View Post");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml"
                                                                                                 WriteLiteral(post.PostId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1710, 80, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div><br />\r\n");
            EndContext();
#line 44 "C:\Users\izmir\source\repos\blog\blog\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1801, 2655, true);
            WriteLiteral(@"
    </div>

</section>






<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<script type=""text/javascript"">var scrolltotop = { setting: { startline: 100, scrollto: 0, scrollduration: 1e3, fadeduration: [500, 100] }, controlHTML: '<img src=""https://i1155.photobucket.com/albums/p559/scrolltotop/arrow12.png"" />', controlattrs: { offsetx: 5, offsety: 5 }, anchorkeyword: ""#top"", state: { isvisible: !1, shouldvisible: !1 }, scrollup: function () { this.cssfixedsupport || this.$control.css({ opacity: 0 }); var t = isNaN(this.setting.scrollto) ? this.setting.scrollto : parseInt(this.setting.scrollto); t = ""string"" == typeof t && 1 == jQuery(""#"" + t).length ? jQuery(""#"" + t).offset().top : 0, this.$body.animate({ scrollTop: t }, this.setting.scrollduration) }, keepfixed: function () { var t = jQuery(window), o = t.scrollLeft() + t.width() - this.$control.width() - this.controlattrs.offsetx, s = t.scrollTop() + t.height() - this.$control.height() - this.controlattrs");
            WriteLiteral(@".offsety; this.$control.css({ left: o + ""px"", top: s + ""px"" }) }, togglecontrol: function () { var t = jQuery(window).scrollTop(); this.cssfixedsupport || this.keepfixed(), this.state.shouldvisible = t >= this.setting.startline ? !0 : !1, this.state.shouldvisible && !this.state.isvisible ? (this.$control.stop().animate({ opacity: 1 }, this.setting.fadeduration[0]), this.state.isvisible = !0) : 0 == this.state.shouldvisible && this.state.isvisible && (this.$control.stop().animate({ opacity: 0 }, this.setting.fadeduration[1]), this.state.isvisible = !1) }, init: function () { jQuery(document).ready(function (t) { var o = scrolltotop, s = document.all; o.cssfixedsupport = !s || s && ""CSS1Compat"" == document.compatMode && window.XMLHttpRequest, o.$body = t(window.opera ? ""CSS1Compat"" == document.compatMode ? ""html"" : ""body"" : ""html,body""), o.$control = t('<div id=""topcontrol"">' + o.controlHTML + ""</div>"").css({ position: o.cssfixedsupport ? ""fixed"" : ""absolute"", bottom: o.controlattrs.offsety, right: o.controlatt");
            WriteLiteral(@"rs.offsetx, opacity: 0, cursor: ""pointer"" }).attr({ title: ""Scroll to Top"" }).click(function () { return o.scrollup(), !1 }).appendTo(""body""), document.all && !window.XMLHttpRequest && """" != o.$control.text() && o.$control.css({ width: o.$control.width() }), o.togglecontrol(), t('a[href=""' + o.anchorkeyword + '""]').click(function () { return o.scrollup(), !1 }), t(window).bind(""scroll resize"", function (t) { o.togglecontrol() }) }) } }; scrolltotop.init();</script>
<noscript>Not seeing a <a href=""https://www.scrolltotop.com/"">Scroll to Top Button</a>? Go to our FAQ page for more info.</noscript>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<blog.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
