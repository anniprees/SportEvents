using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Infra.Common;

namespace SportEvents.Infra.Repositories
{
    public sealed class EventRegistrationsRepository : UniqueEntitiesRepository<EventRegistration, EventRegistrationData>, IEventRegistrationsRepository
    {
        public EventRegistrationsRepository(EventsDbContext c) : base(c, c.Registrations) { }

        protected internal override EventRegistration toDomainObject(EventRegistrationData d)
            => new EventRegistration(d);

    }
}
