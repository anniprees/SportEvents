using System.ComponentModel;
using AidMethods;
using SportEvents.Facade.Common;

namespace SportEvents.Facade.Views
{
    public sealed class EventRegistrationView : UniqueEntityView
    {
        [DisplayName("Event")] public string EventId { get; set; }
        [DisplayName("Participant")] public string ParticipantId { get; set; }
        public string Registrations { get; set; }
        public bool isWithAvailablePlaces { get; set; }
        public int MaxParticipants { get; set; }

    }
}
