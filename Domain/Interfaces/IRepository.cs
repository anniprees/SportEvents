namespace SportEvents.Domain.Interfaces
{
    public interface IRepository<T> : ICrudMethods<T>, IRepository
    {
    }

    public interface IRepository
    {

    }
}
