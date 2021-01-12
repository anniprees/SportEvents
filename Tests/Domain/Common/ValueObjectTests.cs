using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain.Common;

namespace Tests.Domain.Common
{
    [TestClass]
    public class ValueObjectTests : AbstractClassTests<ValueObject<SportsCategoryData>, BaseEntity>
    {

        private class TestClass : ValueObject<SportsCategoryData>
        {

            public TestClass(SportsCategoryData d = null) : base(d) { }

        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass(GetRandom.Object<SportsCategoryData>());
        }

        [TestMethod]
        public void DataTest() => Assert.Inconclusive();

        [TestMethod]
        public void IsUnspecifiedTest()
        {
            Assert.IsTrue(new TestClass().IsUnspecified);
            Assert.IsFalse(new TestClass(GetRandom.Object<SportsCategoryData>()).IsUnspecified);
        }

        [TestMethod]
        public void isUnspecifiedTest() => Assert.Inconclusive();

        [TestMethod]
        public void CanSetDataTest()
        {
            var d = GetRandom.Object<SportsCategoryData>();
            obj = new TestClass(d);
            Assert.AreNotSame(d, obj.Data);
            TestArePropertiesEqual(d, obj.Data);
        }

        [TestMethod]
        public void CanSetNullDataTest()
        {
            obj = new TestClass();
            Assert.IsNotNull(obj.Data);
            Assert.IsTrue(obj.IsUnspecified);
        }

        [TestMethod]
        public void CantChangeDataElementsTest()
        {
            obj = new TestClass(GetRandom.Object<SportsCategoryData>());
            var d = obj.Data;
            obj.Data.Name = GetRandom.String();
            obj.Data.Id = GetRandom.String();
            TestArePropertiesEqual(d, obj.Data);
        }

    }
}
