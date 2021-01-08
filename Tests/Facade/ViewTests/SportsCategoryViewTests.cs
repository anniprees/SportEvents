using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Facade.Common;
using SportEvents.Facade.Views;

namespace Tests.Facade.ViewTests
{
    [TestClass]
    public class SportsCategoryViewTests : SealedClassTests<SportsCategoryView, NamedEntityView>
    {
        [TestMethod]
        public void LocationTest() => IsNullableProperty<string>("Location");

        [TestMethod]
        public void MaxParticipantsTest() => IsProperty<int>("Number of spots");
    }
}
