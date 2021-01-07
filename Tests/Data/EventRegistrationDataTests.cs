using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Data.Common;

namespace Tests.Data
{
    [TestClass]
    public class EventRegistrationDataTests: SealedClassTests<EventRegistrationData, UniqueEntityData>
    {
        [TestMethod]
        public void EventIdTest() => IsNullableProperty(() => obj.EventId, x => obj.EventId = x);
        [TestMethod]
        public void ParticipantIdTest() => IsNullableProperty(() => obj.ParticipantId, x => obj.ParticipantId = x);
    }
}


