using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Facade.Common;

namespace Tests.Facade.Common
{
    [TestClass]
    public class NamedEntityViewTests : AbstractClassTests<NamedEntityView, UniqueEntityView>
    {
        private class TestClass : NamedEntityView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }
        [TestMethod]
        public void NameTest()
        {
            IsNullableProperty(() => obj.Name, x => obj.Name = x);
        }
    }
}
