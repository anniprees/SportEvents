using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.EventsClient
{
    public class RegisterModel : EventRegistrationsPage
    {
        public RegisterModel(IEventRegistrationsRepository r, IEventsRepository e, IParticipantsRepository p)
         : base(r, e, p) { }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!await AddObject()) return Page();
                return RedirectToPage("./Index");
        }
    }
}
