using System.ComponentModel;
using AidMethods;

namespace SportEvents.Facade.Views
{
    public sealed class EventRegistrationView
    {
        [DisplayName("Event")] public string EventId { get; set; }
        public string ParticipantId { get; set; }
    }
}
