using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Registrations
{
    public class CreateModel : EventRegistrationsPage
    {
        public CreateModel(IEventRegistrationsRepository r, IEventsRepository e, IParticipantsRepository p)
         : base(r, e, p) { }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Item.isFull) return RedirectToPage("./Index");
                if (!await AddObject()) return Page();
                    return RedirectToPage("./Index");
        }
    }
}
