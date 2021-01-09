using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.Participants
{
    public class CreateProfileModel : ParticipantsPage
    {
        public CreateProfileModel(IParticipantsRepository p ) : base(p) { }

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
