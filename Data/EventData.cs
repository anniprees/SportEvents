using System;
using System.Collections.Generic;
using System.Text;
using SportEvents.Data.Common;

namespace SportEvents.Data
{
    public sealed class EventData : NamedEntityData
    {
        public DateTime? EventDate { get; set; }

        public DateTime? EventTime { get; set; }

        public string SportsCategoryId { get; set; }

        public string Location { get; set; }

        public int MaxParticipants { get; set; }
    }
}
