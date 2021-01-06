using System.ComponentModel;

namespace SportEvents.Facade.Views
{
    public sealed class EventRegistrationView
    {
        [DisplayName("Event Name")] public string EventId { get; set; }
        public string ParticipantId { get; set; }
    }
}
