using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Client.Events
{
    public class EventsClient : EventsPage
    {
        public EventsClient(IEventsRepository e, ISportsCategoriesRepository s)
        : base(e, s) { }

        public async Task OnGetAsync()
        {
            await GetList();
        }
    }
}
