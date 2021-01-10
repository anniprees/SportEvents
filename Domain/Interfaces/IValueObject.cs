namespace SportEvents.Domain.Interfaces
{
    public interface IValueObject
    {
        bool IsUnspecified { get; }
    }

    public interface IValueObject<out TData> : IValueObject
    {
        TData Data { get; }
    }
}