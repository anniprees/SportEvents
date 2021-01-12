using System;
using System.Collections.Generic;
using System.Text;
using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Common;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.ViewFactories;
using SportEvents.Facade.Views;

namespace Tests.Facade.ViewFactoryTests
{
    [TestClass]
    public class EventViewFactoryTests : BaseTests
    {
        [TestInitialize] public void TestInitialize() => type = typeof(EventViewFactory);
        [TestMethod] public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest() => Assert.Inconclusive();
        //{
        //    var view = GetRandom.Object<EventView>();
        //    var data = EventViewFactory.Create(view).Data;
        //    TestArePropertiesEqual(view, data);
        //}

        [TestMethod]
        public void CreateViewTest() => Assert.Inconclusive();
        //{
        //    var data = GetRandom.Object<EventData>();
        //    var dom = new Event(data);
        //    var p = GetRandom.Int32(1,20);
        //    var view = EventViewFactory.Create(dom);
        //    TestArePropertiesEqual(view, data);
        //}
    }
}
