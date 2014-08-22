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

namespace BetterCms.Module.Pages.Views.Content.Partial
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
    
    #line 1 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.UI;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/Partial/EditHtmlContent.cshtml")]
    public partial class EditHtmlContent : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Content.PageContentViewModel>
    {
        public EditHtmlContent()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.HiddenFor(model => model.EditInSourceMode, new { @id = "bcms-edit-in-source-mode" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-newcontent-top\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 11 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
   Write(Html.Tooltip(PagesGlobalization.AddPageContent_RegularContentTab_ContentName_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                    Write(PagesGlobalization.AddPageContent_RegularContentTab_ContentName_Title);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n        <div");

WriteLiteral(" class=\"bcms-custom-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.TextBoxFor(model => model.ContentName, new { @class = "bcms-editor-field-box", style = "width: 523px;" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.BcmsValidationMessageFor(model => model.ContentName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                    Write(PagesGlobalization.AddPageContent_RegularContentTab_LiveFrom_Title);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n        <div");

WriteLiteral(" class=\"bcms-date-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 21 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.DateTextBoxFor(model => model.LiveFrom, Model.LiveFrom, new Dictionary<string, object> {{"class", "bcms-editor-field-box bcms-datepicker"}, {"style", "width: 127px;"}}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.BcmsValidationMessageFor(model => model.LiveFrom));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"bcms-input-field-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                    Write(PagesGlobalization.AddPageContent_RegularContentTab_LiveTo_Title);

            
            #line default
            #line hidden
WriteLiteral(":</div>\r\n        <div");

WriteLiteral(" class=\"bcms-date-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.DateTextBoxFor(model => model.LiveTo, Model.LiveTo, new Dictionary<string, object> {{"class", "bcms-editor-field-box bcms-datepicker"}, {"style", "width: 127px;"}}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.BcmsValidationMessageFor(model => model.LiveTo));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"bcms-text-editor-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 34 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.TextAreaFor(model => model.PageContent, new { @class = "bcms-contenthtml", @id = Guid.NewGuid() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.CheckBoxFor(model => model.EnabledCustomCss, new { @id = "bcms-enable-custom-css" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 39 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                            Write(Html.Raw(PagesGlobalization.HtmlContent_EnableCustomCss_Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(" id=\"bcms-custom-css-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                Write(PagesGlobalization.HtmlContent_CustomCss_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("    ");

            
            #line 43 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.TextAreaFor(model => model.CustomCss, new { @class = "bcms-editor-field-area bcms-code-field bcms-code-field-css", @style = "width:820px;" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 44 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.BcmsValidationMessageFor(model => model.CustomCss));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 48 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.CheckBoxFor(model => model.EanbledCustomJs, new { @id = "bcms-enable-custom-js" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 49 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                            Write(Html.Raw(PagesGlobalization.HtmlContent_EnableCustomJs_Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(" id=\"bcms-custom-js-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                Write(PagesGlobalization.HtmlContent_CustomJs_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("    ");

            
            #line 53 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.TextAreaFor(model => model.CustomJs, new { @class = "bcms-editor-field-area bcms-code-field bcms-code-field-javascript", @style = "width:820px;" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 54 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.BcmsValidationMessageFor(model => model.CustomJs));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
