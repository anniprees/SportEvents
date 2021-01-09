using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.Categories
{
    public class DetailsModel : SportsCategoriesPage
    {
        public DetailsModel(ISportsCategoriesRepository s)
            : base(s) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await GetObject(id);
            return Page();
        }
    }
}
