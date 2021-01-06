using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportEvents.Domain.Interfaces
{
    public interface ICrudMethods<T>
    {
        Task<List<T>> Get();
        Task<T> Get(string id);
        Task Delete(string id);
        Task Add(T obj);
        Task Update(T obj);
    }
}
