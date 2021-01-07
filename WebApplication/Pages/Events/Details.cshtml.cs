using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportEvents.Data;
using SportEvents.Domain.Interfaces;
using SportEvents.Infra;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.Events
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
