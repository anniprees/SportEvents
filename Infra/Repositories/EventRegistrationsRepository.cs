using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Infra.Common;

namespace SportEvents.Infra.Repositories
{
    public sealed class EventRegistrationsRepository : UniqueEntitiesRepository<EventRegistration, EventRegistrationData>
    {
        public EventRegistrationsRepository(EventsDbContext c) : base(c, c.Registrations) { }

        protected internal override EventRegistration toDomainObject(EventRegistrationData d)
            => new EventRegistration(d);
    }
}
