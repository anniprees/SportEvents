using System.ComponentModel;
using AidMethods;
using SportEvents.Facade.Common;

namespace SportEvents.Facade.Views
{
    public sealed class EventRegistrationView : UniqueEntityView
    {
        [DisplayName("Event")] public string EventId { get; set; }
        public string ParticipantId { get; set; }

        public string GetId() => Compose.Id(EventId, ParticipantId);

    }
}
