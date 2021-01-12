using System.Linq;
using System.Threading.Tasks;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Client.Registrations
{
    public class IndexModel : EventRegistrationsPage
    {
        public IndexModel(IEventRegistrationsRepository r, IEventsRepository e, IParticipantsRepository p)
        : base(r, e, p) { }

        public async Task OnGetAsync()
        {
            await GetList();
            Items.Where(x => x.Id == User.Identity.Name).ToList();
        }
    }
}
