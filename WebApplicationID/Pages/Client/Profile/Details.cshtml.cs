using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Client.Profile
{
    public class DetailsModel : ParticipantsPage
    {

        public DetailsModel(IParticipantsRepository p) : base(p) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await GetObject(id);
            return Page();
        }
    }
}
