using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Events
{
    public class CreateModel : EventsPage
    {
        public CreateModel(IEventsRepository e, ISportsCategoriesRepository s)
         : base(e, s) { }

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
