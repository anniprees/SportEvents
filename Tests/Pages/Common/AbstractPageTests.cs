using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.ViewFactories;
using SportEvents.Facade.Views;
using SportEvents.Pages.Common;

namespace Tests.Pages.Common
{
    public abstract class AbstractPageTests<TClass, TBaseClass> : AbstractClassTests<TClass, TBaseClass>
    where TClass : CrudPage<IEventsRepository, Event, EventView, EventData>
    {
        internal TestRepository db;

        internal class TestClass : CommonPage<IEventsRepository, Event, EventView, EventData>
        {
            protected internal TestClass(IEventsRepository r) : base(r) { }

            public override string ItemId { get; }
            //internal string PageSubTitle { get; set; } = string.Empty;
            protected internal override string GetPageUrl() => string.Empty;
            protected internal override Event ToObject(EventView v) => EventViewFactory.Create(v);
            protected internal override EventView ToView(Event o) => EventViewFactory.Create(o);
        }

        internal class TestRepository : uniqueRepository<Event, EventData>, IEventsRepository
        {
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            db = new TestRepository();
        }


    }

}
