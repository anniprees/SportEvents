using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data.Common;
using SportEvents.Domain.Common;
using SportEvents.Infra;
using SportEvents.Infra.Common;

namespace Tests.Infra
{
    [TestClass]
    public abstract class
        EventsDbContextTests<TRepository, TDomain, TData> : SealedClassTests<TRepository, UniqueEntitiesRepository<TDomain, TData>>
        where TRepository : UniqueEntitiesRepository<TDomain, TData>
        where TData : UniqueEntityData, new()
        where TDomain : UniqueEntity<TData>
    {

        protected EventsDbContext db;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<EventsDbContext>().Options;
            db = new EventsDbContext(options);
        }

        protected abstract TRepository GetObject(EventsDbContext db);

        protected abstract DbSet<TData> GetSet(EventsDbContext db);
    }
}
