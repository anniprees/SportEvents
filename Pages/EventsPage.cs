using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.ViewFactories;
using SportEvents.Facade.Views;
using SportEvents.Pages.Common;

namespace SportEvents.Pages
{
    public class EventsPage : CommonPage<IEventsRepository, Event, EventView, EventData>
    {
        public IEnumerable<SelectListItem> Categories { get; }

        protected internal EventsPage(IEventsRepository e, ISportsCategoriesRepository s)
            : base(e)
        {
            PageTitle = "Sport events";
            Categories = CreateSelectList<SportsCategory, SportsCategoryData>(s);
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string GetPageUrl() => "/Sport/Events";

        protected internal override Event ToObject(EventView view) => EventViewFactory.Create(view);

        protected internal override EventView ToView(Event obj) => EventViewFactory.Create(obj);

        public string GetCategoryName(string categoryId)
        {
            foreach (var c in Categories)
                if (c.Value == categoryId)
                    return c.Text;
            return "Unspecified";
        }

    }
}
