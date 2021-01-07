using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Common;


namespace SportEvents.Pages.Common
{
    public abstract class CrudPage<TRepository, TDomain, TView, TData> 
        : PageModel
        where TRepository : ICrudMethods<TDomain>
    {
        protected TRepository db { get; }

        protected internal CrudPage(TRepository r) => db = r;

        [BindProperty]
        public TView Item { get; set; }

        public IList<TView> Items { get; private set; }

        protected internal async Task<bool> AddObject()
        {
            if (!ModelState.IsValid) return false;
            await db.Add(ToObject(Item)).ConfigureAwait(true);
            return true;
        }

        protected internal async Task<bool> UpdateObject()
        {
            if (!ModelState.IsValid) return false;
            await db.Update(ToObject(Item)).ConfigureAwait(true);

            return true;
        }

        protected internal async Task GetObject(string id)
        {
            var o = await db.Get(id).ConfigureAwait(true);
            Item = ToView(o);
        }

        //protected internal async Task GetList()
        //{
        //    Items = await GetList();
        //}

        protected internal async Task<List<TView>> GetList()
        {
            var l = await db.Get();

            return l.Select(ToView).ToList();
        }

        protected internal async Task DeleteObject(string id)
        {
            await db.Delete(id).ConfigureAwait(true);
        }

        protected internal abstract TDomain ToObject(TView v);

        protected internal abstract TView ToView(TDomain o);

    }
}
