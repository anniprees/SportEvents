using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Facade.ViewFactories;
using SportEvents.Facade.Views;

namespace Tests.Facade.ViewFactoryTests
{[TestClass]
    public class SportsCategoryViewFactoryTests : BaseTests
    {
        [TestInitialize] public void TestInitialize() => type = typeof(SportsCategoryViewFactory);
        [TestMethod] public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<SportsCategoryView>();
            var data = SportsCategoryViewFactory.Create(view).Data;
            TestArePropertiesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<SportsCategoryData>();
            var view = SportsCategoryViewFactory.Create(new SportsCategory(data));
            TestArePropertiesEqual(view, data);
        }
    }
}
