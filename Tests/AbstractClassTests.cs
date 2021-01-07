using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public abstract class AbstractClassTests<TClass, TBaseClass> : BaseClassTests<TClass, TBaseClass>
        {
            [TestMethod]
            public void IsAbstract()
            {
                Assert.IsTrue(type.IsAbstract);
            }
            protected void IsAbstractMethod(string name)
            {
                var i = type.GetMethod(name);
                Assert.IsNotNull(i);
                Assert.IsTrue(i.IsAbstract);
            }
        }
}

