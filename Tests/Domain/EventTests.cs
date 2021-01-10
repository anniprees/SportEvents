using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Common;

namespace Tests.Domain
{
    [TestClass]
    public class EventTests : SealedClassTests<Event, NamedEntity<EventData>>
    {
        protected override Event CreateObject() => new Event(GetRandom.Object<EventData>());

       
        [TestMethod] public void EventDateTest() => IsReadOnlyProperty(obj.Data.EventDate);

        [TestMethod] public void EventTimeTest() => IsReadOnlyProperty(obj.Data.EventTime);

        [TestMethod] public void LocationTest() => IsReadOnlyProperty(obj.Data.Location);

        [TestMethod] public void MaxParticipantsTest() => IsReadOnlyProperty(obj.Data.MaxParticipants);

        [TestMethod] public void SportsCategoryIdTest() => IsReadOnlyProperty(obj.Data.SportsCategoryId);

        [TestMethod]
        public void SportsCategoryTest() => IsReadOnlyProperty(obj, nameof(obj.SportsCategoryId), obj.Data.SportsCategoryId);

    }
}
   