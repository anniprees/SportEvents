using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportEvents.Facade.Common;

namespace SportEvents.Facade.Views
{
    public sealed class EventView : NamedEntityView
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date")] 
        public DateTime? EventDate { get; set; }

        [DisplayName("Time")]
        [DataType(DataType.Time)]
        public DateTime? EventTime { get; set; }

        [DisplayName("Sports category")] 
        public string SportsCategoryId { get; set; }

        [DisplayName("Location")]
        public string Location { get; set; }

        [DisplayName("Number of spots")]
        public int MaxParticipants { get; set; }
    }
}
