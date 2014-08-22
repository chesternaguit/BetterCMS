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

namespace BetterCms.Module.Pages.Views.History
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
    
    #line 1 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Core.DataContracts.Enums;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Module.Pages.Command.History.GetContentHistory;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Module.Pages.ViewModels.History;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Views\History\ContentHistory.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..\Views\History\ContentHistory.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 12 "..\..\Views\History\ContentHistory.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/History/ContentHistory.cshtml")]
    public partial class ContentHistory : System.Web.Mvc.WebViewPage<ContentHistoryViewModel>
    {

#line 15 "..\..\Views\History\ContentHistory.cshtml"
public System.Web.WebPages.HelperResult PreviewLink(ContentHistoryItem item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 16 "..\..\Views\History\ContentHistory.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <a");

WriteLiteralTo(__razor_helper_writer, " class=\"bcms-icn-preview\"");

WriteLiteralTo(__razor_helper_writer, " data-id=\"");


#line 17 "..\..\Views\History\ContentHistory.cshtml"
           WriteTo(__razor_helper_writer, item.Id);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 17 "..\..\Views\History\ContentHistory.cshtml"
                     WriteTo(__razor_helper_writer, RootGlobalization.Button_Preview);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 18 "..\..\Views\History\ContentHistory.cshtml"


#line default
#line hidden
});

#line 18 "..\..\Views\History\ContentHistory.cshtml"
}
#line default
#line hidden

#line 20 "..\..\Views\History\ContentHistory.cshtml"
public System.Web.WebPages.HelperResult RestoreLink(ContentHistoryItem item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 21 "..\..\Views\History\ContentHistory.cshtml"
 
    if (item.CanCurrentUserRestoreIt)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <a");

WriteLiteralTo(__razor_helper_writer, " class=\"bcms-icn-restore\"");

WriteLiteralTo(__razor_helper_writer, " data-id=\"");


#line 24 "..\..\Views\History\ContentHistory.cshtml"
               WriteTo(__razor_helper_writer, item.Id);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, " data-version=\"");


#line 24 "..\..\Views\History\ContentHistory.cshtml"
                                       WriteTo(__razor_helper_writer, item.Version);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 24 "..\..\Views\History\ContentHistory.cshtml"
                                                      WriteTo(__razor_helper_writer, RootGlobalization.Button_Restore);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 25 "..\..\Views\History\ContentHistory.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, "&nbsp;\r\n");


#line 29 "..\..\Views\History\ContentHistory.cshtml"
    }


#line default
#line hidden
});

#line 30 "..\..\Views\History\ContentHistory.cshtml"
}
#line default
#line hidden

#line 32 "..\..\Views\History\ContentHistory.cshtml"
public System.Web.WebPages.HelperResult DisplayStatus(string statusName, ContentStatus status)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 33 "..\..\Views\History\ContentHistory.cshtml"
 
    switch (status)
    {
        case ContentStatus.Archived:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, "<div class=\"bcms-archived-state\">");


#line 37 "..\..\Views\History\ContentHistory.cshtml"
         WriteTo(__razor_helper_writer, statusName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 38 "..\..\Views\History\ContentHistory.cshtml"

            break;

        case ContentStatus.Draft:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, "<div class=\"bcms-draft-state\">");


#line 42 "..\..\Views\History\ContentHistory.cshtml"
      WriteTo(__razor_helper_writer, statusName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 43 "..\..\Views\History\ContentHistory.cshtml"
        
            break;

        case ContentStatus.Published:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, "<div class=\"bcms-published-state\">");


#line 47 "..\..\Views\History\ContentHistory.cshtml"
          WriteTo(__razor_helper_writer, statusName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 48 "..\..\Views\History\ContentHistory.cshtml"
        
            break;

        default:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, "statusName\r\n");


#line 53 "..\..\Views\History\ContentHistory.cshtml"
            break;
    }


#line default
#line hidden
});

