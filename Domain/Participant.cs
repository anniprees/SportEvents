using SportEvents.Data;
using SportEvents.Domain.Common;

namespace SportEvents.Domain
{
    public sealed class Participant : NamedEntity<ParticipantData>
    {
        public Participant(ParticipantData d) : base(d) { }

        public string Email => Data?.Email ?? Unspecified;
        public string PhoneNumber => Data?.PhoneNumber ?? Unspecified;
    }
}
