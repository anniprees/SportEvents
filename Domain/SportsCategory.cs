using SportEvents.Data;
using SportEvents.Domain.Common;

namespace SportEvents.Domain
{
    public sealed class SportsCategory : NamedEntity<SportsCategoryData>
    {
        public SportsCategory(SportsCategoryData d) : base(d) { }

        public string Location => Data?.Location ?? Unspecified;

        public int MaxParticipants => Data?.MaxParticipants ?? UnspecifiedInteger;

    }
}
