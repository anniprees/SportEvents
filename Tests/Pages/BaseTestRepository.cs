using SportEvents.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using SportEvents.Domain.Common;

namespace Tests.Pages
{
    internal class BaseTestRepository<TObj, TData>
        where TObj : UniqueEntity<TData>
        where TData : UniqueEntityData, new()
    {
       internal readonly List<TObj> List;

        public BaseTestRepository()
        {
            List = new List<TObj>();
        }

        public async Task<List<TObj>> Get()
        {
            await Task.CompletedTask;
            return List;
        }

        public async Task<TObj> Get(string id)
        {
            await Task.CompletedTask;
            return List.Find(x => x.Data.Id == id);
        }

        public async Task Delete(string id)
        {
            await Task.CompletedTask;
            var obj = List.Find(x => x.Data.Id == id);
            List.Remove(obj);
        }

        public async Task Add(TObj obj)
        {
            await Task.CompletedTask;
            List.Add(obj);
        }

        public async Task Update(TObj obj)
        {
            await Delete(obj.Data.Id);
            List.Add(obj);
        }
    }
}
