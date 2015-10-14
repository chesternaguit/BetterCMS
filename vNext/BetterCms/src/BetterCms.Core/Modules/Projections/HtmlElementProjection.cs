﻿using System;
using BetterCms.Core.DataContracts;
using BetterCms.Core.Services;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Mvc.ViewFeatures;
using Microsoft.Extensions.WebEncoders;
using Microsoft.Extensions.DependencyInjection;

namespace BetterCms.Core.Modules.Projections
{
    /// <summary>
    /// Represents base projection to render html elements.
    /// </summary>
    public class HtmlElementProjection : IPageActionProjection
    {
        /// <summary>
        /// Determines, if html tag is self closing
        /// </summary>
        private readonly bool isSelfClosing;

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlElementProjection" /> class.
        /// </summary>
        /// <param name="tag">The tag key.</param>
        /// <param name="isSelfClosing">if set to <c>true</c> if html tag is self closing.</param>
        public HtmlElementProjection(string tag, bool isSelfClosing = false)
        {
            Tag = tag;

            this.isSelfClosing = isSelfClosing;
        }

        /// <summary>
        /// Gets or sets function to retrieve an id for html element.
        /// </summary>
        /// <value>
        /// A function to retrieve an id for html element.
        /// </value>
        public Func<IPage, string> Id { get; set; }

        /// <summary>
        /// Gets or sets function to retrieve html element CSS class.
        /// </summary>
        /// <value>
        /// A function to retrieve html element CSS class.
        /// </value>
        public Func<IPage, string> CssClass { get; set; }

        /// <summary>
        /// Gets or sets the tooltip.
        /// </summary>
        /// <value>
        /// The tooltip.
        /// </value>
        public Func<IPage, string> Tooltip { get; set; }

        /// <summary>
        /// Determines, if HTML projection should be rendered.
        /// </summary>
        /// <value>
        /// <c>true</c>, if HTML projection should be rendered, otherwise <c>false</c>.
        /// </value>
        public Func<IPage, bool> ShouldBeRendered { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets permission for rendering.
        /// </summary>
        /// <value>
        /// The role.
        /// </value>
        public string AccessRole { get; set; }

        /// <summary>
        /// Gets html element tag name.
        /// </summary>
        protected string Tag { get; private set; }

        /// <summary>
        /// Renders a control.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="securityService"></param>
        /// <param name="html">The HTML.</param>
        /// <param name="componentHelper">The View Component Helper</param>
        /// <returns><c>true</c> on success, otherwise <c>false</c>.</returns>
        public virtual bool Render(IPage page, ISecurityService securityService, HtmlHelper html, IViewComponentHelper componentHelper = null)
        {
            if (ShouldBeRendered != null && !ShouldBeRendered.Invoke(page))
            {
                return false;
            }

            if (AccessRole != null && !securityService.IsAuthorized(AccessRole))
            {
                return false;
            }

            TagBuilder builder = new TagBuilder(Tag)
            {
                TagRenderMode = isSelfClosing ? TagRenderMode.SelfClosing : TagRenderMode.Normal
            };
            OnPreRender(builder, page, html);
            var encoder = html.ViewContext.HttpContext.ApplicationServices.GetService<IHtmlEncoder>();
            builder.WriteTo(html.ViewContext.Writer, encoder);

            return true;
        }

        /// <summary>
        /// Called before render methods sends element to response output.
        /// </summary>
        /// <param name="builder">The html control renderer.</param>
        /// <param name="page">The page.</param>
        /// <param name="html">The html helper.</param>
        protected virtual void OnPreRender(TagBuilder builder, IPage page, HtmlHelper html)
        {
            if (Id != null)
            {
                builder.Attributes["id"] = Id(page);
            }

            if (CssClass != null)
            {
                string css = builder.Attributes["class"];

                css = !string.IsNullOrEmpty(css) ? string.Concat(css, " ", CssClass(page)) : CssClass(page);

                builder.Attributes.Add("class", css);
            }

            if (Tooltip != null)
            {
                string tooltip = Tooltip(page);
                builder.Attributes.Add("title", tooltip);
            }

            builder.Attributes.Add("data-bcms-order", Order.ToString());
        }
    }
}