#line 55 "..\..\Views\History\ContentHistory.cshtml"
}
#line default
#line hidden

        public ContentHistory()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 57 "..\..\Views\History\ContentHistory.cshtml"
  
    Action<ColumnBuilder<ContentHistoryItem>> columns = column =>
    {
        column.For(f => PreviewLink(f))
               .Encode(false)
               .Named("&nbsp;")
               .Sortable(false)
               .HeaderAttributes(@style => "width: 40px; padding: 10px;", @class => "bcms-tables-nohover");

        column.For(m => m.PublishedOn.ToFormattedDateString())
               .Named(PagesGlobalization.ContentHistory_Column_PublishedOn)
               .SortColumnName("PublishedOn")
               .HeaderAttributes(@style => "width: 95px;")
               .Attributes(@style => "width: 100px;");

        column.For(m => m.PublishedByUser)
               .Named(PagesGlobalization.ContentHistory_Column_PublishedByUser)
               .SortColumnName("PublishedByUser")
               .HeaderAttributes(@style => "width: 200px;")
               .Attributes(@style => "width: 200px;");

        column.For(m => m.ArchivedOn.ToFormattedDateString())
               .Named(PagesGlobalization.ContentHistory_Column_ArchivedOn)
               .SortColumnName("ArchivedOn")
               .HeaderAttributes(@style => "width: 100px;")
               .Attributes(@style => "width: 100px;");

        column.For(m => m.DisplayedFor.ToFormatedTimeString())
               .Named(PagesGlobalization.ContentHistory_Column_DisplayedFor)
               .SortColumnName("DisplayedFor")
               .HeaderAttributes(@style => "width: 105px;")
               .Attributes(@style => "width: 105px;");

        column.For(m => DisplayStatus(m.StatusName, m.Status))
               .Named(PagesGlobalization.ContentHistory_Column_Status)
               .SortColumnName("StatusName")
               .Encode(false)
               .HeaderAttributes(@style => "width: 90px;")
               .Attributes(@style => "width: 90px;");

        column.For(f => RestoreLink(f))
               .Encode(false)
               .Named("&nbsp;")
               .Sortable(false)
               .HeaderAttributes(@style => "width: 170px;", @class => "bcms-tables-nohover")
               .Attributes(@style => "width: 144px;");
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-history-preview-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 108 "..\..\Views\History\ContentHistory.cshtml"
   Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-history-preview\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"bcms-history-preview\"");

WriteLiteral(" style=\"height: 100%\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-history-info\"");

WriteLiteral(" style=\"display: block;\"");

WriteLiteral(">");

            
            #line 111 "..\..\Views\History\ContentHistory.cshtml"
                                                                  Write(PagesGlobalization.ContentHistory_SelectVersionToPreviewMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-history-content\"");

WriteLiteral("></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-history-table-holder\"");

WriteLiteral(">\r\n\r\n");

            
            #line 119 "..\..\Views\History\ContentHistory.cshtml"
        
            
            #line default
            #line hidden
            
            #line 119 "..\..\Views\History\ContentHistory.cshtml"
         using (Html.BeginForm<HistoryController>(f => f.ContentHistory((GetContentHistoryRequest)null), FormMethod.Post, new { @id = "bcms-pagecontenthistory-form", @class = "bcms-ajax-form" }))
        {                        
            
            
            #line default
            #line hidden
            
            #line 121 "..\..\Views\History\ContentHistory.cshtml"
       Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
            
            #line 121 "..\..\Views\History\ContentHistory.cshtml"
                                                      
            
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\History\ContentHistory.cshtml"
       Write(Html.HiddenFor(model => model.ContentId));

            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\History\ContentHistory.cshtml"
                                                     


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-history-table-top\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-large-titles\"");

WriteLiteral(">");

            
            #line 125 "..\..\Views\History\ContentHistory.cshtml"
                                          Write(PagesGlobalization.ContentHistory_OlderVersions);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 127 "..\..\Views\History\ContentHistory.cshtml"
               Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-editor-field-box", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-pagecontenthistory-search-btn\"");

WriteLiteral(">");

            
            #line 128 "..\..\Views\History\ContentHistory.cshtml"
                                                                                    Write(RootGlobalization.Button_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n            </div>                        \r\n");

            
            #line 131 "..\..\Views\History\ContentHistory.cshtml"
            
            
            #line default
            #line hidden
            
            #line 131 "..\..\Views\History\ContentHistory.cshtml"
       Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables bcms-history-grid").RenderUsing(new ScrollableEditableHtmlTableGridRenderer<ContentHistoryItem>()
                                                                                                                                 {
                                                                                                                                     InternalTableCssClass = "bcms-history-cell"

                                                                                                                                 }));

            
            #line default
            #line hidden
            
            #line 135 "..\..\Views\History\ContentHistory.cshtml"
                                                                                                                                   
            
            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\History\ContentHistory.cshtml"
       Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\History\ContentHistory.cshtml"
                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-history-preview-template\"");

WriteLiteral(">\r\n    <iframe src=\"\" style=\"width: 100%; height: 100%; border: 0px;\"></iframe>\r\n" +
"</script>\r\n");

        }
    }
}
#pragma warning restore 1591
