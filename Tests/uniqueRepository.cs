using SportEvents.Data.Common;
using SportEvents.Domain.Common;

namespace Tests
{

    internal class uniqueRepository<TObj, TData> : periodRepository<TObj, TData>
        where TObj : ValueObject<TData>
        where TData : UniqueEntityData, new()
    {

        protected override string getId(TData d) => d.Id;
    }

}