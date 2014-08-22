﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Root.Views.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\CmsLayout.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/CmsLayout.cshtml")]
    public partial class CmsLayout : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderPageViewModel>
    {
        public CmsLayout()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n    <head>\r\n        <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n            .bcms-clearfix:after {\r\n                content: \".\";\r\n           " +
"     visibility: hidden;\r\n                display: block;\r\n                heigh" +
"t: 0;\r\n                clear: both;\r\n            }\r\n        </style>\r\n        <l" +
"ink");

WriteLiteral(" href=\'//fonts.googleapis.com/css?family=Open+Sans:400italic,700italic,400,700\'");

WriteLiteral(" rel=\'stylesheet\'");

WriteLiteral(" type=\'text/css\'");

WriteLiteral(" async />\r\n");

WriteLiteral("        ");

            
            #line 18 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Action("RenderStyleSheetIncludes", "Rendering"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
            function loadBetterCmsScriptAsync(url, callback) {
                var head = document.getElementsByTagName(""head"")[0];
                var scriptTag = document.createElement(""script"");
                scriptTag.type = 'text/javascript';
                scriptTag.src = url;
                scriptTag.async = true;

                // Attach handlers for all browsers
                var done = false;
                scriptTag.onload = scriptTag.onreadystatechange = function() {
                    if (!done && (!this.readyState || this.readyState == ""loaded"" || this.readyState == ""complete"")) {
                        done = true;
                        try {
                            if (callback) {
                                callback();
                            }
                        } finally {
                            scriptTag.onload = scriptTag.onreadystatechange = null;
                            head.removeChild(scriptTag);
                        }
                    }
                };

                head.appendChild(scriptTag);
            }

            (function() {
                if (window.top === window.self) {
                    loadBetterCmsScriptAsync('");

            
            #line 49 "..\..\Views\Shared\CmsLayout.cshtml"
                                         Write(Model.RequireJsPath);

            
            #line default
            #line hidden
WriteLiteral("\', function() {\r\n                        loadBetterCmsScriptAsync(\'");

            
            #line 50 "..\..\Views\Shared\CmsLayout.cshtml"
                                             Write(Model.MainJsPath);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n                    });\r\n                }\r\n            })();\r\n        </scr" +
"ipt>\r\n        <!--[if lt IE 9]>\r\n            <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2140), Tuple.Create("\"", 2168)
            
            #line 56 "..\..\Views\Shared\CmsLayout.cshtml"
, Tuple.Create(Tuple.Create("", 2146), Tuple.Create<System.Object, System.Int32>(Model.Html5ShivJsPath
            
            #line default
            #line hidden
, 2146), false)
);

WriteLiteral("></script>\r\n        <![endif]-->\r\n\r\n    </head>\r\n\r\n    <body ");

            
            #line 61 "..\..\Views\Shared\CmsLayout.cshtml"
     Write(Html.RenderBodyAttributes());

            
            #line default
            #line hidden
WriteLiteral(">\r\n\r\n");

WriteLiteral("        ");

            
            #line 63 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("~/Areas/bcms-root/Views/Shared/Partial/SupportBrowser.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 64 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("~/Areas/bcms-root/Views/Shared/Partial/SupportJavascript.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("        ");

            
            #line 66 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("        ");

            
            #line 68 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("~/Areas/bcms-root/Views/Shared/Partial/MasterPagesPath.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("        ");

            
            #line 70 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(RenderSection("Scripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("        ");

            
            #line 72 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("Partial/Region"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 73 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("Partial/ContentOverlay"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 74 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Action("Container", "Sidebar"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 75 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("Partial/Modal"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 76 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("Partial/Alert"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 77 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("Partial/Confirm"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 78 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("Partial/Info"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 79 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("Partial/Tooltip"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 80 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("Partial/ImagePreview"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 81 "..\..\Views\Shared\CmsLayout.cshtml"
   Write(Html.Partial("Partial/SiteSettingTab"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
