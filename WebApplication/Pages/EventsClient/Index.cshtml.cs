using System.Threading.Tasks;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.EventsClient
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
