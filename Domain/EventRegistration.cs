using System.Collections.Generic;
using System.Data;
using System.Linq;
using AidMethods;
using SportEvents.Data;
using SportEvents.Domain.Common;

namespace SportEvents.Domain
{
    public sealed class EventRegistration : UniqueEntity<EventRegistrationData>
    {
        public EventRegistration(EventRegistrationData d) : base(d) { }

        public string EventId => Data?.EventId ?? Unspecified;
        public string ParticipantId => Data?.ParticipantId ?? Unspecified;
        public Event Event { get; set; }
        public Participant Participant { get; set; }

        //public int Registrations
        //{
        //    get
        //    {
        //        var e = Events.Select(x => x.Id == EventId);
        //        return e.Count();
        //    }
        //}

        //public bool isWithAvailablePlaces
        //{
        //    get
        //    {
        //        var openPlaces = Events.Where(x => x.Id == EventId).Select(x=> x.MaxParticipants).FirstOrDefault();
        //        return openPlaces > Registrations;
        //    }
        //}

    }
}
