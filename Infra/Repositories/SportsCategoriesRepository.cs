using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Infra.Common;

namespace SportEvents.Infra.Repositories
{
    public sealed class SportsCategoriesRepository : UniqueEntitiesRepository<SportsCategory, SportsCategoryData>, ISportsCategoriesRepository
    {
        public SportsCategoriesRepository(EventsDbContext c) : base(c, c.SportsCategories) { }
        
        protected internal override SportsCategory toDomainObject(SportsCategoryData d)
            => new SportsCategory(d);
    }
}
