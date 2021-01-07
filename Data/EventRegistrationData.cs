using SportEvents.Data.Common;

namespace SportEvents.Data
{
    public sealed class EventRegistrationData : UniqueEntityData
    {
        public string EventId { get; set; }

        public string ParticipantId { get; set; }
    }
}
