using System;
using SportEvents.Data;
using SportEvents.Domain.Common;

namespace SportEvents.Domain
{
    public sealed class Event : NamedEntity<EventData>
    {
        public Event (EventData d ) : base(d){}

        public DateTime EventDate => Data?.EventDate ?? UnspecifiedDate;
        public DateTime EventTime => Data?.EventDate ?? UnspecifiedDate;
        public string SportsCategoryId => Data?.SportsCategoryId ?? Unspecified;

        public SportsCategory SportsCategory { get; set; }
    }
}
