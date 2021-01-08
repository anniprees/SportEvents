using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Facade.Common;
using SportEvents.Facade.Views;

namespace Tests.Facade.ViewTests
{
    [TestClass]
    public class ParticipantViewTests : SealedClassTests<ParticipantView, NamedEntityView>
    {
        [TestMethod]
        public void EmailTest() => IsNullableProperty<string>("Email");

        [TestMethod]
        public void PhoneNumberTest() => IsNullableProperty<string>("Phone Number");
    }
}