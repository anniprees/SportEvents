using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Facade.Common;
using SportEvents.Facade.Views;

namespace Tests.Facade.ViewTests
{
    [TestClass]
    public class EventRegistrationViewTests : SealedClassTests<EventRegistrationView, UniqueEntityView>
    {
        [TestMethod]
        public void EventIdTest() => IsNullableProperty<string>("Event");

        [TestMethod]
        public void ParticipantIdTest() => IsNullableProperty<string>("Participant");
        
    }

}