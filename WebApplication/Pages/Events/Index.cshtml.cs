using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportEvents.Data;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Infra;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.Events
{
    public class IndexModel : EventsPage
    {
        public IndexModel(IEventsRepository e, ISportsCategoriesRepository s)
        : base(e, s) { }

        public async Task<List<EventView>> OnGetAsync()
        {
            return await GetList();
        }
    }
}
