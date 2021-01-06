using System;
using System.Collections.Generic;
using System.Text;
using SportEvents.Data.Common;

namespace SportEvents.Data
{
    public sealed class SportsCategoryData : NamedEntityData
    {
        public string Location { get; set; }

        public int MaxParticipants { get; set; }
    }
}
