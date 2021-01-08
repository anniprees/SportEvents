using System;
using System.Collections.Generic;
using System.Text;
using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain.Common;

namespace Tests.Domain.Common
{
    [TestClass]
    public class NamedEntityTests : AbstractClassTests<NamedEntity<EventData>, UniqueEntity<EventData>>
    {
        private class TestClass : NamedEntity<EventData>
        {
            public TestClass(EventData d = null) : base(d) { }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual(Word.Unspecified, obj.Name);
            obj = new TestClass(GetRandom.Object<EventData>());
            IsReadOnlyProperty(obj, GetMember.Name<TestClass>(x => x.Name), obj.Data.Name);
        }
    }
}
