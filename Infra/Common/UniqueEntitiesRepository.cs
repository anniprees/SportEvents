using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportEvents.Data.Common;
using SportEvents.Domain.Common;
using SportEvents.Domain.Interfaces;

namespace SportEvents.Infra.Common
{
    public abstract class UniqueEntitiesRepository<TDomain, TData> : BaseRepository<TDomain, TData>
        where TDomain : IUniqueEntity<TData>
        where TData : UniqueEntityData, new()
    {
        protected UniqueEntitiesRepository(DbContext c, DbSet<TData> s) : base(c, s)
        {
        }
        protected override async Task<TData> getData(string id)
        => await dbSet.FirstOrDefaultAsync(m => m.Id == id);
        protected override TData getDataById(TData d) => dbSet.Find(d.Id);
    }
}
