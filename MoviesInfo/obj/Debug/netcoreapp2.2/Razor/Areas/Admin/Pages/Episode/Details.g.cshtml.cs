#pragma checksum "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f988cc67e8ed9f80d5acb8aa5e0ae72a8f970924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MoviesInfo.Pages.Episode.Areas_Admin_Pages_Episode_Details), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Episode/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/Episode/Details.cshtml", typeof(MoviesInfo.Pages.Episode.Areas_Admin_Pages_Episode_Details), null)]
namespace MoviesInfo.Pages.Episode
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\_ViewImports.cshtml"
using MoviesInfo;

#line default
#line hidden
#line 3 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\_ViewImports.cshtml"
using MoviesInfo.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f988cc67e8ed9f80d5acb8aa5e0ae72a8f970924", @"/Areas/Admin/Pages/Episode/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da675a09bfe9c273a089f7a960b8ed67befec8d4", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Episode_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(110, 133, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>EpisodeModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(244, 56, false);
#line 15 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EpisodeModel.Show.Id));

#line default
#line hidden
            EndContext();
            BeginContext(300, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(362, 52, false);
#line 18 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayFor(model => model.EpisodeModel.Show.Id));

#line default
#line hidden
            EndContext();
            BeginContext(414, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(475, 55, false);
#line 21 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EpisodeModel.Season));

#line default
#line hidden
            EndContext();
            BeginContext(530, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(592, 51, false);
#line 24 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayFor(model => model.EpisodeModel.Season));

#line default
#line hidden
            EndContext();
            BeginContext(643, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(704, 55, false);
#line 27 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EpisodeModel.Number));

#line default
#line hidden
            EndContext();
            BeginContext(759, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(821, 51, false);
#line 30 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayFor(model => model.EpisodeModel.Number));

#line default
#line hidden
            EndContext();
            BeginContext(872, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(933, 60, false);
#line 33 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EpisodeModel.EpisodeName));

#line default
#line hidden
            EndContext();
            BeginContext(993, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1055, 56, false);
#line 36 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayFor(model => model.EpisodeModel.EpisodeName));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1172, 56, false);
#line 39 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EpisodeModel.AirDate));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1290, 52, false);
#line 42 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
       Write(Html.DisplayFor(model => model.EpisodeModel.AirDate));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1389, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f988cc67e8ed9f80d5acb8aa5e0ae72a8f9709249020", async() => {
                BeginContext(1448, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Admin\Pages\Episode\Details.cshtml"
                           WriteLiteral(Model.EpisodeModel.Id);

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
            BeginContext(1456, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1464, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f988cc67e8ed9f80d5acb8aa5e0ae72a8f97092411365", async() => {
                BeginContext(1486, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1502, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesInfo.Areas.Admin.Pages.Episode.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MoviesInfo.Areas.Admin.Pages.Episode.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MoviesInfo.Areas.Admin.Pages.Episode.DetailsModel>)PageContext?.ViewData;
        public MoviesInfo.Areas.Admin.Pages.Episode.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
