using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.Categories
{
    public class CreateModel : SportsCategoriesPage
    {
        public CreateModel(ISportsCategoriesRepository s)
         : base(s) { }

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
