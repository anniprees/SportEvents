using System.Threading.Tasks;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Participants
{
    public class IndexModel : ParticipantsPage
    {
        public IndexModel(IParticipantsRepository p) : base(p) {}

        public async Task OnGetAsync()
        {
            await GetList();
        }
    }
}
