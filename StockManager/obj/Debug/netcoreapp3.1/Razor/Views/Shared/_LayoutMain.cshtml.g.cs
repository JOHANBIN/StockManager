#pragma checksum "C:\Users\chohb88\source\repos\StockManager\StockManager\Views\Shared\_LayoutMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd8263ad80f9b5a02a9e359be649ffc7905a798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutMain), @"mvc.1.0.view", @"/Views/Shared/_LayoutMain.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd8263ad80f9b5a02a9e359be649ffc7905a798", @"/Views/Shared/_LayoutMain.cshtml")]
    public class Views_Shared__LayoutMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/simple-sidebar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\chohb88\source\repos\StockManager\StockManager\Views\Shared\_LayoutMain.cshtml"
  Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css\" integrity=\"sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l\" crossorigin=\"anonymous\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fdd8263ad80f9b5a02a9e359be649ffc7905a7983826", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"canonical\" href=\"https://startbootstrap.com/previews/simple-sidebar\">\r\n");
            }
            );
            WriteLiteral("\r\n<div>\r\n\r\n    <div class=\"d-flex\" id=\"wrapper\">\r\n        <!-- Sidebar -->\r\n        ");
#nullable restore
#line 13 "C:\Users\chohb88\source\repos\StockManager\StockManager\Views\Shared\_LayoutMain.cshtml"
   Write(await Html.PartialAsync("SideBar.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <!-- /#sidebar-wrapper -->
        <!-- Page Content -->
        <div id=""page-content-wrapper"">

            <nav class=""navbar navbar-expand-lg navbar-light bg-light border-bottom"">
                <button class=""btn btn-primary"" id=""menu-toggle"">Toggle Menu</button>

                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>

                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav ml-auto mt-2 mt-lg-0"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""na");
            WriteLiteral(@"v-link"" href=""#"">Link</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Dropdown
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </li>
                    </ul>
                </div>
            </nav>

            <div class=""container-fluid"">
                ");
#nullable restore
#line 49 "C:\Users\chohb88\source\repos\StockManager\StockManager\Views\Shared\_LayoutMain.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <h1 class=""mt-4"">Simple Sidebar</h1>
                <p>The starting state of the menu will appear collapsed on smaller screens, and will appear non-collapsed on larger screens. When toggled using the button below, the menu will change.</p>
                <p>Make sure to keep all page content within the <code>#page-content-wrapper</code>. The top navbar is optional, and just for demonstration. Just create an element with the <code>#menu-toggle</code> ID which will toggle the menu when clicked.</p>
            </div>
        </div>
        <!-- /#page-content-wrapper -->

    </div>
    <!-- /#wrapper -->







</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://code.jquery.com/jquery-3.5.1.js""
            integrity=""sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc=""
            crossorigin=""anonymous""></script>
    <!-- Menu Toggle Script -->
    <script>
        $(""#menu-toggle"").click(function (e) {
            e.preventDefault();
            $(""#wrapper"").toggleClass(""toggled"");
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
