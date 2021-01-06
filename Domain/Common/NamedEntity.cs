﻿using SportEvents.Data.Common;
using SportEvents.Domain.Interfaces;

namespace SportEvents.Domain.Common
{
    public abstract class NamedEntity<T> : UniqueEntity<T>, INamedEntity where T : NamedEntityData, new()
    {
        protected internal NamedEntity(T d = null) : base(d) { }

        public virtual string Name => Data?.Name ?? Unspecified;

    }
}
