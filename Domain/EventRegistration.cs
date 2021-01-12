using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using AidMethods;
using SportEvents.Data;
using SportEvents.Domain.Common;
using SportEvents.Domain.Interfaces;

namespace SportEvents.Domain
{
    public sealed class EventRegistration : UniqueEntity<EventRegistrationData>
    {
        public EventRegistration(EventRegistrationData d) : base(d) { }

        public string EventId => Data?.EventId ?? Unspecified;
        public string ParticipantId => Data?.ParticipantId ?? Unspecified;
        public Event Event => new GetFrom<IEventsRepository, Event>().ById(EventId);
        public Participant Participant => new GetFrom<IParticipantsRepository, Participant>().ById(ParticipantId);

    }
}
