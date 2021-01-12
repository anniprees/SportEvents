using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Registrations
{
    public class DetailsModel : EventRegistrationsPage
    {
        public DetailsModel(IEventRegistrationsRepository r, IEventsRepository e, IParticipantsRepository p)
            : base(r, e, p) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await GetObject(id);
            return Page();
        }
    }
}
