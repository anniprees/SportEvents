using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Infra;
using SportEvents.Infra.Common;
using SportEvents.Infra.Repositories;

namespace Tests.Infra
{
    [TestClass]
    public class
        SportsCategoriesRepositoryTests : EventsDbContextTests<SportsCategoriesRepository, SportsCategory,
            SportsCategoryData>
    {

        protected override Type GetBaseClass() => typeof(UniqueEntitiesRepository<Event, EventData>);

        protected override SportsCategoriesRepository GetObject(EventsDbContext c) => new SportsCategoriesRepository(c);

        protected override DbSet<SportsCategoryData> GetSet(EventsDbContext c) => c.SportsCategories;
    }
}


