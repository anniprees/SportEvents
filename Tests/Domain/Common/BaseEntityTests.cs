using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Domain.Common;

namespace Tests.Domain.Common
{
    [TestClass]
    public class BaseEntityTests : AbstractClassTests<BaseEntity, object>
    {
        private class TestClass : BaseEntity { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod]
        public void UnspecifiedTest() => Assert.AreEqual(BaseEntity.Unspecified, Word.Unspecified);
        [TestMethod]
        public void UnspecifiedDateTest() => Assert.AreEqual(BaseEntity.UnspecifiedDate, DateTime.MinValue);
        [TestMethod]
        public void UnspecifiedDoubleTest() => Assert.AreEqual(BaseEntity.UnspecifiedDouble, double.NaN);
        [TestMethod]
        public void UnspecifiedDecimalTest() => Assert.AreEqual(BaseEntity.UnspecifiedDecimal, Decimal.MaxValue);
        [TestMethod]
        public void UnspecifiedIntegerTest() => Assert.AreEqual(BaseEntity.UnspecifiedInteger, 0);
    }
}
