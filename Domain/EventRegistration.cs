using System.Collections.Generic;
using SportEvents.Data;
using SportEvents.Domain.Common;

namespace SportEvents.Domain
{
    public sealed class EventRegistration : ValueObject<EventRegistrationData>
    {
        public EventRegistration(EventRegistrationData d) : base(d) { }

        public string EventId => Data?.EventId ?? Unspecified;
        public string ParticipantId => Data?.ParticipantId ?? Unspecified;

        public ICollection<Event> Events { get; set; } = new List<Event>();
        public ICollection<Participant> Participants { get; set; } = new List<Participant>();

    }
}
