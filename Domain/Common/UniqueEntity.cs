using SportEvents.Data.Common;

namespace SportEvents.Domain.Common
{
    public abstract class UniqueEntity<T> : ValueObject<T> where T : UniqueEntityData, new()
    {
        protected internal UniqueEntity(T d = null) : base(d) { }

        public virtual string Id => Data?.Id ?? Unspecified;
    }
}
