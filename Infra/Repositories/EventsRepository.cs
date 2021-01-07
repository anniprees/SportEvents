using Abc.Infra;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Infra.Common;

namespace SportEvents.Infra.Repositories
{
    public sealed class EventsRepository : UniqueEntitiesRepository<Event, EventData>, IEventsRepository
    {
        public EventsRepository(EventsDbContext c) : base(c, c.Events) { }
        protected internal override Event toDomainObject(EventData d)
            => new Event(d);
    }
}