using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Client.Registrations
{
    public class DeleteModel : EventRegistrationsPage
    {
        public DeleteModel(IEventRegistrationsRepository r, IEventsRepository e, IParticipantsRepository p)
            :base(r, e, p) { }


        public async Task<IActionResult> OnGetAsync(string id)
        {
            await GetObject(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            await DeleteObject(id);
            return RedirectToPage("./Index");
        }
    }
}
