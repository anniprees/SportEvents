using System;
using System.Collections.Generic;
using System.Linq;
using AidMethods;
using SportEvents.Data;
using SportEvents.Domain.Common;
using SportEvents.Domain.Interfaces;

namespace SportEvents.Domain
{
    public sealed class Event : NamedEntity<EventData>
    {
        public Event (EventData d ) : base(d){}

        public DateTime EventDate => Data?.EventDate ?? UnspecifiedDate;
        public DateTime EventTime => Data?.EventTime ?? UnspecifiedDate;
        public string SportsCategoryId => Data?.SportsCategoryId ?? Unspecified;
        public string Location => Data?.Location ?? Unspecified;
        public int MaxParticipants => Data?.MaxParticipants ?? UnspecifiedInteger;
        public SportsCategory SportsCategory { get; set; }

        private readonly string eventRegistrationId = 
            GetMember.Name<EventRegistrationData>(x => x.EventId);

        public IReadOnlyList<EventRegistration> Registrations => 
            new GetFrom<IEventRegistrationsRepository, EventRegistration>()
                .ListBy(eventRegistrationId, Id);

        public int RegisteredParticipants
        {
            get
            {
                var i = Registrations.Where(x=> x.EventId == Id).Select(x=>x.Id).Count();
                return i;
            }
        }
    }
}
