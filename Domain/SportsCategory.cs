using SportEvents.Data;
using SportEvents.Domain.Common;

namespace SportEvents.Domain
{
    public sealed class SportsCategory : NamedEntity<SportsCategoryData>
    {
        public SportsCategory(SportsCategoryData d) : base(d) { }

    }
}
