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

namespace BetterCms.Module.Pages.Views.Widgets.Partial
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
    
    #line 1 "..\..\Views\Widgets\Partial\WidgetUsagesTemplate.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Widgets\Partial\WidgetUsagesTemplate.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Widgets\Partial\WidgetUsagesTemplate.cshtml"
    using BetterCms.Module.Root.Mvc.Grids;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Widgets\Partial\WidgetUsagesTemplate.cshtml"
    using BetterCms.Module.Root.ViewModels.Shared;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/Partial/WidgetUsagesTemplate.cshtml")]
    public partial class WidgetUsagesTemplate : System.Web.Mvc.WebViewPage<dynamic>
    {
        public WidgetUsagesTemplate()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Widgets\Partial\WidgetUsagesTemplate.cshtml"
  
    var gridViewModel = new EditableGridViewModel
    {
        CanAddNewItems = false,
        CanDeleteItems = false,
        Columns = new List<EditableGridColumn>
            {
                new EditableGridColumn(PagesGlobalization.WidgetUsages_Title_Title, "Title", "title"),
                    
                new EditableGridColumn(PagesGlobalization.WidgetUsages_Type_Title, "", "typeTitle")
                    {
                        HeaderAttributes = "style=\"width: 105px;\""
                    }
            }
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(" id=\"bcms-widget-usages-grid\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 24 "..\..\Views\Widgets\Partial\WidgetUsagesTemplate.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridTemplate, gridViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591