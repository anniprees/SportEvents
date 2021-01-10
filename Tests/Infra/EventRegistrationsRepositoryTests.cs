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
    public class EventRegistrationsRepositoryTests : EventsDbContextTests<EventRegistrationsRepository, EventRegistration, EventRegistrationData>
    {

        protected override Type GetBaseClass() => typeof(UniqueEntitiesRepository<Event, EventData>);

        protected override EventRegistrationsRepository GetObject(EventsDbContext c) => new EventRegistrationsRepository(c);

        protected override DbSet<EventRegistrationData> GetSet(EventsDbContext c) => c.Registrations;
    }
}
