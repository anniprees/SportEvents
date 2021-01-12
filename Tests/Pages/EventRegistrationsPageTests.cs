using System.Linq;
using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Pages;
using SportEvents.Pages.Common;
using Tests.Pages.Common;

namespace Tests.Pages
{
    [TestClass]
    public class EventRegistrationsPageTests : AbstractPageTests<EventRegistrationsPage, 
        CommonPage<IEventRegistrationsRepository, EventRegistration, EventRegistrationView, EventRegistrationData>>
    {
        private class TestClass : EventRegistrationsPage
        {
            internal TestClass(IEventRegistrationsRepository r, IEventsRepository p, IParticipantsRepository e)  : base(r, p, e) { }
        }

        private class EventRegistrationsRepository : BaseTestRepository<EventRegistration, EventRegistrationData>, 
            IEventRegistrationsRepository { }
        private class EventsRepository : BaseTestRepository<Event, EventData>, IEventsRepository { }
        private class ParticipantsRepository : BaseTestRepository<Participant, ParticipantData>, IParticipantsRepository { }

        private EventRegistrationsRepository _registrations;
        private ParticipantsRepository _participants;
        private EventsRepository _events;
        private EventsRepository _openEvents;
        private EventData _eventData;
        private ParticipantData _participantData;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            _registrations = new EventRegistrationsRepository();
            _events = new EventsRepository();
            _participants = new ParticipantsRepository();
            _eventData = GetRandom.Object<EventData>();
            var a = new Event(_eventData);
            _events.Add(a).GetAwaiter();
            AddRandomEvents();

            _participantData = GetRandom.Object<ParticipantData>();
            var b = new Participant(_participantData);
            _participants.Add(b).GetAwaiter();
            AddRandomParticipants();
            obj = new TestClass(_registrations, _events, _participants);

            _openEvents = new EventsRepository();
        }

        private void AddRandomEvents()
        {
            for (var i = 0; i < GetRandom.UInt8(3, 10); i++)
            {
                var d = GetRandom.Object<EventData>();
                var m = new Event(d);
                _events.Add(m).GetAwaiter();
            }
        }

        private void AddRandomParticipants()
        {
            for (var i = 0; i < GetRandom.UInt8(3, 10); i++)
            {
                var d = GetRandom.Object<ParticipantData>();
                var m = new Participant(d);
                _participants.Add(m).GetAwaiter();
            }
        }

        [TestMethod]
        public void ItemIdTest()=> Assert.Inconclusive();
        
        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Registrations", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/Sport/Registrations", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<EventRegistrationView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<EventRegistrationData>();
            var view = obj.ToView(new EventRegistration(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void GetEventNameTest()
        {
            var name = obj.GetEventName(_eventData.Id);
            Assert.AreEqual(_eventData.Name, name);
        }

        [TestMethod]
        public void GetParticipantNameTest()
        {
            var name = obj.GetParticipantName(_participantData.Id);
            Assert.AreEqual(_participantData.Name, name);
        }

        [TestMethod]
        public void EventsTest()
        {
            var list = _events.Get().GetAwaiter().GetResult();
            Assert.AreEqual(list.Count, obj.Events.Count());
        }

        [TestMethod]
        public void ParticipantsTest()
        {
            var list = _participants.Get().GetAwaiter().GetResult();
            Assert.AreEqual(list.Count, obj.Participants.Count());
        }

    }
}

