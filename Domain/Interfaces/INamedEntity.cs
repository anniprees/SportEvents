using SportEvents.Domain.Common;

namespace SportEvents.Domain.Interfaces
{
    public interface INamedEntity : IUniqueEntity
    {
        string Name { get; }
    }

    public interface INamedEntity<out TData> : INamedEntity, IUniqueEntity<TData> { }
}