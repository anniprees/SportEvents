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
    public class ParticipantViewFactoryTests : BaseTests
    {
        [TestInitialize] public void TestInitialize() => type = typeof(ParticipantViewFactory);
        [TestMethod] public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<ParticipantView>();
            var data = ParticipantViewFactory.Create(view).Data;
            TestArePropertiesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<ParticipantData>();
            var view = ParticipantViewFactory.Create(new Participant(data));
            TestArePropertiesEqual(view, data);
        }
    }
}
