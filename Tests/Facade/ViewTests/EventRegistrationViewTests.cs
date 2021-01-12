using System;
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

        [TestMethod]
        public void EventDateTest() => IsNullableProperty<DateTime?>("When");

        [TestMethod]
        public void MaxParticipantsTest() => IsProperty<int>("Number of spots");

        [TestMethod]
        public void RegistrationsTest() => IsProperty<int>("Registrations");

        [TestMethod]
        public void IsFullTest() => Assert.Inconclusive();

    }

}