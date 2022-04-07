#pragma checksum "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00d591bf3256612b2680d81016cf10a71ebda7b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MovieSamurai.Pages.Pages_Actor), @"mvc.1.0.razor-page", @"/Pages/Actor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d591bf3256612b2680d81016cf10a71ebda7b9", @"/Pages/Actor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6bac5ff898bc36e4c8a6ceab54dc84d87fe3d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Actor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("homeLink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "ShowMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
  
    string url = "https://image.tmdb.org/t/p/w500";
    string personPic = url + Model.picPath;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"actorImage\">\r\n    <img id=\"actorPageHeadshot\"");
            BeginWriteAttribute("src", " src=\"", 193, "\"", 209, 1);
#nullable restore
#line 12 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
WriteAttributeValue("", 199, personPic, 199, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 210, "\"", 227, 1);
#nullable restore
#line 12 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
WriteAttributeValue("", 216, Model.name, 216, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n");
#nullable restore
#line 14 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
  
    string birthYear =  @Model.birthday.Substring(0, 4);
    int birthYearInt = Convert.ToInt16(birthYear);
    int curYear = @Model.currentdate.Year;

    int actorAge = curYear - birthYearInt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
 if(@Model.deathday != null) { // re assign value of age based on death day not currrent date if actor dead
    string deathYear = Model.deathday.Substring(0, 4);
    int deathYearInt = Convert.ToInt16(deathYear);

    int deadActorAge = @deathYearInt - @birthYearInt;
    
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"actorInfo\">\r\n        <h1>");
#nullable restore
#line 28 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 28 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                    Write(deadActorAge);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h1>\r\n        <h3>Born: ");
#nullable restore
#line 29 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
             Write(Model.birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 29 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                               Write(Model.birthplace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3>Died: ");
#nullable restore
#line 30 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
             Write(Model.deathday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>");
#nullable restore
#line 31 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
      Write(Model.bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
}
else { // do not display Deathdate


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"actorInfo\">\r\n        <h1>");
#nullable restore
#line 37 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 37 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                    Write(actorAge);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h1>\r\n        <h3>Born: ");
#nullable restore
#line 38 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
             Write(Model.birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 38 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                               Write(Model.birthplace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>");
#nullable restore
#line 39 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
      Write(Model.bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 41 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00d591bf3256612b2680d81016cf10a71ebda7b99867", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 46 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
 if(Model.twitterID != null) {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"celebrityTweets\">\r\n");
#nullable restore
#line 49 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
         for( int i = 0; i < Model.tweetTimes.Count(); i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"celebrityTweet\">\r\n                <img class=\"tweetImage\" src=\"../assets/images/twitterBlue.png\" alt=\"tweet\">\r\n                <div class=\"tweet\">\r\n                    <p class=\"tweetTime\">");
#nullable restore
#line 53 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                                    Write(Model.tweetTimes[i].ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    \r\n");
#nullable restore
#line 55 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                         
                        string link = "";
                        string body = "";
                        string tweetText = @Model.tweetText[i];
                        int start = tweetText.IndexOf("https://");
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                     if(start >= 0) {
                        body = @tweetText.Substring(0 , @start);
                        link = @tweetText.Substring(@start, @tweetText.Length - @start);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"tweetText\">");
#nullable restore
#line 65 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                                        Write(body);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p><a class=\"tweetLink\"");
            BeginWriteAttribute("href", " href=\"", 2157, "\"", 2169, 1);
#nullable restore
#line 65 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
WriteAttributeValue("", 2164, link, 2164, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"");
            BeginWriteAttribute("title", " title=\"", 2186, "\"", 2199, 1);
#nullable restore
#line 65 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
WriteAttributeValue("", 2194, link, 2194, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">  ");
#nullable restore
#line 65 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                                                                                                                     Write(link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 66 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                    }
                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"tweetText\">");
#nullable restore
#line 68 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                                        Write(tweetText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 69 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 73 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!-- for iterator -->\r\n    </div> <!-- celeb tweets -->\r\n");
#nullable restore
#line 75 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!-- if twitterID != null -->\r\n\r\n\r\n<div id=\"actorPhotoGallery\">\r\n");
#nullable restore
#line 79 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
     for( int i = 0; i < @Model.MAX_ACTOR_IMAGES; i++) {
        string galleryPath = url + @Model.photoGalleryUrl[i];
        string galleryPathHeight = @Model.photoGalleryHeight[i] + "px";
        string galleryPathWidth = @Model.photoGalleryWidth[i] + "px";
        
        

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"actorGalleryImg\"");
            BeginWriteAttribute("style", "  style=\"", 2860, "\"", 2905, 4);
            WriteAttributeValue("", 2869, "background-image:", 2869, 17, true);
            WriteAttributeValue(" ", 2886, "url(", 2887, 5, true);
#nullable restore
#line 84 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
WriteAttributeValue("", 2891, galleryPath, 2891, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2903, ");", 2903, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n");
#nullable restore
#line 86 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 89 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
 if(Model.appearsOnMovieIDs != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 id=\"appearsOnHeader\">Also Appears On..</h1>\r\n    <div id=\"postersAppearsOn\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00d591bf3256612b2680d81016cf10a71ebda7b917733", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
             for(int i = 0; i < Model.ACTOR_APPEARSON_MAX_RESULTS; i++) {
                    string appearsOnPoster = "https://image.tmdb.org/t/p/w500/" + Model.posterPaths[i];

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"thumb\"");
                BeginWriteAttribute("style", " style=\"", 3345, "\"", 3411, 7);
                WriteAttributeValue("", 3353, "background", 3353, 10, true);
                WriteAttributeValue(" ", 3363, ":", 3364, 2, true);
                WriteAttributeValue(" ", 3365, "url(", 3366, 5, true);
#nullable restore
#line 95 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
WriteAttributeValue("", 3370, appearsOnPoster, 3370, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3386, ");", 3386, 2, true);
                WriteAttributeValue(" ", 3388, "background-size:", 3389, 17, true);
                WriteAttributeValue(" ", 3405, "100%;", 3406, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("title", "\r\n                        title=\"", 3412, "\"", 3464, 1);
#nullable restore
#line 96 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
WriteAttributeValue("", 3445, Model.overviews[i], 3445, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"submit\" class=\"thumbButton\" name=\"movieID\"");
                BeginWriteAttribute("value", " value=\"", 3547, "\"", 3582, 1);
#nullable restore
#line 97 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
WriteAttributeValue("", 3555, Model.appearsOnMovieIDs[i], 3555, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/> <!-- // name must match parameters in page handler-->\r\n                    </div>\r\n");
#nullable restore
#line 99 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 102 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
}
else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- do nothing -->\r\n");
#nullable restore
#line 105 "C:\Users\ZZ ON A WAV\OneDrive - triOS College\C#\personalProject\MovieSamurai\Pages\Actor.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActorModel>)PageContext?.ViewData;
        public ActorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
