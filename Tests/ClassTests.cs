using System;
using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public abstract class ClassTests<TClass, TBaseClass> : BaseClassTests<TClass, TBaseClass>
        where TClass : class
    {
        
        [TestInitialize]
        public override void TestInitialize()
        {
            obj = CreateObject();
            type = obj.GetType();
        }
        protected virtual TClass CreateObject() => GetRandom.Object<TClass>();

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(obj);
        }
    }
}
