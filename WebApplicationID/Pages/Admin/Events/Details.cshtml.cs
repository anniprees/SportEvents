using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Events
{
    public class DetailsModel : EventsPage
    {
        public DetailsModel(IEventsRepository e, ISportsCategoriesRepository s)
            : base(e, s) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await GetObject(id);
            return Page();
        }
    }
}
