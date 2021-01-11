using System.Collections.Generic;
using AidMethods;
using SportEvents.Data;
using SportEvents.Domain.Common;
using SportEvents.Domain.Interfaces;

namespace SportEvents.Domain
{
    public sealed class Participant : NamedEntity<ParticipantData>
    {
        public Participant(ParticipantData d) : base(d) { }

        public string Email => Data?.Email ?? Unspecified;
        public string PhoneNumber => Data?.PhoneNumber ?? Unspecified;

        private readonly string eventRegistrationId = 
            GetMember.Name<EventRegistrationData>(x => x.ParticipantId);

        public IReadOnlyList<EventRegistration> Registrations => 
            new GetFrom<IEventRegistrationsRepository, EventRegistration>()
                .ListBy(eventRegistrationId, Id);

    }
}
