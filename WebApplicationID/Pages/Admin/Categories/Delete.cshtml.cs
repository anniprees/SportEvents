using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Categories
{
    public class DeleteModel : SportsCategoriesPage
    {
        public DeleteModel(ISportsCategoriesRepository s)
            :base(s) { }


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
