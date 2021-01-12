using System;
using System.ComponentModel;
using AidMethods;
using SportEvents.Facade.Common;

namespace SportEvents.Facade.Views
{
    public sealed class EventRegistrationView : UniqueEntityView
    {
        [DisplayName("Event")] public string EventId { get; set; }
        [DisplayName("Participant")] public string ParticipantId { get; set; }
        public DateTime? EventDate { get; set; }
        public int MaxParticipants { get; set; }
        public int Registrations { get; set; }

        public bool isFull
        {
            get
            {
                if (Registrations >= MaxParticipants) return true;
                return false;
            }
        }

    }
}
