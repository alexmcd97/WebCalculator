#pragma checksum "C:\Users\alexm\Desktop\Programmin\WebCalc\WebCalculator\MyWebCalculator\Views\Calculator\Divide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6226b2dd33037e83e5dfbd31d7ec1e245a8415f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Divide), @"mvc.1.0.view", @"/Views/Calculator/Divide.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Divide.cshtml", typeof(AspNetCore.Views_Calculator_Divide))]
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
#line 1 "C:\Users\alexm\Desktop\Programmin\WebCalc\WebCalculator\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator;

#line default
#line hidden
#line 2 "C:\Users\alexm\Desktop\Programmin\WebCalc\WebCalculator\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6226b2dd33037e83e5dfbd31d7ec1e245a8415f", @"/Views/Calculator/Divide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c93cf8501ee692a6dcd53c1cb5152db45382f", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Divide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\alexm\Desktop\Programmin\WebCalc\WebCalculator\MyWebCalculator\Views\Calculator\Divide.cshtml"
  
    ViewData["Title"] = "Divide";

#line default
#line hidden
            BeginContext(42, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(47, 17, false);
#line 4 "C:\Users\alexm\Desktop\Programmin\WebCalc\WebCalculator\MyWebCalculator\Views\Calculator\Divide.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(64, 10, true);
            WriteLiteral("</h2>\r\n<p>");
            EndContext();
            BeginContext(75, 18, false);
#line 5 "C:\Users\alexm\Desktop\Programmin\WebCalc\WebCalculator\MyWebCalculator\Views\Calculator\Divide.cshtml"
Write(ViewData["Output"]);

#line default
#line hidden
            EndContext();
            BeginContext(93, 63, true);
            WriteLiteral("<p>\r\n\r\n<p>First Variable / Second Variable = Final Result</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
