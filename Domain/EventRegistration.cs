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

    }
}
