#pragma checksum "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "def7824effa229b7e321d7911c55cb39651e2613"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MovieSamurai.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MovieSamurai.Pages
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
#line 1 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\_ViewImports.cshtml"
using MovieSamurai;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"def7824effa229b7e321d7911c55cb39651e2613", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6bac5ff898bc36e4c8a6ceab54dc84d87fe3d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "GetDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "GetActorDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
  
    string path = "https://image.tmdb.org/t/p/w500";
    string backdropUrl = "https://image.tmdb.org/t/p/w1920_and_h800_multi_faces" +
        Model.backdropPath;
    string posterPath = path + Model.posterPath;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def7824effa229b7e321d7911c55cb39651e26135072", async() => {
                WriteLiteral(" <!-- page handler to match method name (excluding OnPost) -->\r\n    <input id=\"searchBox\" type=\"text\" name=\"search\" placeholder=\"movie search...\"> <!-- name needs to match argument name of OnPostSearch -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div id=\"upcomming\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def7824effa229b7e321d7911c55cb39651e26137040", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
         for(int i = 0; i < Model.UPCOMMING_MAX_RESULTS; i++) {
                if(Model.posterURLs[i] != null){
                    String poster_path = path + Model.posterURLs[i];

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"thumb\"");
                BeginWriteAttribute("style", " style=\"", 836, "\"", 898, 7);
                WriteAttributeValue("", 844, "background", 844, 10, true);
                WriteAttributeValue(" ", 854, ":", 855, 2, true);
                WriteAttributeValue(" ", 856, "url(", 857, 5, true);
#nullable restore
#line 20 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 861, poster_path, 861, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 873, ");", 873, 2, true);
                WriteAttributeValue(" ", 875, "background-size:", 876, 17, true);
                WriteAttributeValue(" ", 892, "100%;", 893, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("title", "\r\n                        title=\"", 899, "\"", 951, 1);
#nullable restore
#line 21 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 932, Model.overviews[i], 932, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"submit\" class=\"thumbButton\" name=\"movieID\"");
                BeginWriteAttribute("value", " value=\"", 1034, "\"", 1060, 1);
#nullable restore
#line 22 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 1042, Model.movieIDs[i], 1042, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/> <!-- // name must match parameters in page handler-->\r\n                    </div>\r\n");
#nullable restore
#line 24 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                }
                else{
                    // do nothing
                }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div id=\"posters\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def7824effa229b7e321d7911c55cb39651e261311263", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
         for(int i = 0; i < Model.MAX_RESULTS; i++) {
            if(Model.posterURLs[i] != null){
                String poster_path = path + Model.posterURLs[i];

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"thumb\"");
                BeginWriteAttribute("style", " style=\"", 1547, "\"", 1609, 7);
                WriteAttributeValue("", 1555, "background", 1555, 10, true);
                WriteAttributeValue(" ", 1565, ":", 1566, 2, true);
                WriteAttributeValue(" ", 1567, "url(", 1568, 5, true);
#nullable restore
#line 36 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 1572, poster_path, 1572, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1584, ");", 1584, 2, true);
                WriteAttributeValue(" ", 1586, "background-size:", 1587, 17, true);
                WriteAttributeValue(" ", 1603, "100%;", 1604, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("title", "\r\n                    title=\"", 1610, "\"", 1658, 1);
#nullable restore
#line 37 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 1639, Model.overviews[i], 1639, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"submit\" class=\"thumbButton\" name=\"movieID\"");
                BeginWriteAttribute("value", " value=\"", 1737, "\"", 1763, 1);
#nullable restore
#line 38 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 1745, Model.movieIDs[i], 1745, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/> <!-- // name must match parameters in page handler-->\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
            }
            else{
                    // do nothing
            }
            
        } 

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
 if(Model.movieTitle != "") { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"details\"");
            BeginWriteAttribute("style", " style=\"", 2032, "\"", 2103, 6);
            WriteAttributeValue("", 2040, "background:", 2040, 11, true);
            WriteAttributeValue(" ", 2051, "url(", 2052, 5, true);
#nullable restore
#line 50 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 2056, backdropUrl, 2056, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2068, ");", 2068, 2, true);
            WriteAttributeValue("\r\n        ", 2070, "background-size:", 2080, 26, true);
            WriteAttributeValue(" ", 2096, "cover;", 2097, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div id=\"opacityLayer\">\r\n            <img id=\"poster\"");
            BeginWriteAttribute("src", " src=\"", 2168, "\"", 2185, 1);
#nullable restore
#line 53 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 2174, posterPath, 2174, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"MoviePoster\">\r\n            <div id=\"movieStats\">\r\n                <h1>");
#nullable restore
#line 55 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
               Write(Model.movieTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 55 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                                  Write(Model.releaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h1>\r\n                <h2>");
#nullable restore
#line 56 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
               Write(Model.tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2366, "\"", 2388, 1);
#nullable restore
#line 57 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 2373, Model.homepage, 2373, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Official Website</a>\r\n                <p>");
#nullable restore
#line 58 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
              Write(Model.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Revenue: ");
#nullable restore
#line 59 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                       Write(string.Format("{0:C}",Model.revenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Budget: ");
#nullable restore
#line 60 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                      Write(string.Format("{0:C}",Model.budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div id=video>\r\n");
#nullable restore
#line 63 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                 if(Model.videoKey.Count() > 0 ) {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                     for( int i = 0; i < Model.VIDEO_MAX_RESULTS; i ++) {
                        string videoPath = "https://www.youtube.com/embed/" + @Model.videoKey[i];
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<iframe id=\"youtubeVideo\"");
            BeginWriteAttribute("src", "\r\n                            src=", 2931, "", 2975, 1);
#nullable restore
#line 67 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 2965, videoPath, 2965, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                            title=""Youtube video player""
                            allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture;""
                            allowfullscreen>
                        </iframe> 
");
#nullable restore
#line 72 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                        
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            \r\n            <div id=\"castSlider\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def7824effa229b7e321d7911c55cb39651e261321123", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                     for( int i = 0; i < Model.CAST_MAX_RESULTS; i++ ) {
                        string castPic = path + Model.castPics[i];

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"castContainer\">\r\n                            <div class=\"castPic\"");
                BeginWriteAttribute("style", " style=\"", 3674, "\"", 3761, 6);
                WriteAttributeValue("", 3682, "background:", 3682, 11, true);
                WriteAttributeValue(" ", 3693, "url(", 3694, 5, true);
#nullable restore
#line 81 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 3698, castPic, 3698, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3706, ");", 3706, 2, true);
                WriteAttributeValue(" \r\n                            ", 3708, "background-size:", 3739, 47, true);
                WriteAttributeValue(" ", 3755, "100%;", 3756, 6, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input type=\"submit\" class=\"castButton\" name=\"castID\"");
                BeginWriteAttribute("value", " value=\"", 3850, "\"", 3875, 1);
#nullable restore
#line 83 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
WriteAttributeValue("", 3858, Model.castIds[i], 3858, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                            </div>\r\n                            <p class=\"castName\">");
#nullable restore
#line 85 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                                           Write(Model.castNames[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 87 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
                    }   

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 92 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
