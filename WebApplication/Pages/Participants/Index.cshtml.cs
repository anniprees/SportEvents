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

namespace SportEvents.WebApplication.Pages.Participants
{
    public class IndexModel : ParticipantsPage
    {
        public IndexModel(IParticipantsRepository p) : base(p) {}

        public async Task OnGetAsync()
        {
            await GetList();
        }
    }
}
