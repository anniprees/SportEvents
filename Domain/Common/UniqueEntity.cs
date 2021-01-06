using SportEvents.Data.Common;
using SportEvents.Domain.Interfaces;

namespace SportEvents.Domain.Common
{
    public abstract class UniqueEntity<T> : ValueObject<T>, IUniqueEntity where T : UniqueEntityData, new()
    {
        protected internal UniqueEntity(T d = null) : base(d) { }

        public virtual string Id => Data?.Id ?? Unspecified;
    }
}
