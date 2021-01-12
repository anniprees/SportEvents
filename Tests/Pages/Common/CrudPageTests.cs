using System.Threading.Tasks;
using AidMethods;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
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
        public void AddObjectTest()=> Assert.Inconclusive();


        [TestMethod]
        public void GetObjectTest() => Assert.Inconclusive();
        

        [TestMethod]
        public void UpdateObjectTest() => Assert.Inconclusive();
        

        [TestMethod]
        public void DeleteObjectTest() => Assert.Inconclusive();
        

        [TestMethod]
        public void ToObjectTest() => Assert.Inconclusive();
       

        [TestMethod]
        public void ToViewTest() => Assert.Inconclusive();

    }
}
