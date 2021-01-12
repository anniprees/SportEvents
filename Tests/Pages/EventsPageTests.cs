using System.Linq;
using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Pages;
using SportEvents.Pages.Common;

namespace Tests.Pages
{[TestClass]
    public class EventsPageTests : BaseClassTests<EventsPage, CommonPage<IEventsRepository, Event, EventView, EventData>>
    {
        private class TestClass : EventsPage
        {
            internal TestClass(IEventsRepository e, ISportsCategoriesRepository s) : base(e,s) { }
        }

        private class EventsRepository : BaseTestRepository<Event, EventData>, IEventsRepository { }
        private class SportsCategoriesRepository : BaseTestRepository<SportsCategory, SportsCategoryData>, ISportsCategoriesRepository { }

        private EventsRepository _events;
        private SportsCategoriesRepository _categories;
        private SportsCategoryData _categoryData;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            _events = new EventsRepository();
            _categories = new SportsCategoriesRepository();
            _categoryData = GetRandom.Object<SportsCategoryData>();
            var a = new SportsCategory(_categoryData);
            _categories.Add(a).GetAwaiter();
            AddRandomCategories();
            obj = new TestClass(_events, _categories);
        }

        private void AddRandomCategories()
        {
            for (var i = 0; i < GetRandom.UInt8(3, 10); i++)
            {
                var d = GetRandom.Object<SportsCategoryData>();
                var m = new SportsCategory(d);
                _categories.Add(m).GetAwaiter();
            }
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<EventView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Sport events", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/Sport/Events", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest() => Assert.Inconclusive();
        //{
        //    var view = GetRandom.Object<EventView>();
        //    var o = obj.ToObject(view);
        //    TestArePropertyValuesEqual(view, o.Data);
        //}

        [TestMethod]
        public void ToViewTest() => Assert.Inconclusive();
        //{
        //    var data = GetRandom.Object<EventData>();
        //    var view = obj.ToView(new Event(data));
        //    TestArePropertyValuesEqual(view, data);
        //}

        [TestMethod]
        public void CategoriesTest()
        {
            var list = _categories.Get().GetAwaiter().GetResult();
            Assert.AreEqual(list.Count, obj.Categories.Count());
        }

        [TestMethod]
        public void GetCategoryNameTest()
        {
            var name = obj.GetCategoryName(_categoryData.Id);
            Assert.AreEqual(_categoryData.Name, name);
        }

    }
}

