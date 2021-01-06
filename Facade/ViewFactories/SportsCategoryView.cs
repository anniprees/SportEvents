using AidMethods;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Facade.Views;

namespace SportEvents.Facade.ViewFactories
{
    public sealed class SportsCategoryViewFactory
    {
        public static SportsCategory Create(SportsCategoryView v)
        {
            var d = new SportsCategoryData();
            Copy.Members(v, d);
            return new SportsCategory(d);
        }

        public static SportsCategoryView Create(SportsCategory o)
        {
            var v = new SportsCategoryView();
            Copy.Members(o?.Data, v);
            return v;
        }

    }
}
