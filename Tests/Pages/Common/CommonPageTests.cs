using System.Collections.Generic;
using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Pages.Common;

namespace Tests.Pages.Common
{
    [TestClass]
    public class CommonPageTests : AbstractPageTests<
        CommonPage<IEventsRepository, Event, EventView, EventData>,
        CrudPage<IEventsRepository, Event, EventView, EventData>>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass(new TestRepository());
        }

        [TestMethod] public void ItemIdTest()=> Assert.Inconclusive();
        [TestMethod] public void PageTitleTest() => IsNullableProperty(() => obj.PageTitle, x => obj.PageTitle = x);
        [TestMethod] public void PageSubTitleTest() => IsReadOnlyProperty(obj, nameof(obj.PageSubTitle), obj.GetPageSubTitle());
        [TestMethod] public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());
        [TestMethod] public void GetPageUrlTest() => Assert.AreEqual(obj.PageUrl, obj.GetPageUrl());
        [TestMethod] public void PageUrlTest() => IsReadOnlyProperty(obj, nameof(obj.PageUrl), obj.GetPageUrl());
    }
}

