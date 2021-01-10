using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Data.Common;

namespace Tests.Data
{
    [TestClass]
    public class EventDataTests : SealedClassTests<EventData, NamedEntityData>
    {
        [TestMethod]
        public void EventDateTest() => IsNullableProperty(() => obj.EventDate, x => obj.EventDate = x);
        [TestMethod]
        public void EventTimeTest() => IsNullableProperty(() => obj.EventTime, x => obj.EventTime = x);
        [TestMethod]
        public void SportsCategoryIdTest() => IsNullableProperty(() => obj.SportsCategoryId, x => obj.SportsCategoryId = x);
        [TestMethod]
        public void LocationTest() => IsNullableProperty(() => obj.Location, x => obj.Location = x);
        [TestMethod]
        public void MaxParticipantsTest() => IsProperty(() => obj.MaxParticipants, x => obj.MaxParticipants = x);
    }
}



