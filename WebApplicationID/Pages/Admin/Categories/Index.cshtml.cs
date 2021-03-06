﻿using System.Threading.Tasks;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplicationID.Pages.Admin.Categories
{
    public class IndexModel : SportsCategoriesPage
    {
        public IndexModel(ISportsCategoriesRepository s) : base(s) { }

        public async Task OnGetAsync()
        {
            await GetList();
        }
    }
}
