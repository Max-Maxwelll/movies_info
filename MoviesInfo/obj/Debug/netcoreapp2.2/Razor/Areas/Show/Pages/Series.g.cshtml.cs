#pragma checksum "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Show\Pages\Series.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d6dc4906779561fc50ac5fc8cf25a5ffcf57bcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MoviesInfo.Pages.Areas_Show_Pages_Series), @"mvc.1.0.razor-page", @"/Areas/Show/Pages/Series.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Show/Pages/Series.cshtml", typeof(MoviesInfo.Pages.Areas_Show_Pages_Series), null)]
namespace MoviesInfo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Show\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Show\Pages\_ViewImports.cshtml"
using MoviesInfo;

#line default
#line hidden
#line 3 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Show\Pages\_ViewImports.cshtml"
using MoviesInfo.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6dc4906779561fc50ac5fc8cf25a5ffcf57bcd", @"/Areas/Show/Pages/Series.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da675a09bfe9c273a089f7a960b8ed67befec8d4", @"/Areas/Show/Pages/_ViewImports.cshtml")]
    public class Areas_Show_Pages_Series : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Maksym\source\repos\movies_info\MoviesInfo\Areas\Show\Pages\Series.cshtml"
  
    ViewData["Title"] = "Series";
    ViewData["Header"] = "Series";

#line default
#line hidden
            BeginContext(133, 21, true);
            WriteLiteral("\r\n<h1>Series</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesInfo.Areas.Show.Pages.SeriesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MoviesInfo.Areas.Show.Pages.SeriesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MoviesInfo.Areas.Show.Pages.SeriesModel>)PageContext?.ViewData;
        public MoviesInfo.Areas.Show.Pages.SeriesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591