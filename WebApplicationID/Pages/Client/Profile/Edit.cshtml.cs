using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Client.Profile
{
    public class EditModel : ParticipantsPage
    {
        public EditModel(IParticipantsRepository p) : base(p) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) { return NotFound(); }

            await GetObject(id);

            if (Item == null) { return NotFound(); }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await UpdateObject();
            return RedirectToPage("./Index");
        }

    }
}
