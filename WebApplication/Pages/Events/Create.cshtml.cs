using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportEvents.Data;
using SportEvents.Domain.Interfaces;
using SportEvents.Infra;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.Events
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
