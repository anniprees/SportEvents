﻿using System;
using System.Collections.Generic;
using System.Text;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Infra.Common;

namespace SportEvents.Infra.Repositories
{
    public sealed class ParticipantsRepository : UniqueEntitiesRepository<Participant, ParticipantData>
    {
        public ParticipantsRepository(EventsDbContext c) : base(c, c.Participants) { }
        protected internal override Participant toDomainObject(ParticipantData d)
            => new Participant(d);
    }
}
