using AidMethods;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Facade.Views;

namespace SportEvents.Facade.ViewFactories
{
    public static class EventViewFactory
    {
        public static Event Create(EventView v)
        {
            var d = new EventData();
            Copy.Members(v, d);
            return new Event(d);
        }

        public static EventView Create(Event o)
        {
            var v = new EventView();
            Copy.Members(o?.Data, v);
            v.SportsCategory = o.SportsCategory.Name;
            return v;
        }

    }
}
