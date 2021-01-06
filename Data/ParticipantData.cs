using SportEvents.Data.Common;

namespace SportEvents.Data
{
    public sealed class ParticipantData : NamedEntityData
    {
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
