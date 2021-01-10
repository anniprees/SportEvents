using System;
using System.Collections.Generic;
using System.Text;
using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
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
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<EventView>();
            var data = EventViewFactory.Create(view).Data;
            TestArePropertiesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<EventData>();
            var view = EventViewFactory.Create(new Event(data));
            TestArePropertiesEqual(view, data);
        }
    }
}
