using System.Threading.Tasks;
using AidMethods;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.ViewFactories;
using SportEvents.Facade.Views;
using SportEvents.Pages.Common;

namespace Tests.Pages.Common
{
    [TestClass]
    public class CrudPageTests : AbstractPageTests<CrudPage<IEventsRepository, Event, EventView, EventData>, PageModel>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass(db);
        }
        
        [TestMethod]
        public void ItemTest()
        {
            IsProperty(() => obj.Item, x => obj.Item = x);
        }
        [TestMethod]
        public void ItemsTest()
        {
            IsReadOnlyProperty(obj, nameof(obj.Items), null);
        }

        [TestMethod]
        public void AddObjectTest()
        {
            var idx = db.list.Count;
            obj.Item = GetRandom.Object<EventView>();
            obj.AddObject().GetAwaiter();
            TestArePropertiesEqual(obj.Item, db.list[idx].Data);
        }


        [TestMethod]
        public void GetObjectTest()
        {
            var count = GetRandom.UInt8(5, 10);
            var index = GetRandom.UInt8(0, count);
            for (var i = 0; i < count; i++) AddObjectTest();
            var item = db.list[index];
            obj.GetObject(item.Data.Id).GetAwaiter();
            Assert.AreEqual(count, db.list.Count);
            TestArePropertyValuesEqual(item.Data, obj.Item);
        }

        [TestMethod]
        public void UpdateObjectTest()
        {
            GetObjectTest();
            var index = GetRandom.Int32(0, db.list.Count);
            var itemId = db.list[index].Data.Id;
            obj.Item = GetRandom.Object<EventView>();
            obj.Item.Id = itemId;
            obj.UpdateObject().GetAwaiter();
            TestArePropertyValuesEqual(db.list[^1].Data, obj.Item);
        }

        [TestMethod]
        public void DeleteObjectTest()
        {
            AddObjectTest();
            obj.DeleteObject(obj.Item.Id).GetAwaiter();
            Assert.AreEqual(0, db.list.Count);
        }

        [TestMethod]
        public void ToObjectTest()
        {
            var v = GetRandom.Object<EventView>();
            var o = obj.ToObject(v);
            TestArePropertyValuesEqual(v, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<EventData>();
            var v = obj.ToView(new Event(d));
            TestArePropertyValuesEqual(d, v);
        }
    }
}
