using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Participants
{
    public class CreateModel : ParticipantsPage
    {
        public CreateModel(IParticipantsRepository p ) : base(p) { }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!await AddObject())
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
