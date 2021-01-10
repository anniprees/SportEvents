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
    public class EventsRepositoryTests : EventsDbContextTests<EventsRepository, Event, EventData>
    {

        protected override Type GetBaseClass() => typeof(UniqueEntitiesRepository<Event, EventData>);

        protected override EventsRepository GetObject(EventsDbContext c) => new EventsRepository(c);

        protected override DbSet<EventData> GetSet(EventsDbContext c) => c.Events;
    }
}

