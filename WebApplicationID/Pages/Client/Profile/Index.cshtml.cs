using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Client.Profile
{
    public class IndexModel : ParticipantsPage
    {
        public IndexModel(IParticipantsRepository p) : base(p) {}

        public async Task OnGetAsync()
        {
            await GetList();
            Items.Where(x => x.Id == User.Identity.Name).ToList();
        }
    }
}
