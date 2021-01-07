using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportEvents.Data.Common;
using SportEvents.Domain.Common;
using SportEvents.Domain.Interfaces;

namespace SportEvents.Pages.Common {

    public abstract class CommonPage<TRepository, TDomain, TView, TData> :
        CrudPage<TRepository, TDomain, TView, TData>
        where TRepository : ICrudMethods<TDomain> {

        protected internal CommonPage(TRepository r) : base(r) { }

        public abstract string ItemId { get; }

        public string PageTitle { get; set; }

        public string PageSubTitle => GetPageSubTitle();

        protected internal virtual string GetPageSubTitle() => string.Empty;

        public string PageUrl => GetPageUrl();

        protected internal abstract string GetPageUrl();

        protected static IEnumerable<SelectListItem> CreateSelectList<TDomain, TData>(IRepository<TDomain> r)
            where TDomain : UniqueEntity<TData>
            where TData : NamedEntityData, new() {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.Name, m.Data.Id)).ToList();
        }


    }

}
