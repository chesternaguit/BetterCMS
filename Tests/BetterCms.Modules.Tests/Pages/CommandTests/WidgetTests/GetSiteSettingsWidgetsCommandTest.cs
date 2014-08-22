﻿using System;
using System.Linq;

using BetterCms.Core.DataAccess;
using BetterCms.Core.DataAccess.DataContext;
using BetterCms.Module.Pages.Command.Widget.GetSiteSettingsWidgets;
using BetterCms.Module.Pages.Models;
using BetterCms.Module.Pages.Services;
using BetterCms.Module.Pages.ViewModels.Filter;
using BetterCms.Module.Root.Mvc.Grids.GridOptions;

using NUnit.Framework;

namespace BetterCms.Test.Module.Pages.CommandTests.WidgetTests
{
    [TestFixture]
    public class GetSiteSettingsWidgetsCommandTest : IntegrationTestBase
    {
        [Test]
        public void Should_Return_Widgets_List_Successfully()
        {
            RunActionInTransaction(
                session =>
                    {
                        ServerControlWidget control1 = TestDataProvider.CreateNewServerControlWidget();
                        HtmlContentWidget control2 = TestDataProvider.CreateNewHtmlContentWidget();

                        control1.Id = Guid.NewGuid();
                        control1.Name = Guid.NewGuid().ToString().Replace("-", string.Empty);

                        session.SaveOrUpdate(control1);
                        session.SaveOrUpdate(control2);
                        session.Flush();

                        var unitOfWork = new DefaultUnitOfWork(session);
                        var repository = new DefaultRepository(unitOfWork);
                        var widgetService = new DefaultWidgetService(repository, unitOfWork, null, null);
                        var command = new GetSiteSettingsWidgetsCommand(widgetService);

                        var response = command.Execute(new WidgetsFilter { SearchQuery = control1.Name.Substring(1, control1.Name.Length - 1) });

                        Assert.IsNotNull(response);
                        Assert.IsNotNull(response.Items);
                        Assert.GreaterOrEqual(response.Items.Count(), 1);

                        var widget = response.Items.FirstOrDefault(w => control1.Id == w.Id);
                        Assert.IsNotNull(widget);
                        Assert.AreEqual(control1.Name, widget.WidgetName);
                    });
        }

        [Test]
        public void Should_Return_Empty_List()
        {
            RunActionInTransaction(
                session =>
                    {
                        var unitOfWork = new DefaultUnitOfWork(session);
                        var repository = new DefaultRepository(unitOfWork);
                        var widgetService = new DefaultWidgetService(repository, unitOfWork, null, null);
                        var command = new GetSiteSettingsWidgetsCommand(widgetService);

                        var response = command.Execute(new WidgetsFilter { SearchQuery = Guid.NewGuid().ToString() });

                        Assert.IsNotNull(response);
                        Assert.IsNotNull(response.Items);
                        Assert.IsEmpty(response.Items);
                    });

        }
    }
}
