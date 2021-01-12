using System.Threading.Tasks;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Registrations
{
    public class IndexModel : EventRegistrationsPage
    {
        public IndexModel(IEventRegistrationsRepository r, IEventsRepository e, IParticipantsRepository p)
        : base(r, e, p) { }

        public async Task OnGetAsync()
        {
            await GetList();
        }
    }
}
