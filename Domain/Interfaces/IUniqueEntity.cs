namespace SportEvents.Domain.Interfaces
{
    public interface IUniqueEntity
    {
        string Id { get; }
    }
    public interface IUniqueEntity<out TData> : IUniqueEntity
    {
        TData Data { get; }
    }
}