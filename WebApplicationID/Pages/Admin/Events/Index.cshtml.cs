using System.Threading.Tasks;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Events
{
    public class IndexModel : EventsPage
    {
        public IndexModel(IEventsRepository e, ISportsCategoriesRepository s)
        : base(e, s) { }

        public async Task OnGetAsync()
        {
            await GetList();
        }
    }
}
