using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Facade.Views;

namespace Tests.AidMethods
{
    [TestClass]
    public class CopyTests : BaseTests
    {

        [TestInitialize]
        public void TestInitialize()
        {
            type = typeof(Copy);
        }

        [TestMethod]
        public void MembersTest()
        {
            var x = GetRandom.Object<EventData>();
            var y = GetRandom.Object<EventView>();
            TestArePropertyValuesNotEqual(x, y);
            Copy.Members(x, y);
            TestArePropertyValuesEqual(x, y);
        }
    }
}
