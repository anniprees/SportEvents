using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain.Common;

namespace Tests.Domain.Common
{
    [TestClass]
    public class UniqueEntityTests : AbstractClassTests<UniqueEntity<EventData>, ValueObject<EventData>>
    {
        private class TestClass : UniqueEntity<EventData>
        {
            public TestClass(EventData d = null) : base(d) { }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass(GetRandom.Object<EventData>());
        }

        [TestMethod]
        public void IdTest() => IsReadOnlyProperty(obj.Id);
    }
}
