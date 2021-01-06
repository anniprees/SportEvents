using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportEvents.Facade.Common;

namespace SportEvents.Facade.Views
{
    public sealed class EventView : NamedEntityView
    {
        [Required] [DisplayName("Date")] public DateTime EventDate { get; set; }
        [DisplayName("Time")] public DateTime EventTime { get; set; }
        [DisplayName("Spots available")] public string SportsCategory { get; set; }

    }
}
