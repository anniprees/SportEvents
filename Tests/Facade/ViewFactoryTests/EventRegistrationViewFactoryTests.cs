using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Facade.ViewFactories;
using SportEvents.Facade.Views;

namespace Tests.Facade.ViewFactoryTests
{[TestClass]
    public class EventRegistrationViewFactoryTests : BaseTests
    {
        [TestInitialize] public void TestInitialize() => type = typeof(EventRegistrationViewFactory);
        [TestMethod] public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest() => Assert.Inconclusive();
        //{
        //    var view = GetRandom.Object<EventRegistrationView>();
        //    var data = EventRegistrationViewFactory.Create(view).Data;
        //    TestArePropertiesEqual(view, data);
        //}

        [TestMethod]
        public void CreateViewTest() => Assert.Inconclusive();

        //{
        //    var data = GetRandom.Object<EventRegistrationData>();
        //    var dom = new EventRegistration(data);
        //    var view = EventRegistrationViewFactory.Create(new EventRegistration(data));
        //    TestArePropertiesEqual(view, data);
        //}
    }
}

