using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Common;

namespace Tests.Domain
{
    [TestClass]
    public class EventRegistrationTests: SealedClassTests<EventRegistration, UniqueEntity<EventRegistrationData>>
    {
        protected override EventRegistration CreateObject() => new EventRegistration(GetRandom.Object<EventRegistrationData>());
        [TestMethod] public void EventIdTest() => IsReadOnlyProperty(obj.Data.EventId);
        [TestMethod] public void ParticipantIdTest() => IsReadOnlyProperty(obj.Data.ParticipantId);

        [TestMethod]
        public void EventTest() => IsReadOnlyProperty(obj, nameof(obj.EventId), obj.Data.EventId);
        [TestMethod]
        public void ParticipantTest() => IsReadOnlyProperty(obj, nameof(obj.ParticipantId), obj.Data.ParticipantId);
    }
}
