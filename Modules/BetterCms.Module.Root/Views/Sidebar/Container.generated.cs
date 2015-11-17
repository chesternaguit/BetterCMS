﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Sidebar/Container.cshtml")]
    public partial class _Views_Sidebar_Container_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.Models.Sidebar.SidebarContainerViewModel>
    {
        public _Views_Sidebar_Container_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"bcms-sidemenu\"");

WriteLiteral(" class=\"bcms-sidemenu bcms-layer\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-sidemenu-handle\"");

WriteLiteral(" id=\"bcms-sidemenu-handle\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-sidemenu-toggler\"");

WriteLiteral(" id=\"bcms-sidemenu-hide\"");

WriteLiteral(" title=\"Open/Close CMS sidebar\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-sidemenu-openclosearrow\"");

WriteLiteral(">Show/Hide</div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-sidemenu-switch\"");

WriteLiteral(" id=\"bcms-sidemenu-switch\"");

WriteLiteral(" title=\"Turn CMS edit mode ON or OFF\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-sidemenu-on\"");

WriteLiteral(">On</div>\r\n            <div");

WriteLiteral(" class=\"bcms-sidemenu-off\"");

WriteLiteral(">Off</div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" id=\"bcms-sidemenu-pubstatus\"");

WriteLiteral(" class=\"bcms-sidemenu-pubstatus\"");

WriteLiteral(" title=\"Page is published.\"");

WriteLiteral(" data-bcms-order=\"10\"");

WriteLiteral("></div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-sidemenu-drag-handle\"");

WriteLiteral(" id=\"bcms-sidemenu-draghandle\"");

WriteLiteral(" title=\"Drag to adjust sidebar position\"");

WriteLiteral(">&nbsp;</div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-sidemenu-header\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-user-profile\"");

WriteLiteral(" id=\"bcms-user-profile\"");

WriteLiteral(" data-url=\"/bcms-users/UserProfile/EditProfile\"");

WriteLiteral(">Simonas</div>\r\n        <a");

WriteLiteral(" class=\"bcms-cp-preview-btn\"");

WriteLiteral(" data-bcms-order=\"10\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Preview</a>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-sidemenu-body\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-publisher-block bcms-publisher-switch-on\"");

WriteLiteral(" data-bcms-order=\"10\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-publisher-switch\"");

WriteLiteral(" title=\"Publish or Unpublish this page\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-publisher-on\"");

WriteLiteral(">Yes</div>\r\n                <div");

WriteLiteral(" class=\"bcms-publisher-off\"");

WriteLiteral(">No</div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-publisher-info\"");

WriteLiteral(" data-bcms-module=\"bcms.pages\"");

WriteLiteral(" data-bcms-action=\"changePublishStatus\"");

WriteLiteral(">Published<div");

WriteLiteral(" class=\"bcms-publisher-includes-draft\"");

WriteLiteral(">(Includes Drafts)</div></div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-cp-btn bcms-cp-btn-add bcms-onclick-action\"");

WriteLiteral(" data-bcms-order=\"10\"");

WriteLiteral(" data-bcms-module=\"bcms.pages\"");

WriteLiteral(" data-bcms-action=\"addNewPage\"");

WriteLiteral(">New page</div>\r\n        <div");

WriteLiteral(" class=\"bcms-cp-btn bcms-onclick-action\"");

WriteLiteral(" data-bcms-order=\"30\"");

WriteLiteral(" data-bcms-module=\"bcms.pages\"");

WriteLiteral(" data-bcms-action=\"clonePage\"");

WriteLiteral(">Duplicate this page</div>\r\n        <div");

WriteLiteral(" class=\"bcms-cp-btn bcms-onclick-action\"");

WriteLiteral(" data-bcms-order=\"200\"");

WriteLiteral(" data-bcms-module=\"bcms.blog\"");

WriteLiteral(" data-bcms-action=\"postNewArticle\"");

WriteLiteral(">Create new article</div>\r\n\r\n        ");

WriteLiteral("\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-buttons-block\"");

WriteLiteral(" data-bcms-order=\"10\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-cp-settings-btn bcms-onclick-action\"");

WriteLiteral(" data-bcms-order=\"30\"");

WriteLiteral(" data-bcms-module=\"bcms.pages.properties\"");

WriteLiteral(" data-bcms-action=\"editPageProperties\"");

WriteLiteral(">Properties</div>\r\n            <div");

WriteLiteral(" class=\"bcms-cp-settings-btn bcms-cp-seo-btn bcms-onclick-action\"");

WriteLiteral(" data-bcms-order=\"20\"");

WriteLiteral(" data-bcms-module=\"bcms.pages.seo\"");

WriteLiteral(" data-bcms-action=\"openEditSeoDialog\"");

WriteLiteral(">Edit SEO</div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-cp-settings-btn bcms-onclick-action\"");

WriteLiteral(" data-bcms-order=\"900\"");

WriteLiteral(" data-bcms-module=\"bcms.siteSettings\"");

WriteLiteral(" data-bcms-action=\"openSiteSettings\"");

WriteLiteral(">Site settings</div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-buttons-block\"");

WriteLiteral(" data-bcms-order=\"10\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-cp-delete bcms-onclick-action\"");

WriteLiteral(" data-bcms-order=\"700\"");

WriteLiteral(" data-bcms-module=\"bcms.pages\"");

WriteLiteral(" data-bcms-action=\"deleteCurrentPage\"");

WriteLiteral(">Delete page</div>\r\n            <div");

WriteLiteral(" class=\"bcms-cp-logout bcms-onclick-action\"");

WriteLiteral(" data-bcms-order=\"800\"");

WriteLiteral(" data-bcms-module=\"bcms.authentication\"");

WriteLiteral(" data-bcms-action=\"logout\"");

WriteLiteral(">Log Out</div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-sidemenu-footer\"");

WriteLiteral(">\r\n        <svg");

WriteLiteral(" class=\"bcms-cp-logo\"");

WriteLiteral(" height=\"22\"");

WriteLiteral(" width=\"22\"");

WriteLiteral(" viewBox=\"0 0 22 22\"");

WriteLiteral(">\r\n            <g");

WriteLiteral(" fill-rule=\"evenodd\"");

WriteLiteral(">\r\n                <path");

WriteLiteral(" fill=\"#4ad8e5\"");

WriteLiteral(" d=\"m0 0h22v22h-22v-22\"");

WriteLiteral(" />\r\n                <path");

WriteLiteral(" fill=\"#5d7293\"");

WriteLiteral(" d=\"m7 7h15v15h-15v-15\"");

WriteLiteral(" />\r\n                <path");

WriteLiteral(" fill=\"#184258\"");

WriteLiteral(" d=\"m7 7h9v9h-9v-9\"");

WriteLiteral(" />\r\n                <path");

WriteLiteral(" fill=\"#fff\"");

WriteLiteral(" d=\"m12 12h4v4h-4v-4\"");

WriteLiteral(" />\r\n            </g>\r\n        </svg>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-cp-version-number\"");

WriteLiteral(">1.11.0-dev</div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-cp-position-handle\"");

WriteLiteral(" title=\"Move sidebar to the other side\"");

WriteLiteral(" id=\"bcms-sidemenu-position-handle\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-sidemenu-stick-text\"");

WriteLiteral(" title=\"stick to the right\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
