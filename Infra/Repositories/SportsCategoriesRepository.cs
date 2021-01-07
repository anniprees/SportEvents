using System;
using System.Collections.Generic;
using System.Text;
using Abc.Infra;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Infra.Common;

namespace SportEvents.Infra.Repositories
{
    public sealed class SportsCategoriesRepository : UniqueEntitiesRepository<SportsCategory, SportsCategoryData>
    {
        public SportsCategoriesRepository(EventsDbContext c) : base(c, c.SportsCategories) { }
        
        protected internal override SportsCategory toDomainObject(SportsCategoryData d)
            => new SportsCategory(d);
    }
}
