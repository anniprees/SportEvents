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
    public class ParticipantRepositoryTests : EventsDbContextTests<ParticipantsRepository, Participant, ParticipantData>
    {

        protected override Type GetBaseClass() => typeof(UniqueEntitiesRepository<Event, EventData>);

        protected override ParticipantsRepository GetObject(EventsDbContext c) => new ParticipantsRepository(c);

        protected override DbSet<ParticipantData> GetSet(EventsDbContext c) => c.Participants;
    }
}
