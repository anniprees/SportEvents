using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Pages;
using SportEvents.Pages.Common;
using Tests.Pages.Common;

namespace Tests.Pages
{
    [TestClass]
    public class SportsCategoriesPageTests : AbstractPageTests<SportsCategoriesPage, CommonPage<ISportsCategoriesRepository, SportsCategory, SportsCategoryView, SportsCategoryData>>
    {
        private class TestClass : SportsCategoriesPage
        {
            internal TestClass(ISportsCategoriesRepository r) : base(r) { }
        }
        private class SportsCategoriesRepository : BaseTestRepository<SportsCategory, SportsCategoryData>, ISportsCategoriesRepository { }

        private SportsCategoriesRepository _categories;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            _categories = new SportsCategoriesRepository();
            obj = new TestClass(_categories);
        }


        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<SportsCategoryView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Sports categories", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/Sport/Categories", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<SportsCategoryView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<SportsCategoryData>();
            var view = obj.ToView(new SportsCategory(data));
            TestArePropertyValuesEqual(view, data);
        }

    }
}

